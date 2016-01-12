using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slight.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }


        //One User can have Many Posts
        public int UserId { get; set; }

        public virtual User User { get; set; }

        //One Post Can have many Categories
        public virtual ICollection<Category> Categories { get; set; }

        // One Post can have Many comments
        public virtual ICollection<Comment> Comments { get; set; }

        //Many 
        public virtual ICollection<User> Respects { get; set; }

        public Post()
        {
            Time = DateTime.Now;
            Comments = new List<Comment>();
            Respects = new List<User>();
            Categories = new List<Category>();
            User = new User();
        }
    }
}