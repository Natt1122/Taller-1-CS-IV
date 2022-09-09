using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum;
            string linea;

            Console.WriteLine("Ingrese el primer número");
            linea= Console.ReadLine();
            num1= int.Parse(linea);
            Console.WriteLine("Ingrese el segundo número");
            linea= Console.ReadLine();
            num2= int.Parse(linea);
            Console.WriteLine("Ingrese el tercer número");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if(num1==num2 &&num1==num3)
            {
                sum = num1 + num2;
                Console.WriteLine("La suma de los dos primeros números es: "+sum+" Y lamultiplicación con la suma es: "+sum*num3 );

            }
            else
            {
                Console.WriteLine("Los numeros no son iguales");
            }
            Console.ReadKey();
        }
    }
}
