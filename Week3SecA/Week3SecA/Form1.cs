using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3SecA
{
    public partial class Form1 : Form
    {
        private BookDB thisBookList = new BookDB();

        public Form1()
        {
            InitializeComponent();
            dataGridViewBooks.DataSource = thisBookList.GetBooks();
            dataGridViewBooks.Refresh();        
        }       
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            thisBookList.AddBook(GetBook());
            dataGridViewBooks.DataSource = thisBookList.GetBooks();
            dataGridViewBooks.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ShowBook(thisBookList.RemoveBook());
            dataGridViewBooks.DataSource = thisBookList.GetBooks();
            dataGridViewBooks.Refresh();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = thisBookList.GetBooks();
            dataGridViewBooks.Refresh();
        }

        private Book GetBook()
        {
            
            
            Book aBook = new Book(txtISBN.Text, txtAuthor.Text, txtTitle.Text, Convert.ToInt32(txtYear.Text));
            return aBook;
        }

        private void ShowBook(Book book)
        {
            txtISBN.Text = book.ISBN1;
            txtAuthor.Text = book.Author1;
            txtTitle.Text = book.Title1;
            txtTitle.Text = Convert.ToString(book.YearPublished1);
        }

        private void ClearControl()
        {
            txtISBN.Text = "";
            txtAuthor.Text = "";
            txtTitle.Text = "";
            txtTitle.Text = "";
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            thisBookList.ClearBooks();
            dataGridViewBooks.DataSource = thisBookList.GetBooks();
            dataGridViewBooks.Refresh();
        }

        private void btnCountBooks_Click(object sender, EventArgs e)
        {
            labelMessage.Text = Convert.ToString(thisBookList.CountBooks()) + " Books";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Book[] bookArray = new Book[thisBookList.CountBooks()];
            //bookArray = thisBookList.GetBooks();
            //for (int i=0;i<bookArray.Length;i++ )
            //{
            //    if (txtISBN.Text == bookArray[i].ISBN1)
            //        labelMessage.Text = "Found Book";
            //    else if (txtTitle.Text == bookArray[i].Title1)
            //        labelMessage.Text = "Found Book";
            //    else if (txtAuthor.Text == bookArray[i].Author1)
            //        labelMessage.Text = "Found Book";
            //    //else if (Convert.ToInt32(txtYear.Text) == bookArray[i].YearPublished1)
            //    //    labelMessage.Text = "Found Book";
            //    else labelMessage.Text = "Found Not Book";

            //}
            Book aBook = GetBook();
            if (thisBookList.FindBook(aBook))
                labelMessage.Text = "Found Book";
            else labelMessage.Text = "Found Not Book";
        }
    }
}
