using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Model;

namespace WpfTest.ViewModel
{
    class TestViewModel
    {
        public TestModel Model { get; set; }
        public TestViewModel()
        {
            Model = new TestModel();
            Model.CommandBase.DoExcute = Excute;
        }

        void Excute(object obj)
        {
            //Model.Gender = Model.Gender == 0 ? 1 : 0;
        }
    }
}
