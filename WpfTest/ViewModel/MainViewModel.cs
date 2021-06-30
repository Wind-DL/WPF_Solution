using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTest.ViewModel
{
    class MainViewModel:Common.NotifyProperty
    {
        public Common.CommandBase Command { set; get; } = new Common.CommandBase();

        private FrameworkElement _element;

        public FrameworkElement Element
        {
            get { return _element; }
            set
            {
                _element = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Command.DoExcute = Excute;
            _element = new FrameworkElement();
        }

        void Excute(object obj)
        {
            Type type = Type.GetType("WpfTest.View." + obj.ToString());
            ConstructorInfo constructorInfo = type.GetConstructor(Type.EmptyTypes);
            Element = (FrameworkElement)constructorInfo.Invoke(null);
        }
    }
}
