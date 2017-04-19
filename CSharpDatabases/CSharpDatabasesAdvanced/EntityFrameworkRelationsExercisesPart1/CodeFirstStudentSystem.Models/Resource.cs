using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentSystem.Models
{
    public class Resource
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string TypeOfResource { get; set; }

        [Required]
        public string URL { get; set; }

        public ICollection<License> Licenses { get; set; }

        public override string ToString()
        {
            string printing = this.Name + "\n" + this.TypeOfResource + "\n" + this.URL;

            return printing;
        }
    }
}
