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
            if (SelecionarUsuario != null)
            {

                // abrir o formulário de edição do cardápio
                var frmEditar = new FrmUsuarioCad(SelecionarUsuario);
                frmEditar.ShowDialog();
                // atualizar o cardápio após a edição
                BuscarUsuario();
                SelecionarUsuario = null;//limpa a seleção após a edição
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
                //Consulta a tabela Usuário
                var usuario = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(TextUsuario.Text))
                {
                    // Filtra os itens do Usuário com base no texto de pesquisa
                    usuario = usuario.Where(u => u.NomeCompleto.Contains(textNomeCompleto.Text));
                    
                }
                //popular o DataGridView com os dados do cardápio
                dataGridView1.DataSource = usuario.ToList();
            }
        }

        
    }
}
