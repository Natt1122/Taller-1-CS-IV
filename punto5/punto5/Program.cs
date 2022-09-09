using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string linea;
            Console.WriteLine("Ingrese el valor de x");
            linea= Console.ReadLine();
            x = int.Parse(linea);
            Console.WriteLine("Ingrese el valor de y");
            linea = Console.ReadLine();
            y = int.Parse(linea);

            if(x>0 && y>0)
            {
                Console.WriteLine("Pertenece al cuadrante 1");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Pertenece al cuadrante 2");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Pertenece al cuadrante 3");

            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Pertenece al cuadrante 4");
            }
            else
            {
                Console.WriteLine("Debe ser diferente a 0");
            }
            Console.ReadKey();
        }
    }
}
