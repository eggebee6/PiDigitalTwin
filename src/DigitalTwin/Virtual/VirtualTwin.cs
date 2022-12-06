using DigitalTwin.Comms.Ua;
using DigitalTwin.Comms;
using Microsoft.Extensions.Logging;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;
using DigitalTwin.Physical;

namespace DigitalTwin.Virtual
{
  public class VirtualTwin
  {
    private readonly IPhysicalTwin physicalTwin;
    private readonly PhysicalTwinModel physicalTwinModel;

    private VirtualTwinUaNode virtualTwinUaNode = null;

    public VirtualTwin(IPhysicalTwin physicalTwin)
    {
      this.physicalTwin = physicalTwin ?? throw new ArgumentNullException(nameof(physicalTwin));
      physicalTwinModel = new PhysicalTwinModel();
      InitializePhysicalTwin();
    }

    private void InitializePhysicalTwin()
    {
      physicalTwin.AccelerometerChanged += OnAccelerometerChanged;
      physicalTwin.AngularRateChanged += OnAngularRateChanged;
      physicalTwin.MagnetometerChanged += OnMagnetometerChanged;
      physicalTwin.JoystickChanged += OnJoystickChanged;
    }

    public void AssociateUaNode(VirtualTwinUaNode node)
    {
      virtualTwinUaNode = node ?? throw new ArgumentNullException(nameof(node));
    }

    public void RemoveUaNode()
    {
      virtualTwinUaNode = null;
    }

    public void OnAccelerometerChanged(object sender, EventArgs e)
    {
      try
      {
        var sensor = physicalTwin.Accelerometer();

        physicalTwinModel.AccelerometerX = sensor.X;
        physicalTwinModel.AccelerometerY = sensor.Y;
        physicalTwinModel.AccelerometerZ = sensor.Z;

        virtualTwinUaNode?.UpdateMeasurements(physicalTwinModel);
      }
      catch (Exception)
      {
        throw;
      }
    }

    private void OnAngularRateChanged(object sender, EventArgs e)
    {
    }

    private void OnMagnetometerChanged(object sender, EventArgs e)
    {
    }

    private void OnJoystickChanged(object sender, EventArgs e)
    {
    }
  }
}
