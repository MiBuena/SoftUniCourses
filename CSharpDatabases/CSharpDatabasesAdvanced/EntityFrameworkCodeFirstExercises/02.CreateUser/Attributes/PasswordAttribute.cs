using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CreateUser.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    class PasswordAttribute : ValidationAttribute
    {
        private readonly int PassMinLength;
        private readonly int PassMaxLength;

        public PasswordAttribute(int minPasswordLength = 0, int maximumPasswordLength = 30)
        {
            this.PassMinLength = minPasswordLength;
            this.PassMaxLength = maximumPasswordLength;
        }

        public bool ShouldContainLowercase { get; set; }

        public bool ShouldContainUppercase { get; set; }

        public bool ShouldContainDigit { get; set; }

        public bool ShouldContainSpecialSymbol { get; set; }

        public override bool IsValid(object value)
        {
            string stringValue = (string) value;

            if (this.ShouldContainDigit && !stringValue.Any(char.IsDigit))
            {
                return false;
            }

            if (this.ShouldContainLowercase && !stringValue.Any(char.IsLower))
            {
                return false;
            }


            if (this.ShouldContainUppercase && !stringValue.Any(char.IsUpper))
            {
                return false;
            }

            if (this.ShouldContainSpecialSymbol && !ContainsASpecialSymbol(stringValue))
            {
                return false;
            }

            return true;
        }

        private bool ContainsASpecialSymbol(string value)
        {
            char[] specialSymbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '<', '>', '?' };

            if (value.Any(x => specialSymbols.Contains(x)))
            {
                return true;
            }

            return false;
        }
    }
}
