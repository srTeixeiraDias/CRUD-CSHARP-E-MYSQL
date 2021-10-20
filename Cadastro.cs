using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private string Letra(string str)       //metodo aprendido hoje, transforma as primeiras letras das palavras de uma frase em maiuscula
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        private string LetraM(string nom)        //metodo que exclui os conectidos do array abaixo
        {
            var resultado = "";
            var palavrasdeletadas = new string[] { "da", "de", "di", "do", "du", "e" };

            var palavras = nom.Split(' ');

            foreach (string palavra in palavras)
            {
                if(palavrasdeletadas.Contains(palavra))
                {
                    resultado += palavra + " ";
                }
                else
                {
                    resultado += Letra(palavra) + " ";
                }

                

               
            }
            resultado = resultado.Trim();
            return resultado;
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
            string nome, email, telefone, celular, cpf;
            nome = txt_nome.Text;
            cpf = txt_cpf.Text;
            email = txt_email.Text;
            telefone = txt_telefone.Text;
            celular = txt_celular.Text;
           



            if (txt_nome.Text == "" || txt_email.Text== "" || txt_celular.Text == "" || maskedTextBox1.Text == "" || txt_cpf.Text == "")
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS OBRIGATÓRIOS(*)!","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nome.Focus();

            }
            else
            {
                conexao con = new conexao(); //novo objeto da classe de conexão 
                
                try
                {
                    string nomeM;
                    nomeM = LetraM(txt_nome.Text);  //transformando o txt nome com as letras maiusculas
                    con.conectar();
                    label8.Text = "CONEXÇÃO OK";
                    string sql = "insert into cadastro values ( @cpf, @Nome ,@Telefone, @Celular, @Email, @Data_nasc)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                    cmd.Parameters.AddWithValue("@Nome", nomeM);
                    cmd.Parameters.AddWithValue("@Telefone", txt_telefone.Text);
                    cmd.Parameters.AddWithValue("@Celular", txt_celular.Text);
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@Data_nasc", maskedTextBox1.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario cadastrado com sucesso!", "CADASTRO EFETUADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_data_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
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
