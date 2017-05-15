using System;

namespace SDDP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.sayHello();
            Student student = new Student();
            student.sayHello();
            student.setAge(21);
            student.showAge();
            Teacher teacher = new Teacher();
            teacher.sayHello();
            teacher.setAge(30);
            teacher.explain();
            Console.ReadKey();
        }
    }
}