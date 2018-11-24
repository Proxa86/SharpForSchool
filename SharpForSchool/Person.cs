using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpForSchool
{
    class Person
    {
        string firstName;
        string lastName;

        public Person()
        {
            firstName = "Johny";
            lastName = "Rocket";
        }

        public Person(string f , string l)
        {
            firstName = f;
            lastName = l;
        }

        public void LuckyNumber(int numberOfTeeth, int age)
        {
            Console.WriteLine("lucky number :" + numberOfTeeth * age);
        }
    }
}
