using MySql.Data.MySqlClient;
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
    public partial class pesquisar : Form
    {
        public pesquisar()
        {
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void escondercampos()
        {
            txt_nome.Enabled = false;
            txt_telefone.Enabled = false;
            txt_celular.Enabled = false;
            txt_email.Enabled = false;
            txt_data.Enabled = false;
            
        }

        public void hablitarcampos()
        {
            txt_nome.Enabled = true;
            txt_telefone.Enabled = true;
            txt_celular.Enabled = true;
            txt_email.Enabled = true;
            txt_data.Enabled = true;

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao(); //novo objeto da classe de conexão

            try 
            {
                if (txt_pesquisa.Text == "")
                {
                    MessageBox.Show("Digite o nome para efetuarmos a pesquisa!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.conectar();
                
                string sql = "select * from cadastro where Nome=@pesquisa;";
                MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                cmd.Parameters.AddWithValue("@pesquisa", txt_pesquisa.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
               
                if (rdr.HasRows == true)
                {

                    
                    
                        txt_nome.Text = Convert.ToString(rdr["Nome"]);
                        txt_telefone.Text = Convert.ToString(rdr["telefone"]);
                        txt_celular.Text = Convert.ToString(rdr["celular"]);
                        txt_email.Text = Convert.ToString(rdr["email"]);
                        maskedTextBox1.Text = Convert.ToString(rdr["Data_nasc"]);
                       
                    txt_pesquisa.Focus();



                }
                else
                {
                    throw new Exception("Nome inválido ou não cadastrado!");
                }
                   
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.desconectar();
            }

            txt_pesquisa.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_email.Clear();
            maskedTextBox1.Clear(); 
            txt_pesquisa.Clear();
            txt_pesquisa.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            busca busca = new busca();
            busca.ShowDialog();
        }
    }
}
