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
    public partial class FrmMesaCad : Form
    {
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMesa();
        }

        private void SalvarMesa()
        {
            throw new NotImplementedException();
        }

        private void textNumeroMesa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
