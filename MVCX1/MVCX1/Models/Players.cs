using System;
using System.Collections.Generic;

namespace MVCX1.Models
{
    public partial class Players
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Shoot { get; set; }
        public int Dribble { get; set; }
        public int Passing { get; set; }
        public int Defence { get; set; }
    }
}
