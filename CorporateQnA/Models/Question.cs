﻿using System;

namespace CorporateQnA.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int UpVotes { get; set; }
        public int Views { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
