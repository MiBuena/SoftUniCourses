using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.CreateUser.Attributes
{
    class EmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isEmailValid = ValidateEmail((string)value);

            if (!isEmailValid)
            {
                return false;
            }

            return true;
        }

        private bool ValidateEmail(string value)
        {
            string[] parameters = value.Split('@');

            if (parameters.Length != 2)
            {
                return false;
            }

            bool isUserValid = ValidateUser(parameters[0]);

            bool isHostValid = ValidateHost(parameters[1]);

            return isHostValid && isUserValid;
        }

        private bool ValidateHost(string host)
        {
            string pattern = @"(\w+\.\w+)(\.\w+)*";

            Regex regex = new Regex(pattern);
            bool containsValidHost = regex.IsMatch(host);

            return containsValidHost;
        }

        private bool ValidateUser(string user)
        {
            string pattern = @"\w*\d*(?<!^).*_*-*(?!$)\w*\d*";

            Regex regex = new Regex(pattern);
            bool containsValidUser = regex.IsMatch(user);


            return containsValidUser;
        }
    }
}
