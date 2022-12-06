using DigitalTwin.Comms.Ua;
using DigitalTwin.Virtual;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalTwin.Comms
{
  public class VirtualTwinUaNode
  {
    private readonly CustomNodeManager2 parentNodeManager;
    public readonly SenseHatVirtualTwinState UaNode;

    public VirtualTwinUaNode(
      CustomNodeManager2 parent,
      SenseHatVirtualTwinState uaNode)
    {
      parentNodeManager = parent ?? throw new ArgumentNullException(nameof(parent));
      UaNode = uaNode ?? throw new ArgumentNullException(nameof(uaNode));
    }

    private ServerSystemContext SystemContext => parentNodeManager.SystemContext;

    public void UpdateMeasurements(PhysicalTwinModel physicalTwin)
    {
      UaNode.Accelerometer.X.Value = physicalTwin.AccelerometerX;
      UaNode.Accelerometer.Y.Value = physicalTwin.AccelerometerY;
      UaNode.Accelerometer.Z.Value = physicalTwin.AccelerometerZ;

      UaNode.AngularRate.X.Value = physicalTwin.AngularRateX;
      UaNode.AngularRate.Y.Value = physicalTwin.AngularRateY;
      UaNode.AngularRate.Z.Value = physicalTwin.AngularRateZ;

      UaNode.Magnetometer.X.Value = physicalTwin.MagnetometerX;
      UaNode.Magnetometer.Y.Value = physicalTwin.MagnetometerY;
      UaNode.Magnetometer.Z.Value = physicalTwin.MagnetometerZ;

      UaNode.Joystick.Up.Value = physicalTwin.JoystickUp;
      UaNode.Joystick.Down.Value = physicalTwin.JoystickDown;
      UaNode.Joystick.Left.Value = physicalTwin.JoystickLeft;
      UaNode.Joystick.Right.Value = physicalTwin.JoystickRight;
      UaNode.Joystick.Pushbutton.Value = physicalTwin.JoystickPushbutton;

      UaNode.ClearChangeMasks(SystemContext, true);
    }
  }
}
