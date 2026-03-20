using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadordenumeros = 1;
            int contador = 1;
            int contadordivisor = 0;

            do
            {
                do
                {
                    if (contadordenumeros%contador==0)
                    {
                        contadordivisor++;
                    }
                    contador++;

                } while (contador<=contadordenumeros);

                contador = 1;

                if (true)
                {
                    Console.WriteLine(contadordenumeros);
                    contadordenumeros++;

                }
                contadordivisor = 0;
                contadordenumeros++;

            } while (contadordenumeros<=100);
        }
    }
}
