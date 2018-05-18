using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola mundo";
            bool bandera = true;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine(bandera.ToString());
            Console.WriteLine(fecha.ToShortDateString());
            Console.ReadKey();

        }
    }
}
