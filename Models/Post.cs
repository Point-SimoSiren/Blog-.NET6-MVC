using System;
using System.Collections.Generic;

namespace BlogMVC.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int Postid { get; set; }
        public string Header { get; set; } = null!;
        public string Body { get; set; } = null!;
        public int Author { get; set; }
        public int Likes { get; set; } = 0;
        public DateTime Time { get; set; } = DateTime.Now;

        public virtual User userid { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
