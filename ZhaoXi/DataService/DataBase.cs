using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using ZhaoXi.Common;
using ZhaoXi.EnityDto;

namespace ZhaoXi.DataService
{
    class DataBase
    {
        private static DataBase _dataBase;
        private DataBase() { }
        public static DataBase GetInstanse()
        {
            return _dataBase ?? new DataBase();
        }

        MySqlConnection _connection;
        MySqlDataAdapter _adapter;

        bool OpenConnection()
        {
            try
            {
                _connection = new MySqlConnection();
                _connection.ConnectionString= ConfigurationManager.ConnectionStrings["db"].ConnectionString;
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
            bool res = false;
            DataSet ds = new DataSet();
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand command = new MySqlCommand();
                    string name = userInfor.User_name;
                    string password = MD5Hepler.GetMD5Str(name + "@" + userInfor.Password);
                    string str = string.Format("select * from users where user_name='{0}' and password='{1}'", name, password);
                    command.CommandText = str;
                    _adapter = new MySqlDataAdapter(str, _connection);
                    int count = _adapter.Fill(ds);
                    if (count > 0)
                    {
                        res = true;
                    }
                }
            }
            catch
            {

            }
            finally
            {
                ds.Dispose();
                Dispose();

            }
            return res;
        }

        void Dispose()
        {
            if (_connection != null)
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
}
