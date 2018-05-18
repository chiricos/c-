using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso7
{
    class clsEmpleados
    {
        private string _Nombre;
        private int _Edad;

        public clsEmpleados()
        {
            Nombre = "";
            Edad = 0;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal SueldoDiario { get; set; }

        
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
}
