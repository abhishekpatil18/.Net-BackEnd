using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Assignment_1
{
    internal class Question1
    {
        public string Display(string s1, string s2)
        {
            return string.Concat(s1, s2);
        }

        public bool isSame(string s1, string s2)
        {
            return s1.Equals(s2);
        }

        public string Reverse(string s1)
        {
            char[] chars = s1.ToCharArray();
            string rev = "";
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                rev += chars[i];
            }
            return rev;

            /*New Method for reversing string
             
            Array.Reverse(chars);
            string newStr=new string(chars);
            return (newStr);
            
             */
        }

        public string subString(string s1, int index)
        {
            if (index > s1.Length)
            {
                Console.WriteLine("Enter correct index value");
                return "";
            }
            else
            {
                //return s1.Substring(index);
                return s1[index..];
            }

        }
    }
}
