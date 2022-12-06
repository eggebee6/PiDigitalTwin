using DigitalTwin.Comms;
using DigitalTwin.Physical;
using DigitalTwin.Virtual;
using DigitalTwin.Comms.Ua;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DigitalTwin
{
  public class PiDigitalTwin
  {
    public readonly IPhysicalTwin PhysicalTwin;
    public readonly VirtualTwin VirtualTwin;
    public readonly UaServer UaServer;

    private readonly ILogger<PiDigitalTwin> logger;

    public PiDigitalTwin(
      IPhysicalTwin physicalTwin,
      Action<UaServerOptions> serverOptionsConfig,
      ILoggerFactory loggerFactory)
    {
      if (serverOptionsConfig is null)
      {
        throw new ArgumentNullException(nameof(serverOptionsConfig));
      }

      PhysicalTwin = physicalTwin ?? throw new ArgumentNullException(nameof(physicalTwin));

      var serverOpts = new Action<UaServerOptions>(options =>
      {
        serverOptionsConfig(options);
        options.DigitalTwin = this;
      });

      UaServer = new UaServer(serverOpts);

      logger = loggerFactory?.CreateLogger<PiDigitalTwin>() ?? throw new ArgumentNullException(nameof(loggerFactory));

      VirtualTwin = new VirtualTwin(PhysicalTwin, loggerFactory);
    }

    public async Task LaunchUaServer(
      string configFile,
      X509Certificate2 certificate = null,
      string certificatePassword = null)
    {
      await UaServer.LaunchServer(UaServer, configFile, certificate, certificatePassword);
    }

    public void StopUaServer()
    {
      UaServer.StopServer(UaServer);
    }
  }
}
