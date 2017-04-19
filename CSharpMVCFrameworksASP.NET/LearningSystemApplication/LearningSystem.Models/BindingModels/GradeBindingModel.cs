﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Models.BindingModels
{
    public class GradeBindingModel
    {
        public int StudentId { get; set; }

        [Required]
        public Grade Grade { get; set; }
    }
}
