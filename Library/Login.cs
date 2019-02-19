using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        Form previous;
        public Login(Form form)
        {
            InitializeComponent();
            previous = form;
            FormClosed += Login_FormClosed;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            previous.Visible = true;
        }
    }
}
