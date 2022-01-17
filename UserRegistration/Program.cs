using System;
namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USER REGISTRATION PROGRAM");
            Patterns myObj = new Patterns();
            Console.WriteLine("ENTER A VALID FIRST NAME");
            myObj.FirstName(Console.ReadLine());
            Console.WriteLine("ENTER A VALID LAST NAME");
            myObj.LastName(Console.ReadLine());
            Console.WriteLine("ENTER A VALID EMAIL ID");
            myObj.EmailId(Console.ReadLine());
            Console.WriteLine("ENTER A VALID MOBILE NUMBER WITH COUNTRY CODE");
            myObj.Phone_No(Console.ReadLine());


        }
    }
}
