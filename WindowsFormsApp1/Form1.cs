using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.button1.Parent = this;
            //this.button1.BackColor = Color.FromArgb(100, 255, 0, 0);
           this.button1.BackColor = Color.Transparent;
        }
    }
}
