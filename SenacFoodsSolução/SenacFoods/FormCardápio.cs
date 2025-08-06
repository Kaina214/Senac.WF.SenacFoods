
namespace SenacFoods
{

    public partial class FormCardápio : Form
    {
        mesaItem? cardapioSelecionado;

        public FormCardápio()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Click do editar
            if (cardapioSelecionado != null)
            {

                // abrir o formulário de edição do cardápio
                var frmEditar = new FrmCardapioCad(cardapioSelecionado);
                frmEditar.ShowDialog();
                // atualizar o cardápio após a edição
                BuscarCardápio();
                cardapioSelecionado = null;//limpa a seleção após a edição
            }
        }


        private void FormCardápio_Load(object sender, EventArgs e)
        {
            BuscarCardápio();
        }

        private void BuscarCardápio()
        {
            // Conecta ao banco de dados
            using (var bd = new ComandaDBContext())
            {
                //Consulta a tabela Cardápio
                var cardapio = bd.Mesa.AsQueryable();
                if (!string.IsNullOrEmpty(textPesquisa.Text))
                {
                    // Filtra os itens do cardápio com base no texto de pesquisa
                    cardapio = cardapio.Where(c => c.NumeroMesa.Contains(textPesquisa.Text) ||
                                                              c.SituacaoMesa.Contains(textPesquisa.Text));
                }
                //popular o DataGridView com os dados do cardápio
                dataGridView1.DataSource = cardapio.ToList();
            }
        }



        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardápio();
        }

        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            //chamar o metodo buscar cardápio
            BuscarCardápio();
        }

        // excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Mesa.Remove(cardapioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardápio();
                cardapioSelecionado = null; // Limpa a seleção após a exclusão
            }
            else { MessageBox.Show("Selecione um cardápio para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }





        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as mesaItem;
                btnEditar.Enabled = true;

            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
