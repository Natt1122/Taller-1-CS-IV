using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.WriteLine("Ingrese el Primer número");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo número");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingrese el tercer número");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.WriteLine("Algún número es menor a Diez");

            }
            else
            {
                Console.WriteLine("Todos los numeros son mayores de diez");
            }
            Console.ReadKey();
        }
    }
}
