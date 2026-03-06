






























using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipodepizza = " ";
            string vegetariana = "vegetariana";
            string novegetariana = "no vegetariana ";
            string opcion1 = " ";
            string opcion2 = " ";
            string opcion3 = " ";
            string opcion4 = " ";
            string opcion5 = " ";
            string opcion6 = " ";
            string si = "si";
            string no = "no";

            //Pizzas vegetariana
            float pimientochampiñoneslechuga = 20.000f;
            float tofuchampiñoneslechuga = 30.000f;
            float otracombinacionV = 25.000f;

            //Pizzas no vegetatianas
            float respollo = 10.000f;
            float restocineta = 15.000f;
            float chorizotocineta = 25.000f;
            float otracombinacionNV = 22.000f;

            Console.WriteLine("¿Desea una pizza vegetariana o una no vegetariana? Por favor escribir ´vegetariana´ o ´no vegetariana´ ");
            tipodepizza = Console.ReadLine();

            if (tipodepizza != novegetariana && tipodepizza == vegetariana)
            {
                Console.WriteLine("¿Desea una Pizza de pimiento, champiñones y lechuga?");
                opcion1 = Console.ReadLine().ToLower();

                if (opcion1 == si && opcion1 != no)
                {
                    Console.WriteLine($"La pizza vale: {pimientochampiñoneslechuga} + 19%");
                }
                else if (opcion1 == no && opcion1 != si)
                {
                    Console.WriteLine("¿Desea una Pizza de tofu, champiñones y lechuga?");
                    opcion2 = Console.ReadLine().ToLower();

                    if (opcion2 == si && opcion2 != no)
                    {
                        Console.WriteLine($"La pizza vale: {tofuchampiñoneslechuga} + 15%");
                    }
                    else if (opcion2 == no && opcion2 != si)
                    {
                        Console.WriteLine("¿Desea una pizza con otra combinacion?");
                        opcion3 = Console.ReadLine().ToLower();

                        if (opcion3 == si && opcion3 != no)
                        {
                            Console.WriteLine($"La pizza vale: {otracombinacionV} + 10%");
                        }
                        else if (opcion3 == no && opcion3 !=si)
                        {
                            Console.WriteLine("Esos son nuestros unicos sabores vegetarianos, si desea una pizza no vegetariana vuelva a ingresar");
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("¿Desea pizza de res con pollo?");
                opcion4 = Console.ReadLine().ToLower();

                if (opcion4 == si && opcion4 != no)
                {
                    Console.WriteLine($"La piza vale: {respollo} + 19%");
                }
                else if (opcion4 == no && opcion4 !=si)
                {
                    Console.WriteLine("¿Desea pizza de res con tocineta?");
                    opcion5 = Console.ReadLine().ToLower();

                    if (opcion5 == si && opcion5 !=no)
                    {
                        Console.WriteLine($"La pizza vale: {restocineta} + 17%");
                    }
                    else if (opcion5 == no && opcion5 != si)
                    {
                        Console.WriteLine("¿Desea pizza de chorizo y tocineta?");
                        opcion6 = Console.ReadLine().ToLower();

                        if (opcion6 == si && opcion6 != no)
                        {
                            Console.WriteLine($"La pizza vale: {chorizotocineta} + 9%");
                        }
                        else if (opcion6 == no && opcion6 != si)
                        {
                            Console.WriteLine($"Si desea otra combinacion, esta vale: {otracombinacionNV}");
                        }
                    }
                }

            }

          
        }
    }
}
