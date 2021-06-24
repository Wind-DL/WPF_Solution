using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTest.Common
{
    class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoExcute?.Invoke(parameter);
        }

        public Action<Object> DoExcute { set; get; }
        public Func<Object, bool> DoCanExcute { set; get; }
    }
}
