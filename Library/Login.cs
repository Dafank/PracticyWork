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
                db.AutentnDatas.Add(new AutentnData { Email = Email.Text, Password = Password.Text });
                db.SaveChanges();
                // TODO: Тут має створюватись вікно, і має бути перевірка
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
    }
}
