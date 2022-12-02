using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_2.Questions
{
    internal class Question_1
    {
        public void Display()
        {
            Console.WriteLine("Abhishek Patil");
        }
        public void Validate(string email)
        {
            Regex regex = new(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",RegexOptions.CultureInvariant | RegexOptions.Singleline);
            Console.WriteLine($"The email is {email}");
            bool isValidEmail = regex.IsMatch(email);
            if (!isValidEmail)
            {
                Console.WriteLine($"The email is invalid");
            }
            else
            {
                Console.WriteLine($"The email is valid");
            }
            Console.ReadLine();
        }
    }
}
