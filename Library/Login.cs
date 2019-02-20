using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLibrary;
using System.Net.Mail;
using System.Data.Entity;

namespace Library
{
    public partial class Login : Form
    {
        Form previous;
        DataBaseModel db;
        public Login(Form form)
        {
            InitializeComponent();
            previous = form;
            db = new DataBaseModel();
            FormClosed += Login_FormClosed;
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            previous.Visible = true;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (CheckEmail(Email.Text) & CheckPassword(Password.Text))
            {
                if (TryAuthorize(Email.Text, Password.Text))
                {
                    MessageBox.Show("HEllo");
                }
            }
        }
        private bool CheckEmail(string email)
        {
            emailError.Text = "Email can't be empty";
            emailError.Visible = false;
            if (email == string.Empty)
            {
                emailError.Visible = true;
                return false;
            }
            if (email.Length >= 50)
            {
                emailError.Text = "Email Out of Range";
                emailError.Visible = true;
                return false;
            }
            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch (FormatException)
            {
                emailError.Text = "Invalid email";
                emailError.Visible = true;
                return false;
            }
            return true;
        }
        private bool CheckPassword(string password)
        {
            passwordError.Visible = false;
            passwordError.Text = "Password can't be empty";
            if (password == string.Empty)
            {
                passwordError.Visible = true;
                return false;
            }
            else if (password.Length >= 30)
            {
                passwordError.Text = "Password Out of Range";
                passwordError.Visible = true;
                return false;
            }
            return true;
        }
        public bool TryAuthorize(string email, string password)
        {
            if (db.AutentnDatas.Any(u => u.Email == email&u.Password == password))
            {
                return true;
            }
            MessageBox.Show("Email or Password not correct","User doesn't exist");
            return false;
        }
    }
}
