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

namespace Controls
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
            DependencyProperty.Register("Value", typeof(int), typeof(Instrument), new PropertyMetadata(1,
                new PropertyChangedCallback(OnPropertyChanged)
                ));

        public static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as Instrument).Refresh();
        }

        public Instrument()
        {
            InitializeComponent();
            SizeChanged += Instrument_SizeChanged;
        }

        private void Instrument_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double minSize = Math.Min(RenderSize.Width, RenderSize.Height);
            backEllispse.Height = minSize;
            backEllispse.Width = minSize;
        }

         void Refresh()
        {
            double radius = backEllispse.Width / 2;
            mainCanvas.Children.Clear();
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
                    mainCanvas.Children.Add(line);
                
            }
        }
    }
}
