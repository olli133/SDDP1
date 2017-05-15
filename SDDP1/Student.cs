using System;
using System.Collections.Generic;
using System.Text;

namespace SDDP1
{
    class Student : Person
    {
        public void goToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void showAge()
        {
            Console.WriteLine("My age is: {0} years old.", _age);
        }
    }
}
