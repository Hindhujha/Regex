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
        public string Regex_First_Name = "^[A-Z]+[a-z]{3,}$"; 
        public string Regex_Last_Name = "^[A-Z]+[a-z]{3,}$";
        public string Regex_Email_Id = "^[a-z 0-9 . _ ]+[@][a-z]+[.][a-z]{2,3}$";
        public string Regex_Phone_No = "^[9][1][][6 7 8 9][0-9]{9}$";
        public string Regex_Password = "^[a-z A-Z 0-9 ! @ # $ % ^ & *]{8,15}$";
        //validating first name
        public void FirstName(string FirstName)
        {
            try
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //validating last name
        public void LastName(string LastName)
        {
            try
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //validating email id
        public void EmailId(string EmailId)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //validating Mobile No
        public void Phone_No(string Phone_No)
        {
            try
            {
                if (Regex.IsMatch(Phone_No, Regex_Phone_No) == true)

                {
                    Console.WriteLine("MOBILE NUMBER  IS VALID");
                }
                else
                {
                    Console.WriteLine("MOBILE NUMBER IS NOT VALID ENTER A VALID NUMBER");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //validating Password
        public void Password(string Password)
        {
            try
            {
                if (Regex.IsMatch(Password, Regex_Password) == true)

                {
                    Console.WriteLine("PASSWORD  IS VALID");
                }
                else
                {
                    Console.WriteLine("PASSWORD IS NOT VALID ENTER A VALID PASSWORD");
                }
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
