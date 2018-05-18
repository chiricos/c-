using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso6
{
    public class clsEmpleados
    {
        public string Nombre;
        public decimal sueldoDiario;
        public int Edad;

        public clsEmpleados()
        {
            Nombre = "";
            sueldoDiario = 0.0m;
            Edad = 0;
        }

        public decimal CalculaSalario(int NumeroDias)
        {
            return sueldoDiario * NumeroDias;
        }
    }
}
