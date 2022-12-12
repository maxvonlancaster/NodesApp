namespace NodesApp.DAL.Entities
{
    public class Post
    {
        public long PostId { get; set; }
        public string Text { get; set; }
        public byte[] File { get; set; }
        public DateTime DateCreated { get; set; }

        public long NodeId { get; set; }
        public virtual Node Node { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual User Poster { get; set; }

    }
}
