using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
       public string name;
       public int rollNumber;
        public Student(string name,int rollNumber)
        {
            this.name = name;
            this.rollNumber = rollNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", 12);
            Student s2 = new Student("shahzaib", 15);
            List<Student> s = new List<Student>() { s1, s2 };
            List<Student> sorted = s.OrderBy(e => e.rollNumber).ToList();
            foreach(Student s3 in sorted)
            {
                Console.WriteLine(s3.name, s3.rollNumber);
            }
            Console.ReadKey();
        }
    }
}
