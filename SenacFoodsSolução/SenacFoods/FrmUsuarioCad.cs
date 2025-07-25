namespace SenacFoods
{
    public partial class FrmUsuarioCad : Form
    {
        private Usuario _usuario;
        public FrmUsuarioCad(Usuario? selecionarUsuario)
        {
            InitializeComponent();
        }

        public FrmUsuarioCad()
        {
        }
        private void CarregarDadosNaTela()
        {
            //popular os campos de texto e checkbox
            if (_usuario != null)
            {
                TxtNomeCompleto.Text = _usuario.Nome;
                //comboBoxPerfilDoUsuario. = _usuario.PerfilDoUsuário;
                TxtEMail.Text = _usuario.Email;
                TextSenha.Text = _usuario.Senha;
                
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //INSERIR
            if (_usuario == null)
            {
                InserirUsuario();
            }
            //ATUALIZAR
            else
            {
                AtualizarUsuario();
            }
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                //captar os dados da tela
                string NomeCompleto = TxtNomeCompleto.Text;
                string EMail = TxtEMail.Text;
                string Senha = TextSenha.Text;
                
                var usuario = banco.Usuarios.First(x => x.Id == _usuario.Id);
                usuario.Nome = NomeCompleto;
                usuario.Email = EMail;
                usuario.Senha = Senha;
                

            }
        }

        private void InserirUsuario()
        {
            
        }
    }
}
