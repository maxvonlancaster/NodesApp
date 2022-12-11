namespace NodesApp.DAL.Entities
{
    public class Node
    {
        public long Id { get; set; }
        public string Link { get; set; }
        public string NodeName { get; set; }
        public string Text { get; set; }
        public byte[] File { get; set; }
    }
}
