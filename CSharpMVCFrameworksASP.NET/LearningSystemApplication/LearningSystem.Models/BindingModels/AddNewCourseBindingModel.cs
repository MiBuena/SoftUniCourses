using System;
using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Models.BindingModels
{
    public class AddNewCourseBindingModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string TrainerId { get; set; }

        [Required]
        
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
