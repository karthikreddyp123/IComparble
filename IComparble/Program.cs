using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparble
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] arrStudent = new Student[] { new Student() { Name = "Karthik" },
            new Student() { Name = "Rahul" },
            new Student() { Name = "Vivek" },
            new Student() { Name = "Aditya" }};

            Array.Sort(arrStudent);
            foreach(Student i in arrStudent)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadLine();
        }
    }
    public class Student : IComparable
    {
        public string Name { get; set; }
        public int CompareTo(object obj)
        {
            Student stuObj = obj as Student;
            if (stuObj != null)
            {
                return this.Name.CompareTo(stuObj.Name);
            }
            return -1;
        }
    }
}
