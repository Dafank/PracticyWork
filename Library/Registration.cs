using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLibrary;

namespace Library
{
    public partial class Registration : Form
    {
        Form previous;
        DataBaseModel db;
        public Registration(Form form)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (CheckNames(LastName.Text, FirstName.Text, MiddleName.Text)&CheckEmail(Email.Text)&CheckPassword(Password.Text))
            {
                AutentnData data = new AutentnData() { Email = Email.Text, Password = Password.Text };
                db.UserInfoes.Add(new UserInfo
                {
                    LName = LastName.Text,
                    FName = FirstName.Text,
                    MName = MiddleName.Text,
                    AutentnData = data
                });
                db.SaveChanges();
            }
        }

        public bool CheckNames(string last,string first,string middle)
        {
            errorLastName.Visible = false;
            errorFirstName.Visible = false;
            errorMiddleName.Visible = false;
            errorLastName.Text = "Last Name can't be empty";
            errorFirstName.Text = "First Name can't be empty";
            errorMiddleName.Text = "Middle Name can't be empty";
            bool flag = true;
            if (last == string.Empty)
            {
                errorLastName.Visible = true;
                flag = false;
            }
            else if (last.Length >= 30)
            {
                errorLastName.Text = "Last Name out of range";
                errorLastName.Visible = true;
                flag = false;
            }
            else if (!Regex.IsMatch(last, @"^[a-zA-Z]+$"))
            {
                errorLastName.Text = "Last Name can't contains numbers";
                errorLastName.Visible = true;
                flag = false;
            }
            if (first == string.Empty)
            {
                errorFirstName.Visible = true;
                flag = false;
            }
            else if (first.Length >= 30)
            {
                errorLastName.Text = "First Name out of range";
                errorFirstName.Visible = true;
                flag = false;
            }
            else if (!Regex.IsMatch(first, @"^[a-zA-Z]+$"))
            {
                errorFirstName.Text = "First Name can't contains numbers";
                errorFirstName.Visible = true;
                flag = false;
            }
            if (middle == string.Empty)
            {
                errorMiddleName.Visible = true;
                flag = false;
            }
            else if (middle.Length >= 30)
            {
                errorLastName.Text = "Middle Name out of range";
                errorMiddleName.Visible = true;
                flag = false;
            }
            else if (!Regex.IsMatch(middle, @"^[a-zA-Z]+$"))
            {
                errorMiddleName.Text = "Middle Name can't contains numbers";
                errorMiddleName.Visible = true;
                flag = false;
            }

            if (flag)
                return true;
            else
                return false;
        }
        private bool CheckEmail(string email)
        {
            errorEmail.Text = "Email can't be empty";
            errorEmail.Visible = false;
            if (email == string.Empty)
            {
                errorEmail.Visible = true;
                return false;
            }
            if (email.Length >= 50)
            {
                errorEmail.Text = "Email Out of Range";
                errorEmail.Visible = true;
                return false;
            }
            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch (FormatException)
            {
                errorEmail.Text = "Invalid email";
                errorEmail.Visible = true;
                return false;
            }
            return true;
        }
        private bool CheckPassword(string password)
        {
            errorPassword.Visible = false;
            errorPassword.Text = "Password can't be empty";
            if (password == string.Empty)
            {
                errorPassword.Visible = true;
                return false;
            }
            else if (password.Length >= 30)
            {
                errorPassword.Text = "Password Out of Range";
                errorPassword.Visible = true;
                return false;
            }
            return true;
        }
    }
}
