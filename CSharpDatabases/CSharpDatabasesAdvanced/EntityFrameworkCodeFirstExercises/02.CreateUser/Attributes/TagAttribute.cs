using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.CreateUser.Attributes
{
    class TagAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool hasValidContent = ValidateContentTag((string)value);

            bool hasValidLength = value.ToString().Length <= 20;

            return hasValidContent && hasValidLength;
        }

        private bool ValidateContentTag(string tag)
        {
            string pattern = @"^#[^\s]+";

            Regex regex = new Regex(pattern);
            bool hasValidContent = regex.IsMatch(tag);

            return hasValidContent;
        }
    }
}
