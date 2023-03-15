using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Producto__
{
    class Ejercicio01
    {
        static void Main()
        {
            /* 
                1. Hacer una función llamada “producto” que reciba dos números enteros y 
                   que devuelva el producto de ambos. Luego hacer un programa que pida el 
                   precio de un artículo y la cantidad vendida y muestre por pantalla el 
                   monto total a pagar. Usar la función. 
            */

            Console.Write("Precio del artículo: $");
            float precioArticulo = float.Parse(Console.ReadLine());
            Console.Write("Cantidad vendida: ");
            int cantidadVendida = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTotal a pagar: " +
                              $"${Producto(precioArticulo, cantidadVendida)}");
        }

        static float Producto(float precio, int cantidad)
        {
            return precio * cantidad;
        }
    }
}
