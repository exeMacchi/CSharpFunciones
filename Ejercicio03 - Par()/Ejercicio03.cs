using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Par__
{
    class Ejercicio03
    {
        static void Main()
        {
            /* 
                3. Hacer una función llamada “par” que reciba un número entero y devuelva 
                   1 si es par o cero si no lo es. Hacer un programa para ingresar 20 
                   números aleatorios y mostrar por pantalla cuántos son pares.
            */

            Random random = new Random();
            const int tamMax = 20;
            int[] vNumeros = new int[tamMax];
            int cantNumPares = 0;

            // Proceso de asignación y verificación
            for (int i = 0; i < tamMax; i++)
            {
                vNumeros[i] = random.Next(21);

                if (Par(vNumeros[i]) == 1)
                {
                    cantNumPares++;
                }
            }

            // Mostrar resultados
            Console.Write("Números: ");
            for (int i = 0; i < tamMax; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Cantidad de números pares: {cantNumPares}");
            Console.WriteLine();
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
    }
}
