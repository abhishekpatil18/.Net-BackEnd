using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Questions
{
    internal class Student
    {
        public int stu_id;
        string stu_dept;
        string stu_name;
        int stu_semester;

        public int studId
        {
            get { return stu_id; }
            set { stu_id = value; }
        }
        public string studName
        {
            get { return stu_name; }
            set { stu_name = value; }
        }
        public int studSemester
        {
            get { return stu_semester; }
            set { stu_semester = value; }
        }
        public string studDept
        {
            get { return stu_dept; }
            set { stu_dept = value; }
        }
        public override string ToString()
        {
            return studId + " " +studName+" "+studDept+" "+studSemester;
        }

        public void ShowStudents()
        {
            
        }

    }

}

       

