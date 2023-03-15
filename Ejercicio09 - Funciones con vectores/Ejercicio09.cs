using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Funciones_con_vectores
{
    class Ejercicio09
    {
        static void Main()
        {
            /* 
                9. Realice un programa que ingrese a un vector de 20 posiciones, números 
                   al azar del 1 al 10, muestre dichos números, halle la cantidad de 
                   números mayores a 5 y halle la cantidad de números menores o iguales 
                   que 5. Mostrar ambos resultados. 
            */

            const int tamMax = 20;
            int[] vNumeros = new int[tamMax];

            LlenarVectorAzar(vNumeros, tamMax);
            MostrarVector(vNumeros, tamMax);

            int cantNumMay5 = CantNumMayoresA5(vNumeros, tamMax);
            int cantNumMenOIgual5 = CantNumMenOIgualesA5(vNumeros, tamMax);

            MostrarResultados(cantNumMay5, cantNumMenOIgual5);
        }

        static void LlenarVectorAzar(int[] vNumeros, in int elementos)
        {
            Random random = new Random();

            for (int i = 0; i < elementos; i++)
            {
                vNumeros[i] = random.Next(1, 11);
            }
        }

        static void MostrarVector(int[] vNumeros, in int elementos)
        {
            Console.Write("Números: ");
            for (int i = 0; i < elementos; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine();
        }

        static int CantNumMayoresA5(int[] vNumeros, in int elementos)
        {
            int cant = 0;
            for (int i = 0; i < elementos; i++)
            {
                if (vNumeros[i] > 5)
                {
                    cant++;
                }
            }
            return cant;
        }

        static int CantNumMenOIgualesA5(int[] vNumeros, in int elementos)
        {
            int cant = 0;

            for (int i = 0; i < elementos; i++)
            {
                if (vNumeros[i] <= 5)
                {
                    cant++;
                }
            }
            return cant;
        }
        
        static void MostrarResultados(int cantNumMay5, int cantNumMenOIgual5)
        {
            Console.WriteLine($"Cantidad de números mayores a 5: {cantNumMay5}");
            Console.WriteLine($"Cantidad de números menores o iguales a 5: " +
                              $"{cantNumMenOIgual5}");
        }
    }
}
