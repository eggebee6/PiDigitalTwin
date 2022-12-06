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
  public class SenseHatTest : IPhysicalTwin
  {
    private readonly Random rng = new Random();

    public event EventHandler MagnetometerChanged;
    public event EventHandler AccelerometerChanged;
    public event EventHandler AngularRateChanged;
    public event EventHandler JoystickChanged;

    private readonly ILogger<IPhysicalTwin> logger;
    private readonly Timer updateTimer;

    public SenseHatTest(ILoggerFactory loggerFactory)
    {
      if (loggerFactory is null)
      {
        throw new ArgumentNullException(nameof(loggerFactory));
      }

      logger = loggerFactory.CreateLogger<SenseHatTest>();

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
    public Vector3 Magnetometer()
    {
      float x = (float)(rng.NextDouble() - rng.NextDouble());
      float y = (float)(rng.NextDouble() - rng.NextDouble());
      float z = (float)(rng.NextDouble() - rng.NextDouble());

      return new Vector3(x, y, z);
    }

    public string AccelerometerUnits => "G";
    public Vector3 Accelerometer()
    {
      float x = (float)(rng.NextDouble() - rng.NextDouble());
      float y = (float)(rng.NextDouble() - rng.NextDouble());
      float z = (float)(rng.NextDouble() - rng.NextDouble());

      return new Vector3(x, y, z);
    }

    public string AngularRateUnits => "Degrees/second";
    public Vector3 AngularRate()
    {
      float x = (float)(rng.NextDouble() - rng.NextDouble());
      float y = (float)(rng.NextDouble() - rng.NextDouble());
      float z = (float)(rng.NextDouble() - rng.NextDouble());

      return new Vector3(x, y, z);
    }

    public bool JoystickDown()
    {
      return (rng.Next(0, 2) == 1);
    }

    public bool JoystickLeft()
    {
      return (rng.Next(0, 2) == 1);
    }

    public bool JoystickPushbutton()
    {
      return (rng.Next(0, 2) == 1);
    }

    public bool JoystickRight()
    {
      return (rng.Next(0, 2) == 1);
    }

    public bool JoystickUp()
    {
      return (rng.Next(0, 2) == 1);
    }
  }
}
