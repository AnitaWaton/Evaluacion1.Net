using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenesPorAhi_AOsorio
{
    public partial class Form1 : Form
    {
        MovimientoTarjeta tarjetita = new MovimientoTarjeta();
        public Form1()
        {
            InitializeComponent();
            gbMovimiento_AOsorio.Visible = false;
        }

        private void btnCrear_AOsorio_Click(object sender, EventArgs e)
        {
            string tipoCuenta_AOsorio = "";
            if (rbtnVGold_AOsorio.Checked == true)
            {
                tipoCuenta_AOsorio = "Cuenta Vista Gold";
            }
            else if (rbtnVPlat_AOsorio.Checked == true)
            {
                tipoCuenta_AOsorio = "Cuenta Vista Platinum";
            }

            tarjetita.NumeroCliente_AOsorio = txtNumT_AOsorio.Text;
            tarjetita.NombreCliente_AOsorio = txtNom_AOsorio.Text;
            tarjetita.TipoTarjeta_AOsorio = tipoCuenta_AOsorio;

            if (string.IsNullOrEmpty(txtNom_AOsorio.Text) && string.IsNullOrEmpty(txtNumT_AOsorio.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese sus datos!");
            }
            else if (rbtnVGold_AOsorio.Checked == false && rbtnVPlat_AOsorio.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Selecciones una tarjeta!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Usuario creado :)");
                gbMovimiento_AOsorio.Visible = true;
            }
        }

        private void btnNuevo_AOsorio_Click(object sender, EventArgs e)
        {
            txtNumT_AOsorio.Clear();
            txtNom_AOsorio.Clear();
            rbtnVGold_AOsorio.Checked = false;
            rbtnVPlat_AOsorio.Checked = false;
            gbMovimiento_AOsorio.Visible = false;
        }

        private void btnCompra_AOsorio_Click(object sender, EventArgs e)
        {
            int cantidad_AOsorio = int.Parse(txtCompra_AOsorio.Text);
            tarjetita.compra(cantidad_AOsorio);
            LBox_AOsorio.Items.Add("El número de cuenta bancaria es: " +
            tarjetita.NumeroCliente_AOsorio + ", Compra Registrada: $" + cantidad_AOsorio + " CLP. ");
        }

        private void btnPago_AOsorio_Click(object sender, EventArgs e)
        {
            int cantidad_AOsorio = int.Parse(txtPago_AOsorio.Text);
            if (tarjetita.pago(cantidad_AOsorio))
            {
                LBox_AOsorio.Items.Add("El número de cuenta bancaria es: " +
                tarjetita.NumeroCliente_AOsorio + ", Pago registrado: $" + cantidad_AOsorio + " CLP. ");
            }
            else
            {
                LBox_AOsorio.Items.Add("El numero de cuenta bancaria es: " +
                tarjetita.NumeroCliente_AOsorio + "OPERACION NO VALIDA (SALDO INSUFICIENTE)");
            }
        }

        private void btnConsultar_AOsorio_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(" ESTADO DE CUENTA \n" +
                "Numero de cuenta: " + tarjetita.NumeroCliente_AOsorio + "\n" +
                "Nombre cliente: " + tarjetita.NombreCliente_AOsorio + "\n" +
                "Tipo cuenta: " + tarjetita.TipoTarjeta_AOsorio + "\n" +
                "Saldo cuenta: $" + tarjetita.SaldoCliente_AOsorio.ToString() + "CLP. \n \n" +
                DateTime.Now.ToString());
        }
    }
}
