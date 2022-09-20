namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class btn : Form
    {

        public btn()
        {
            InitializeComponent();
        }

        private void btnCotacao_Click(object sender, EventArgs e)
        {
            var form = new CotacaoDolar();
            form.Show();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            var form = new Comissao();
            form.Show();
        }
    }
}