using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week3SecA
{
    public class Book
    {
        private string ISBN;
        private string Author;
        private string Title;
        private int YearPublished;

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Author1 { get => Author; set => Author = value; }
        public string Title1 { get => Title; set => Title = value; }
        public int YearPublished1 { get => YearPublished; set => YearPublished = value; }

        public Book(string iSBN, string author, string title, int yearPublished)
        {
            ISBN1 = iSBN;
            Author1 = author;
            Title1 = title;
            YearPublished1 = yearPublished;
        }

        public Book()
        {
        }


    }
}
