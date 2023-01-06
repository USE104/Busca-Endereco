namespace BuscaCEP
{
    partial class frmBuscaEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaEndereco));
            this.lblQualmeuEndereco = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSuperior = new System.Windows.Forms.GroupBox();
            this.grpInferior = new System.Windows.Forms.GroupBox();
            this.Copiar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCompleto = new System.Windows.Forms.TextBox();
            this.grpMeio = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSeuEndereco = new System.Windows.Forms.Label();
            this.mkdNum = new System.Windows.Forms.MaskedTextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblUFEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.mkdCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblDigiteCEP = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSuperior.SuspendLayout();
            this.grpInferior.SuspendLayout();
            this.grpMeio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQualmeuEndereco
            // 
            this.lblQualmeuEndereco.AutoSize = true;
            this.lblQualmeuEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblQualmeuEndereco.Location = new System.Drawing.Point(162, 34);
            this.lblQualmeuEndereco.Name = "lblQualmeuEndereco";
            this.lblQualmeuEndereco.Size = new System.Drawing.Size(351, 36);
            this.lblQualmeuEndereco.TabIndex = 0;
            this.lblQualmeuEndereco.Text = "Qual é o meu Endereço ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpSuperior
            // 
            this.grpSuperior.BackColor = System.Drawing.Color.Gold;
            this.grpSuperior.Controls.Add(this.pictureBox2);
            this.grpSuperior.Controls.Add(this.pictureBox1);
            this.grpSuperior.Controls.Add(this.lblQualmeuEndereco);
            this.grpSuperior.Location = new System.Drawing.Point(0, -7);
            this.grpSuperior.Name = "grpSuperior";
            this.grpSuperior.Size = new System.Drawing.Size(682, 115);
            this.grpSuperior.TabIndex = 7;
            this.grpSuperior.TabStop = false;
            // 
            // grpInferior
            // 
            this.grpInferior.BackColor = System.Drawing.Color.LightGray;
            this.grpInferior.Controls.Add(this.Copiar);
            this.grpInferior.Controls.Add(this.btnPesquisar);
            this.grpInferior.Controls.Add(this.btnSair);
            this.grpInferior.Controls.Add(this.btnLimpar);
            this.grpInferior.Location = new System.Drawing.Point(0, 358);
            this.grpInferior.Name = "grpInferior";
            this.grpInferior.Size = new System.Drawing.Size(682, 68);
            this.grpInferior.TabIndex = 8;
            this.grpInferior.TabStop = false;
            // 
            // Copiar
            // 
            this.Copiar.BackColor = System.Drawing.Color.Wheat;
            this.Copiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Copiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Copiar.Location = new System.Drawing.Point(248, 17);
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(82, 43);
            this.Copiar.TabIndex = 20;
            this.Copiar.Text = "Copiar";
            this.Copiar.UseVisualStyleBackColor = false;
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Wheat;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(141, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 43);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPesquisar_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(452, 17);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 43);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Wheat;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(346, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 43);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // txtCompleto
            // 
            this.txtCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCompleto.Location = new System.Drawing.Point(574, 392);
            this.txtCompleto.Name = "txtCompleto";
            this.txtCompleto.Size = new System.Drawing.Size(10, 26);
            this.txtCompleto.TabIndex = 12;
            this.txtCompleto.Visible = false;
            // 
            // grpMeio
            // 
            this.grpMeio.BackColor = System.Drawing.Color.LightGray;
            this.grpMeio.Controls.Add(this.txtUF);
            this.grpMeio.Controls.Add(this.textBox1);
            this.grpMeio.Controls.Add(this.lblSeuEndereco);
            this.grpMeio.Controls.Add(this.mkdNum);
            this.grpMeio.Controls.Add(this.lblNum);
            this.grpMeio.Controls.Add(this.lblUFEstado);
            this.grpMeio.Controls.Add(this.txtCidade);
            this.grpMeio.Controls.Add(this.lblCidade);
            this.grpMeio.Controls.Add(this.txtBairro);
            this.grpMeio.Controls.Add(this.lblBairro);
            this.grpMeio.Controls.Add(this.txtEndereco);
            this.grpMeio.Controls.Add(this.lblEndereco);
            this.grpMeio.Controls.Add(this.mkdCEP);
            this.grpMeio.Controls.Add(this.lblDigiteCEP);
            this.grpMeio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpMeio.Location = new System.Drawing.Point(0, 102);
            this.grpMeio.Name = "grpMeio";
            this.grpMeio.Size = new System.Drawing.Size(682, 264);
            this.grpMeio.TabIndex = 7;
            this.grpMeio.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(11, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(658, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSeuEndereco
            // 
            this.lblSeuEndereco.AutoSize = true;
            this.lblSeuEndereco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSeuEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSeuEndereco.Location = new System.Drawing.Point(244, 181);
            this.lblSeuEndereco.Name = "lblSeuEndereco";
            this.lblSeuEndereco.Size = new System.Drawing.Size(209, 24);
            this.lblSeuEndereco.TabIndex = 14;
            this.lblSeuEndereco.Text = "Esse é o seu Endereço";
            // 
            // mkdNum
            // 
            this.mkdNum.BackColor = System.Drawing.Color.White;
            this.mkdNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mkdNum.Location = new System.Drawing.Point(555, 33);
            this.mkdNum.Mask = "00000";
            this.mkdNum.Name = "mkdNum";
            this.mkdNum.Size = new System.Drawing.Size(58, 29);
            this.mkdNum.TabIndex = 13;
            this.mkdNum.ValidatingType = typeof(int);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNum.Location = new System.Drawing.Point(286, 34);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(254, 25);
            this.lblNum.TabIndex = 12;
            this.lblNum.Text = "e o Número de Identificação";
            // 
            // lblUFEstado
            // 
            this.lblUFEstado.AutoSize = true;
            this.lblUFEstado.Location = new System.Drawing.Point(443, 150);
            this.lblUFEstado.Name = "lblUFEstado";
            this.lblUFEstado.Size = new System.Drawing.Size(31, 20);
            this.lblUFEstado.TabIndex = 11;
            this.lblUFEstado.Text = "UF";
            this.lblUFEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCidade.Location = new System.Drawing.Point(236, 140);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(201, 29);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCidade.Location = new System.Drawing.Point(136, 145);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 25);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBairro.Location = new System.Drawing.Point(236, 112);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(341, 29);
            this.txtBairro.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBairro.Location = new System.Drawing.Point(136, 110);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(63, 25);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEndereco.Location = new System.Drawing.Point(236, 77);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(341, 29);
            this.txtEndereco.TabIndex = 5;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEndereco.Location = new System.Drawing.Point(136, 79);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(96, 25);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // mkdCEP
            // 
            this.mkdCEP.BackColor = System.Drawing.Color.White;
            this.mkdCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkdCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mkdCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mkdCEP.Location = new System.Drawing.Point(186, 34);
            this.mkdCEP.Mask = "00000-000";
            this.mkdCEP.Name = "mkdCEP";
            this.mkdCEP.Size = new System.Drawing.Size(94, 29);
            this.mkdCEP.TabIndex = 3;
            // 
            // lblDigiteCEP
            // 
            this.lblDigiteCEP.AutoSize = true;
            this.lblDigiteCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDigiteCEP.Location = new System.Drawing.Point(39, 34);
            this.lblDigiteCEP.Name = "lblDigiteCEP";
            this.lblDigiteCEP.Size = new System.Drawing.Size(150, 25);
            this.lblDigiteCEP.TabIndex = 2;
            this.lblDigiteCEP.Text = "Digite seu CEP:";
            // 
            // txtUF
            // 
            this.txtUF.BackColor = System.Drawing.Color.White;
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUF.Location = new System.Drawing.Point(480, 145);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(62, 29);
            this.txtUF.TabIndex = 16;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmBuscaEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 423);
            this.Controls.Add(this.grpInferior);
            this.Controls.Add(this.grpSuperior);
            this.Controls.Add(this.grpMeio);
            this.Controls.Add(this.txtCompleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBuscaEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Endereço";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSuperior.ResumeLayout(false);
            this.grpSuperior.PerformLayout();
            this.grpInferior.ResumeLayout(false);
            this.grpMeio.ResumeLayout(false);
            this.grpMeio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQualmeuEndereco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpSuperior;
        private System.Windows.Forms.GroupBox grpInferior;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button Copiar;
        private System.Windows.Forms.TextBox txtCompleto;
        private System.Windows.Forms.GroupBox grpMeio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSeuEndereco;
        private System.Windows.Forms.MaskedTextBox mkdNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblUFEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox mkdCEP;
        private System.Windows.Forms.Label lblDigiteCEP;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

