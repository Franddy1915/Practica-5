using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5__Producto_Vectorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Columna;
            int Producto1;
            int Producto2;
            int TotalVec1 = 0;
            int TotalVec2 = 0;
            int TotalVec3 = 0;

            int[,] Matriz = { { 2, 4, 6 }, { 1, 3, 5 } };
            Columna = 0;
    

            if (Columna < 3)
            {
                if (Matriz[0, Columna] == Matriz[0, 0])
                {
                    Producto1 = Matriz[0, 1] * Matriz[1, 2];
                    Producto2 = Matriz[1, 1] * Matriz[0, 2];
                    TotalVec1 = Producto1 + Producto2;
                    Columna++;
                    if (Matriz[0, Columna] == Matriz[0, 1])
                    {
                        Producto1 = Matriz[0, 0] * Matriz[1, 2];
                        Producto2 = Matriz[1, 0] * Matriz[0, 2];
                        TotalVec2 = Producto1 + Producto2;
                        Columna++;
                        if (Matriz[0, Columna] == Matriz[0, 2])
                        {
                            Producto1 = Matriz[0, 0] * Matriz[1, 1];
                            Producto2 = Matriz[1, 0] * Matriz[0, 1];
                            TotalVec3 = Producto1 + Producto2;
                        }
                    }
                }
            }
            Console.WriteLine("El Producto Vectorial Es : <{0}, {1}, {2}>", TotalVec1, TotalVec2, TotalVec3);
            Console.ReadKey();

        }
    }
}
