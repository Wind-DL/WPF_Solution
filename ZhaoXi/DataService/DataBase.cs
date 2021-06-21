using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using ZhaoXi.EnityDto;

namespace ZhaoXi.DataService
{
    class DataBase
    {
        private DataBase _dataBase;
        private DataBase() { }
        public DataBase GetInstanse()
        {
            return _dataBase ?? new DataBase();
        }

        MySqlConnection _connection;
        MySqlDataAdapter _adapter;

        bool OpenConnection()
        {
            try
            {
                string conStr = ConfigurationManager.ConnectionStrings.ToString();
                _connection = new MySqlConnection();
                _connection.Open();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool CheckUserInfor(UserInfor userInfor)
        {
            if (OpenConnection())
            {
                MySqlCommand command = new MySqlCommand();
                string name = userInfor.User_name;
                string password = userInfor.Password;
                string str = string.Format("select * from users where user_name={0} and password={1}", name, password);
                _adapter = new MySqlDataAdapter();
                command.CommandText = str;
                _adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                int count = _adapter.Fill(ds);
                if (count < 0)
                {
                    Dispose();
                    return true;
                }
            }
            Dispose();
            return false;
        }

        void Dispose()
        {
            if(_connection!=null)
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }

            if (_adapter != null)
            {
                _adapter.Dispose();
                _adapter = null;
            }
    }
}
