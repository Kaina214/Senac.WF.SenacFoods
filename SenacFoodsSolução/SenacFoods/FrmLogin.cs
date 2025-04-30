namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            this.Hide();
            //criar uma instancia de frmprincipal
            var frmPricipal = new FrmPrinncipal();
            //exibe a tela principal 
            frmPricipal.Show();

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
