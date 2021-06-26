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
using WpfTest.ViewModel;

namespace WpfTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Draw();
        }

        //135~405.
        //分为100份

        void Draw()
        {

            double step = 270.0 / 100;
            for (int i = 0; i < 101; i++)
            {
                int length = 0;
                if ((i % 5) == 0)
                {
                    if ((i % 10) == 0)
                        length = 20;
                    else
                        length = 15;
                }
                else
                    length = 10;
                Line line = new Line();
                double arc = (135 + step * i) * Math.PI / 180;
                line.X1 = 150 + 150 * Math.Cos(arc);
                line.Y1 = 150 + 150 * Math.Sin(arc);

                line.X2 = 150 + (150 - length) * Math.Cos(arc);
                line.Y2 = 150 + (150 - length) * Math.Sin(arc);
                line.Stroke = Brushes.Blue;
                line.StrokeThickness = 3;
                canvas.Children.Add(line);
            }
        }
    }
}
