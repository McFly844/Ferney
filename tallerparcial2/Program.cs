using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerparcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calificaciones//
            double calificacion1 = 0;
            double calificacion2 = 0;
            double calificacion3 = 0;
           
            //Otros operadores//
            double umaCalificaciones = 0;
            int cantidaddeCalificaciones1=0;
            int cantidaddeCalificaciones2 = 0;
            int cantidaddeCalificaciones3= 0;
            double promedio = 0;
            string opcion1 = " ";
            string opcion2 = " ";
            string opcion3 = " ";
            string si = "si";
            string no = "no";

            do
            {
                Console.WriteLine("Ingrese la calificacion");
                calificacion1 = Convert.ToDouble(Console.ReadLine());

                cantidaddeCalificaciones1 = cantidaddeCalificaciones1 + 1;

              umaCalificaciones = umaCalificaciones + calificacion1;

                Console.WriteLine("Desea continuar?");
                Console.WriteLine("Si/No");

                opcion1 = Console.ReadLine().ToLower();

            } while (opcion1 == si);

            promedio = umaCalificaciones / cantidaddeCalificaciones1;

            Console.WriteLine($"El promedio de las calificaciones es {promedio}");


        }
    }
}
