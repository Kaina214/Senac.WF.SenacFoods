using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmUsuario : Form
    {
        Usuario? SelecionarUsuario;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmUsuarioCad().ShowDialog();

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void BuscarUsuario()
        {
            // Conecta ao banco de dados
            using (var bd = new ComandaDBContext())
            {
                //Consulta a tabela Cardápio
                var usuario = bd.UsuarioAdd.AsQueryable();
                if (!string.IsNullOrEmpty(textPesquisarUsuario.Text))
                {
                    // Filtra os itens do cardápio com base no texto de pesquisa
                    usuario = usuario.Where(u => u.NomeCompleto.Contains(textNomeCompleto.Text) ||
                                                              u.Descricao.Contains(textNomeCompleto.Text));
                }
                //popular o DataGridView com os dados do cardápio
                dataGridView1.DataSource = cardapio.ToList();
            }
        }
    }
}
