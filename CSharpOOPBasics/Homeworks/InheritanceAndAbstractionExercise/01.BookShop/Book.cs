using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BookShop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "The price can not be negative");
                }

                this.price = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Author", "The author can not be null");
                }

                this.author = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title", "The title can not be null");
                }
                this.title = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("-Type: {0}\n-Title: {1}\n-Author: {2}\n-Price: {3}", this.GetType().Name, this.Title, this.Author, this.Price));


            return sb.ToString();
        }
    }
}
