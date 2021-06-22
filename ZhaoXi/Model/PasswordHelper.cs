using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ZhaoXi.Model
{
    class PasswordHelper
    {
        public static string GetPassword(DependencyObject obj)
        {
            return (string)obj.GetValue(PasswordProperty);
        }

        public static void SetPassword(DependencyObject obj, string value)
        {
            obj.SetValue(PasswordProperty, value);
        }

        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordHelper), new PropertyMetadata("", CallBack));

        static void CallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pb = d as PasswordBox;
            pb.PasswordChanged -= Pb_PasswordChanged;
            pb.PasswordChanged += Pb_PasswordChanged;
        }

        private static void Pb_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pb = sender as PasswordBox;
            SetPassword(pb, pb.Password);
        }
    }
}
