using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CondicionalesMultiples.OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DiaSemana = "";
            float subtotal = 0f;
            float descuento = 0f;  

            Console.WriteLine("Ingrese monto de la compra");
            subtotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese dia de la semana");
            DiaSemana = Console.ReadLine().ToLower();

            switch (DiaSemana)
            {
                case "lunes":
                    descuento = subtotal * 0.10f;
                    Console.WriteLine($"Hoy es lunes, el descuento es de {descuento} el valor a pagar es de {subtotal - descuento}");
                    break;
                case "martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es martes, el descuento es de {descuento} el valor a pagar es de {subtotal - descuento}");
                    break;
                case "miercoles":
                    descuento = subtotal * 0.10f;
                    Console.WriteLine($"Hoy es miercoles, el descuento es de {descuento} el valor a pagar es de {subtotal - descuento}");
                    break;
                case "jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es jueves, el descuento es de {descuento} el valor a pagar es de {subtotal - descuento}");
                    break;
                case "viernes":
                    descuento = subtotal * 0.20f;
                    Console.WriteLine($"Hoy es viernes, el descuento es de {descuento} el valor a pagar es de {subtotal - descuento}");
                    break;
                case "sabado":
                    descuento = subtotal * 0.0f;
                    Console.WriteLine($"Hoy es sabado, el descuento es de {descuento} el valor a pagar es de {subtotal - descuento}");
                    break;
                case "domingo":
                    descuento = subtotal * 0.0f;
                    Console.WriteLine($"Hoy es domingo, el descuento es de {descuento} el valor a pagar es de {subtotal - descuento}");
                    break;

                default:
                    Console.WriteLine("Escriba un dia de la semana valido");
                    break; 
            }
        }
    }
}
