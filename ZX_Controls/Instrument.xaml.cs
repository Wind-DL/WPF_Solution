using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZX_Controls
{
    /// <summary>
    /// Instrument.xaml 的交互逻辑
    /// </summary>
    public partial class Instrument : UserControl
    {

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(Instrument), new PropertyMetadata(0, new PropertyChangedCallback(Callback)));

        static void Callback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Instrument instrument = d as Instrument;
            instrument.Refresh();
        }

        List<Nums> Nums = new List<Nums>();
        public Instrument()
        {
            InitializeComponent();
            SizeChanged += Instrument_SizeChanged;
            Nums.Add(new ZX_Controls.Nums { Num = -40 });
            Nums.Add(new ZX_Controls.Nums { Num = -30 });
            Nums.Add(new ZX_Controls.Nums { Num = -20 });
            Nums.Add(new ZX_Controls.Nums { Num = -10 });
            Nums.Add(new ZX_Controls.Nums { Num = 0 });
            Nums.Add(new ZX_Controls.Nums { Num = 10 });
            Nums.Add(new ZX_Controls.Nums { Num = 20 });
            Nums.Add(new ZX_Controls.Nums { Num = 30 });
            Nums.Add(new ZX_Controls.Nums { Num = 40 });
        }

        private void Instrument_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double min = Math.Min(RenderSize.Width, RenderSize.Height);
            back.Width = min;
            back.Height = min;
            Refresh();
        }

        void Refresh()
        {
            bool b = double.IsNaN(back.Width);
            if (!b)
            {
                double radius = back.Width / 2;
                canvas.Children.Clear();
                int min = -20;
                int max = 80;
                int defference = max - min;
                double step = 270.0 / defference;
                int length = 0;
                for (int i = 0; i <= defference; i++)
                {
                    if ((i % 5) == 0)
                    {
                        if ((i % 10) == 0)
                        {
                            length = 20;
                        }
                        else
                            length = 15;
                    }
                    else
                        length = 10;
                    Line line = new Line();
                    double arc = (135 + step * i) * Math.PI / 180;
                    line.X1 = radius + (radius - 3) * Math.Cos(arc);
                    line.Y1 = radius + (radius - 3) * Math.Sin(arc);

                    line.X2 = radius + (radius - length - 3) * Math.Cos(arc);
                    line.Y2 = radius + (radius - length - 3) * Math.Sin(arc);
                    line.Stroke = Brushes.White;
                    line.StrokeThickness = 2;
                    canvas.Children.Add(line);
                }

                //1，把path包在了canvas内，显示不出来，不知道为什么？
                //2，添加动画时，对象使用错误了，对动画的使用不理解。
                pointerPath.Fill = Brushes.Blue;
                double rate = 1 - 5 / radius;
                pointerPath.RenderTransformOrigin = new Point(0.5, 0.5);
                string pathData = string.Format("M{0},0 L{1},{0} {2},{0}", radius, radius - 5, radius + 5);
                DoubleAnimation ad = new DoubleAnimation(step * Value, new Duration(TimeSpan.FromMilliseconds(500)));
                rtPointer.BeginAnimation(RotateTransform.AngleProperty, ad);
                pointerPath.Data = Geometry.Parse(pathData);
            }
        }
    }

    public class Nums
    {
        public int Num { get; set; }
    }
}
