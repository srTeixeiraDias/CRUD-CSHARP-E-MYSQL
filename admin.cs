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
        public bool resultado;
        public admin()
        {
            InitializeComponent();
            
        }

        public void btn_autorizar_Click(object sender, EventArgs e)
        {
            
            if (txt_adm.Text!="admin" || txt_senha.Text != "admin")
            {
                MessageBox.Show("ADMINISTRADOR INVALIDO, AÇÃO NÃO AUTORIZADA!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_adm.Clear();
                txt_senha.Clear();
                resultado = false;
                
            }
            else
            {
                MessageBox.Show("ADMINISTRADOR VALIDO, AÇÃO AUTORIZADA!", "AUTORIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                resultado = true;

                

                Close();
            }
            
        }

        public  bool Autorizar(string auto)
        {
            
            if (txt_adm.Text != "admin" && txt_senha.Text != "admin")
            {
                MessageBox.Show("ADMINISTRADOR INVALIDO, AÇÃO NÃO AUTORIZADA!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;


            }
            else
            {
                MessageBox.Show("ADMINISTRADOR VALIDO, AÇÃO AUTORIZADA!", "AUTORIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            
            return true;
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
