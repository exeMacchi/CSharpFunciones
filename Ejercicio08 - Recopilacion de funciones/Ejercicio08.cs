using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___Recopilacion_de_funciones
{
    class Ejercicio08
    {
        static void Main()
        {
            /* 
                8. Hacer un programa que permita ingresar una lista de números que corta 
                   cuando se ingresa un cero. A partir de dichos datos informar:
	                   a. El mayor de los números pares.
	                   b. La cantidad de números impares.
	                   c. El menor de los números primos.
                   Hacer uso de las funciones anteriormente desarrolladas. 
            */

            // Los números ingresados serán aleatorios para agilizar el ejercicio.
            Random random = new Random();
            int N = random.Next(101), maxNumPar = 0, cantNumImpares = 0, minNumPrimo = 0;
            bool banPar = false, banPrimo = false;

            // Proceso de verificación y muestra
            while (N != 0)
            {
                if (Par(N) == 1)
                {
                    if (!banPar)
                    {
                        maxNumPar = N;
                        banPar = true;
                    }
                    else if (N > maxNumPar)
                    {
                        maxNumPar = N;
                    }
                }
                else
                {
                    cantNumImpares++;
                }

                if (Primo(N) == 1)
                {
                    if (!banPrimo)
                    {
                        minNumPrimo = N;
                        banPrimo = true;
                    }
                    else if (N < minNumPrimo)
                    {
                        minNumPrimo = N;
                    }
                }

                Console.Write(N + " ");
                N = random.Next(101);
            }
            Console.WriteLine();

            // Resultados
            Console.WriteLine($"El máximo número par: {maxNumPar}");
            Console.WriteLine($"Cantidad de números impares: {cantNumImpares}");
            Console.WriteLine($"El mínimo número primo: {minNumPrimo}");
        }

        static int Par(int N)
        {
            if (N % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static int Primo(int N)
        {
            int cont = 0;

            for (int i = N; i > 0; i--)
            {
                if (N % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
