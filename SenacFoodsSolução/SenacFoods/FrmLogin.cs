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
            bool loginValido = ValidarLogin(textLogin.Text, textSenha.Text);
            if (loginValido)
            {
                this.Hide();
                //criar uma instancia de frmprincipal
                var frmPricipal = new FrmPrinncipal(textLogin.Text, textSenha.Text);
                //exibe a tela principal 
                frmPricipal.Show();

            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            if(nome == "adimin" && senha == "123")
            {
                return true;
            }
            else
            {
                MessageBox.Show(" Login ou senha inválidos");
            }
                return false;
           




        }
        

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
