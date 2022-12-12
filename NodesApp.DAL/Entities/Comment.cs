namespace NodesApp.DAL.Entities
{
    public class Comment
    {
        public long CommentId { get; set; }
        public string Text { get; set; }
        public byte[] File { get; set; }
        public DateTime DateCreated { get; set; }

        public long PostId { get; set; }
        public long UserId { get; set; }
        public virtual Post Post { get; set; }
        public virtual User Poster { get; set; }

    }
}
