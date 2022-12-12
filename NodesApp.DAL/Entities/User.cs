using static NodesApp.DAL.Utils.Enums;

namespace NodesApp.DAL.Entities
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserTypeEnum UserType { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual List<UserNode> UserNodes { get; set; }

    }
}
