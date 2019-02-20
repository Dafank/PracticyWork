using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLibrary;

namespace Library
{
    public partial class ProfileData : UserControl
    {
        readonly int UserId;
        DataBaseModel db;
        public ProfileData(int Id)
        {
            InitializeComponent();
            db = new DataBaseModel();
            UserId = Id;
            SetData();
        }

        public void SetData()
        {
            var user = from temp in db.UserInfoes
                       where temp.UserID == UserId
                       select new
                       {
                           LName = temp.LName,
                           FName = temp.FName,
                           MName = temp.MName,
                           Email = temp.AutentnData.Email,
                           Books = temp.Libraries.Where(x => x.BookOwner == temp.UserID).Count()
                       };
            foreach (var item in user)
            {
                lastNamelabel.Text = item.LName;
                firstNamelabel.Text = item.FName;
                middleNamelabel.Text = item.MName;
                emailLabel.Text = item.Email;
                dateLabel.Text = DateTime.Now.ToShortTimeString();
                try
                {
                    booksAmount.Text = item.Books.ToString();
                }
                catch(Exception)
                {
                    booksAmount.Text = "0";
                }
                //TODO: Add Date here!
            }
                       
        }

    }
}
