using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenesPorAhi_AOsorio
{
    class Tarjeta: Cliente
    {
        private string numeroCliente_AOsorio;
        private string tipoTarjeta_AOsorio;

        public Tarjeta()
        {
        }

        public Tarjeta(string numeroCliente_AOsorio, string tipoTarjeta_AOsorio)
        {
            this.NumeroCliente_AOsorio = numeroCliente_AOsorio;
            this.TipoTarjeta_AOsorio = tipoTarjeta_AOsorio;
        }

        public string NumeroCliente_AOsorio { get => numeroCliente_AOsorio; set => numeroCliente_AOsorio = value; }
        public string TipoTarjeta_AOsorio { get => tipoTarjeta_AOsorio; set => tipoTarjeta_AOsorio = value; }
    }
}
