using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Barsik = new Animal();
            Barsik.kindOfAnimal = "Cat";
            Barsik.name = "Cat Barsik";
            Barsik.numberOfLegs = 4;
            Barsik.height = 50;
            Barsik.length = 110;
            Barsik.color = "Black";
            Barsik.hasTail = true;
            Barsik.isMammal = true;

            int n = Barsik.NumberOfLegs("Turkey");
            Console.WriteLine("Turkey have "+ n+ " legs");

            Bird b = new Bird();
            b.kindOfAnimal = "Eagle";
            b.isMammal = false;
            b.featherColor = "Black";


            Person Petr = new Person();
            Petr.LuckyNumber(24, 14);

            Person p = new Person("Petr", "Ivanov");
            

            Console.ReadKey();
        }
    }
}
