namespace SenacFoods
{
    public partial class FrmCardapioCad : Form
    {
        private usuarioItem _cardapioItem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(usuarioItem cardapiointem)
        {
            _cardapioItem = cardapiointem;
            InitializeComponent();
            // carregar os dados da tela
            CarregarDadosNaTela();

        }
        //metodo que gera o evento de carregamento do form
        private void CarregarDadosNaTela()
        {
            //popular os campos de texto e checkbox
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescricao.Text = _cardapioItem.Descricao;
                txtPreço.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {   //INSERIR
            if (_cardapioItem == null)
            {
                InserirCardapio();
            }
            //ATUALIZAR
            else
            {
                AtualizarCardapio();
            }
            
        }

        private void AtualizarCardapio()
        {
           using(var banco = new ComandaDBContext())
            {
                //captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreço.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked
                    //atualizar o cardapio
                var cardapioItem = banco.CardapioItens.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;

            }
        }

        private void InserirCardapio()
        {
            //conectar ao banco de dados
            using (var banco = new ComandaDBContext())
            {


                // captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreço.Text.Trim(), out decimal preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                // criar um novo cardapio
                var cardapio = new usuarioItem()

                {
                    Titulo = titulo,
                    Descricao = descricao,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                // adicionar o cardapio
                banco.CardapioItens.Add(cardapio);
                banco.SaveChanges();
                // salvar as alterações no banco


            }
            MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtPreço_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
