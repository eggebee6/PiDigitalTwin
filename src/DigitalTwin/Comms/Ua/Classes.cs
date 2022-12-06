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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace DigitalTwin.Comms.Ua
{
  #region Sensor3DState Class
#if (!OPCUA_EXCLUDE_Sensor3DState)
  /// <summary>
  /// Stores an instance of the Sensor3DType ObjectType.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public partial class Sensor3DState : BaseObjectState
  {
    #region Constructors
    /// <summary>
    /// Initializes the type with its default attribute values.
    /// </summary>
    public Sensor3DState(NodeState parent) : base(parent)
    {
    }

    /// <summary>
    /// Returns the id of the default type definition node for the instance.
    /// </summary>
    protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
    {
      return Opc.Ua.NodeId.Create(DigitalTwin.Comms.Ua.ObjectTypes.Sensor3DType, DigitalTwin.Comms.Ua.Namespaces.PiDigitalTwin, namespaceUris);
    }

#if (!OPCUA_EXCLUDE_InitializationStrings)
    /// <summary>
    /// Initializes the instance.
    /// </summary>
    protected override void Initialize(ISystemContext context)
    {
      base.Initialize(context);
      Initialize(context, InitializationString);
      InitializeOptionalChildren(context);
    }

    /// <summary>
    /// Initializes the instance with a node.
    /// </summary>
    protected override void Initialize(ISystemContext context, NodeState source)
    {
      InitializeOptionalChildren(context);
      base.Initialize(context, source);
    }

    /// <summary>
    /// Initializes the any option children defined for the instance.
    /// </summary>
    protected override void InitializeOptionalChildren(ISystemContext context)
    {
      base.InitializeOptionalChildren(context);
    }

    #region Initialization String
    private const string InitializationString =
       "AQAAACgAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaURpZ2l0YWxUd2lu/////wRggAIBAAAA" +
       "AQAUAAAAU2Vuc29yM0RUeXBlSW5zdGFuY2UBAQEAAQEBAAEAAAD/////BAAAADVgiQoCAAAAAQABAAAA" +
       "WAEBAgADAAAAAA0AAABYLWF4aXMgb3V0cHV0AC8APwIAAAAAC/////8BAf////8AAAAANWCJCgIAAAAB" +
       "AAEAAABZAQEDAAMAAAAADQAAAFktYXhpcyBvdXRwdXQALwA/AwAAAAAL/////wEB/////wAAAAA1YIkK" +
       "AgAAAAEAAQAAAFoBAQQAAwAAAAANAAAAWi1heGlzIG91dHB1dAAvAD8EAAAAAAv/////AQH/////AAAA" +
       "ADVgiQoCAAAAAQAFAAAAVW5pdHMBAQUAAwAAAAAMAAAAU2Vuc29yIHVuaXRzAC4ARAUAAAAADP////8B" +
       "Af////8AAAAA";
    #endregion
#endif
    #endregion

    #region Public Properties
    /// <remarks />
    public BaseDataVariableState<double> X
    {
      get
      {
        return m_x;
      }

      set
      {
        if (!Object.ReferenceEquals(m_x, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_x = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<double> Y
    {
      get
      {
        return m_y;
      }

      set
      {
        if (!Object.ReferenceEquals(m_y, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_y = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<double> Z
    {
      get
      {
        return m_z;
      }

      set
      {
        if (!Object.ReferenceEquals(m_z, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_z = value;
      }
    }

    /// <remarks />
    public PropertyState<string> Units
    {
      get
      {
        return m_units;
      }

      set
      {
        if (!Object.ReferenceEquals(m_units, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_units = value;
      }
    }
    #endregion

    #region Overridden Methods
    /// <summary>
    /// Populates a list with the children that belong to the node.
    /// </summary>
    /// <param name="context">The context for the system being accessed.</param>
    /// <param name="children">The list of children to populate.</param>
    public override void GetChildren(
        ISystemContext context,
        IList<BaseInstanceState> children)
    {
      if (m_x != null)
      {
        children.Add(m_x);
      }

      if (m_y != null)
      {
        children.Add(m_y);
      }

      if (m_z != null)
      {
        children.Add(m_z);
      }

      if (m_units != null)
      {
        children.Add(m_units);
      }

      base.GetChildren(context, children);
    }

    /// <summary>
    /// Finds the child with the specified browse name.
    /// </summary>
    protected override BaseInstanceState FindChild(
        ISystemContext context,
        QualifiedName browseName,
        bool createOrReplace,
        BaseInstanceState replacement)
    {
      if (QualifiedName.IsNull(browseName))
      {
        return null;
      }

      BaseInstanceState instance = null;

      switch (browseName.Name)
      {
        case DigitalTwin.Comms.Ua.BrowseNames.X:
          {
            if (createOrReplace)
            {
              if (X == null)
              {
                if (replacement == null)
                {
                  X = new BaseDataVariableState<double>(this);
                }
                else
                {
                  X = (BaseDataVariableState<double>)replacement;
                }
              }
            }

            instance = X;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Y:
          {
            if (createOrReplace)
            {
              if (Y == null)
              {
                if (replacement == null)
                {
                  Y = new BaseDataVariableState<double>(this);
                }
                else
                {
                  Y = (BaseDataVariableState<double>)replacement;
                }
              }
            }

            instance = Y;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Z:
          {
            if (createOrReplace)
            {
              if (Z == null)
              {
                if (replacement == null)
                {
                  Z = new BaseDataVariableState<double>(this);
                }
                else
                {
                  Z = (BaseDataVariableState<double>)replacement;
                }
              }
            }

            instance = Z;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Units:
          {
            if (createOrReplace)
            {
              if (Units == null)
              {
                if (replacement == null)
                {
                  Units = new PropertyState<string>(this);
                }
                else
                {
                  Units = (PropertyState<string>)replacement;
                }
              }
            }

            instance = Units;
            break;
          }
      }

      if (instance != null)
      {
        return instance;
      }

      return base.FindChild(context, browseName, createOrReplace, replacement);
    }
    #endregion

    #region Private Fields
    private BaseDataVariableState<double> m_x;
    private BaseDataVariableState<double> m_y;
    private BaseDataVariableState<double> m_z;
    private PropertyState<string> m_units;
    #endregion
  }
#endif
  #endregion

  #region PushbuttonEventState Class
#if (!OPCUA_EXCLUDE_PushbuttonEventState)
  /// <summary>
  /// Stores an instance of the PushbuttonEventType ObjectType.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public partial class PushbuttonEventState : BaseEventState
  {
    #region Constructors
    /// <summary>
    /// Initializes the type with its default attribute values.
    /// </summary>
    public PushbuttonEventState(NodeState parent) : base(parent)
    {
    }

    /// <summary>
    /// Returns the id of the default type definition node for the instance.
    /// </summary>
    protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
    {
      return Opc.Ua.NodeId.Create(DigitalTwin.Comms.Ua.ObjectTypes.PushbuttonEventType, DigitalTwin.Comms.Ua.Namespaces.PiDigitalTwin, namespaceUris);
    }

#if (!OPCUA_EXCLUDE_InitializationStrings)
    /// <summary>
    /// Initializes the instance.
    /// </summary>
    protected override void Initialize(ISystemContext context)
    {
      base.Initialize(context);
      Initialize(context, InitializationString);
      InitializeOptionalChildren(context);
    }

    /// <summary>
    /// Initializes the instance with a node.
    /// </summary>
    protected override void Initialize(ISystemContext context, NodeState source)
    {
      InitializeOptionalChildren(context);
      base.Initialize(context, source);
    }

    /// <summary>
    /// Initializes the any option children defined for the instance.
    /// </summary>
    protected override void InitializeOptionalChildren(ISystemContext context)
    {
      base.InitializeOptionalChildren(context);
    }

    #region Initialization String
    private const string InitializationString =
       "AQAAACgAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaURpZ2l0YWxUd2lu/////wRggAIBAAAA" +
       "AQAbAAAAUHVzaGJ1dHRvbkV2ZW50VHlwZUluc3RhbmNlAQEGAAEBBgAGAAAA/////wkAAAAVYIkKAgAA" +
       "AAAABwAAAEV2ZW50SWQBAQcAAC4ARAcAAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
       "dFR5cGUBAQgAAC4ARAgAAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEJ" +
       "AAAuAEQJAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBCgAALgBECgAA" +
       "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAQsAAC4ARAsAAAABACYB/////wEB////" +
       "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEMAAAuAEQMAAAAAQAmAf////8BAf////8AAAAA" +
       "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQEOAAAuAEQOAAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
       "AAAAU2V2ZXJpdHkBAQ8AAC4ARA8AAAAABf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQdXNoYnV0" +
       "dG9uU3RhdGUBARAAAC4ARBAAAAAAAf////8BAf////8AAAAA";
    #endregion
#endif
    #endregion

    #region Public Properties
    /// <remarks />
    public PropertyState<bool> PushbuttonState
    {
      get
      {
        return m_pushbuttonState;
      }

      set
      {
        if (!Object.ReferenceEquals(m_pushbuttonState, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_pushbuttonState = value;
      }
    }
    #endregion

    #region Overridden Methods
    /// <summary>
    /// Populates a list with the children that belong to the node.
    /// </summary>
    /// <param name="context">The context for the system being accessed.</param>
    /// <param name="children">The list of children to populate.</param>
    public override void GetChildren(
        ISystemContext context,
        IList<BaseInstanceState> children)
    {
      if (m_pushbuttonState != null)
      {
        children.Add(m_pushbuttonState);
      }

      base.GetChildren(context, children);
    }

    /// <summary>
    /// Finds the child with the specified browse name.
    /// </summary>
    protected override BaseInstanceState FindChild(
        ISystemContext context,
        QualifiedName browseName,
        bool createOrReplace,
        BaseInstanceState replacement)
    {
      if (QualifiedName.IsNull(browseName))
      {
        return null;
      }

      BaseInstanceState instance = null;

      switch (browseName.Name)
      {
        case DigitalTwin.Comms.Ua.BrowseNames.PushbuttonState:
          {
            if (createOrReplace)
            {
              if (PushbuttonState == null)
              {
                if (replacement == null)
                {
                  PushbuttonState = new PropertyState<bool>(this);
                }
                else
                {
                  PushbuttonState = (PropertyState<bool>)replacement;
                }
              }
            }

            instance = PushbuttonState;
            break;
          }
      }

      if (instance != null)
      {
        return instance;
      }

      return base.FindChild(context, browseName, createOrReplace, replacement);
    }
    #endregion

    #region Private Fields
    private PropertyState<bool> m_pushbuttonState;
    #endregion
  }
#endif
  #endregion

  #region JoystickState Class
#if (!OPCUA_EXCLUDE_JoystickState)
  /// <summary>
  /// Stores an instance of the JoystickType ObjectType.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public partial class JoystickState : BaseObjectState
  {
    #region Constructors
    /// <summary>
    /// Initializes the type with its default attribute values.
    /// </summary>
    public JoystickState(NodeState parent) : base(parent)
    {
    }

    /// <summary>
    /// Returns the id of the default type definition node for the instance.
    /// </summary>
    protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
    {
      return Opc.Ua.NodeId.Create(DigitalTwin.Comms.Ua.ObjectTypes.JoystickType, DigitalTwin.Comms.Ua.Namespaces.PiDigitalTwin, namespaceUris);
    }

#if (!OPCUA_EXCLUDE_InitializationStrings)
    /// <summary>
    /// Initializes the instance.
    /// </summary>
    protected override void Initialize(ISystemContext context)
    {
      base.Initialize(context);
      Initialize(context, InitializationString);
      InitializeOptionalChildren(context);
    }

    /// <summary>
    /// Initializes the instance with a node.
    /// </summary>
    protected override void Initialize(ISystemContext context, NodeState source)
    {
      InitializeOptionalChildren(context);
      base.Initialize(context, source);
    }

    /// <summary>
    /// Initializes the any option children defined for the instance.
    /// </summary>
    protected override void InitializeOptionalChildren(ISystemContext context)
    {
      base.InitializeOptionalChildren(context);
    }

    #region Initialization String
    private const string InitializationString =
       "AQAAACgAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaURpZ2l0YWxUd2lu/////4RggAIBAAAA" +
       "AQAUAAAASm95c3RpY2tUeXBlSW5zdGFuY2UBAREAAQERABEAAAABAQAAAAAkAAEBFgAFAAAANWCJCgIA" +
       "AAABAAIAAABVcAEBEgADAAAAAAwAAABVcCBkaXJlY3Rpb24ALwA/EgAAAAAB/////wEB/////wAAAAA1" +
       "YIkKAgAAAAEABAAAAERvd24BARMAAwAAAAAOAAAARG93biBkaXJlY3Rpb24ALwA/EwAAAAAB/////wEB" +
       "/////wAAAAA1YIkKAgAAAAEABAAAAExlZnQBARQAAwAAAAAOAAAATGVmdCBkaXJlY3Rpb24ALwA/FAAA" +
       "AAAB/////wEB/////wAAAAA1YIkKAgAAAAEABQAAAFJpZ2h0AQEVAAMAAAAADwAAAFJpZ2h0IGRpcmVj" +
       "dGlvbgAvAD8VAAAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAKAAAAUHVzaGJ1dHRvbgEBFgADAAAA" +
       "AAoAAABQdXNoYnV0dG9uAC8APxYAAAAAAf////8BAQEAAAAAJAEBAREAAAAAAA==";
    #endregion
#endif
    #endregion

    #region Public Properties
    /// <remarks />
    public BaseDataVariableState<bool> Up
    {
      get
      {
        return m_up;
      }

      set
      {
        if (!Object.ReferenceEquals(m_up, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_up = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<bool> Down
    {
      get
      {
        return m_down;
      }

      set
      {
        if (!Object.ReferenceEquals(m_down, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_down = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<bool> Left
    {
      get
      {
        return m_left;
      }

      set
      {
        if (!Object.ReferenceEquals(m_left, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_left = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<bool> Right
    {
      get
      {
        return m_right;
      }

      set
      {
        if (!Object.ReferenceEquals(m_right, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_right = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<bool> Pushbutton
    {
      get
      {
        return m_pushbutton;
      }

      set
      {
        if (!Object.ReferenceEquals(m_pushbutton, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_pushbutton = value;
      }
    }
    #endregion

    #region Overridden Methods
    /// <summary>
    /// Populates a list with the children that belong to the node.
    /// </summary>
    /// <param name="context">The context for the system being accessed.</param>
    /// <param name="children">The list of children to populate.</param>
    public override void GetChildren(
        ISystemContext context,
        IList<BaseInstanceState> children)
    {
      if (m_up != null)
      {
        children.Add(m_up);
      }

      if (m_down != null)
      {
        children.Add(m_down);
      }

      if (m_left != null)
      {
        children.Add(m_left);
      }

      if (m_right != null)
      {
        children.Add(m_right);
      }

      if (m_pushbutton != null)
      {
        children.Add(m_pushbutton);
      }

      base.GetChildren(context, children);
    }

    /// <summary>
    /// Finds the child with the specified browse name.
    /// </summary>
    protected override BaseInstanceState FindChild(
        ISystemContext context,
        QualifiedName browseName,
        bool createOrReplace,
        BaseInstanceState replacement)
    {
      if (QualifiedName.IsNull(browseName))
      {
        return null;
      }

      BaseInstanceState instance = null;

      switch (browseName.Name)
      {
        case DigitalTwin.Comms.Ua.BrowseNames.Up:
          {
            if (createOrReplace)
            {
              if (Up == null)
              {
                if (replacement == null)
                {
                  Up = new BaseDataVariableState<bool>(this);
                }
                else
                {
                  Up = (BaseDataVariableState<bool>)replacement;
                }
              }
            }

            instance = Up;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Down:
          {
            if (createOrReplace)
            {
              if (Down == null)
              {
                if (replacement == null)
                {
                  Down = new BaseDataVariableState<bool>(this);
                }
                else
                {
                  Down = (BaseDataVariableState<bool>)replacement;
                }
              }
            }

            instance = Down;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Left:
          {
            if (createOrReplace)
            {
              if (Left == null)
              {
                if (replacement == null)
                {
                  Left = new BaseDataVariableState<bool>(this);
                }
                else
                {
                  Left = (BaseDataVariableState<bool>)replacement;
                }
              }
            }

            instance = Left;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Right:
          {
            if (createOrReplace)
            {
              if (Right == null)
              {
                if (replacement == null)
                {
                  Right = new BaseDataVariableState<bool>(this);
                }
                else
                {
                  Right = (BaseDataVariableState<bool>)replacement;
                }
              }
            }

            instance = Right;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Pushbutton:
          {
            if (createOrReplace)
            {
              if (Pushbutton == null)
              {
                if (replacement == null)
                {
                  Pushbutton = new BaseDataVariableState<bool>(this);
                }
                else
                {
                  Pushbutton = (BaseDataVariableState<bool>)replacement;
                }
              }
            }

            instance = Pushbutton;
            break;
          }
      }

      if (instance != null)
      {
        return instance;
      }

      return base.FindChild(context, browseName, createOrReplace, replacement);
    }
    #endregion

    #region Private Fields
    private BaseDataVariableState<bool> m_up;
    private BaseDataVariableState<bool> m_down;
    private BaseDataVariableState<bool> m_left;
    private BaseDataVariableState<bool> m_right;
    private BaseDataVariableState<bool> m_pushbutton;
    #endregion
  }
#endif
  #endregion

  #region RGBLEDState Class
#if (!OPCUA_EXCLUDE_RGBLEDState)
  /// <summary>
  /// Stores an instance of the RGBLEDType ObjectType.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public partial class RGBLEDState : BaseObjectState
  {
    #region Constructors
    /// <summary>
    /// Initializes the type with its default attribute values.
    /// </summary>
    public RGBLEDState(NodeState parent) : base(parent)
    {
    }

    /// <summary>
    /// Returns the id of the default type definition node for the instance.
    /// </summary>
    protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
    {
      return Opc.Ua.NodeId.Create(DigitalTwin.Comms.Ua.ObjectTypes.RGBLEDType, DigitalTwin.Comms.Ua.Namespaces.PiDigitalTwin, namespaceUris);
    }

#if (!OPCUA_EXCLUDE_InitializationStrings)
    /// <summary>
    /// Initializes the instance.
    /// </summary>
    protected override void Initialize(ISystemContext context)
    {
      base.Initialize(context);
      Initialize(context, InitializationString);
      InitializeOptionalChildren(context);
    }

    /// <summary>
    /// Initializes the instance with a node.
    /// </summary>
    protected override void Initialize(ISystemContext context, NodeState source)
    {
      InitializeOptionalChildren(context);
      base.Initialize(context, source);
    }

    /// <summary>
    /// Initializes the any option children defined for the instance.
    /// </summary>
    protected override void InitializeOptionalChildren(ISystemContext context)
    {
      base.InitializeOptionalChildren(context);
    }

    #region Initialization String
    private const string InitializationString =
       "AQAAACgAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaURpZ2l0YWxUd2lu/////wRggAIBAAAA" +
       "AQASAAAAUkdCTEVEVHlwZUluc3RhbmNlAQEXAAEBFwAXAAAA/////wMAAAA1YIkKAgAAAAEAAwAAAFJl" +
       "ZAEBGAADAAAAAA0AAABSZWQgaW50ZW5zaXR5AC8APxgAAAAAA/////8BAf////8AAAAANWCJCgIAAAAB" +
       "AAUAAABHcmVlbgEBGQADAAAAAA8AAABHcmVlbiBpbnRlbnNpdHkALwA/GQAAAAAD/////wEB/////wAA" +
       "AAA1YIkKAgAAAAEABAAAAEJsdWUBARoAAwAAAAAOAAAAQmx1ZSBpbnRlbnNpdHkALwA/GgAAAAAD////" +
       "/wEB/////wAAAAA=";
    #endregion
#endif
    #endregion

    #region Public Properties
    /// <remarks />
    public BaseDataVariableState<byte> Red
    {
      get
      {
        return m_red;
      }

      set
      {
        if (!Object.ReferenceEquals(m_red, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_red = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<byte> Green
    {
      get
      {
        return m_green;
      }

      set
      {
        if (!Object.ReferenceEquals(m_green, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_green = value;
      }
    }

    /// <remarks />
    public BaseDataVariableState<byte> Blue
    {
      get
      {
        return m_blue;
      }

      set
      {
        if (!Object.ReferenceEquals(m_blue, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_blue = value;
      }
    }
    #endregion

    #region Overridden Methods
    /// <summary>
    /// Populates a list with the children that belong to the node.
    /// </summary>
    /// <param name="context">The context for the system being accessed.</param>
    /// <param name="children">The list of children to populate.</param>
    public override void GetChildren(
        ISystemContext context,
        IList<BaseInstanceState> children)
    {
      if (m_red != null)
      {
        children.Add(m_red);
      }

      if (m_green != null)
      {
        children.Add(m_green);
      }

      if (m_blue != null)
      {
        children.Add(m_blue);
      }

      base.GetChildren(context, children);
    }

    /// <summary>
    /// Finds the child with the specified browse name.
    /// </summary>
    protected override BaseInstanceState FindChild(
        ISystemContext context,
        QualifiedName browseName,
        bool createOrReplace,
        BaseInstanceState replacement)
    {
      if (QualifiedName.IsNull(browseName))
      {
        return null;
      }

      BaseInstanceState instance = null;

      switch (browseName.Name)
      {
        case DigitalTwin.Comms.Ua.BrowseNames.Red:
          {
            if (createOrReplace)
            {
              if (Red == null)
              {
                if (replacement == null)
                {
                  Red = new BaseDataVariableState<byte>(this);
                }
                else
                {
                  Red = (BaseDataVariableState<byte>)replacement;
                }
              }
            }

            instance = Red;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Green:
          {
            if (createOrReplace)
            {
              if (Green == null)
              {
                if (replacement == null)
                {
                  Green = new BaseDataVariableState<byte>(this);
                }
                else
                {
                  Green = (BaseDataVariableState<byte>)replacement;
                }
              }
            }

            instance = Green;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Blue:
          {
            if (createOrReplace)
            {
              if (Blue == null)
              {
                if (replacement == null)
                {
                  Blue = new BaseDataVariableState<byte>(this);
                }
                else
                {
                  Blue = (BaseDataVariableState<byte>)replacement;
                }
              }
            }

            instance = Blue;
            break;
          }
      }

      if (instance != null)
      {
        return instance;
      }

      return base.FindChild(context, browseName, createOrReplace, replacement);
    }
    #endregion

    #region Private Fields
    private BaseDataVariableState<byte> m_red;
    private BaseDataVariableState<byte> m_green;
    private BaseDataVariableState<byte> m_blue;
    #endregion
  }
#endif
  #endregion

  #region SenseHatVirtualTwinState Class
#if (!OPCUA_EXCLUDE_SenseHatVirtualTwinState)
  /// <summary>
  /// Stores an instance of the SenseHatVirtualTwinType ObjectType.
  /// </summary>
  /// <exclude />
  [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
  public partial class SenseHatVirtualTwinState : BaseObjectState
  {
    #region Constructors
    /// <summary>
    /// Initializes the type with its default attribute values.
    /// </summary>
    public SenseHatVirtualTwinState(NodeState parent) : base(parent)
    {
    }

    /// <summary>
    /// Returns the id of the default type definition node for the instance.
    /// </summary>
    protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
    {
      return Opc.Ua.NodeId.Create(DigitalTwin.Comms.Ua.ObjectTypes.SenseHatVirtualTwinType, DigitalTwin.Comms.Ua.Namespaces.PiDigitalTwin, namespaceUris);
    }

#if (!OPCUA_EXCLUDE_InitializationStrings)
    /// <summary>
    /// Initializes the instance.
    /// </summary>
    protected override void Initialize(ISystemContext context)
    {
      base.Initialize(context);
      Initialize(context, InitializationString);
      InitializeOptionalChildren(context);
    }

    /// <summary>
    /// Initializes the instance with a node.
    /// </summary>
    protected override void Initialize(ISystemContext context, NodeState source)
    {
      InitializeOptionalChildren(context);
      base.Initialize(context, source);
    }

    /// <summary>
    /// Initializes the any option children defined for the instance.
    /// </summary>
    protected override void InitializeOptionalChildren(ISystemContext context)
    {
      base.InitializeOptionalChildren(context);
    }

    #region Initialization String
    private const string InitializationString =
       "AQAAACgAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaURpZ2l0YWxUd2lu/////4RggAIBAAAA" +
       "AQAfAAAAU2Vuc2VIYXRWaXJ0dWFsVHdpblR5cGVJbnN0YW5jZQEBGwABARsAGwAAAAECAAAAADAAAQEr" +
       "AAAwAQEAzQgFAAAABGCACgEAAAABAAwAAABNYWduZXRvbWV0ZXIBARwAAC8BAQEAHAAAAP////8EAAAA" +
       "NWCJCgIAAAABAAEAAABYAQEdAAMAAAAADQAAAFgtYXhpcyBvdXRwdXQALwA/HQAAAAAL/////wEB////" +
       "/wAAAAA1YIkKAgAAAAEAAQAAAFkBAR4AAwAAAAANAAAAWS1heGlzIG91dHB1dAAvAD8eAAAAAAv/////" +
       "AQH/////AAAAADVgiQoCAAAAAQABAAAAWgEBHwADAAAAAA0AAABaLWF4aXMgb3V0cHV0AC8APx8AAAAA" +
       "C/////8BAf////8AAAAANWCJCgIAAAABAAUAAABVbml0cwEBIAADAAAAAAwAAABTZW5zb3IgdW5pdHMA" +
       "LgBEIAAAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAEFjY2VsZXJvbWV0ZXIBASEAAC8BAQEA" +
       "IQAAAP////8EAAAANWCJCgIAAAABAAEAAABYAQEiAAMAAAAADQAAAFgtYXhpcyBvdXRwdXQALwA/IgAA" +
       "AAAL/////wEB/////wAAAAA1YIkKAgAAAAEAAQAAAFkBASMAAwAAAAANAAAAWS1heGlzIG91dHB1dAAv" +
       "AD8jAAAAAAv/////AQH/////AAAAADVgiQoCAAAAAQABAAAAWgEBJAADAAAAAA0AAABaLWF4aXMgb3V0" +
       "cHV0AC8APyQAAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAUAAABVbml0cwEBJQADAAAAAAwAAABT" +
       "ZW5zb3IgdW5pdHMALgBEJQAAAAAM/////wEB/////wAAAAAEYMAKAQAAAAsAAABBbmd1bGFyUmF0ZQEA" +
       "EwAAAEFuZ3VsYXIgcmF0ZSBzZW5zb3IBASYAAC8BAQEAJgAAAP////8EAAAANWCJCgIAAAABAAEAAABY" +
       "AQEnAAMAAAAADQAAAFgtYXhpcyBvdXRwdXQALwA/JwAAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEA" +
       "AQAAAFkBASgAAwAAAAANAAAAWS1heGlzIG91dHB1dAAvAD8oAAAAAAv/////AQH/////AAAAADVgiQoC" +
       "AAAAAQABAAAAWgEBKQADAAAAAA0AAABaLWF4aXMgb3V0cHV0AC8APykAAAAAC/////8BAf////8AAAAA" +
       "NWCJCgIAAAABAAUAAABVbml0cwEBKgADAAAAAAwAAABTZW5zb3IgdW5pdHMALgBEKgAAAAAM/////wEB" +
       "/////wAAAACEYMAKAQAAAAgAAABKb3lzdGljawEAJwAAAEZvdXItZGlyZWN0aW9uIGpveXN0aWNrIHdp" +
       "dGggcHVzaGJ1dHRvbgEBKwAALwEBEQArAAAAAQIAAAAAMAEBARsAACQAAQEwAAUAAAA1YIkKAgAAAAEA" +
       "AgAAAFVwAQEsAAMAAAAADAAAAFVwIGRpcmVjdGlvbgAvAD8sAAAAAAH/////AQH/////AAAAADVgiQoC" +
       "AAAAAQAEAAAARG93bgEBLQADAAAAAA4AAABEb3duIGRpcmVjdGlvbgAvAD8tAAAAAAH/////AQH/////" +
       "AAAAADVgiQoCAAAAAQAEAAAATGVmdAEBLgADAAAAAA4AAABMZWZ0IGRpcmVjdGlvbgAvAD8uAAAAAAH/" +
       "////AQH/////AAAAADVgiQoCAAAAAQAFAAAAUmlnaHQBAS8AAwAAAAAPAAAAUmlnaHQgZGlyZWN0aW9u" +
       "AC8APy8AAAAAAf////8BAf////8AAAAANWCJCgIAAAABAAoAAABQdXNoYnV0dG9uAQEwAAMAAAAACgAA" +
       "AFB1c2hidXR0b24ALwA/MAAAAAAB/////wEBAQAAAAAkAQEBKwAAAAAABGDACgEAAAADAAAATEVEAQAH" +
       "AAAAUkdCIExFRAEBMQAALwEBFwAxAAAA/////wMAAAA1YIkKAgAAAAEAAwAAAFJlZAEBMgADAAAAAA0A" +
       "AABSZWQgaW50ZW5zaXR5AC8APzIAAAAAA/////8BAf////8AAAAANWCJCgIAAAABAAUAAABHcmVlbgEB" +
       "MwADAAAAAA8AAABHcmVlbiBpbnRlbnNpdHkALwA/MwAAAAAD/////wEB/////wAAAAA1YIkKAgAAAAEA" +
       "BAAAAEJsdWUBATQAAwAAAAAOAAAAQmx1ZSBpbnRlbnNpdHkALwA/NAAAAAAD/////wEB/////wAAAAA=";
    #endregion
#endif
    #endregion

    #region Public Properties
    /// <remarks />
    public Sensor3DState Magnetometer
    {
      get
      {
        return m_magnetometer;
      }

      set
      {
        if (!Object.ReferenceEquals(m_magnetometer, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_magnetometer = value;
      }
    }

    /// <remarks />
    public Sensor3DState Accelerometer
    {
      get
      {
        return m_accelerometer;
      }

      set
      {
        if (!Object.ReferenceEquals(m_accelerometer, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_accelerometer = value;
      }
    }

    /// <remarks />
    public Sensor3DState AngularRate
    {
      get
      {
        return m_angularRate;
      }

      set
      {
        if (!Object.ReferenceEquals(m_angularRate, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_angularRate = value;
      }
    }

    /// <remarks />
    public JoystickState Joystick
    {
      get
      {
        return m_joystick;
      }

      set
      {
        if (!Object.ReferenceEquals(m_joystick, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_joystick = value;
      }
    }

    /// <remarks />
    public RGBLEDState LED
    {
      get
      {
        return m_lED;
      }

      set
      {
        if (!Object.ReferenceEquals(m_lED, value))
        {
          ChangeMasks |= NodeStateChangeMasks.Children;
        }

        m_lED = value;
      }
    }
    #endregion

    #region Overridden Methods
    /// <summary>
    /// Populates a list with the children that belong to the node.
    /// </summary>
    /// <param name="context">The context for the system being accessed.</param>
    /// <param name="children">The list of children to populate.</param>
    public override void GetChildren(
        ISystemContext context,
        IList<BaseInstanceState> children)
    {
      if (m_magnetometer != null)
      {
        children.Add(m_magnetometer);
      }

      if (m_accelerometer != null)
      {
        children.Add(m_accelerometer);
      }

      if (m_angularRate != null)
      {
        children.Add(m_angularRate);
      }

      if (m_joystick != null)
      {
        children.Add(m_joystick);
      }

      if (m_lED != null)
      {
        children.Add(m_lED);
      }

      base.GetChildren(context, children);
    }

    /// <summary>
    /// Finds the child with the specified browse name.
    /// </summary>
    protected override BaseInstanceState FindChild(
        ISystemContext context,
        QualifiedName browseName,
        bool createOrReplace,
        BaseInstanceState replacement)
    {
      if (QualifiedName.IsNull(browseName))
      {
        return null;
      }

      BaseInstanceState instance = null;

      switch (browseName.Name)
      {
        case DigitalTwin.Comms.Ua.BrowseNames.Magnetometer:
          {
            if (createOrReplace)
            {
              if (Magnetometer == null)
              {
                if (replacement == null)
                {
                  Magnetometer = new Sensor3DState(this);
                }
                else
                {
                  Magnetometer = (Sensor3DState)replacement;
                }
              }
            }

            instance = Magnetometer;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Accelerometer:
          {
            if (createOrReplace)
            {
              if (Accelerometer == null)
              {
                if (replacement == null)
                {
                  Accelerometer = new Sensor3DState(this);
                }
                else
                {
                  Accelerometer = (Sensor3DState)replacement;
                }
              }
            }

            instance = Accelerometer;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.AngularRate:
          {
            if (createOrReplace)
            {
              if (AngularRate == null)
              {
                if (replacement == null)
                {
                  AngularRate = new Sensor3DState(this);
                }
                else
                {
                  AngularRate = (Sensor3DState)replacement;
                }
              }
            }

            instance = AngularRate;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.Joystick:
          {
            if (createOrReplace)
            {
              if (Joystick == null)
              {
                if (replacement == null)
                {
                  Joystick = new JoystickState(this);
                }
                else
                {
                  Joystick = (JoystickState)replacement;
                }
              }
            }

            instance = Joystick;
            break;
          }

        case DigitalTwin.Comms.Ua.BrowseNames.LED:
          {
            if (createOrReplace)
            {
              if (LED == null)
              {
                if (replacement == null)
                {
                  LED = new RGBLEDState(this);
                }
                else
                {
                  LED = (RGBLEDState)replacement;
                }
              }
            }

            instance = LED;
            break;
          }
      }

      if (instance != null)
      {
        return instance;
      }

      return base.FindChild(context, browseName, createOrReplace, replacement);
    }
    #endregion

    #region Private Fields
    private Sensor3DState m_magnetometer;
    private Sensor3DState m_accelerometer;
    private Sensor3DState m_angularRate;
    private JoystickState m_joystick;
    private RGBLEDState m_lED;
    #endregion
  }
#endif
  #endregion
}