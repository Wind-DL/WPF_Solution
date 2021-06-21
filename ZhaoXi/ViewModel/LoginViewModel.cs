using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZhaoXi.Model;

namespace ZhaoXi.ViewModel
{
    class LoginViewModel
    {
        private LoginModel _loginModel;

        public LoginModel LoginModel
        {
            get { return _loginModel; }
            set { _loginModel = value; }
        }

        public LoginViewModel()
        {
            LoginModel = new LoginModel();
            _loginModel.CloseCommand.ExecuteCommand = new Action<object>((object obj) => 
            {
                (obj as Window).Close();
            });
           /* _loginModel.LoginCommand .ExecuteCommand= new Action<object>((object obj) => 
            { 

            });*/
        }

    }
}
