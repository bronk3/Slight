using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slight.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        //Many to Many
        public virtual ICollection<Category> Categories { get; set; }

        //One To Many
        public virtual ICollection<Post> Posts { get; set; }

        //One To One
        public virtual Settings Settings { get; set; }

        //Many to Many
        public virtual ICollection<Post> Respects { get; set; }

        public User()
        {
            Posts = new List<Post>();
            Respects = new List<Post>();
            Categories = new List<Category>();
            Settings = new Settings();
        }
    }
}