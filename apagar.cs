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
    public partial class apagar : Form
    {
        public apagar()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao(); //novo objeto da classe de conexão

            try
            {
                if (txt_deletar.Text == "")
                {
                    MessageBox.Show("Digite o cpf do cadastro que será deletado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.conectar();

                string sql = "select * from cadastro where cpf=@pesquisa;";
                MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                cmd.Parameters.AddWithValue("@pesquisa", txt_deletar.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows == true)
                {



                    txt_nome.Text = Convert.ToString(rdr["Nome"]);
                    txt_cpf.Text = Convert.ToString(rdr["cpf"]);
                    txt_telefone.Text = Convert.ToString(rdr["telefone"]);
                    txt_celular.Text = Convert.ToString(rdr["celular"]);
                    txt_email.Text = Convert.ToString(rdr["email"]);
                    maskedTextBox1.Text = Convert.ToString(rdr["Data_nasc"]);

                    txt_deletar.Focus();



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

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            
         DialogResult resp= MessageBox.Show("DESEJA MESMO DELETAR ESSE CADASTRO, ESSA DECISÃO NÃO PODERÁ SER REFEITA!", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resp == DialogResult.Yes)
            {

                if(txt_nome.Text== "")
                {
                    MessageBox.Show("FAÇA A CONSULTA PARA SABER SE ESTÁ DELETANDO O USUÁRIO CORRETO!!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    conexao con = new conexao(); //novo objeto da classe de conexão


                    try
                    {
                        con.conectar();
                        string sql = "delete from cadastro where cpf=@cpf";
                        MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                        cmd.Parameters.AddWithValue("@cpf", txt_deletar.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario deletado com sucesso!", "DELETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_nome.Clear();
                        txt_telefone.Clear();
                        txt_celular.Clear();
                        txt_cpf.Clear();
                        txt_email.Clear();
                        maskedTextBox1.Clear();
                        txt_deletar.Clear();
                        txt_deletar.Focus();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        con.desconectar();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Ok, usuario não deletado!!", "NÃO DELETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_email.Clear();
            maskedTextBox1.Clear();
            txt_deletar.Clear();
            txt_deletar.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
