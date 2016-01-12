using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slight.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public string BackgroundColor { get; set; }
        public string FontStyle { get; set; }

        //One To One
        public virtual User User { get; set; }
    }
}