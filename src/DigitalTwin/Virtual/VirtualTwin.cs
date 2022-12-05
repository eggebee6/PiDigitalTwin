using DigitalTwins.Comms.Ua;
using DigitalTwins.Comms;
using Microsoft.Extensions.Logging;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalTwin.Virtual
{
  public class VirtualTwin
  {
    public static SenseHatVirtualTwinState CreateUaNode(
      ServerSystemContext systemContext,
      ushort namespaceIndex,
      FolderState serverFolder)
    {
      // Create virtual twin node
      var node = new SenseHatVirtualTwinState(serverFolder);
      node.Create(
        systemContext,
        null,
        new QualifiedName("VirtualTwin", namespaceIndex),
        null,
        true);

      // Add folder references
      node.AddReference(ReferenceTypeIds.Organizes, true, serverFolder.NodeId);
      serverFolder.AddReference(ReferenceTypeIds.Organizes, false, node.NodeId);

      // Add notifier references
      node.AddReference(ReferenceTypeIds.HasNotifier, true, serverFolder.NodeId);
      serverFolder.AddReference(ReferenceTypeIds.HasNotifier, false, node.NodeId);

      // Return created node
      return node;
    }
  }
}
