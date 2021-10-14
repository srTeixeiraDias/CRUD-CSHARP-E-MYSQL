
namespace fundBra
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEfetuarCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNovoCad = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl_saida = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_data = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.txt_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEfetuarCad
            // 
            this.btnEfetuarCad.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEfetuarCad.BackgroundImage = global::fundBra.Properties.Resources.botao;
            this.btnEfetuarCad.FlatAppearance.BorderSize = 0;
            this.btnEfetuarCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfetuarCad.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarCad.Image = global::fundBra.Properties.Resources.cadastrar_1;
            this.btnEfetuarCad.Location = new System.Drawing.Point(228, 334);
            this.btnEfetuarCad.Name = "btnEfetuarCad";
            this.btnEfetuarCad.Size = new System.Drawing.Size(125, 69);
            this.btnEfetuarCad.TabIndex = 0;
            this.btnEfetuarCad.UseVisualStyleBackColor = false;
            this.btnEfetuarCad.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefone:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Email:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Data de Nascimento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "*Nome:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_nome.Location = new System.Drawing.Point(228, 196);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(311, 20);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_email.Location = new System.Drawing.Point(228, 269);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(311, 20);
            this.txt_email.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(178, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "CADASTRO DE USUÁRIO";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // btnNovoCad
            // 
            this.btnNovoCad.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNovoCad.BackgroundImage = global::fundBra.Properties.Resources.botao;
            this.btnNovoCad.FlatAppearance.BorderSize = 0;
            this.btnNovoCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCad.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCad.Location = new System.Drawing.Point(45, 350);
            this.btnNovoCad.Name = "btnNovoCad";
            this.btnNovoCad.Size = new System.Drawing.Size(132, 45);
            this.btnNovoCad.TabIndex = 13;
            this.btnNovoCad.Text = "NOVO CADASTRO";
            this.btnNovoCad.UseVisualStyleBackColor = false;
            this.btnNovoCad.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(415, 357);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 38);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbl_saida
            // 
            this.lbl_saida.AutoSize = true;
            this.lbl_saida.Location = new System.Drawing.Point(181, 324);
            this.lbl_saida.Name = "lbl_saida";
            this.lbl_saida.Size = new System.Drawing.Size(0, 13);
            this.lbl_saida.TabIndex = 16;
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_telefone.Location = new System.Drawing.Point(228, 231);
            this.txt_telefone.Mask = "(00)0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(114, 20);
            this.txt_telefone.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "*Celular: ";
            // 
            // txt_celular
            // 
            this.txt_celular.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_celular.Location = new System.Drawing.Point(425, 231);
            this.txt_celular.Mask = "(00)00000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(114, 20);
            this.txt_celular.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.txt_data);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 424);
            this.panel2.TabIndex = 20;
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_data.Controls.Add(this.label9);
            this.txt_data.Controls.Add(this.label8);
            this.txt_data.Controls.Add(this.maskedTextBox1);
            this.txt_data.Controls.Add(this.label4);
            this.txt_data.Controls.Add(this.pictureBox1);
            this.txt_data.Controls.Add(this.label6);
            this.txt_data.Controls.Add(this.txt_celular);
            this.txt_data.Controls.Add(this.btnEfetuarCad);
            this.txt_data.Controls.Add(this.label7);
            this.txt_data.Controls.Add(this.label1);
            this.txt_data.Controls.Add(this.txt_telefone);
            this.txt_data.Controls.Add(this.label2);
            this.txt_data.Controls.Add(this.lbl_saida);
            this.txt_data.Controls.Add(this.label3);
            this.txt_data.Controls.Add(this.btnSair);
            this.txt_data.Controls.Add(this.btnNovoCad);
            this.txt_data.Controls.Add(this.label5);
            this.txt_data.Controls.Add(this.txt_nome);
            this.txt_data.Controls.Add(this.txt_email);
            this.txt_data.Location = new System.Drawing.Point(9, 11);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(582, 401);
            this.txt_data.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.maskedTextBox1.Location = new System.Drawing.Point(228, 300);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 20);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::fundBra.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(63, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 153);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Por: Samuel Teixeira Dias";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 423);
            this.Controls.Add(this.panel2);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.panel2.ResumeLayout(false);
            this.txt_data.ResumeLayout(false);
            this.txt_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEfetuarCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNovoCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl_saida;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txt_data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

