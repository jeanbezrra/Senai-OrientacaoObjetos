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
            btnConverter.Enabled = false;
        }
        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            { var resultado = decimal.Parse(txtVdolarHoje.Text);
                CotacaoEhValido = true;
                if (ValorEmDolarEhValido && CotacaoEhValido)
                {
                    btnConverter.Enabled = true;
                }
            }
            catch(Exception)

            var vValorhj = decimal.Parse(txtVdolarHoje.Text);
            var vConversao = decimal.Parse(txtVconversao.Text);
            var resultado = vValorhj * vConversao;

            MessageBox.Show($"Valor é { resultado.ToString()}");        
            
        }
    }
}