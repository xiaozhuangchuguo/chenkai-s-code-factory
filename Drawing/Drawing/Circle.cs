using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Drawing
{
    class Circle:DrawingShape,IColor,IDraw
    {
        public Circle(int diameter):base(diameter)
        {

        }


        public override  void Draw(Canvas c)
        {
            if (this.shape!= null)
            {
                c.Children.Remove(this.shape);
            }
            else
            {
                this.shape=new Ellipse();
            }
            base.Draw(c);
        }


        public void setColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void setLocation(int xCoord, int yCoord)
        {
            throw new NotImplementedException();
        }
    }
}
