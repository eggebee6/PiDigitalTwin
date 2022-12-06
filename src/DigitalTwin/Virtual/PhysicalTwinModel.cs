using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalTwin.Virtual
{
  public class PhysicalTwinModel
  {
    public const int MeasurementCount = 14;

    public double AccelerometerX { get; set; }
    public double AccelerometerY { get; set; }
    public double AccelerometerZ { get; set; }

    public double AngularRateX { get; set; }
    public double AngularRateY { get; set; }
    public double AngularRateZ { get; set; }

    public double MagnetometerX { get; set; }
    public double MagnetometerY { get; set; }
    public double MagnetometerZ { get; set; }

    public bool JoystickUp { get; set; }
    public bool JoystickDown { get; set; }
    public bool JoystickLeft { get; set; }
    public bool JoystickRight { get; set; }
    public bool JoystickPushbutton { get; set; }

    private double[] measurements;
    public double[] MeasurementVector => measurements;

    private double[] predictions;
    public double[] PredictionVector => predictions;

    private double[] error;
    public double[] ErrorVector => error;

    public PhysicalTwinModel()
    {
      measurements = new double[MeasurementCount];
      predictions = new double[MeasurementCount];
      error = new double[MeasurementCount];
    }
    
    public void MeasurementsUpdated()
    {
      measurements.CopyTo(predictions, 0);

      int index = 0;

      measurements[index++] = AccelerometerX;
      measurements[index++] = AccelerometerY;
      measurements[index++] = AccelerometerZ;

      measurements[index++] = AngularRateX;
      measurements[index++] = AngularRateY;
      measurements[index++] = AngularRateZ;

      measurements[index++] = MagnetometerX;
      measurements[index++] = MagnetometerY;
      measurements[index++] = MagnetometerZ;

      measurements[index++] = JoystickUp ? 1 : 0;
      measurements[index++] = JoystickDown ? 1 : 0;
      measurements[index++] = JoystickLeft ? 1 : 0;
      measurements[index++] = JoystickRight ? 1 : 0;
      measurements[index++] = JoystickPushbutton ? 1 : 0;

      for (int i = 0; i < MeasurementCount; ++i)
      {
        error[i] = predictions[i] - measurements[i];
      }
    }
  }
}
