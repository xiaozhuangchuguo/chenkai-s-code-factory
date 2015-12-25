using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DrawingUsingProperties
{
    interface IDraw
    {
        int X { get; set; }
        int Y {get;set;}
        void Draw(Canvas canvas);
    }
}
