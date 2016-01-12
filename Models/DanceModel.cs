using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slight.Models
{
    public class DanceModel
    {
        public static int BootStrapGrid = 12;
        public Role Role;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Durration { get; set; }
        public PointOfView PointOfView { get; set; }

        public StepModel[][] Steps { get; set; }

        public int StepGridWidth 
        {
            get {
                    int length = this.Steps[0].Length;
                    var width = BootStrapGrid / length;
                    return width;
                }
            set { }
        }
    }
}
