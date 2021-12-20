using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculator

            //inputs
            Console.Write("Napiste cislo 1: ");
            double num1;
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Napiste cislo 2: ");
            double num2;
            double.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("Zvolte operaciu (uvedte cislo z ponuky):\n1-scitanie\n2-odcitanie\n3-nasobenie\n4-delenie");
            int volbaOperacie = Int32.Parse(Console.ReadLine());


            //operation
            switch (volbaOperacie)
            {
                case 1:
                    Console.WriteLine($"Vysledok scitania je {Addition(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Vysledok odcitania je {Subtraction(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Vysledok nasobenia je {Multiplication(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Vysledok delenia je {Division(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Nespravny vstup. Opakuj volbu.");
                    break;
            }


            Console.ReadLine();

        }
        //addition
        static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        //subtraction
        static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        //multiplication
        static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        //division
        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
