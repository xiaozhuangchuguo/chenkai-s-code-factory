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

namespace change10to8
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

        private void showStep_Click(object sender, RoutedEventArgs e)
        {
            int amount = int.Parse(numberBox.Text);
            string current = "";
            showBox.Text = "";
            do
            {
                int nextDigit = amount % 8;
                amount /= 8;
                int digitCode = '0' + nextDigit;
                char digit =Convert.ToChar(digitCode);
                current = digit + current;
                showBox.Text += current + "\n";
            }
            while(amount!=0);
        }
    }
}
