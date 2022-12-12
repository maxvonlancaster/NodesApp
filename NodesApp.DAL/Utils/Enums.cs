namespace NodesApp.DAL.Utils
{
    public class Enums
    {
        public enum NodeTypeEnum 
        {
            SinglePost,
            Gallery,
            Sub,
            Board,
            Slack,
            Group,
            Forum
        }

        public enum NodeActive 
        {
            Active,
            Quarantined,
            Banned
        }

        public enum UserTypeEnum
        { 
            Owner,
            Admin,
            Member,
            Quarantined,
            Banned
        }

        public enum ColorsEnum
        {
            
        }

        public enum NoYesEnum
        {
        
        }


    }
}
