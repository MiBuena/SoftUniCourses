using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    class Book: IComparable<Book>
    {
        public string Title { get; set; }   
        public string Author { get; set; }


        public int CompareTo(Book other)
        {
            var authorCompare = this.Author.CompareTo(other.Author);

            if (authorCompare != 0)
            {
                return authorCompare;
            }

            return this.Title.CompareTo(other.Title);
        }
    }
}
