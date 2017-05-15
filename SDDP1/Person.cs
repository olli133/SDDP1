using System;
using System.Collections.Generic;
using System.Text;

namespace SDDP1
{
    class Person
    {
        protected int _age;

        public void setAge(int n)
        {
            _age = n;
        }
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
