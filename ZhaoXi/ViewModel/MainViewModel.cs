using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZhaoXi.Common;
using ZhaoXi.Model;

namespace ZhaoXi.ViewModel
{
    class MainViewModel : NotifyProperty
    {
        public UserModel UserInfor { get; set; }
        private int _serachText;

        public int SearchText
        {
            get { return _serachText; }
            set { _serachText = value; OnPropertyChanged(); }
        }
        private FrameworkElement _mainContent;

        public FrameworkElement MainContent
        {
            get { return _mainContent; }
            set { _mainContent = value; OnPropertyChanged(); }
        }

        public CommandBase NavChangedCommand { get; set; }

        public MainViewModel()
        {
            UserInfor = new UserModel();
            NavChangedCommand = new CommandBase();
            NavChangedCommand.ExecuteCommand = new Action<object>(DoNavChanged);
           //  NavChangedCommand.CanExecute = new Func<object, bool>((obj) => true);
           
        }

        private void DoNavChanged(object obj)
        {
            //加载其他程序集
            Type type = Type.GetType("ZhaoXi.View." + obj.ToString());
            ConstructorInfo cti = type.GetConstructor(System.Type.EmptyTypes);
            MainContent = (FrameworkElement)cti.Invoke(null);
        }
    }
}

