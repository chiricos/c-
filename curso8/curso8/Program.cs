using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso8
{
    class Program
    {
        static void Main(string[] args)
        {

            clsClientesVentas Cliente = new clsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Edward Diaz";
            Cliente.Nombres = "Marcos";
            Cliente.RFC = "HEHM";
            Cliente.Direccion = "Calle 69 # 3 a 33 s";
            Cliente.Colonia = "La gran via";
            Cliente.Municipio = "bogota";
            Cliente.EsCredito = false;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
            {
                Console.WriteLine("El cliente es de credito");
            }
            else
            {
                Console.WriteLine("El cliente no es de credito");
            }
            Console.ReadKey();
        }
    }
}
