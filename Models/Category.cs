using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slight.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        //TODO Settings For this Category
        public string FontSize { get; set; }
        public string Color { get; set; }
        public string FontStyle { get; set; }
        public string FontWeight { get; set; }
        public string TextDecoration { get; set; }
        public string LetterSpaceing { get; set; }
        public string TextTransform { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}