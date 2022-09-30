using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;

namespace AplicacaoPoo.Estrutural.Windows
{
    //Construtor //Construtor //Construtor //Construtor //Construtor
    public partial class frmConversorMoeda : Form
    {
        public frmConversorMoeda()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
            txtValorEmDolar.Text = "1";

            //Coloca os valores da nossa classe dentro do combobox.
            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;
            

        }
        //Construtor //Construtor //Construtor //Construtor //Construtor

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            if (txtValorEmDolar.Text == "")
            {
                cmbMoedas.Enabled = false;
                return;
            }
            cmbMoedas.Enabled = true;
            EfetuarConversaoMoeda();
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfetuarConversaoMoeda();
        } 
         
        private void EfetuarConversaoMoeda()
        //#region MEU PROGRAMA
        //Atalho para comentar código CTRL + K + C
        //Atalho para descomentar o código CTRL + K + U

        {
            try
            {
                if (txtValorEmDolar.Text == "") return;
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var moedaService = new ConverterMoedaService();
                switch (cmbMoedas.SelectedValue)
                {
                    case MoedaHelper.Dolar:
                        {
                            var valorConvertido =
                                moedaService.ConverterDolarEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Euro:
                        {
                            var valorConvertido =
                                moedaService.ConverterEuroEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Libra:
                        {
                            var valorConvertido =
                                moedaService.ConverterLibraEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libra} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    default:
                        break;
                }
                //#endregion

                //#region PROGRAMA TOP DAS GALAXIA DO PROFESSOR

                //#endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisar informar o valor numérico");
                txtValorEmDolar.Text = String.Empty;
                txtValorEmDolar.Focus();
            }


        }
    }
}