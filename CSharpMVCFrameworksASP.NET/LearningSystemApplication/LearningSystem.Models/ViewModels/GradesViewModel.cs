using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Models.ViewModels
{
    public class GradesViewModel
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public Grade Grade { get; set; }
    }
}
