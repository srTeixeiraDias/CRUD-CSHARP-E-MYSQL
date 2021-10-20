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
    public partial class busca : Form
    {
        public busca()
        {
            InitializeComponent();

            lsl_busca.View = View.Details;
            lsl_busca.AllowColumnReorder = true;
            lsl_busca.FullRowSelect = true;
            lsl_busca.GridLines = true;

            lsl_busca.Columns.Add("CPF", 160, HorizontalAlignment.Center);
            lsl_busca.Columns.Add("Nome", 160, HorizontalAlignment.Center);
            lsl_busca.Columns.Add("Email", 160, HorizontalAlignment.Center);
            
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            conexao con = new conexao(); //novo objeto da classe de conexão   

            if(txt_busca.Text != "")
            {
                try
                {


                    con.conectar();

                    string buscar = "'%" + txt_busca.Text + "%'";

                    string sql = "select cpf, nome, email from cadastro where Nome like " + buscar + " or email like " + buscar;
                    // string sql = "select nome, email from cadastro where Nome like '%@buscar%' or email like '%@buscar%' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con.conn);
                    //  cmd.Parameters.AddWithValue("@buscar", txt_busca.Text);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    lsl_busca.Items.Clear();

                    while (rdr.Read())
                    {
                        string[] row =
                        {
                        rdr.GetString(0),
                        rdr.GetString(1),
                        rdr.GetString(2)
                    };

                        var linha = new ListViewItem(row);
                        lsl_busca.Items.Add(linha);
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
            else
            {
                MessageBox.Show("Você não inseriu nenhum nume ou parte de nome para a busca!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lsl_busca.Items.Clear();
            txt_busca.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
