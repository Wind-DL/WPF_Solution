using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Common;

namespace WpfTest.Model
{
    class TestModel: NotifyProperty
    {
        private string _input;

        public string Input
        {
            get { return _input; }
            set { _input = value; OnPropertyChanged(); }
        }

        public CommandBase TestCommand { get; } = new CommandBase();

    }
}
