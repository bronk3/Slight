using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slight.Models
{
    public class StepModel
    {
        public FootType FootType;

        public int Position {get;set;}
        public int[] Order { get; set; }
        public int Durration { get; set; }
        public double Orientation { get; set; }

        public bool IsNull { get; set; }
    }
}
