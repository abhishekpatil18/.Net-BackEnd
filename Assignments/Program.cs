using Assignments.Assignment_1;
using System;
//Assignments.Assignment_1.Question1;

namespace Assignments
{
    internal class Program
    {
        public static void Question_1(Question1 q1)
        {
            Console.WriteLine(q1.Display("Abhi"," Patil"));
            Console.WriteLine(q1.isSame("Abhi"," Patil"));
            Console.WriteLine(q1.Reverse("Abhi"));
            Console.WriteLine(q1.subString("Abhi",2));
        }
        static void Main(string[] args)
        {
            Question1 obj = new Question1();
            //Question_1(obj);

            Question2 q2 = new Question2();
            //q2.validate("abhi@gmail.in");

            Question3 q3 = new Question3();
            //q3.showENum();

            //Question4 q4 = new Question4();
            BankAccount account = new BankAccount();
            account.openBankAccount("Abhishek", "saving");

            Customer customer = new Customer();
            customer.calculateSavingInterest(100000, 2);
            


        }
    }
}