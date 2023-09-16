﻿namespace AppAvaliacaoAtividade2.Formularios
{
    partial class FormAreaTriangulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAreaTriangulos));
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblHipotenusa = new System.Windows.Forms.Label();
            this.lblCatetoB = new System.Windows.Forms.Label();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoDeco = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.txtCatetoB = new System.Windows.Forms.TextBox();
            this.lblCatetoA = new System.Windows.Forms.Label();
            this.txtCatetoA = new System.Windows.Forms.TextBox();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblHipotenusa);
            this.groupBoxPrincipal.Controls.Add(this.lblCatetoB);
            this.groupBoxPrincipal.Controls.Add(this.txtHipotenusa);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.txtCatetoB);
            this.groupBoxPrincipal.Controls.Add(this.lblCatetoA);
            this.groupBoxPrincipal.Controls.Add(this.txtCatetoA);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(26, 107);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 484);
            this.groupBoxPrincipal.TabIndex = 65;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblHipotenusa
            // 
            this.lblHipotenusa.AutoSize = true;
            this.lblHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipotenusa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHipotenusa.Location = new System.Drawing.Point(18, 141);
            this.lblHipotenusa.Name = "lblHipotenusa";
            this.lblHipotenusa.Size = new System.Drawing.Size(160, 20);
            this.lblHipotenusa.TabIndex = 47;
            this.lblHipotenusa.Text = "Lado C (Hipotenusa):";
            // 
            // lblCatetoB
            // 
            this.lblCatetoB.AutoSize = true;
            this.lblCatetoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatetoB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCatetoB.Location = new System.Drawing.Point(18, 88);
            this.lblCatetoB.Name = "lblCatetoB";
            this.lblCatetoB.Size = new System.Drawing.Size(126, 20);
            this.lblCatetoB.TabIndex = 41;
            this.lblCatetoB.Text = "Lado B (Cateto):";
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtHipotenusa.Location = new System.Drawing.Point(17, 162);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(189, 24);
            this.txtHipotenusa.TabIndex = 46;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblClassificacao);
            this.groupBoxResultado.Controls.Add(this.lblResultadoDeco);
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Controls.Add(this.lblResultadoTitulo);
            this.groupBoxResultado.Location = new System.Drawing.Point(236, 33);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(333, 181);
            this.groupBoxResultado.TabIndex = 41;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblResultadoDeco
            // 
            this.lblResultadoDeco.AutoSize = true;
            this.lblResultadoDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDeco.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultadoDeco.Location = new System.Drawing.Point(50, 94);
            this.lblResultadoDeco.Name = "lblResultadoDeco";
            this.lblResultadoDeco.Size = new System.Drawing.Size(233, 16);
            this.lblResultadoDeco.TabIndex = 39;
            this.lblResultadoDeco.Text = "O RESULTADO SERÁ EXIBIDO AQUI";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(18, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(206, 20);
            this.lblResultado.TabIndex = 38;
            this.lblResultado.Text = "O resultado da área (m²) é...";
            this.lblResultado.Visible = false;
            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.AutoSize = true;
            this.lblResultadoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTitulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultadoTitulo.Location = new System.Drawing.Point(109, -5);
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.Size = new System.Drawing.Size(124, 24);
            this.lblResultadoTitulo.TabIndex = 37;
            this.lblResultadoTitulo.Text = "RESULTADO";
            // 
            // txtCatetoB
            // 
            this.txtCatetoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCatetoB.Location = new System.Drawing.Point(17, 109);
            this.txtCatetoB.Name = "txtCatetoB";
            this.txtCatetoB.Size = new System.Drawing.Size(189, 24);
            this.txtCatetoB.TabIndex = 40;
            // 
            // lblCatetoA
            // 
            this.lblCatetoA.AutoSize = true;
            this.lblCatetoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatetoA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCatetoA.Location = new System.Drawing.Point(18, 35);
            this.lblCatetoA.Name = "lblCatetoA";
            this.lblCatetoA.Size = new System.Drawing.Size(126, 20);
            this.lblCatetoA.TabIndex = 45;
            this.lblCatetoA.Text = "Lado A (Cateto):";
            // 
            // txtCatetoA
            // 
            this.txtCatetoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCatetoA.Location = new System.Drawing.Point(17, 56);
            this.txtCatetoA.Name = "txtCatetoA";
            this.txtCatetoA.Size = new System.Drawing.Size(189, 24);
            this.txtCatetoA.TabIndex = 43;
            this.txtCatetoA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCatetoA_KeyDown);
            this.txtCatetoA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCatetoA_KeyUp);
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnCalcular);
            this.groupBoxBotoes.Controls.Add(this.btnNovo);
            this.groupBoxBotoes.Location = new System.Drawing.Point(17, 228);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 211);
            this.groupBoxBotoes.TabIndex = 40;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(178, 46);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(213, 44);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseCompatibleTextRendering = true;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 12.22F);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Location = new System.Drawing.Point(178, 120);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(213, 44);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseCompatibleTextRendering = true;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.linkJuletopi.Location = new System.Drawing.Point(266, 454);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(184, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Júlio Cézar Pereira Camargo (Juletopi)";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.linkJuletopi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJuletopi_LinkClicked);
            // 
            // labeltxtdeco
            // 
            this.labeltxtdeco.AutoSize = true;
            this.labeltxtdeco.Location = new System.Drawing.Point(158, 454);
            this.labeltxtdeco.Name = "labeltxtdeco";
            this.labeltxtdeco.Size = new System.Drawing.Size(112, 13);
            this.labeltxtdeco.TabIndex = 25;
            this.labeltxtdeco.Text = "Feito com 💙 e C# por";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtitulo.Location = new System.Drawing.Point(237, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(159, 21);
            this.lblSubtitulo.TabIndex = 64;
            this.lblSubtitulo.Text = "Áreas de Triângulos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(28, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(579, 47);
            this.lblTitulo.TabIndex = 63;
            this.lblTitulo.Text = "Calculadora de Áreas Triangulares";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-5, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(651, 98);
            this.pictureBoxTitulo.TabIndex = 62;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblClassificacao.Location = new System.Drawing.Point(18, 74);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(226, 20);
            this.lblClassificacao.TabIndex = 40;
            this.lblClassificacao.Text = "A classificação do triângulo é...";
            this.lblClassificacao.Visible = false;
            // 
            // FormAreaTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 611);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAreaTriangulos";
            this.Text = "Calculadora de Área de Triângulos";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.groupBoxBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Label lblHipotenusa;
        private System.Windows.Forms.Label lblCatetoB;
        private System.Windows.Forms.TextBox txtHipotenusa;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoDeco;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.TextBox txtCatetoB;
        private System.Windows.Forms.Label lblCatetoA;
        private System.Windows.Forms.TextBox txtCatetoA;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label lblClassificacao;
    }
}