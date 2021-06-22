using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ZhaoXi.DataService;
using ZhaoXi.EnityDto;
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
            _loginModel.LoginCommand.ExecuteCommand = new Action<object>((object obj) =>
            {
                Task.Run(() =>
                {
                    UserInfor userInfor = new UserInfor() { User_name = _loginModel.UserName, Password = _loginModel.Password };
                    if (!DataBase.GetInstanse().CheckUserInfor(userInfor))
                    {
                        _loginModel.ErrorMessage = "账号或者密码错误";
                    }
                    else
                    {
                        Application.Current.Dispatcher.Invoke(() => { (obj as Window).DialogResult = true; });
                    }
                });
            });
        }
    }
}
