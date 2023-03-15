using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Primo__
{
    class Ejercicio04
    {
        static void Main()
        {
            /*
                4. Hacer una función llamada “primo” que reciba un número entero y 
                   devuelva 1 si el número es primo o 0 si no lo es. Hacer un programa
                   para ingresar números. El lote corta cuando se ingresa un número cero. 
                   Informar el promedio teniendo en cuenta sólo los números primos. 
            */

            // Los números ingresados van a ser aleatorios para agilizar el ejercicio
            Random random = new Random();
            int N = random.Next(0, 51);
            int acumPrimos = 0, cantPrimos = 0;

            // Proceso de verificación y muestra
            while (N != 0)
            {
                Console.Write(N + " ");

                if (Primo(N) == 1)
                {
                    acumPrimos += N;
                    cantPrimos++;
                }

                N = random.Next(0, 51);
            }
            Console.WriteLine();

            float promedio = acumPrimos / (float) cantPrimos;

            if (acumPrimos != 0)
            {
                Console.WriteLine($"Promedio números primos: {Math.Round(promedio, 2)}");
            }
            else
            {
                Console.WriteLine("Ningún número primo fue ingresado");
            }
            Console.WriteLine();
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
