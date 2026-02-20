using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            float sueldo = 0f;
            float edad = 0f;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Ingrese el nombre del usuario");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            nombre = Console.ReadLine(); // Lo que llega desde la consola, es de tipo string
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese edad del usario");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            edad = Convert.ToSingle (Console.ReadLine());

            if (edad>=18)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{nombre} , bienvenido a mi pagina");
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese el sueldo del usuario");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            sueldo = Convert.ToSingle(Console.ReadLine());
      

            if (sueldo>=3000)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"La persona {nombre} , debe pagar impuestos");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            
        
            
        }
    }
}
