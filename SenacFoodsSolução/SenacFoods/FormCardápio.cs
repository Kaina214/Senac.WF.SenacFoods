using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FormCardápio : Form
    {
        public FormCardápio()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                var cardapio = bd.CardapioItens.AsQueryable();
                if(!string.IsNullOrEmpty(textPesquisa.Text))
                {
                    // Filtra os itens do cardápio com base no texto de pesquisa
                    cardapio = cardapio.Where(c => c.Titulo.Contains(textPesquisa.Text) || 
                                                              c.Descricao.Contains(textPesquisa.Text));
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
    }
}
