namespace NodesApp.DAL.Entities
{
    public class Message
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public Message ReplyTo { get; set; }
        public User Sender { get; set; }


    }
}
