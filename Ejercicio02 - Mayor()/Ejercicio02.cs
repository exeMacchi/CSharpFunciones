using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Mayor__
{
    class Ejercicio02
    {
        static void Main()
        {
            /* 
                2. Hacer una función llamada “mayor” que reciba dos números enteros y 
                   devuelva el mayor de ellos o cero si son iguales.
            */

            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int mayor = Mayor(num1, num2);

            if (num1 != num2)
            {
                Console.WriteLine($"El máximo es {mayor}");
            }
            else
            {
                Console.WriteLine($"Ambos números son iguales.");
            }
        }

        static int Mayor(int N1, int N2)
        {
            if (N1 > N2)
            {
                return N1;
            }
            else
            {
                return N2;
            }
        }
    }
}
