using System.ComponentModel.DataAnnotations;

namespace NodesApp.DAL.Entities
{
    public class NodeSettings
    {
        [Key]
        public long NodeSettingsId { get; set; }
        public long NodeId { get; set; }


        public virtual Node Node { get; set; }
    
    
    }
}
