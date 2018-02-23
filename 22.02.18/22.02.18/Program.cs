using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._18
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = 5;
            Student Hesabla()
            {
                return new Student("Samir");
            }
            Console.WriteLine(Hesabla().Name);
        }
    }
    class Student
    {
        public string Name;
        public Student(string _name)
        {
            Name = _name;
        }
    }
}
class Student
{
    public string Name; 
    public Student(string _name)
    {
        Name = _name;
    }
}
