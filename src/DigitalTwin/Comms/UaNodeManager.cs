using DigitalTwins.Comms.Ua;
using DigitalTwins.Comms;
using Microsoft.Extensions.Logging;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;
using DigitalTwin.Virtual;

namespace DigitalTwins.Comms
{
  /// <summary>
  /// A node manager for a server that exposes several variables.
  /// </summary>
  public class UaNodeManager : CustomNodeManager2
  {
    public const string UaServerNamespace = "http://mkecybertech.com/UA/PiDigitalTwin";
    private readonly UaServer uaServer;

    #region Constructors
    /// <summary>
    /// Initializes the node manager.
    /// </summary>
    public UaNodeManager(
      IServerInternal internalServer,
      ApplicationConfiguration configuration,
      UaServer uaServer)
      : base(internalServer, configuration, UaServerNamespace)
    {
      this.uaServer = uaServer ?? throw new ArgumentNullException(nameof(uaServer));

      SystemContext.NodeIdFactory = this;

      List<string> namespaceUris = new List<string>()
      {
        DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin,
        DigitalTwins.Comms.Ua.Namespaces.PiDigitalTwin + "/Instance"
      };

      NamespaceUris = namespaceUris;

      m_typeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
      m_namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);

      logger = uaServer.GetLogger<UaNodeManager>();
    }
    #endregion

    #region IDisposable Members
    /// <summary>
    /// An overrideable version of the Dispose.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
      }
    }
    #endregion

    #region INodeIdFactory Members
    /// <summary>
    /// Creates the NodeId for the specified node.
    /// </summary>
    public override NodeId New(ISystemContext context, NodeState node)
    {
      return node.NodeId;
    }
    #endregion

    #region INodeManager Members
    /// <summary>
    /// Does any initialization required before the address space can be used.
    /// </summary>
    /// <remarks>
    /// The externalReferences is an out parameter that allows the node manager to link to nodes
    /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
    /// should have a reference to the root folder node(s) exposed by this node manager.  
    /// </remarks>
    public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
    {
      lock (Lock)
      {
        base.CreateAddressSpace(externalReferences);

        if (!externalReferences.TryGetValue(Opc.Ua.ObjectIds.RootFolder, out IList<IReference>? references))
        {
          references = new List<IReference>();
          externalReferences[Opc.Ua.ObjectIds.RootFolder] = references;
        }

        // Create server folder
        FolderState serverFolder = new FolderState(null);
        serverFolder.Create(
          SystemContext,
          new NodeId(Guid.NewGuid(), NamespaceIndex),
          new QualifiedName("DigitalTwin", m_namespaceIndex),
          null,
          false);

        references.Add(new NodeStateReference(ReferenceTypeIds.Organizes, false, serverFolder.NodeId));
        serverFolder.AddReference(ReferenceTypeIds.Organizes, true, Opc.Ua.ObjectIds.RootFolder);

        AddPredefinedNode(SystemContext, serverFolder);

        // Initialize virtual twin node
        VirtualTwinNode = VirtualTwin.CreateUaNode(
          SystemContext,
          m_namespaceIndex,
          serverFolder);
        AddPredefinedNode(SystemContext, VirtualTwinNode);
      }
    }

    /// <summary>
    /// Frees any resources allocated for the address space.
    /// </summary>
    public override void DeleteAddressSpace()
    {
      lock (Lock)
      {
        base.DeleteAddressSpace();
      }
    }

    /// <summary>
    /// Returns a unique handle for the node.
    /// </summary>
    protected override NodeHandle GetManagerHandle(ServerSystemContext context, NodeId nodeId, IDictionary<NodeId, NodeState> cache)
    {
      lock (Lock)
      {
        // quickly exclude nodes that are not in the namespace. 
        if (!IsNodeIdInNamespace(nodeId))
        {
          return null;
        }

        NodeState node = null;

        if (!PredefinedNodes.TryGetValue(nodeId, out node))
        {
          return null;
        }

        NodeHandle handle = new NodeHandle();

        handle.NodeId = nodeId;
        handle.Node = node;
        handle.Validated = true;

        return handle;
      }
    }

    /// <summary>
    /// Verifies that the specified node exists.
    /// </summary>
    protected override NodeState ValidateNode(
        ServerSystemContext context,
        NodeHandle handle,
        IDictionary<NodeId, NodeState> cache)
    {
      // not valid if no root.
      if (handle == null)
      {
        return null;
      }

      // check if previously validated.
      if (handle.Validated)
      {
        return handle.Node;
      }

      // TBD

      return null;
    }
    #endregion

    #region Overridden Methods
    #endregion

    #region Custom Methods
    #endregion

    #region Private Fields
    private ushort m_namespaceIndex;
    private ushort m_typeNamespaceIndex;

    private readonly ILogger<UaNodeManager> logger;

    private SenseHatVirtualTwinState VirtualTwinNode = null;
    #endregion
  }

}
