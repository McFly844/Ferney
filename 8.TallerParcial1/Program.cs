using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TallerParcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1 = 0.0f;
            float numero2 = 0.0f;
            float numero3 = 0.0f;

            Console.WriteLine("Ingrese numero 1 (debe ser entero)");
            numero1 =Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2 (debe ser entero)");
            numero2 =Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3 (debe ser entero)");
            numero3 = Single.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero2 != numero3)
            {
                Console.WriteLine("los numeros son diferentes");
                if (numero1 > numero2 && numero1 > numero3 && numero3 < numero2)
                {
                    Console.WriteLine($"El orden de los numeros es {numero3} , {numero2} , {numero1}");

                    if (numero2 > numero1 && numero2 > numero3 && numero3 < numero1)
                    {
                        Console.WriteLine($"El orden de los numeros es {numero3} , {numero1} , {numero2}");

                        if (numero3 > numero1 && numero3 > numero2 && numero2 < numero1)
                        {
                            Console.WriteLine($"El orden de los numeros es {numero2} , {numero1} , {numero3}");

                        }
                     }
            }
             
           
            
        
            
            
      

        }
    }
}
