using System;
using System.Collections.Generic;

namespace BlogMVC.Models
{
    public partial class Comment
    {
        public int Commentid { get; set; }
        public string Text { get; set; } = null!;
        public int Userid { get; set; }
        public int Postid { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;

        public virtual Post Post { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
