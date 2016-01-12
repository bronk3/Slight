using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slight.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }

        //One Post can have Many comments
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public Comment()
        {
            Time = DateTime.Now;
        }
    }
}