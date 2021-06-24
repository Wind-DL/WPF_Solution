using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            Type type = Type.GetType("WpfTest.View." + obj.ToString());
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            Model.MainContent = (FrameworkElement)constructor.Invoke(null);

        }
    }
}
