using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Tarea25febCondicionalesAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0.0f;
            float nota2 = 0.0f;
            float nota3 = 0.0f;
            float promedio = 0.0f;

            Console.WriteLine("Ingrese la nota 1");
            nota1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2");
            nota2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            nota3 = Single.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio>=9.5 && promedio<=10.0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Excelente");
            }
            else
            {
                if (promedio>=9.5 && promedio<9.5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Muy bien");
                }
                else
                {
                    if (promedio>=7.5 && promedio<8.5)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Bien");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Mal")
                    }
                }
            }

        }
    }
}
