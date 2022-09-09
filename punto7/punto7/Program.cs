using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.WriteLine("Ingrese el primer número");
            linea= Console.ReadLine();
            num1= int.Parse(linea);
            Console.WriteLine("Ingrese el segundo número");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingrese el tercer número");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if(num1>num2 && num1>num3)
            {
                if(num2>num3)
                {
                    Console.WriteLine("El numero mayor es: "+num1 + " y el menor: "+num3);
                }
               else
                {
                    Console.WriteLine("El numero mayor es: " + num1 + " y el menor: " + num2);
                }
            }
            if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El numero mayor es: " + num2 + " y el menor: " + num3);
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + num2 + " y el menor: " + num1);
                }
            }
            if (num3 > num1 && num3 > num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine("El numero mayor es: " + num3 + " y el menor: " + num2);
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + num3 + " y el menor: " + num1);
                } 
            }
            else
            {
                Console.WriteLine("Los numeros deben ser diferentes");
            }
            Console.ReadKey();
        }
    }
}
