using AplicacaoPoo.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Windows
{
    public partial class frmCliente : Form
    {
        private object txtCpf;

        public frmCliente()
        {
            InitializeComponent();
            var cliente = new Cliente();
            cliente.Nome = "Jean Bezerra";
            txtClienteNome.Text = cliente.Nome;
            txtCPF.Text = "119.579.397-96";
            lblSaldoInicialValor.Text = "1000";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var credito = new Credito();    
        }
    }
}
