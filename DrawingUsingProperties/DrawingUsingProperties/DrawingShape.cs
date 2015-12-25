﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;

namespace DrawingUsingProperties
{
    abstract class DrawingShape
    {
        protected int _size;
        protected int _x = 0, _y = 0;
        protected Shape shape = null;
        public DrawingShape(int size)
        {
            this._size = size;
        }
        public int X
        {
            get { return this._x; }
            set { this._x = value; }
        }
        public int Y
        {
            get { return this._y; }
            set { this._y = value; }
        }
        public Color color
        {
            set
            {
                if (this.shape != null)
                {
                    SolidColorBrush brush = new SolidColorBrush(value);
                    this.shape.Fill = brush;
                }
            }
        }

        public virtual void Draw(Canvas canvas)
        {
            if (this.shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }
            this.shape.Height = this._size;
            this.shape.Width = this._size;
            Canvas.SetTop(this.shape, this._y);
            Canvas.SetLeft(this.shape, this._x);
            canvas.Children.Add(this.shape);
        }
    }
}
