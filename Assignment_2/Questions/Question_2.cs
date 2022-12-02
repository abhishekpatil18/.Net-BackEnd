using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_2.Questions
{
    internal class Question_2
    {
        public void NullReferenceExample(string str)
        {
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Please check the string str.");
                Console.WriteLine(err.Message);
            }
            catch(Exception ex) {
                Console.WriteLine("Error Message : ", ex.Message);
            }
            Console.WriteLine("Continuing with other statments..");
        }

        public void DivideByZeroExample(int a)
        {
            int n = 100;
            try
            {
                int b = n/a;
                Console.WriteLine(b);
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("Divided by Zero Error : "+ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Message : ",ex.Message);
            }
        }

    }
}

