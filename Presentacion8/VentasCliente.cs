using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    class VentasCliente : Clientes
    {
        private bool _EsCredito;
        private string _RFC;
        private string _Colonia;

        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
        public string RFC { get => _RFC; set => _RFC = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }

        
    }
}
