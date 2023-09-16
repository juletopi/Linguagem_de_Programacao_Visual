namespace AppAvaliacaoAtividade1
{
    partial class AtividadeAvaliativa1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtividadeAvaliativa1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.lblMetaVendas = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtMetaVendas = new System.Windows.Forms.TextBox();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblResultadoDeco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(30, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(560, 47);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Simulador de Comissões e Metas";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-5, -4);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(632, 98);
            this.pictureBoxTitulo.TabIndex = 32;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblSalario);
            this.groupBoxPrincipal.Controls.Add(this.cmbCargo);
            this.groupBoxPrincipal.Controls.Add(this.lblVendas);
            this.groupBoxPrincipal.Controls.Add(this.txtSalario);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.txtVendas);
            this.groupBoxPrincipal.Controls.Add(this.lblMetaVendas);
            this.groupBoxPrincipal.Controls.Add(this.lblCargo);
            this.groupBoxPrincipal.Controls.Add(this.txtMetaVendas);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(16, 100);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 480);
            this.groupBoxPrincipal.TabIndex = 43;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSalario.Location = new System.Drawing.Point(18, 190);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(62, 20);
            this.lblSalario.TabIndex = 47;
            this.lblSalario.Text = "Salário:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Gerente",
            "Supervisor de Vendas",
            "Vendedor Master",
            "Vendedor Padrão",
            "Vendedor Junior"});
            this.cmbCargo.Location = new System.Drawing.Point(17, 49);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(202, 26);
            this.cmbCargo.TabIndex = 38;
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVendas.Location = new System.Drawing.Point(18, 137);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(68, 20);
            this.lblVendas.TabIndex = 41;
            this.lblVendas.Text = "Vendas:";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtSalario.Location = new System.Drawing.Point(17, 211);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(189, 24);
            this.txtSalario.TabIndex = 46;
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
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(18, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(138, 24);
            this.lblResultado.TabIndex = 38;
            this.lblResultado.Text = "O resultado é...";
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
            // txtVendas
            // 
            this.txtVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtVendas.Location = new System.Drawing.Point(17, 158);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(189, 24);
            this.txtVendas.TabIndex = 40;
            // 
            // lblMetaVendas
            // 
            this.lblMetaVendas.AutoSize = true;
            this.lblMetaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaVendas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMetaVendas.Location = new System.Drawing.Point(18, 84);
            this.lblMetaVendas.Name = "lblMetaVendas";
            this.lblMetaVendas.Size = new System.Drawing.Size(130, 20);
            this.lblMetaVendas.TabIndex = 45;
            this.lblMetaVendas.Text = "Meta de Vendas:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCargo.Location = new System.Drawing.Point(18, 26);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(143, 20);
            this.lblCargo.TabIndex = 44;
            this.lblCargo.Text = "Selecione o Cargo:";
            // 
            // txtMetaVendas
            // 
            this.txtMetaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMetaVendas.Location = new System.Drawing.Point(17, 105);
            this.txtMetaVendas.Name = "txtMetaVendas";
            this.txtMetaVendas.Size = new System.Drawing.Size(189, 24);
            this.txtMetaVendas.TabIndex = 43;
            this.txtMetaVendas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMetaVendas_KeyDown);
            this.txtMetaVendas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMetaVendas_KeyUp);
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
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
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
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
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
            this.lblSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtitulo.Location = new System.Drawing.Point(207, 57);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(203, 21);
            this.lblSubtitulo.TabIndex = 44;
            this.lblSubtitulo.Text = "Concessionária ÔMEGA Ω";
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
            // AtividadeAvaliativa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 591);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AtividadeAvaliativa1";
            this.Text = "ATIVIDADE AVALIATIVA 1 | Simulador de Comissões e Metas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.groupBoxBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Label lblMetaVendas;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtMetaVendas;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblResultadoDeco;
    }
}

