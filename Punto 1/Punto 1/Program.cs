using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes, dia;
            string linea;
            Console.WriteLine("Escriba el número del día");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.WriteLine("Escriba el número del mes");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            if (dia == 24 && mes == 12)
            {
                Console.WriteLine("Pertenece a navidad");
            }
            else
            {
                Console.WriteLine(" NO pertenece a navidad");
            }
            Console.ReadKey();
        }
    }
}
