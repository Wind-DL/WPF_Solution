using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZhaoXi.Common
{
    class MD5Hepler
    {
        public static string GetMD5Str(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            string MD5_Str = "";
            foreach (byte item in bytes)
            {
                MD5_Str += item.ToString("X2");
            }
            return MD5_Str;
        }
    }
}
