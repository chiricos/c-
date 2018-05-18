using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total;
            clsEmpleados empleado = new clsEmpleados();
            empleado.Edad = 25;
            empleado.Nombre = "Edward Diaz";
            empleado.SueldoDiario = 300000.0m;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El empleado: " + empleado.Nombre);
            Console.WriteLine("El salario mensual es: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}
