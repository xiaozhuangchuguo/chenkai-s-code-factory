﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace Drawing
{
    interface IDraw
    {
        void setLocation(int xCoord, int yCoord);
        void Draw(Canvas canvas);
    }
}
