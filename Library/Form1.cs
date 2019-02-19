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
            Operation();
        }

        void Operation()
        {
            db.Books.Add(new Book { BookName = "AWS", Cost = 30, PageAmount = 300, Year = 2013 });
            db.SaveChanges();
            StringBuilder builder = new StringBuilder();

            foreach (var item in db.Books)
            {
                builder.Append($"{item.BookName} {item.Cost}\n {item.PageAmount} {item.Year}");
            }

            MessageBox.Show(builder.ToString());
        }
    }
}
