using LiveCharts.Wpf;
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

namespace WpfTest.MyControls
{
    /// <summary>
    /// UintQuery.xaml 的交互逻辑
    /// </summary>
    public partial class UintQuery : UserControl
    {

        public List<string> Times
        {
            get { return (List<string>)GetValue(TimesProperty); }
            set { SetValue(TimesProperty, value); }
        }
        public static readonly DependencyProperty TimesProperty =
            DependencyProperty.Register("Times", typeof(List<string>), typeof(UintQuery), new PropertyMetadata(null,new PropertyChangedCallback(CallBack)));


        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(UintQuery), new PropertyMetadata(0, new PropertyChangedCallback(CallBack)));

        static void CallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Refresh();
        }


        static void Refresh()
        {
            //Console.WriteLine("hello");
        }

       public List<Times> TimeValues { set; get; } = new List<Times>();
        public UintQuery()
        {
            InitializeComponent();
            TimeValues.Add(new Times { Value = "08:30" });
            TimeValues.Add(new Times { Value = "09:30" });
            TimeValues.Add(new Times { Value = "10:30" });
            TimeValues.Add(new Times { Value = "11:30" });
            TimeValues.Add(new Times { Value = "12:30" });
            TimeValues.Add(new Times { Value = "13:30" });
            TimeValues.Add(new Times { Value = "14:30" });
            TimeValues.Add(new Times { Value = "15:30" });
            TimeValues.Add(new Times { Value = "16:30" });
            TimeValues.Add(new Times { Value = "17:30" });
            TimeValues.Add(new Times { Value = "18:30" });
            TimeValues.Add(new Times { Value = "19:30" });
            TimeValues.Add(new Times { Value = "20:30" });

            DataContext = this;
        }
    }

    public class Times
    {
        public string Value { set; get; }
    }
}
