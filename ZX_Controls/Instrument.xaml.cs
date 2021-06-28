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
            instrument.Refresh(Int32.Parse(e.NewValue.ToString()));

        }

        public Instrument()
        {
            InitializeComponent();
            SizeChanged += Instrument_SizeChanged;
        }

        private void Instrument_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double min = Math.Min(RenderSize.Width, RenderSize.Height);
            grid.Width = min;
            grid.Height = min;
            Refresh(Value);
        }

        void Refresh(int angle)
        {
            bool b1 = double.IsNaN(grid.Width);
            bool b2 = double.IsNaN(grid.Height);
            if (!b1&&!b2)
            {
                double radius = grid.Width / 2;
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
                    line.StrokeThickness = 1;
                    canvas.Children.Add(line);
                }
               // textBlock.Text = angle.ToString();
               // rotate.Angle = angle;
            }
        }
    }
}
