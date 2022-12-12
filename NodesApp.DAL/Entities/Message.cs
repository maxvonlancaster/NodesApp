using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NodesApp.DAL.Entities
{
    public class Message
    {
        [Key]
        public long MessageId { get; set; }
        public long? MessageReplyTo { get; set; }
        public string Text { get; set; }
        public long ReceiverId { get; set; }
        public long SenderId { get; set; }


        [ForeignKey("MessageReplyTo")]
        public virtual Message ReplyTo { get; set; }
        [ForeignKey("SenderId")]
        public virtual User Sender { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("ReceiverId")]
        public virtual User Receiver { get; set; }


    }
}
