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
        //full和不是full的测试。
        //需要给属性赋初始值，或者检查属性的时候，就用full
        //其他时间可用简单属性。

        private TestModel _model;

        public TestModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public TestViewModel()
        {
            _model = new Model.TestModel();
            _model.TestCommand.DoExcute = Show;
            _model.TestCommand.DoCanExcute = Enable;
        }

        void Show(Object obj)
        {
            System.Windows.MessageBox.Show(_model.Input);
        }

        bool Enable(Object obj)
        {
             return string.IsNullOrEmpty(_model.Input) ? false : true;
        }
    }
}
