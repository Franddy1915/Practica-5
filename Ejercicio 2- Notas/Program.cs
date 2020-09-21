using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[4] { 90, 88, 92, 79 };// array unidireccional
            for (int i = 0; i < notas.Length; i++)
            {
                System.Console.WriteLine(notas[i]);

            }
            Console.ReadKey();
        }
    }
}
