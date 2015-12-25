﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace  DrawingUsingProperties
{
    class Circle:DrawingShape,IColor,IDraw
    {
        public Circle(int diameter): base(diameter)
        {
        }
        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Ellipse();
            }
            base.Draw(canvas);
        }
    }
}