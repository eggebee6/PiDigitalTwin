using DigitalTwin.Comms;
using DigitalTwin.Physical;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalTwin
{
  public class PiDigitalTwinFactory
  {
    private ILoggerFactory loggerFactory = null;
    private IPhysicalTwin physicalTwin = null;
    private Action<UaServerOptions> serverOptionsConfig = null;

    public PiDigitalTwin BuildDigitalTwin()
    {
      if (loggerFactory is null)
      {
        throw new InvalidOperationException("Logger factory is null");
      }

      if (physicalTwin is null)
      {
        throw new InvalidOperationException("Physical twin is null");
      }

      if (serverOptionsConfig is null)
      {
        throw new InvalidOperationException("Server configuration is null");
      }

      return new PiDigitalTwin(
        physicalTwin,
        serverOptionsConfig,
        loggerFactory);
    }

    public PiDigitalTwinFactory SetLoggerFactory(ILoggerFactory loggerFactory)
    {
      this.loggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
      return this;
    }

    public PiDigitalTwinFactory SetPhysicalTwin(IPhysicalTwin physicalTwin)
    {
      this.physicalTwin = physicalTwin ?? throw new ArgumentNullException(nameof(physicalTwin));
      return this;
    }

    public PiDigitalTwinFactory ConfigureUaServer(Action<UaServerOptions> config)
    {
      this.serverOptionsConfig = config ?? throw new ArgumentNullException(nameof(config));
      return this;
    }
  }
}
