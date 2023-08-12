namespace AppExemplo2.Formularios
{
    partial class FormAlertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlertas));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblSelecionarOpc = new System.Windows.Forms.Label();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExemplo = new System.Windows.Forms.Button();
            this.btnPergunta = new System.Windows.Forms.Button();
            this.btnErro = new System.Windows.Forms.Button();
            this.btnAtencao = new System.Windows.Forms.Button();
            this.btnInformacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(10, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(599, 47);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Alertas de Interação com o Usuário";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-33, -4);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 32;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblSelecionarOpc);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(14, 76);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 33;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblSelecionarOpc
            // 
            this.lblSelecionarOpc.AutoSize = true;
            this.lblSelecionarOpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarOpc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSelecionarOpc.Location = new System.Drawing.Point(17, 27);
            this.lblSelecionarOpc.Name = "lblSelecionarOpc";
            this.lblSelecionarOpc.Size = new System.Drawing.Size(283, 18);
            this.lblSelecionarOpc.TabIndex = 25;
            this.lblSelecionarOpc.Text = "• Selecione uma das opções abaixo:";
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linkJuletopi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJuletopi_LinkClicked);
            // 
            // labeltxtdeco
            // 
            this.labeltxtdeco.AutoSize = true;
            this.labeltxtdeco.Location = new System.Drawing.Point(223, 471);
            this.labeltxtdeco.Name = "labeltxtdeco";
            this.labeltxtdeco.Size = new System.Drawing.Size(112, 13);
            this.labeltxtdeco.TabIndex = 25;
            this.labeltxtdeco.Text = "Feito com 💙 e C# por";
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.label1);
            this.groupBoxBotoes.Controls.Add(this.btnExemplo);
            this.groupBoxBotoes.Controls.Add(this.btnPergunta);
            this.groupBoxBotoes.Controls.Add(this.btnErro);
            this.groupBoxBotoes.Controls.Add(this.btnAtencao);
            this.groupBoxBotoes.Controls.Add(this.btnInformacao);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 44);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 421);
            this.groupBoxBotoes.TabIndex = 28;
            this.groupBoxBotoes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(261, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "↓";
            // 
            // btnExemplo
            // 
            this.btnExemplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnExemplo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExemplo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExemplo.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnExemplo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExemplo.Location = new System.Drawing.Point(188, 355);
            this.btnExemplo.Name = "btnExemplo";
            this.btnExemplo.Size = new System.Drawing.Size(176, 37);
            this.btnExemplo.TabIndex = 25;
            this.btnExemplo.Text = "EXEMPLO";
            this.btnExemplo.UseCompatibleTextRendering = true;
            this.btnExemplo.UseVisualStyleBackColor = false;
            this.btnExemplo.Click += new System.EventHandler(this.btnExemplo_Click);
            // 
            // btnPergunta
            // 
            this.btnPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.btnPergunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPergunta.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPergunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPergunta.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnPergunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPergunta.Location = new System.Drawing.Point(77, 266);
            this.btnPergunta.Name = "btnPergunta";
            this.btnPergunta.Size = new System.Drawing.Size(391, 44);
            this.btnPergunta.TabIndex = 24;
            this.btnPergunta.Text = "❔ PERGUNTA";
            this.btnPergunta.UseCompatibleTextRendering = true;
            this.btnPergunta.UseVisualStyleBackColor = false;
            this.btnPergunta.Click += new System.EventHandler(this.btnPergunta_Click);
            // 
            // btnErro
            // 
            this.btnErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.btnErro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErro.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnErro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErro.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnErro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnErro.Location = new System.Drawing.Point(77, 189);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(391, 44);
            this.btnErro.TabIndex = 23;
            this.btnErro.Text = "❌ ERRO";
            this.btnErro.UseCompatibleTextRendering = true;
            this.btnErro.UseVisualStyleBackColor = false;
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // btnAtencao
            // 
            this.btnAtencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
            this.btnAtencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtencao.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAtencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtencao.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnAtencao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtencao.Location = new System.Drawing.Point(77, 115);
            this.btnAtencao.Name = "btnAtencao";
            this.btnAtencao.Size = new System.Drawing.Size(391, 44);
            this.btnAtencao.TabIndex = 22;
            this.btnAtencao.Text = "⚠  ATENÇÃO";
            this.btnAtencao.UseCompatibleTextRendering = true;
            this.btnAtencao.UseVisualStyleBackColor = false;
            this.btnAtencao.Click += new System.EventHandler(this.btnAtencao_Click);
            // 
            // btnInformacao
            // 
            this.btnInformacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(190)))), ((int)(((byte)(210)))));
            this.btnInformacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacao.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInformacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacao.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnInformacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformacao.Location = new System.Drawing.Point(77, 37);
            this.btnInformacao.Name = "btnInformacao";
            this.btnInformacao.Size = new System.Drawing.Size(391, 44);
            this.btnInformacao.TabIndex = 21;
            this.btnInformacao.Text = "ℹ  INFORMAÇÃO";
            this.btnInformacao.UseCompatibleTextRendering = true;
            this.btnInformacao.UseVisualStyleBackColor = false;
            this.btnInformacao.Click += new System.EventHandler(this.btnInformacao_Click);
            // 
            // FormAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 587);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAlertas";
            this.Text = "Exemplos de Alertas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxBotoes.ResumeLayout(false);
            this.groupBoxBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Label lblSelecionarOpc;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnPergunta;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.Button btnAtencao;
        private System.Windows.Forms.Button btnInformacao;
        private System.Windows.Forms.Button btnExemplo;
        private System.Windows.Forms.Label label1;
    }
}