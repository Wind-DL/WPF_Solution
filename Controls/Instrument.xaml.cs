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


        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(Instrument), new PropertyMetadata(double.NaN,
                new PropertyChangedCallback(OnPropertyChanged)
                ));

        public static void OnPropertyChanged(DependencyObject d,DependencyPropertyChangedEventArgs e)
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
            double min = 0;
            double max = 100;
            double step = 270.0 / (max - min);
            for (int i = 0; i < max - min; i++)
            {
                Line lineScale = new Line();
                lineScale.X1 = 100;
                lineScale.Y1 = 100;
                lineScale.X2 = 200;
                lineScale.Y2 = 300;
                lineScale.Stroke = Brushes.White;
                lineScale.StrokeThickness = 2;
                mainCanvas.Children.Add(lineScale);
            }
        }
    }
}
