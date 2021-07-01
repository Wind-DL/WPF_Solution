using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        public string MachineName
        {
            get { return (string)GetValue(MachineNameProperty); }
            set { SetValue(MachineNameProperty, value); }
        }


        public static readonly DependencyProperty MachineNameProperty =
            DependencyProperty.Register("MachineName", typeof(string), typeof(UintQuery), new PropertyMetadata(null));


        static void CallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }



        static void Refresh()
        {
            //Console.WriteLine("hello");


        }

        public ObservableCollection<Times> TimeValues { set; get; } = new ObservableCollection<Times>();
        bool _start = true;
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

            Task.Factory.StartNew(async () =>
            {
                while (_start)
                {
                    if (IsNight())
                    {
                        TimeValues[0].Value = "20:30"; TimeValues[1].Value = "21:30"; TimeValues[2].Value = "22:30";
                        TimeValues[3].Value = "23:30"; TimeValues[4].Value = "00:30"; TimeValues[5].Value = "01:30";
                        TimeValues[6].Value = "02:30"; TimeValues[7].Value = "03:30"; TimeValues[8].Value = "04:30";
                        TimeValues[9].Value = "05:30"; TimeValues[10].Value = "06:30"; TimeValues[11].Value = "07:30";
                        TimeValues[12].Value = "08:30";
                    }
                    else
                    {
                        TimeValues[0].Value = "08:30"; TimeValues[1].Value = "09:30"; TimeValues[2].Value = "10:30";
                        TimeValues[3].Value = "11:30"; TimeValues[4].Value = "12:30"; TimeValues[5].Value = "13:30";
                        TimeValues[6].Value = "14:30"; TimeValues[7].Value = "15:30"; TimeValues[8].Value = "16:30";
                        TimeValues[9].Value = "17:30"; TimeValues[10].Value = "18:30"; TimeValues[11].Value = "19:30";
                        TimeValues[12].Value = "20:30";
                    }
                    await Task.Delay(1000);
                }
            });

        }

        bool IsNight()
        {
            DateTime t1 = Convert.ToDateTime("08:30");
            DateTime t2 = Convert.ToDateTime("20:30");
            if (DateTime.Compare(t1, DateTime.Now) <= 0 && DateTime.Compare(t2, DateTime.Now) >= 0)
            {
                return false;
            }
            return true;
        }

        ~UintQuery()
        {
            _start = false;
        }

    }

    public class Times
    {
        public string Value { set; get; }
    }

    public enum Shift
    {
        Day, Night
    }
}
