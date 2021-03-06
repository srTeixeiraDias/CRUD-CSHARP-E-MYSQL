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
    public partial class atualizar : Form
    {
        public atualizar()
        {
            InitializeComponent();

        }


        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao(); //novo objeto da classe de conexão

            

            try
            {
                con.conectar();
               
                string sql = "Update cadastro set cpf=@cpf, nome= @nome, telefone=@telefone, celular=@celular, Email=@email, Data_nasc=@data where cpf= @pesquisa";
                MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                cmd.Parameters.AddWithValue("@celular", txt_celular.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@pesquisa", txt_alteracao.Text);

                
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO, CONSULTE E VERIFIQUE AS ALTERAÇÕES!", "ATUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                con.desconectar();
            }
            txt_alteracao.Clear();
            txt_nome.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_email.Clear();
            txt_cpf.Clear();
            txt_alteracao.Focus();
            

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao(); //novo objeto da classe de conexão

            try
            {
                if (txt_alteracao.Text == "")
                {
                  
                    MessageBox.Show("Digite o CPF do cadastro que será atualizado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.conectar();

                string sql = "select * from cadastro where cpf=@pesquisa;";
                MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                cmd.Parameters.AddWithValue("@pesquisa", txt_alteracao.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows == true)
                {



                    txt_nome.Text = Convert.ToString(rdr["Nome"]);
                    txt_cpf.Text = Convert.ToString(rdr["cpf"]);
                    txt_telefone.Text = Convert.ToString(rdr["telefone"]);
                    txt_celular.Text = Convert.ToString(rdr["celular"]);
                    txt_email.Text = Convert.ToString(rdr["email"]);
                    dateTimePicker1.Value = Convert.ToDateTime(rdr["Data_nasc"]);

                    txt_alteracao.Focus();



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

            

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_alteracao.Clear();
            txt_nome.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_email.Clear();
            txt_cpf.Clear();
            txt_alteracao.Focus();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
