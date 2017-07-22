using System;
using System.Text.RegularExpressions;

namespace OOPadv
{
    public class Phone : IBrowsable, ICallable
    {

        public string Browse(string a)
        {
            Regex validator = new Regex(@"\d");
            if (validator.IsMatch(a))
            {
                return "Invalid URL!";
            }
            else return $"Browsing: {a}!";
        }

        public string Call(string a)
        {
            Regex validator = new Regex(@"[^\d]");
            if (validator.IsMatch(a))
            {
                return "Invalid number!";
            }
            else return $"Calling... {a}";
        }
    }
}
