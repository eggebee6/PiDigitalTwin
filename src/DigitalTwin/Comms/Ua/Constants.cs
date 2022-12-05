/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace DigitalTwins.Comms.Ua
{
  #region Object Identifiers
  /// <summary>
  /// A class that declares constants for all Objects in the Model Design.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class Objects
  {
    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer Object.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Magnetometer = 28;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer Object.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Accelerometer = 33;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate Object.
    /// </summary>
    public const uint SenseHatVirtualTwinType_AngularRate = 38;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick Object.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Joystick = 43;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED Object.
    /// </summary>
    public const uint SenseHatVirtualTwinType_LED = 49;
  }
  #endregion

  #region ObjectType Identifiers
  /// <summary>
  /// A class that declares constants for all ObjectTypes in the Model Design.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class ObjectTypes
  {
    /// <summary>
    /// The identifier for the Sensor3DType ObjectType.
    /// </summary>
    public const uint Sensor3DType = 1;

    /// <summary>
    /// The identifier for the PushbuttonEventType ObjectType.
    /// </summary>
    public const uint PushbuttonEventType = 6;

    /// <summary>
    /// The identifier for the JoystickType ObjectType.
    /// </summary>
    public const uint JoystickType = 17;

    /// <summary>
    /// The identifier for the RGBLEDType ObjectType.
    /// </summary>
    public const uint RGBLEDType = 23;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType ObjectType.
    /// </summary>
    public const uint SenseHatVirtualTwinType = 27;
  }
  #endregion

  #region Variable Identifiers
  /// <summary>
  /// A class that declares constants for all Variables in the Model Design.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class Variables
  {
    /// <summary>
    /// The identifier for the Sensor3DType_X Variable.
    /// </summary>
    public const uint Sensor3DType_X = 2;

    /// <summary>
    /// The identifier for the Sensor3DType_Y Variable.
    /// </summary>
    public const uint Sensor3DType_Y = 3;

    /// <summary>
    /// The identifier for the Sensor3DType_Z Variable.
    /// </summary>
    public const uint Sensor3DType_Z = 4;

    /// <summary>
    /// The identifier for the Sensor3DType_Units Variable.
    /// </summary>
    public const uint Sensor3DType_Units = 5;

    /// <summary>
    /// The identifier for the PushbuttonEventType_PushbuttonState Variable.
    /// </summary>
    public const uint PushbuttonEventType_PushbuttonState = 16;

    /// <summary>
    /// The identifier for the JoystickType_Up Variable.
    /// </summary>
    public const uint JoystickType_Up = 18;

    /// <summary>
    /// The identifier for the JoystickType_Down Variable.
    /// </summary>
    public const uint JoystickType_Down = 19;

    /// <summary>
    /// The identifier for the JoystickType_Left Variable.
    /// </summary>
    public const uint JoystickType_Left = 20;

    /// <summary>
    /// The identifier for the JoystickType_Right Variable.
    /// </summary>
    public const uint JoystickType_Right = 21;

    /// <summary>
    /// The identifier for the JoystickType_Pushbutton Variable.
    /// </summary>
    public const uint JoystickType_Pushbutton = 22;

    /// <summary>
    /// The identifier for the RGBLEDType_Red Variable.
    /// </summary>
    public const uint RGBLEDType_Red = 24;

    /// <summary>
    /// The identifier for the RGBLEDType_Green Variable.
    /// </summary>
    public const uint RGBLEDType_Green = 25;

    /// <summary>
    /// The identifier for the RGBLEDType_Blue Variable.
    /// </summary>
    public const uint RGBLEDType_Blue = 26;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_X Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Magnetometer_X = 29;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_Y Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Magnetometer_Y = 30;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_Z Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Magnetometer_Z = 31;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_Units Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Magnetometer_Units = 32;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_X Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Accelerometer_X = 34;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_Y Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Accelerometer_Y = 35;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_Z Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Accelerometer_Z = 36;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_Units Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Accelerometer_Units = 37;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_X Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_AngularRate_X = 39;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_Y Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_AngularRate_Y = 40;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_Z Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_AngularRate_Z = 41;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_Units Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_AngularRate_Units = 42;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Up Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Joystick_Up = 44;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Down Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Joystick_Down = 45;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Left Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Joystick_Left = 46;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Right Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Joystick_Right = 47;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Pushbutton Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_Joystick_Pushbutton = 48;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED_Red Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_LED_Red = 50;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED_Green Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_LED_Green = 51;

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED_Blue Variable.
    /// </summary>
    public const uint SenseHatVirtualTwinType_LED_Blue = 52;
  }
  #endregion

  #region Object Node Identifiers
  /// <summary>
  /// A class that declares constants for all Objects in the Model Design.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class ObjectIds
  {
    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer Object.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Magnetometer = new ExpandedNodeId(DigitalTwins.Comms.Ua.Objects.SenseHatVirtualTwinType_Magnetometer, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer Object.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Accelerometer = new ExpandedNodeId(DigitalTwins.Comms.Ua.Objects.SenseHatVirtualTwinType_Accelerometer, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate Object.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_AngularRate = new ExpandedNodeId(DigitalTwins.Comms.Ua.Objects.SenseHatVirtualTwinType_AngularRate, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick Object.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Joystick = new ExpandedNodeId(DigitalTwins.Comms.Ua.Objects.SenseHatVirtualTwinType_Joystick, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED Object.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_LED = new ExpandedNodeId(DigitalTwins.Comms.Ua.Objects.SenseHatVirtualTwinType_LED, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);
  }
  #endregion

  #region ObjectType Node Identifiers
  /// <summary>
  /// A class that declares constants for all ObjectTypes in the Model Design.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class ObjectTypeIds
  {
    /// <summary>
    /// The identifier for the Sensor3DType ObjectType.
    /// </summary>
    public static readonly ExpandedNodeId Sensor3DType = new ExpandedNodeId(DigitalTwins.Comms.Ua.ObjectTypes.Sensor3DType, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the PushbuttonEventType ObjectType.
    /// </summary>
    public static readonly ExpandedNodeId PushbuttonEventType = new ExpandedNodeId(DigitalTwins.Comms.Ua.ObjectTypes.PushbuttonEventType, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the JoystickType ObjectType.
    /// </summary>
    public static readonly ExpandedNodeId JoystickType = new ExpandedNodeId(DigitalTwins.Comms.Ua.ObjectTypes.JoystickType, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the RGBLEDType ObjectType.
    /// </summary>
    public static readonly ExpandedNodeId RGBLEDType = new ExpandedNodeId(DigitalTwins.Comms.Ua.ObjectTypes.RGBLEDType, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType ObjectType.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType = new ExpandedNodeId(DigitalTwins.Comms.Ua.ObjectTypes.SenseHatVirtualTwinType, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);
  }
  #endregion

  #region Variable Node Identifiers
  /// <summary>
  /// A class that declares constants for all Variables in the Model Design.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class VariableIds
  {
    /// <summary>
    /// The identifier for the Sensor3DType_X Variable.
    /// </summary>
    public static readonly ExpandedNodeId Sensor3DType_X = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.Sensor3DType_X, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the Sensor3DType_Y Variable.
    /// </summary>
    public static readonly ExpandedNodeId Sensor3DType_Y = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.Sensor3DType_Y, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the Sensor3DType_Z Variable.
    /// </summary>
    public static readonly ExpandedNodeId Sensor3DType_Z = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.Sensor3DType_Z, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the Sensor3DType_Units Variable.
    /// </summary>
    public static readonly ExpandedNodeId Sensor3DType_Units = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.Sensor3DType_Units, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the PushbuttonEventType_PushbuttonState Variable.
    /// </summary>
    public static readonly ExpandedNodeId PushbuttonEventType_PushbuttonState = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.PushbuttonEventType_PushbuttonState, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the JoystickType_Up Variable.
    /// </summary>
    public static readonly ExpandedNodeId JoystickType_Up = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.JoystickType_Up, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the JoystickType_Down Variable.
    /// </summary>
    public static readonly ExpandedNodeId JoystickType_Down = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.JoystickType_Down, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the JoystickType_Left Variable.
    /// </summary>
    public static readonly ExpandedNodeId JoystickType_Left = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.JoystickType_Left, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the JoystickType_Right Variable.
    /// </summary>
    public static readonly ExpandedNodeId JoystickType_Right = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.JoystickType_Right, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the JoystickType_Pushbutton Variable.
    /// </summary>
    public static readonly ExpandedNodeId JoystickType_Pushbutton = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.JoystickType_Pushbutton, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the RGBLEDType_Red Variable.
    /// </summary>
    public static readonly ExpandedNodeId RGBLEDType_Red = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.RGBLEDType_Red, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the RGBLEDType_Green Variable.
    /// </summary>
    public static readonly ExpandedNodeId RGBLEDType_Green = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.RGBLEDType_Green, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the RGBLEDType_Blue Variable.
    /// </summary>
    public static readonly ExpandedNodeId RGBLEDType_Blue = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.RGBLEDType_Blue, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_X Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Magnetometer_X = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Magnetometer_X, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_Y Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Magnetometer_Y = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Magnetometer_Y, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_Z Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Magnetometer_Z = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Magnetometer_Z, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Magnetometer_Units Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Magnetometer_Units = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Magnetometer_Units, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_X Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Accelerometer_X = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Accelerometer_X, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_Y Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Accelerometer_Y = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Accelerometer_Y, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_Z Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Accelerometer_Z = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Accelerometer_Z, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Accelerometer_Units Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Accelerometer_Units = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Accelerometer_Units, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_X Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_AngularRate_X = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_AngularRate_X, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_Y Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_AngularRate_Y = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_AngularRate_Y, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_Z Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_AngularRate_Z = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_AngularRate_Z, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_AngularRate_Units Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_AngularRate_Units = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_AngularRate_Units, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Up Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Joystick_Up = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Joystick_Up, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Down Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Joystick_Down = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Joystick_Down, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Left Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Joystick_Left = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Joystick_Left, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Right Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Joystick_Right = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Joystick_Right, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_Joystick_Pushbutton Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_Joystick_Pushbutton = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_Joystick_Pushbutton, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED_Red Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_LED_Red = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_LED_Red, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED_Green Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_LED_Green = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_LED_Green, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);

    /// <summary>
    /// The identifier for the SenseHatVirtualTwinType_LED_Blue Variable.
    /// </summary>
    public static readonly ExpandedNodeId SenseHatVirtualTwinType_LED_Blue = new ExpandedNodeId(DigitalTwins.Comms.Ua.Variables.SenseHatVirtualTwinType_LED_Blue, DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin);
  }
  #endregion

  #region BrowseName Declarations
  /// <summary>
  /// Declares all of the BrowseNames used in the Model Design.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class BrowseNames
  {
    /// <summary>
    /// The BrowseName for the Accelerometer component.
    /// </summary>
    public const string Accelerometer = "Accelerometer";

    /// <summary>
    /// The BrowseName for the AngularRate component.
    /// </summary>
    public const string AngularRate = "Angular rate sensor";

    /// <summary>
    /// The BrowseName for the Blue component.
    /// </summary>
    public const string Blue = "Blue";

    /// <summary>
    /// The BrowseName for the Down component.
    /// </summary>
    public const string Down = "Down";

    /// <summary>
    /// The BrowseName for the Green component.
    /// </summary>
    public const string Green = "Green";

    /// <summary>
    /// The BrowseName for the Joystick component.
    /// </summary>
    public const string Joystick = "Four-direction joystick with pushbutton";

    /// <summary>
    /// The BrowseName for the JoystickType component.
    /// </summary>
    public const string JoystickType = "JoystickType";

    /// <summary>
    /// The BrowseName for the LED component.
    /// </summary>
    public const string LED = "RGB LED";

    /// <summary>
    /// The BrowseName for the Left component.
    /// </summary>
    public const string Left = "Left";

    /// <summary>
    /// The BrowseName for the Magnetometer component.
    /// </summary>
    public const string Magnetometer = "Magnetometer";

    /// <summary>
    /// The BrowseName for the Pushbutton component.
    /// </summary>
    public const string Pushbutton = "Pushbutton";

    /// <summary>
    /// The BrowseName for the PushbuttonEventType component.
    /// </summary>
    public const string PushbuttonEventType = "PushbuttonEventType";

    /// <summary>
    /// The BrowseName for the PushbuttonState component.
    /// </summary>
    public const string PushbuttonState = "PushbuttonState";

    /// <summary>
    /// The BrowseName for the Red component.
    /// </summary>
    public const string Red = "Red";

    /// <summary>
    /// The BrowseName for the RGBLEDType component.
    /// </summary>
    public const string RGBLEDType = "RGBLEDType";

    /// <summary>
    /// The BrowseName for the Right component.
    /// </summary>
    public const string Right = "Right";

    /// <summary>
    /// The BrowseName for the SenseHatVirtualTwinType component.
    /// </summary>
    public const string SenseHatVirtualTwinType = "SenseHatVirtualTwinType";

    /// <summary>
    /// The BrowseName for the Sensor3DType component.
    /// </summary>
    public const string Sensor3DType = "Sensor3DType";

    /// <summary>
    /// The BrowseName for the Units component.
    /// </summary>
    public const string Units = "Units";

    /// <summary>
    /// The BrowseName for the Up component.
    /// </summary>
    public const string Up = "Up";

    /// <summary>
    /// The BrowseName for the X component.
    /// </summary>
    public const string X = "X";

    /// <summary>
    /// The BrowseName for the Y component.
    /// </summary>
    public const string Y = "Y";

    /// <summary>
    /// The BrowseName for the Z component.
    /// </summary>
    public const string Z = "Z";
  }
  #endregion

  #region Namespace Declarations
  /// <summary>
  /// Defines constants for all namespaces referenced by the model design.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public static partial class Namespaces
  {
    /// <summary>
    /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
    /// </summary>
    public const string OpcUa = "http://opcfoundation.org/UA/";

    /// <summary>
    /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
    /// </summary>
    public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

    /// <summary>
    /// The URI for the PiDigitalTwin namespace (.NET code namespace is 'DigitalTwins.Comms.Ua').
    /// </summary>
    public const string PiDigitalTwin = "http://mkecybertech.com/UA/PiDigitalTwin";
  }
  #endregion
}