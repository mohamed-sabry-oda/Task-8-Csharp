using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }


        public Book()
        {
            Title = "Any";
            Author = "Mo";
        }

        public Book(string title)
        {
            Title = title;
            Author = "Mo";
        }
        public Book(string title, string author) {
            Title = title; 
            Author = author;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }

    }
}
