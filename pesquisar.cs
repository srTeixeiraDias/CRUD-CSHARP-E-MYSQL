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
                
                string sql = "select * from cadastro where cpf=@pesquisa;";
                MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                cmd.Parameters.AddWithValue("@pesquisa", txt_pesquisa.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
               
                if (rdr.HasRows == true)
                {

                    
                    
                        txt_nome.Text = Convert.ToString(rdr["Nome"]);
                        mskd_cpf.Text = Convert.ToString(rdr["cpf"]);
                        txt_telefone.Text = Convert.ToString(rdr["telefone"]);
                        txt_celular.Text = Convert.ToString(rdr["celular"]);
                        txt_email.Text = Convert.ToString(rdr["email"]);
                        maskedTextBox1.Text = Convert.ToString(rdr["Data_nasc"]);
                       
                    txt_pesquisa.Focus();



                }
                else
                {
                    throw new Exception("CPF inválido ou não cadastrado!");
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

        private void txt_data_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pesquisar_Load(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskd_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
