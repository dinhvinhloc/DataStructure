using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3SecA
{
    public class BookDB
    {
        private Stack<Book> bookList = new Stack<Book>();

        private Book b1 = new Book("5423423", "Ravinder", "Java Programming", 2020);
        private Book b2 = new Book("6456456", "Bill", "Oracle Database", 2019);
        private Book b3 = new Book("4564564", "Pawandeep", "SQL Server Development", 2021);

        public BookDB()
        {
            this.bookList.Push(b1);
            this.bookList.Push(b2);
            this.bookList.Push(b3);

        }

        public void AddBook(Book book)
        {
            bookList.Push(book);
        }

        public Book RemoveBook()
        {
            return bookList.Pop();
        }

        public Book[] GetBooks()
        {
            return bookList.ToArray();
        }

        public void ClearBooks()
        {
            bookList.Clear();
        }

        public int CountBooks()
        {
            return bookList.Count();
        }

        public bool FindBook(Book book)
            
        {
            return bookList.Contains(book);
        }
    }
}
