﻿

namespace EF_001_ConventionsOverConfigrations.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int TweetId { get; set; }
        public int CommentBy { get; set; }
        public string? CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}