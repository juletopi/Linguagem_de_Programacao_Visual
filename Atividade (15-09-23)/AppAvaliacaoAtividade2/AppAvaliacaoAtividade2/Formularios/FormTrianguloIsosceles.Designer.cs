﻿namespace AppAvaliacaoAtividade2.Formularios
{
    partial class FormTrianguloIsosceles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrianguloIsosceles));
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.cmbOpcCalculo = new System.Windows.Forms.ComboBox();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoDeco = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblOpcCalculo = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblBase);
            this.groupBoxPrincipal.Controls.Add(this.cmbOpcCalculo);
            this.groupBoxPrincipal.Controls.Add(this.lblLadoB);
            this.groupBoxPrincipal.Controls.Add(this.txtBase);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.txtLadoB);
            this.groupBoxPrincipal.Controls.Add(this.lblLadoA);
            this.groupBoxPrincipal.Controls.Add(this.lblOpcCalculo);
            this.groupBoxPrincipal.Controls.Add(this.txtLadoA);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(24, 107);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 480);
            this.groupBoxPrincipal.TabIndex = 61;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblBase.Location = new System.Drawing.Point(18, 190);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(50, 20);
            this.lblBase.TabIndex = 47;
            this.lblBase.Text = "Base:";
            // 
            // cmbOpcCalculo
            // 
            this.cmbOpcCalculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOpcCalculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOpcCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbOpcCalculo.FormattingEnabled = true;
            this.cmbOpcCalculo.Items.AddRange(new object[] {
            "1. Calcular a área do triângulo isósceles",
            "2. Calcular a altura do triângulo isósceles",
            "3. Encontrar a aresta(lado) do triângulo isósceles",
            "4. Encontrar a base do triângulos isósceles"});
            this.cmbOpcCalculo.Location = new System.Drawing.Point(17, 49);
            this.cmbOpcCalculo.Name = "cmbOpcCalculo";
            this.cmbOpcCalculo.Size = new System.Drawing.Size(202, 26);
            this.cmbOpcCalculo.TabIndex = 38;
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLadoB.Location = new System.Drawing.Point(18, 137);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(126, 20);
            this.lblLadoB.TabIndex = 41;
            this.lblLadoB.Text = "Lado B (Cateto):";
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBase.Location = new System.Drawing.Point(17, 211);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(189, 24);
            this.txtBase.TabIndex = 46;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblResultadoDeco);
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Controls.Add(this.lblResultadoTitulo);
            this.groupBoxResultado.Location = new System.Drawing.Point(236, 33);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(333, 202);
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
            // txtLadoB
            // 
            this.txtLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtLadoB.Location = new System.Drawing.Point(17, 158);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(189, 24);
            this.txtLadoB.TabIndex = 40;
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLadoA.Location = new System.Drawing.Point(18, 84);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(126, 20);
            this.lblLadoA.TabIndex = 45;
            this.lblLadoA.Text = "Lado A (Cateto):";
            // 
            // lblOpcCalculo
            // 
            this.lblOpcCalculo.AutoSize = true;
            this.lblOpcCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcCalculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblOpcCalculo.Location = new System.Drawing.Point(18, 26);
            this.lblOpcCalculo.Name = "lblOpcCalculo";
            this.lblOpcCalculo.Size = new System.Drawing.Size(135, 20);
            this.lblOpcCalculo.TabIndex = 44;
            this.lblOpcCalculo.Text = "Opção de cálculo:";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtLadoA.Location = new System.Drawing.Point(17, 105);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(189, 24);
            this.txtLadoA.TabIndex = 43;
            this.txtLadoA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCatetoA_KeyDown);
            this.txtLadoA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCatetoA_KeyUp);
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnCalcular);
            this.groupBoxBotoes.Controls.Add(this.btnNovo);
            this.groupBoxBotoes.Location = new System.Drawing.Point(17, 249);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 192);
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
            this.btnCalcular.Location = new System.Drawing.Point(178, 38);
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
            this.btnNovo.Location = new System.Drawing.Point(178, 112);
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
            this.linkJuletopi.Location = new System.Drawing.Point(266, 452);
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
            this.labeltxtdeco.Location = new System.Drawing.Point(158, 452);
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
            this.lblSubtitulo.Location = new System.Drawing.Point(235, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(154, 21);
            this.lblSubtitulo.TabIndex = 60;
            this.lblSubtitulo.Text = "Triângulo Isósceles";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(26, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(579, 47);
            this.lblTitulo.TabIndex = 59;
            this.lblTitulo.Text = "Calculadora de Áreas Triangulares";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-7, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(651, 98);
            this.pictureBoxTitulo.TabIndex = 58;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // FormTrianguloIsosceles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 607);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTrianguloIsosceles";
            this.Text = "Calculadora de Área do Triângulo Isósceles";
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
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.ComboBox cmbOpcCalculo;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoDeco;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblOpcCalculo;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
    }
}