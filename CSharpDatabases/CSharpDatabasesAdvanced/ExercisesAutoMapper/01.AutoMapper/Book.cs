﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AutoMapper
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Author Author { get; set; }
    }
}
