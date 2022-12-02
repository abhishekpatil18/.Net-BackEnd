using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2.Questions
{
    internal class Question4
    {
        public void ReadFile()
        {
        string file = @"C:\Users\Abhishek.Patil\Desktop\TestTextFile.txt";
            Console.WriteLine("Reading File using File.ReadAllText()");
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("File Does not Exist");
            }
            Console.WriteLine();
        }
    }
}
