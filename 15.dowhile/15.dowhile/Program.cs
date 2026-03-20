using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA BÁSICA ===");

            while (true)
            {
                // Mostrar menú de opciones
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Suma (+)");
                Console.WriteLine("2. Resta (-)");
                Console.WriteLine("3. Multiplicación (*)");
                Console.WriteLine("4. División (/)");
                Console.WriteLine("5. Salir");

                Console.Write("Elije una opción (1-5): ");
                string opcion = Console.ReadLine();

                // Validar opción
                if (opcion == "5")
                {
                    Console.WriteLine("¡Gracias por usar la calculadora!");
                    break;
                }

                if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
                {
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    continue;
                }

                // Solicitar números
                Console.Write("Ingresa el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;
                string operacion = "";

                // Realizar cálculo según la opción
                switch (opcion)
                {
                    case "1":
                        resultado = num1 + num2;
                        operacion = "+";
                        break;
                    case "2":
                        resultado = num1 - num2;
                        operacion = "-";
                        break;
                    case "3":
                        resultado = num1 * num2;
                        operacion = "*";
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("¡Error! No se puede dividir por cero.");
                            continue;
                        }
                        resultado = num1 / num2;
                        operacion = "/";
                        break;
                }

                // Mostrar resultado
                Console.WriteLine($"\n{num1} {operacion} {num2} = {resultado}");
                Console.WriteLine("Presiona Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
    }

