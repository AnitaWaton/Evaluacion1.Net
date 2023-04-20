using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenesPorAhi_AOsorio
{
    class Cliente
    {
        private string nombreCliente_AOsorio;
        private int saldoCliente_AOsorio;

        public Cliente()
        {
        }

        public Cliente(string nombreCliente_AOsorio, int saldoCliente_AOsorio)
        {
            this.NombreCliente_AOsorio = nombreCliente_AOsorio;
            this.SaldoCliente_AOsorio = saldoCliente_AOsorio;
        }

        public string NombreCliente_AOsorio { get => nombreCliente_AOsorio; set => nombreCliente_AOsorio = value; }
        public int SaldoCliente_AOsorio { get => saldoCliente_AOsorio; set => saldoCliente_AOsorio = value; }
    }
}
