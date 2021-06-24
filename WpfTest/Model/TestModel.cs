using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfTest.Common;

namespace WpfTest.Model
{
    class TestModel : NotifyProperty
    {
        private FrameworkElement _mainContent;

        public FrameworkElement MainContent
        {
            get { return _mainContent; }
            set { _mainContent = value; OnPropertyChanged(); }
        }

        public CommandBase CommandBase { get; set; } = new CommandBase();
    }
}
