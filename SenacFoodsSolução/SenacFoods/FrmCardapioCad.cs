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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }

        private void SalvarCardapio()
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
                var cardapio = new Cardapiointem()

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
    }
}
