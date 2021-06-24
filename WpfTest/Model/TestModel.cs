using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Common;

namespace WpfTest.Model
{
    class TestModel : NotifyProperty
    {
        private int _gender;

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged(); }
        }


        public CommandBase CommandBase { get; set; } = new CommandBase();
    }
}
