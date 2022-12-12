using System.ComponentModel.DataAnnotations;
using static NodesApp.DAL.Utils.Enums;

namespace NodesApp.DAL.Entities
{
    public class UserNode
    {
        [Key]
        public long UserNodeId { get; set; }
        public long UserId { get; set; }
        public long NodeId { get; set; }
        public UserTypeEnum UserType { get; set; }

        public virtual User User { get; set; }
        public virtual Node Node { get; set; }

    }
}
