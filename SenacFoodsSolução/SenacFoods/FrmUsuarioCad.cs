namespace SenacFoods
{
    public partial class FrmUsuarioCad : Form
    {
        private Usuario _usuarioItem;
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
                TxtNomeCompleto.Text = _usuarioItem.NomeCompleto;
                comboBoxPerfilDoUsuario.comboBox = _usuarioItem.PerfilDoUsuário;
                TxtEMail.Text = _usuarioItem.EMail;
                TextSenha.Text = _usuarioItem.Senha;
                TextConfirmacaoDeSenha.Text = _usuarioItem.ConfirmacaoDeSenha;
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
            if (_usuarioItem == null)
            {
                InserirUsuario();
            }
            //ATUALIZAR
            else
            {
                AtualizarUsuario();
            }
        }
    }
}
