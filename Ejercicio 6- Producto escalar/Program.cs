using System;

namespace Ejercicio_6__Producto_escalar
{
    class Program
    {
        static void Main(string[] args)
        {
            int subtotal;
            int total = 0;

            int[] VectorA = { 2, 4, 6 };
            int[] VectorB = { 1, 3, 5 };

            for (int i = 0; i < VectorA.Length; i++)
            {
                subtotal = VectorA[i] * VectorB[i];
                total += subtotal;
            }
            System.Console.WriteLine("El total del producto Escalar es: {0}",total);
            Console.ReadKey();
        }

    }
}
