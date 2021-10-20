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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            
        }

        public void btn_autorizar_Click(object sender, EventArgs e)
        {
            bool retorno;
            if (txt_adm.Text=="admin" && txt_senha.Text == "admin")
            {
                Close();
            }
            else
            {
                MessageBox.Show("ADMINISTRADOR INVALIDO, AÇÃO NÃO AUTORIZADA!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                retorno = false;
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
