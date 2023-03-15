using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___SumaResta__
{
    class Ejercicio06
    {
        static void Main()
        {
            /* 
                6. Hacer una función que se llame “sumaResta” que reciba dos números y que 
                   devuelva la suma Y la resta del primer número con el segundo. 
            */

            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"La suma: {SumaResta(num1, ref num2)}");
            Console.WriteLine($"La resta: {num2}");
        }

        static int SumaResta(int N1, ref int N2)
        {
            int suma = N1 + N2;
            N2 = N1 - N2;
            return suma;
        }
    }
}
