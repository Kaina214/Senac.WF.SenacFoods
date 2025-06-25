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
        {   //CONECTA // ao banco de dados
            bool usuarioValido = false;
            using (var banco = new ComandaDBContext())
            {
                // Verifica se o usuário existe no banco de dados
                //CONSULTAR A TABELA USUARIOS SELECIONANDO O USUÁRIO COM O NOME E SENHA INFORMADOS
                var usuario = banco
                    .Usuarios
                    .FirstOrDefault(u => u.Email.ToLower() == nome.ToLower() && u.Senha == senha);
                if (usuario != null)
                {
                    // Usuário encontrado, login válido
                    usuarioValido = true;
                }
            }
            //// Verifica se o usuário foi encontrado
            if (usuarioValido)
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

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
