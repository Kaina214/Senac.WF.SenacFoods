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
    public partial class FrmPrinncipal : Form
    {
        public FrmPrinncipal(string nome, String senha)
        {
            InitializeComponent();
            //exibe o nome do FormUsuarios na tela
            lblMensagem.Text = " Bem vindo" + nome;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btncomanda(object sender, EventArgs e)
        {
            var frmcomanda = new FrmComanda();
            frmcomanda.ShowDialog();
        }

        private void btnpedidodacozinha(object sender, EventArgs e)
        {
            var frmpedidosdacozinha = new FrmPedidoCozinha();
            frmpedidosdacozinha.ShowDialog();
        }

        private void btnusuarios(object sender, EventArgs e)
        {
            var frmusuarios = new FormUsuarios();
            frmusuarios.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmcardapio = new FormCardápio();
            frmcardapio.ShowDialog();
        }
    }
}
