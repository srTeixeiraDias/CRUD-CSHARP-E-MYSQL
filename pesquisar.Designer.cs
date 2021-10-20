
namespace fundBra
{
    partial class pesquisar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_data = new System.Windows.Forms.Panel();
            this.mskd_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.lbl_saida = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.txt_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.txt_data);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 456);
            this.panel2.TabIndex = 21;
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_data.Controls.Add(this.mskd_cpf);
            this.txt_data.Controls.Add(this.label1);
            this.txt_data.Controls.Add(this.maskedTextBox1);
            this.txt_data.Controls.Add(this.txt_celular);
            this.txt_data.Controls.Add(this.label7);
            this.txt_data.Controls.Add(this.label2);
            this.txt_data.Controls.Add(this.txt_telefone);
            this.txt_data.Controls.Add(this.label3);
            this.txt_data.Controls.Add(this.label5);
            this.txt_data.Controls.Add(this.label9);
            this.txt_data.Controls.Add(this.txt_nome);
            this.txt_data.Controls.Add(this.txt_email);
            this.txt_data.Controls.Add(this.label13);
            this.txt_data.Controls.Add(this.label12);
            this.txt_data.Controls.Add(this.label11);
            this.txt_data.Controls.Add(this.btn_limpar);
            this.txt_data.Controls.Add(this.label10);
            this.txt_data.Controls.Add(this.txt_pesquisa);
            this.txt_data.Controls.Add(this.label8);
            this.txt_data.Controls.Add(this.label4);
            this.txt_data.Controls.Add(this.pictureBox1);
            this.txt_data.Controls.Add(this.label6);
            this.txt_data.Controls.Add(this.btn_consultar);
            this.txt_data.Controls.Add(this.lbl_saida);
            this.txt_data.Controls.Add(this.btnSair);
            this.txt_data.Location = new System.Drawing.Point(9, 11);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(582, 433);
            this.txt_data.TabIndex = 6;
            this.txt_data.Paint += new System.Windows.Forms.PaintEventHandler(this.txt_data_Paint);
            // 
            // mskd_cpf
            // 
            this.mskd_cpf.BackColor = System.Drawing.Color.YellowGreen;
            this.mskd_cpf.Enabled = false;
            this.mskd_cpf.Location = new System.Drawing.Point(427, 253);
            this.mskd_cpf.Mask = "000.000.000-00";
            this.mskd_cpf.Name = "mskd_cpf";
            this.mskd_cpf.Size = new System.Drawing.Size(114, 20);
            this.mskd_cpf.TabIndex = 41;
            this.mskd_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskd_cpf_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(359, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "*CPF: ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(233, 253);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 20);
            this.maskedTextBox1.TabIndex = 39;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txt_celular
            // 
            this.txt_celular.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_celular.Enabled = false;
            this.txt_celular.Location = new System.Drawing.Point(430, 326);
            this.txt_celular.Mask = "(00)00000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(114, 20);
            this.txt_celular.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "*Celular: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Telefone:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Location = new System.Drawing.Point(233, 326);
            this.txt_telefone.Mask = "(00)0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(114, 20);
            this.txt_telefone.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "*Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "*Data de Nascimento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "*Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(233, 214);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(311, 20);
            this.txt_nome.TabIndex = 34;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(233, 288);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(311, 20);
            this.txt_email.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Dubai", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(352, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Não sei o cpf";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(226, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Por: Samuel Teixeira Dias";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 27;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_limpar.BackgroundImage = global::fundBra.Properties.Resources.botao;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.Location = new System.Drawing.Point(91, 378);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(90, 43);
            this.btn_limpar.TabIndex = 26;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Insira CPF para pesquisa:";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_pesquisa.Location = new System.Drawing.Point(230, 173);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(311, 20);
            this.txt_pesquisa.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 23;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(190, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "PESQUISA DE USUARIO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_consultar.BackgroundImage = global::fundBra.Properties.Resources.botao;
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Image = global::fundBra.Properties.Resources.pesquisar_1;
            this.btn_consultar.Location = new System.Drawing.Point(230, 362);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(125, 68);
            this.btn_consultar.TabIndex = 0;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // lbl_saida
            // 
            this.lbl_saida.AutoSize = true;
            this.lbl_saida.Location = new System.Drawing.Point(181, 324);
            this.lbl_saida.Name = "lbl_saida";
            this.lbl_saida.Size = new System.Drawing.Size(0, 13);
            this.lbl_saida.TabIndex = 16;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(399, 386);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 35);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 459);
            this.Controls.Add(this.panel2);
            this.Name = "pesquisar";
            this.Load += new System.EventHandler(this.pesquisar_Load);
            this.panel2.ResumeLayout(false);
            this.txt_data.ResumeLayout(false);
            this.txt_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txt_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label lbl_saida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox mskd_cpf;
    }
}