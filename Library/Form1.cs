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

namespace Library
{
    public partial class Form1 : Form
    {
        DataBaseModel db;
        public Form1()
        {
            db = new DataBaseModel();
            InitializeComponent();
            AutentnData.eror += ErrorEmail;
            Operation();
            
        }


        public void ErrorEmail(object sender, string arg)
        {
            MessageBox.Show(arg);
        }

        void Operation()
        {
            db.AutentnDatas.Add(new AutentnData { Email = "fentik9814@.com", Password = "Lorka12" });
            //db.Books.Add(new Book { BookName = "AWS", Cost = 30, PageAmount = 300, Year = 2013 });
            db.SaveChanges();
            StringBuilder builder = new StringBuilder();

            foreach (var item in db.AutentnDatas)
            {
                //builder.Append($"{item.BookName} {item.Cost}\n {item.PageAmount} {item.Year}");
                builder.Append($"{item.Email}\n {item.Password}");
            }

            MessageBox.Show(builder.ToString());
        }
    }
}
