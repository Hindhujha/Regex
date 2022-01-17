using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Patterns
    {
        public string Regex_First_Name = "[A-Z]+[a-z]{3,}";
        public void FirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, Regex_First_Name) == true)

            {
                Console.WriteLine("FIRST NAME IS VALID");
            }
            else
            {
                Console.WriteLine("FIRST NAME IS NOT VALID ENTER A VALID NAME");
            }
        }
    }
}
