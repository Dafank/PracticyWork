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
    public partial class Form1 : Form
    {
        LibraryModel Library;
        public Form1()
        {
            Library = new LibraryModel();
            InitializeComponent();
            Operation();
        }

        public void Operation()
        {
            Library.Books.Add(new Book {BookID = 1,BookName = "Хело браза",Cost = 30.21m,PageAmount = 300,Year = 2018});
            StringBuilder builder = new StringBuilder();
            foreach (var item in Library.Books)
            {
                builder.Append($"{item.BookName}\n {item.Cost}\n {item.PageAmount}\n {item.Year}");
            }
            MessageBox.Show(builder.ToString());
        }
    }
}
