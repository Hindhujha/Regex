using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
using System.Text.RegularExpressions;
namespace TestUserDetails
{
    [TestClass]
    public class UserDetails
    {
        [TestMethod]//first name
        public void FirstName()
        {
            string Regex_FirstName = "^[A-Z]+[a-z]{3,}$";
            string firstName = "HINDHUJHA";
            
                if (Regex.IsMatch(firstName, Regex_FirstName) == true)
                {
                    Patterns pattern = new Patterns();
                    Assert.AreEqual(firstName, pattern.FirstName);
                }
               
        }

        [TestMethod]//last name
        public void LastName()
        {
            string Regex_LastName = "^[A-Z]+[a-z]{3,}$";
            string lastName = "SRIDHAR";

            if (Regex.IsMatch(lastName, Regex_LastName) == true)
            {
                Patterns pattern = new Patterns();
                Assert.AreEqual(lastName, pattern.LastName);
            }

        }

        [TestMethod]//phone number
        public void PhoneNumber()
        {
            string Regex_PhoneNumber = "^[9][1][][6 7 8 9][0-9]{9}$";
            string phoneNumber = "8248922137";

            if (Regex.IsMatch(phoneNumber, Regex_PhoneNumber) == true)
            {
                Patterns pattern = new Patterns();
                Assert.AreEqual(phoneNumber, pattern.Phone_No);
            }

        }



    }
}