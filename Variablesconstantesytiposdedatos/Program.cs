using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variablesconstantesytiposdedatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enteros
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            int num1 = 5;
            int num2 = -num1;
            int num3 = -num2;
            Console.WriteLine(num1 + "//" + num2 + "//" + num3);
            //Aritmeticos
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            int num4 = 3 + 5;
            int num5 = 12 - 63;
            int num6 = 26 * 14;
            float num7 = 5 / 3f;
            Console.WriteLine("\nSuma: {0}, Resta: {1}, Multiplicacion: {2}, Division: {3}",num4,num5,num6,num7);
            //Incremento y decremento
            num4++; // num4 + 1
            num5--; // num5 - 1
            num6 += 4; // num6 + 4
            num4 -= 10; // num4 + 10
            num5 *= 3; //num5 * 3
            num6 /= 2; //num6 / 2
            num6 *= num4; //num6 * num4
            //Orden de evaluacion de operadores
            int num8 = 4 * 3 / 2;
            int num9 = 4 * (3 / 2);
            int num10 = 4 + 6 * (2 / 1);
            //Operadores logicos
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine"
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
