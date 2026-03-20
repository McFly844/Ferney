using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._2.dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseñaCorrecta = "1234";
            string contraseñaIngresada;
            int intentos = 0;

            Console.WriteLine("=== CONTRASEÑA ===");

            do
            {
                Console.Write("Ingrese la contraseña: ");
                contraseñaIngresada = Console.ReadLine();
                intentos++;

                if (contraseñaIngresada != contraseñaCorrecta)
                {
                    Console.WriteLine("¡Contraseña incorrecta! Intente nuevamente.\n");
                }
            }
            while (contraseñaIngresada != contraseñaCorrecta);

            Console.WriteLine($"\n¡Contraseña correcta!");
            Console.WriteLine($"Número de intentos realizados: {intentos}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
