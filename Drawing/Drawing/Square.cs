using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace Drawing
{
    class Square : DrawingShape,IDraw,IColor
    {
        public Square(int sideLength)
            : base(sideLength)
        {
        }
        public override void Draw(Canvas c)
        {
            if (this.shape != null)
            {
                c.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Rectangle();
            }
            base.Draw(c);
        }

        public void setLocation(int xCoord, int yCoord)
        {
            throw new NotImplementedException();
        }

        public void setColor(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
