﻿namespace NodesApp.DAL.Entities
{
    public class Comment
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public byte[] File { get; set; }
    }
}
