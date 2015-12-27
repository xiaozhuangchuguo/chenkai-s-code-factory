using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Polygon
    {
        public int NumSides { get; set; }
        public double Sidelength { get; set; }

        public Polygon()
        {
            this.NumSides = 4;
            this.Sidelength = 10.0;
        }
    }
}
