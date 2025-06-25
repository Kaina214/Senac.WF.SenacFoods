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
                var cardapio = bd.CardapioItens.ToList();
                //popular o DataGridView com os dados do cardápio
                dataGridView1.DataSource = cardapio;
            }
        }
    }
}
