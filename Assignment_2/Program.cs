using Assignment_2.Questions;
using ConsoleApp2;
using System.Runtime.ConstrainedExecution;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Question_1 que = new Question_1();
            //Que1.Validate("abhicpatil2192000@gmail.com");

            //Question 2
            Question_2 que2 = new Question_2();
            //string a = null;
            //que2.NullReferenceExample(a);
            //que2.DivideByZeroExample(0);

            //Questoin 3
            Student que3 = new Student();
            List<Student> stu = new List<Student>()
            {
          
                // Create 3 Student details
                new Student{ studId = 101,  studName= "bobby",studDept = "CSE", studSemester = 2 },
                new Student{ stu_id = 102, studName = "sravan",studDept = "ECE", studSemester = 1 },
                new Student{ stu_id = 103, studName = "deepu",studDept = "EEE", studSemester = 4},
            };

            IEnumerable<Student> Query = from student in stu select student;

            foreach (Student e in Query)
            {
                Console.WriteLine(e.ToString());
            }


            Question4 que4 = new Question4();
            que4.ReadFile();

            Employees emp = new Employees();
            emp.ShowData();


            Console.WriteLine("This is Question 6 \n");
            Question6 que6 = new Question6();
            que6.Assignment_Q_6();


        }
    }
}