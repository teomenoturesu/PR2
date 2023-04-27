using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    internal class Book
    {
        public string Title { get; private set; }
        public Author Author { get; private set; }
        public string Annotation { get; private set; }
        public ushort Year { get; set; }
        public Book(string title, Author author, string annotation, ushort year)
        {
            Title = title;
            Author = author;
            Annotation = annotation;
            Year = year;
        }
    }
}
