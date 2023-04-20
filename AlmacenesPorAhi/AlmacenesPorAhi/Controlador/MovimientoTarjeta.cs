using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenesPorAhi_AOsorio
{
    class MovimientoTarjeta : Tarjeta
    {
        public void compra(int cantidad_AOsorio)
        {
            SaldoCliente_AOsorio += cantidad_AOsorio;
        }
        public bool pago(int cantidad_AOsorio)
        {
            if (SaldoCliente_AOsorio >= cantidad_AOsorio)
            {
                SaldoCliente_AOsorio -= cantidad_AOsorio;
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Saldo insuficiente \n" + "Operacion invalida");
                return false;
            }
        }
    }
}