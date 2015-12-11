using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drawing
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawingCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Square mySquare = new Square(100);
            if (mySquare is IDraw)
            {
                IDraw drawSquare = mySquare;
                drawSquare.setLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawSquare.Draw(drawingCanvas);
            }
            if (mySquare is IColor)
            {
                IColor colorSquare = mySquare;
                colorSquare.setColor(Colors.Cyan);
            }
        }

        private void drawingCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Circle myCircle = new Circle(50);
            if (myCircle is IDraw)
            {
                IDraw drawCircle = myCircle;
                drawCircle.setLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawCircle.Draw(drawingCanvas);
            }
            if (myCircle is IColor)
            {
                IColor colorCircle = myCircle;
                colorCircle.setColor(Colors.HotPink);
            }
        }
    }
}
