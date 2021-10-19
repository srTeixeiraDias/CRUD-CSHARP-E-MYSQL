
namespace fundBra
{
    partial class busca
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
            this.lsl_busca = new System.Windows.Forms.ListView();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn_busca = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_saida = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.txt_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.txt_data);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 424);
            this.panel2.TabIndex = 22;
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_data.Controls.Add(this.lsl_busca);
            this.txt_data.Controls.Add(this.btn_limpar);
            this.txt_data.Controls.Add(this.btnSair);
            this.txt_data.Controls.Add(this.btn_busca);
            this.txt_data.Controls.Add(this.label12);
            this.txt_data.Controls.Add(this.label11);
            this.txt_data.Controls.Add(this.label10);
            this.txt_data.Controls.Add(this.txt_busca);
            this.txt_data.Controls.Add(this.label8);
            this.txt_data.Controls.Add(this.label4);
            this.txt_data.Controls.Add(this.pictureBox1);
            this.txt_data.Controls.Add(this.label6);
            this.txt_data.Controls.Add(this.lbl_saida);
            this.txt_data.Location = new System.Drawing.Point(9, 11);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(582, 401);
            this.txt_data.TabIndex = 6;
            // 
            // lsl_busca
            // 
            this.lsl_busca.BackColor = System.Drawing.Color.YellowGreen;
            this.lsl_busca.HideSelection = false;
            this.lsl_busca.Location = new System.Drawing.Point(114, 263);
            this.lsl_busca.Name = "lsl_busca";
            this.lsl_busca.Size = new System.Drawing.Size(311, 86);
            this.lsl_busca.TabIndex = 33;
            this.lsl_busca.UseCompatibleStateImageBehavior = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_limpar.BackgroundImage = global::fundBra.Properties.Resources.botao;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.Location = new System.Drawing.Point(114, 355);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(90, 43);
            this.btn_limpar.TabIndex = 32;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(335, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 35);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn_busca
            // 
            this.btn_busca.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_busca.BackgroundImage = global::fundBra.Properties.Resources.botao;
            this.btn_busca.FlatAppearance.BorderSize = 0;
            this.btn_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busca.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca.Image = global::fundBra.Properties.Resources.pesquisar_1;
            this.btn_busca.Location = new System.Drawing.Point(337, 211);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(88, 44);
            this.btn_busca.TabIndex = 30;
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(110, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Digite parte ou inteiro do nome ou email:";
            // 
            // txt_busca
            // 
            this.txt_busca.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_busca.Location = new System.Drawing.Point(114, 222);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(209, 20);
            this.txt_busca.TabIndex = 25;
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
            this.label6.Location = new System.Drawing.Point(162, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Busca de nome para consulta";
            // 
            // lbl_saida
            // 
            this.lbl_saida.AutoSize = true;
            this.lbl_saida.Location = new System.Drawing.Point(181, 324);
            this.lbl_saida.Name = "lbl_saida";
            this.lbl_saida.Size = new System.Drawing.Size(0, 13);
            this.lbl_saida.TabIndex = 16;
            // 
            // busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 425);
            this.Controls.Add(this.panel2);
            this.Name = "busca";
            this.Text = "busca";
            this.panel2.ResumeLayout(false);
            this.txt_data.ResumeLayout(false);
            this.txt_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txt_data;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_saida;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListView lsl_busca;
    }
}