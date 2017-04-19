using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningSystem.Models.EntityModels;

namespace LearningSystem.Models.BindingModels
{
    public class AssessStudentsBindingModel
    {
        public int CourseId { get; set; }

        
        public List<GradeBindingModel> Grades { get; set; }

    }
}
