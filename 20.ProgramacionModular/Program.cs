using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ProgramacionModular
{
    internal class Program
    {
        static int AñoActual = 2026;
        static void Main(string[] args)
        {
            string nombre = "Josh";
            string apellido = "Silver";
            Console.WriteLine("I know you're fucking someone else");
            Saludo("Peter", "Steele");
            Saludo(nombre, apellido);
            Console.WriteLine($"Edad: {EdadAñoNacimiento()}");
            Console.WriteLine($"Edad: {EdadAñoNacimiento(1943)}");
            Console.ReadKey();
            BorrarPantalla();

        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void Saludo(string nombre, string apellidos)
        {
            Console.WriteLine($"{nombre} {apellidos} knows you're fucking someone else");
        }

        static int EdadAñoNacimiento()
        {
            int AñoNacimiento = 1962;
            int Edad = AñoActual - AñoNacimiento;
            return Edad;
        }

        static int EdadAñoNacimiento(int AñoNacimiento) 
        {
            return AñoActual - AñoNacimiento;
        }

    }
}
