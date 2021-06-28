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
        public List<Student> Students { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Students = new List<Student>()
            {
                new Student(){Name="zhang",Age=18,Address="河南"},
                  new Student(){Name="wang",Age=19,Address="苏州"},
                    new Student(){Name="li",Age=20,Address="山东"},
                      new Student(){Name="zhao",Age=22,Address="上海"},
                         new Student(){Name="zhang",Age=18,Address="河南"},
                  new Student(){Name="wang",Age=19,Address="苏州"},
                    new Student(){Name="li",Age=20,Address="山东"},
                      new Student(){Name="zhao",Age=22,Address="上海"},
                         new Student(){Name="zhang",Age=18,Address="河南"},
                  new Student(){Name="wang",Age=19,Address="苏州"},
                    new Student(){Name="li",Age=20,Address="山东"},
                       new Student(){Name="zhang",Age=18,Address="河南"},
                  new Student(){Name="wang",Age=19,Address="苏州"},
                    new Student(){Name="li",Age=20,Address="山东"},
                      new Student(){Name="zhao",Age=22,Address="上海"},
                      new Student(){Name="zhao",Age=22,Address="上海"},
            };
           
        }
    }
}
