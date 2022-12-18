using NodesApp.DAL.Entities;
using static NodesApp.DAL.Utils.Enums;

namespace NodesApp.Models
{
    public class NodeModel
    {
        public long NodeId { get; set; }
        public string Link { get; set; }
        public string NodeName { get; set; }
        public string Text { get; set; }
        public byte[]? File { get; set; }
        public ColorsEnum Color { get; set; }
        public NodeTypeEnum NodeType { get; set; }
        public DateTime DateCreated { get; set; }

        public NodeModel(Node node)
        {
            NodeId = node.NodeId;
            Link = node.Link;   
            NodeName = node.NodeName;
            Text = node.Text;
            File = node.File;
            Color = node.Color;
            NodeType = node.NodeType;
            DateCreated = node.DateCreated;
        }

        public NodeModel()
        {
        }

        public Node ToEntity() 
        {
            return new Node() 
            {
                NodeId = NodeId,
                Link = Link,
                NodeName = NodeName,
                Text = Text,
                File = File,
                Color = Color,
                NodeType = NodeType,
                DateCreated = DateCreated
            };
        }
    }
}
