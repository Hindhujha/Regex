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
        public string Regex_Last_Name = "[A-Z]+[a-z]{3,}";
        public string Regex_Email_Id = "[a-z 0-9 . _ ]+[@][a-z]+[.][a-z]{2,3}";
        //validating first name
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
        //validating last name
        public void LastName(string LastName)
        {
            if (Regex.IsMatch(LastName, Regex_Last_Name) == true)

            {
                Console.WriteLine("Last NAME IS VALID");
            }
            else
            {
                Console.WriteLine("LAST NAME IS NOT VALID ENTER A VALID NAME");
            }
        }
        //validating email id
        public void EmailId(string EmailId)
        {
            if (Regex.IsMatch(EmailId, Regex_Email_Id) == true)

            {
                Console.WriteLine("Email Id  IS VALID");
            }
            else
            {
                Console.WriteLine("Email Id IS NOT VALID ENTER A VALID NAME");
            }
        }
    }
}
