using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailSender.Extensions
{
    public static class StringExtensions
    {
        public static string StripHTML(this string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
    }
}
