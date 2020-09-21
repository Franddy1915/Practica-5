using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3__Ordenar_Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglo desordenado
            int[] numeros = { 9, 15, 1, 14, 8, 7, 6, 5 };
            // Crear un comparador que ordena de manera ascendente
            Comparison<int> comparador = new Comparison<int>((numero1, numero2) => numero1.CompareTo(numero2));
            // Llamar a Array.Sort, pasando el arreglo a ordenar y el comparador
            Array.Sort<int>(numeros, comparador);
            // Ahora simplemente imprimimos
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
