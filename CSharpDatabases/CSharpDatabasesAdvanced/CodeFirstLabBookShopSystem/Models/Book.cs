using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enumerations;

namespace Models
{
    public class Book
    {
        public Book()
        {
            this.RelatedBooks = new List<Book>();
        }

        public int Id { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }

        public EditionType EditionType { get; set; }

        public decimal Price { get; set; }

        public int Copies { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Pages { get; set; }

        public Author Author { get; set; }

        public Category Category { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public virtual ICollection<Book> RelatedBooks { get; set; }

    }
}
