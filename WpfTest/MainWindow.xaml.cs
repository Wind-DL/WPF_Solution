using Microsoft.Expression.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using WpfTest.Model;
using WpfTest.ViewModel;

namespace WpfTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Students { set; get; } = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Students.Add(new Student { Name = "-40" });
            Students.Add(new Student { Name = "-30" });
            Students.Add(new Student { Name = "-20" });
            Students.Add(new Student { Name = "-10" });
            Students.Add(new Student { Name = "0" });
            Students.Add(new Student { Name = "10" });
            Students.Add(new Student { Name = "20" });
            Students.Add(new Student { Name = "30" });
            Students.Add(new Student { Name = "40" });
            DataContext = this;
            LineArrow lineArrow = new LineArrow();
        
        }
    }
}
