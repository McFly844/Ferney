using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ArreglosMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fila, columna//
            int[,] numeros = new int[2, 3];
            numeros[0, 0] = 13;
            numeros[0, 1] = 65;
            numeros[0, 2] = 0;
            numeros[1, 0] = 45;
            numeros[1, 1] = 100;
            numeros[1, 2] = 29;

            string[,] nombres =
                               {
                                 {"Ferney","Martin"},
                                 {"Eustalino","TunTungSahur"},
                                 {"Göring","Robbie" }
                               };

            //Recorrer matrices para llenarla//
            char[,] simbolo = new char[2, 5];

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)


                {
                    Console.WriteLine($"Ingrese ek valor pero la matriz [{f},{c}]");
                    simbolo[f,c]=char.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            for (int f = 0; f <simbolo.GetLength(0); f++)
            {
                for (int c = 0; c < simbolo.GetLength(1); c++)
                {
                    Console.Write($"{simbolo [f,c]}");
                }
                Console.WriteLine();
            }
        } 
    }
}
