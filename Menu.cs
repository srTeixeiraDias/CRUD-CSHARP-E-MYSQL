using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fundBra
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar consulta = new pesquisar();
            consulta.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //admin admin = new admin();
           // admin.ShowDialog();
            
            atualizar update = new atualizar();
            update.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
          //  admin admin = new admin();
          //  admin.ShowDialog();
            apagar deletar = new apagar();
            deletar.ShowDialog();
        }
    }
}
