using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__ShowMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Padre.ShowMessege("hola desde clase padre");
            Hija.ShowMessege("Hola desde clase hija");
            
            Console.ReadKey();

        }
    }
}
