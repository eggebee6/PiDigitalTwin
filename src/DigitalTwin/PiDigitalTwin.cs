using DigitalTwin.Comms;
using DigitalTwin.Physical;
using DigitalTwin.Virtual;
using DigitalTwin.Comms.Ua;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalTwin
{
  public class PiDigitalTwin
  {
    public readonly IPhysicalTwin PhysicalTwin;
    public readonly VirtualTwin VirtualTwin;
    public readonly UaServer UaServer;

    public PiDigitalTwin(
      IPhysicalTwin physicalTwin,
      UaServer uaServer)
    {
      PhysicalTwin = physicalTwin ?? throw new ArgumentNullException(nameof(physicalTwin));
      UaServer = uaServer ?? throw new ArgumentNullException(nameof(uaServer));

      VirtualTwin = new VirtualTwin(PhysicalTwin);
    }
  }
}
