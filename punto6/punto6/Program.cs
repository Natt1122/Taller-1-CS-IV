using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suel, ant;
            float suelact;
            string linea;

            Console.WriteLine("Ingrese el sueldo");
            linea = Console.ReadLine();
            suel= int.Parse(linea);
            Console.WriteLine("Ingrese los años de antigüedad");
            linea= Console.ReadLine();
            ant = int.Parse(linea);

            if (suel < 500 && ant >= 10)
            {
                suelact = suel * 120/100;
                Console.WriteLine("Aumento del 20%: "+ suelact);
            }
            if (suel < 500 && ant < 10)
            {
                suelact = suel * 105 / 100;
                Console.WriteLine("Aumento del 5%: " + suelact);
            }
            if(suel>=500)
            {
                Console.WriteLine(suel);
            }
            Console.ReadKey();
        }
    }
}
