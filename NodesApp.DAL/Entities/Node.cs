using System.ComponentModel.DataAnnotations;
using static NodesApp.DAL.Utils.Enums;

namespace NodesApp.DAL.Entities
{
    public class Node
    {
        [Key]
        public long NodeId { get; set; }
        public string Link { get; set; }
        public string NodeName { get; set; }
        public string Text { get; set; }
        public byte[]? File { get; set; }
        public ColorsEnum Color { get; set; }
        public NodeTypeEnum NodeType { get; set; }
        public DateTime DateCreated { get; set; }


        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<UserNode> UserNodes { get; set; }

    }
}
