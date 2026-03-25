using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ciclosfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal acumulador = 1;
            int finalRango = 0; 
            int inicioRango = 0;

            Console.WriteLine("Ingrese el inicio");
            inicioRango = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tope");
            finalRango = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Los numeros multiplos de 5 de {inicioRango} a {finalRango} son ");

            for (int contador = inicioRango; contador <= finalRango; contador++)
            {
                if (contador%5 == 0)
                {
                    Console.WriteLine(contador);
                }
            }

           

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
