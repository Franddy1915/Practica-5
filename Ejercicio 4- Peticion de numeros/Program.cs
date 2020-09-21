using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4__Peticion_de_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n;
            int cant;
            int suma = 0;
            int promedio = 0;
            Console.WriteLine("Ingrese el tamaño del arreglo");
            cant = int.Parse(Console.ReadLine());
            n = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese los numero "+(i+1)+ " : " );
                n[1] = int.Parse(Console.ReadLine());
                suma += n[1];//suma + suma + n[1]
                promedio = suma / cant;
            }
            Console.WriteLine("La suma de todos los numeros es: " + suma);
            Console.WriteLine("El promedio de todos los numeros es: " + promedio);
            Console.ReadKey();


        }
    }
}
