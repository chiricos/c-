using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso8
{
    public class clsClientes
    {

        private int _idCliente;
        private string _Nombres;
        private string _Apellidos;

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        
        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }





    }
}
