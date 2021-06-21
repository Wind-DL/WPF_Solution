using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoXi.Common;

namespace ZhaoXi.Model
{
    class LoginModel : NotifyProperty
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; OnPropertyChanged(); }
        }

        public CommandBase LoginCommand { get; set; }

        public CommandBase CloseCommand { get; set; }

        public LoginModel()
        {
            LoginCommand = new CommandBase();
            CloseCommand = new CommandBase();
        }
    }
}
