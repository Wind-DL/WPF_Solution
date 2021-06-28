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
            Students = new List<Student>();
            Students.Add(new Student { Name = "zhang", Age = 20, Address = "河南" });
            Students.Add(new Student { Name = "zhang", Age = 20, Address = "河南" });
            Students.Add(new Student { Name = "zhang", Age = 20, Address = "河南" });
            Students.Add(new Student { Name = "zhang", Age = 20, Address = "河南" });
            DataContext = this;

        }
    }
}
