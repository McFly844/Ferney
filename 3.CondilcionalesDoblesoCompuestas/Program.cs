using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CondilcionalesDoblesoCompuestas
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string nombre = " ";
            float sueldo = 0f;
            float numero1 = 0f;
            float numero2 = 0f;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ingrese el primer numero");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            numero1 = Single.Parse(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ingrese el segundo numero");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            numero2 = Single.Parse(Console.ReadLine());

            if (numero1>numero2)
            {
               // Console.BackgroundColor = ConsoleColor.Green;
               // Console.WriteLine($"{nombre}, debe pagar impuestos");
                //Console.BackgroundColor = ConsoleColor.Black;
                //Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("ingrese nombre de usuario");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            nombre = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("ingrese el valor del sueldo");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            sueldo = Single.Parse(Console.ReadLine());

            if (sueldo>=3000)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"{nombre}, debe pagar impuestos");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"{nombre}, no debe pagar impuestos");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
            }

    }
}
