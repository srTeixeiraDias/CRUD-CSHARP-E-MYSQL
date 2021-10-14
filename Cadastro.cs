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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nome, email, telefone, celular;
            nome = txt_nome.Text;
            email = txt_email.Text;
            telefone = txt_telefone.Text;
            celular = txt_celular.Text;
           



            if (txt_nome.Text == "" ||  txt_email.Text== "" || txt_celular.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS OBRIGATÓRIOS(*)!","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nome.Focus();

            }
            else
            {
                conexao con = new conexao(); //novo objeto da classe de conexão 
                
                try
                {
                    con.conectar();
                    label8.Text = "CONExÇÃO OK";
                    string sql = "insert into cadastro values ( @Nome, @Telefone, @Celular, @Email, @Data_nasc)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                    cmd.Parameters.AddWithValue("@Nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@Telefone", txt_telefone.Text );
                    cmd.Parameters.AddWithValue("@Celular", txt_celular.Text );
                    cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@Data_nasc", maskedTextBox1.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario cadastrado com sucesso!", "CADASTRO EFETUADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_nome.Clear();
                    txt_telefone.Clear();
                    txt_celular.Clear();
                    txt_email.Clear();
                    maskedTextBox1.Clear();
                    txt_nome.Focus();
                }

                catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    con.desconectar();
                }
                
            }

            

        }

   

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_email.Clear();
            maskedTextBox1.Clear();
            txt_nome.Focus();

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
