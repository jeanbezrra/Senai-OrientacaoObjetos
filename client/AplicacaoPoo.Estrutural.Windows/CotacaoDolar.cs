using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class CotacaoDolar : Form
    {
        private bool CotacaoEhValido;
        private bool ValorEmDolarEhValido;
        public CotacaoDolar()
        {
            InitializeComponent();
            HabilitarOuDesabilitarBotaoCalcularConversao();
        }
        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorAtualDolar = decimal.Parse(txtVdolarHoje.Text);
            var valorEmDolar = decimal.Parse(txtVconversao.Text);

            var resultado = valorEmDolar * valorAtualDolar;
            MessageBox.Show($"Valor em Reais: {resultado.ToString("C")}");
        }
        private void txtDolarHoje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtVdolarHoje.Text);
                CotacaoEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtVdolarHoje.Focus();
                CotacaoEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
        }

        private void txtVconversao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtVconversao.Text);
                ValorEmDolarEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtVconversao.Focus();
                ValorEmDolarEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
        }
        private void HabilitarOuDesabilitarBotaoCalcularConversao()
        {
            if (ValorEmDolarEhValido && CotacaoEhValido)
            {
                btnConverter.Enabled = true;
            }
            else
            {
                btnConverter.Enabled = false;
            }
        }
    }
}