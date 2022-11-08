using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question2
    {
        public void validate(string eMail)
        {
            int at = 0;
            char[] chars = eMail.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                if(chars[i] == '@')
                {
                    at++;
                }
            }
            string str = eMail.Substring(chars.Length - 4);
            if ((at>0 && at < 2))
            {
                if((str == ".com"))
                {
                Console.WriteLine("Your Email is Valid");
                }
                else
                {
                    Console.WriteLine("Your email should Ends with .com");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Your Email contains Too many @");
            }
            
        }
    }
}
