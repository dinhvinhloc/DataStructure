using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_HashTable_and_Dictionary
{
    public class Course
    {
        private string code;
        private string title;
        private int credit;

        public string Code { get => code; set => code = value; }
        public string Title { get => title; set => title = value; }
        public int Credit { get => credit; set => credit = value; }

        public override string ToString()
        {
            string str = "";
            str += "Code    :" + Code + Environment.NewLine;
            str += "Title   :" + Title + Environment.NewLine;
            str += "Credits :" + Credit + Environment.NewLine;
            return str;
        }
    }
}
