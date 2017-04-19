using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Models.EntityModels
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        public string  Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }
    }
}
