using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalTwin.Physical
{
  public interface IPhysicalTwin
  {
    System.Numerics.Vector3 Magnetometer();
    string MagnetometerUnits { get; }
    event EventHandler MagnetometerChanged;

    System.Numerics.Vector3 Accelerometer();
    string AccelerometerUnits { get; }
    event EventHandler AccelerometerChanged;

    System.Numerics.Vector3 AngularRate();
    string AngularRateUnits { get; }
    event EventHandler AngularRateChanged;

    bool JoystickUp();
    bool JoystickDown();
    bool JoystickLeft();
    bool JoystickRight();
    bool JoystickPushbutton();
    event EventHandler JoystickChanged;
  }
}
