using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            int opcion = CapturarOpcion();
            RealizarOpcion(opcion);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("----------------------------MENU----------------------------");
            Console.WriteLine("1.Suma                                            2.Resta");
            Console.WriteLine("3.Multiplicacion                                  4.Division");
            Console.WriteLine("------------------------------------------------------------");
        }

        static int CapturarOpcion()
        {
            Console.WriteLine("Ingrese una opcion del menu");
            return int.Parse(Console.ReadLine());
        }

        static void RealizarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    suma();
                    break;
                case 2:
                    resta();
                    break;
                case 3:
                    multiplicacion();
                    break;
                case 4:
                    division();
                    break;
                default:
                    Console.WriteLine("Ingrese una operacion valida");
                    break;
            }
        }

        static void suma()
        {
            Console.WriteLine("----------------------------SUMA----------------------------");
        }

        static void resta()
        {
            Console.WriteLine("---------------------------RESTA----------------------------");
        }

        static void multiplicacion()
        {
            Console.WriteLine("------------------------MULTIPLICACION-----------------------");
        }

        static void division()
        {
            Console.WriteLine("-------------------------DIVISION----------------------------");
        }
    }
}
