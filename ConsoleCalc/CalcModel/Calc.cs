using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc.CalcModel
{
    internal class Calc
    {
        public string Calculate()
        {
            Console.WriteLine("Enter First Number");
            string n1 = Console.ReadLine();

            Console.WriteLine("Enter Second Number");
            string n2= Console.ReadLine();

            Console.WriteLine("Enter Operator");
            string op = Console.ReadLine();

            
            switch (op)
            {
                case "+":
                   return $"{Convert.ToInt32(n1) + Convert.ToInt32(n2)}";
                case "-":
                    return $"{Convert.ToInt32(n1) - Convert.ToInt32(n2)}";
                case "*":
                    return $"{Convert.ToInt32(n1) * Convert.ToInt32(n2)}";
                case "/":
                    return $"{Convert.ToInt32(n1) / Convert.ToInt32(n2)}";
                default:
                   return "Enter Correct details";
            }

        }
    }
}
