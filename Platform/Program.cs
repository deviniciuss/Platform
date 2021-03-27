using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Platform
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("_______________________________");
            Console.WriteLine();
            Console.WriteLine("  *  WELCOME THE PLATFORM   *");
            Console.WriteLine("_______________________________");
            Console.WriteLine("How many days for month you work?");
            double day = double.Parse(Console.ReadLine());
            Console.WriteLine("Which your monthly salary?");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Person p1 = new Person(day, salary);
            Console.WriteLine();
            Console.WriteLine("You are: " + p1.IncomePerson());
            Console.WriteLine(" _______________________________________________");
            Console.WriteLine("|   Global Population Distribuition by Income   |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|_______________________________________________|");
            Console.WriteLine("| Poor                -         15%             | ");
            Console.WriteLine("|_______________________________________________| ");
            Console.WriteLine("| Low Income          -         56%             | ");
            Console.WriteLine("|_______________________________________________| ");
            Console.WriteLine("| Middle Income       -         13%             | ");
            Console.WriteLine("|_______________________________________________| ");
            Console.WriteLine("| Upper-middle Income -         9%              | ");
            Console.WriteLine("|_______________________________________________| ");
            Console.WriteLine("| Hight Income        -         7%              | ");
            Console.WriteLine("|_______________________________________________| ");
            Console.WriteLine();
            Console.WriteLine("Reference: https://www.pewresearch.org/");


        }
    }
}
