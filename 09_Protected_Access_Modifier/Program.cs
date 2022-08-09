using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Protected_Access_Modifier
{
    class School
    {
        public string strSchoolName;
        private string strAddress;
        protected static int intStudentCount = 0;
        public string Address
        {
            get { return strAddress; }
        }
        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }
        public int GetTotalStudents ()
        {
            return intStudentCount;
        }
    }
    class Student : School
    {
        private string strName; //e
        public Student(string strName, string strSchoolName, string strAddress) : base(strSchoolName, strAddress)
        {
            this.strName = strName;
            intStudentCount++; //Derive class can see the protected variable in base class.
        }
        public string GetInfo()
        {
            return "Student name: "+ strName + " ,School name: "+ strSchoolName + " ,Address: " + Address;
        }
    
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student ObjS1, ObjS2;
            Console.Write("Enter student 1 name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student 1 school: ");
            string school = Console.ReadLine();
            Console.Write("Enter student 1 address: ");
            string address = Console.ReadLine();
            ObjS1 = new Student(name, school, address);

            Console.Write("Enter student 2 name: ");
            name = Console.ReadLine();
            Console.Write("Enter student 2 school: ");
            school = Console.ReadLine();
            Console.Write("Enter student 2 address: ");
            address = Console.ReadLine();
            ObjS2 = new Student(name, school, address);

            Console.WriteLine(ObjS1.GetInfo());
            Console.WriteLine(ObjS2.GetInfo());
            Console.WriteLine("Number of students: "+ ObjS1.GetTotalStudents().ToString());
            Console.ReadKey();
        }
    }
}
