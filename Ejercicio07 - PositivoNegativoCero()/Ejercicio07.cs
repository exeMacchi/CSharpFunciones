using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___PositivoNegativoCero__
{
    class Ejercicio07
    {
        static void Main()
        {
            /*
                7. Hacer una función de tipo void (porque no va a devolver nada) llamada 
                   “positivoNegativoCero” que reciba un número por valor y una variable 
                   por referencia, y que analice el número y escriba variable recibida por 
                   referencia con:
	                   a. 1 si el número es positivo.
	                   b. -1 si el número es negativo.
	                   c. 0 si el número es cero.
                   Hacer un programa main que permita ingresar 100 números y emitir por 
                   pantalla cuántos son positivos, cuántos negativos y cuántos cero.
            */

            // Los números ingresados serán aleatorios para agilizar el ejercicio.
            Random random = new Random();
            int cantPositivos = 0, cantNegativos = 0, cantCeros = 0;

            for (int i = 0; i < 100; i++)
            {
                int N = random.Next(-10, 11);
                
                int R = 0;
                PositivoNegativoCero(N, ref R);
                
                if (R == 0)
                {
                    Console.WriteLine($"{i + 1}. El número es cero ({N})");
                    cantCeros++;
                }
                else if (R == 1)
                {
                    Console.WriteLine($"{i + 1}. El número es positivo ({N})");
                    cantPositivos++;
                }
                else
                {
                    Console.WriteLine($"{i + 1}. El número es negativo ({N})");
                    cantNegativos++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Cantidad de números positivos: {cantPositivos}");
            Console.WriteLine($"Cantidad de números negativos: {cantNegativos}");
            Console.WriteLine($"Cantidad de ceros: {cantCeros}");
        }

        static void PositivoNegativoCero(int N, ref int R)
        {
            if (N == 0)
            {
                R = 0;
            }
            else if (N > 0)
            {
                R = 1;
            }
            else
            {
                R = -1;
            }
        }
    }
}
