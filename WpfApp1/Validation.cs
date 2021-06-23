using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class Validation : ValidationRule

    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(value==null)
            {
                return new ValidationResult(false, "不能为空");
            }else if(value.ToString().Length>6)
            {
                return new ValidationResult(false, "不能超过6个字节");
            }else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
