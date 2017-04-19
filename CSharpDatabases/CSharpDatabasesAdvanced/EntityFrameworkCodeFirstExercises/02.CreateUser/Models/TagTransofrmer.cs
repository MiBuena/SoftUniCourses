using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.CreateUser.Models
{
    static class TagTransofrmer
    {
        public static string Transform(string tag)
        {
            string text = tag;
            string pattern = @"\s+";
            string replacement = "";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            if (result[0] != '#')
            {
                result = "#" + result;
            }

            result = result.Substring(0, 20);

            return result;
        }
    }
}
