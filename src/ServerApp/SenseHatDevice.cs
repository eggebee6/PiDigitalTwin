using DigitalTwin.Physical;
using Iot.Device.SenseHat;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading;

namespace ServerApp
{
  internal class SenseHatDevice : IPhysicalTwin
  {
    private ILogger<IPhysicalTwin> logger { get; }
    private readonly Timer updateTimer;

    private readonly Iot.Device.SenseHat.SenseHat senseHat;

    public event EventHandler MagnetometerChanged;
    public event EventHandler AccelerometerChanged;
    public event EventHandler AngularRateChanged;
    public event EventHandler JoystickChanged;

    public SenseHatDevice(ILoggerFactory loggerFactory)
    {
      if (loggerFactory is null)
      {
        throw new ArgumentNullException(nameof(loggerFactory));
      }

      logger = loggerFactory.CreateLogger<SenseHatDevice>();

      senseHat = new Iot.Device.SenseHat.SenseHat();
      if (senseHat is null)
      {
        logger.LogError("Failed to create SenseHat device object");
        throw new Exception("Failed to create SenseHAT device object");
      }

      updateTimer = new Timer(InvokeUpdates, null, 100, 100);
    }

    private void InvokeUpdates(object state)
    {
      MagnetometerChanged?.Invoke(null, null);
      AccelerometerChanged?.Invoke(null, null);
      AngularRateChanged?.Invoke(null, null);
      JoystickChanged?.Invoke(null, null);
    }

    public string MagnetometerUnits => "Gauss";
    public Vector3 Magnetometer() =>
      senseHat.Magnetometer.MagneticInduction;

    public string AccelerometerUnits => "G";
    public Vector3 Accelerometer() =>
      senseHat.Acceleration;

    public string AngularRateUnits => "Degrees/second";
    public Vector3 AngularRate() =>
      senseHat.AngularRate;

    public bool JoystickDown()
    {
      senseHat.Joystick.Read();
      return senseHat.Joystick.HoldingDown;
    }

    public bool JoystickLeft()
    {
      senseHat.Joystick.Read();
      return senseHat.Joystick.HoldingLeft;
    }

    public bool JoystickRight()
    {
      senseHat.Joystick.Read();
      return senseHat.Joystick.HoldingRight;
    }

    public bool JoystickUp()
    {
      senseHat.Joystick.Read();
      return senseHat.Joystick.HoldingUp;
    }

    public bool JoystickPushbutton()
    {
      senseHat.Joystick.Read();
      return senseHat.Joystick.HoldingButton;
    }
  }
}
