using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Pagos__
{
    class Ejercicio05
    {
        static void Main()
        {
            /* 
                5. Hacer una función llamada “pagos” que reciba un monto (float) y una 
                   cantidad de pagos (entero) y devuelva el monto de cada pago. Hacer un 
                   programa para ingresar 10 ventas. Para cada venta se conoce el monto y 
                   la cantidad de pagos. El programa deberá mostrar la cantidad de pagos y 
                   el monto del pago para cada una de las ventas.   
            */

            // Los números ingresados serán aleatorios para agilizar el ejercicio.
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                float monto = random.Next(1, 1000);
                int cantPagos = random.Next(1, 13);

                Console.WriteLine($"---------- Venta número {i + 1} ----------");
                Console.WriteLine($"Monto total: ${monto}");
                Console.WriteLine($"Cantidad de pagos: {cantPagos}");
                Console.WriteLine($"\nMonto por cuota: " +
                                  $"${Math.Round(Pagos(monto, cantPagos), 2)}\n");
            }
        }
        static float Pagos(float monto, int cantPagos)
        {
            return monto / cantPagos;
        }
    }
}
