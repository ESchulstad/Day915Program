using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day915Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the beginning of our class example.");

            ////our first person instance
            //Person thisPerson = new Person();

            //thisPerson.Greet("Jarryd");

            //Console.WriteLine();

            ////Our second person instance
            //Person secondPerson = new Person(25, "Lupe","Purple","Whattup?");
            ////secondPerson.greeting = "How's it going?";
            //secondPerson.Greet("Clone Jarryd");

            Student freshman = new Student("John Doe", 19, "University School", "Underwater Basket Weaving", 3.0);
            freshman.Name = "Johnny Doe";
            //freshman.PrintAllDetails();
            //freshman.Birthday();
       
            //freshman.PrintAllDetails();

            for (int i = 0; i < 10; i++) 
            {
                freshman.PrintAllDetails();
                freshman.Birthday();
                System.Threading.Thread.Sleep(500);
            }
        }

    }
}
