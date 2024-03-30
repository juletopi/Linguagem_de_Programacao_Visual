namespace Atividade__28_03_24_
{
    partial class FormSimulacaoComissao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimulacaoComissao));
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblLinkJuletopi = new System.Windows.Forms.LinkLabel();
            this.cbSelecaoCargo = new System.Windows.Forms.ComboBox();
            this.lblRodape = new System.Windows.Forms.Label();
            this.lblComboBox = new System.Windows.Forms.Label();
            this.groupBoxBotoesCampos = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSimular = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblResultadosComissao = new System.Windows.Forms.Label();
            this.lblMeta = new System.Windows.Forms.Label();
            this.txtMeta = new System.Windows.Forms.TextBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupComboBox = new System.Windows.Forms.GroupBox();
            this.lblLinhaHorizontal2 = new System.Windows.Forms.Label();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblLinhaHorizontal1 = new System.Windows.Forms.Label();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxBotoesCampos.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            this.groupComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblLinkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.cbSelecaoCargo);
            this.groupBoxPrincipal.Controls.Add(this.lblRodape);
            this.groupBoxPrincipal.Controls.Add(this.lblComboBox);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoesCampos);
            this.groupBoxPrincipal.Controls.Add(this.groupComboBox);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(17, 114);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(618, 607);
            this.groupBoxPrincipal.TabIndex = 11;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblLinkJuletopi
            // 
            this.lblLinkJuletopi.AccessibleDescription = "Um link para informações sobre o autor.";
            this.lblLinkJuletopi.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.lblLinkJuletopi.AutoSize = true;
            this.lblLinkJuletopi.LinkColor = System.Drawing.Color.Tomato;
            this.lblLinkJuletopi.Location = new System.Drawing.Point(360, 583);
            this.lblLinkJuletopi.Name = "lblLinkJuletopi";
            this.lblLinkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.lblLinkJuletopi.TabIndex = 9;
            this.lblLinkJuletopi.TabStop = true;
            this.lblLinkJuletopi.Text = "Juletopi";
            this.lblLinkJuletopi.VisitedLinkColor = System.Drawing.Color.Tomato;
            this.lblLinkJuletopi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkJuletopi_LinkClicked);
            // 
            // cbSelecaoCargo
            // 
            this.cbSelecaoCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelecaoCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelecaoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSelecaoCargo.FormattingEnabled = true;
            this.cbSelecaoCargo.Items.AddRange(new object[] {
            "Vendedor Junior",
            "Vendedor Padrão",
            "Vendedor Master",
            "Surpevisor de Vendas",
            "Gerente"});
            this.cbSelecaoCargo.Location = new System.Drawing.Point(30, 55);
            this.cbSelecaoCargo.Name = "cbSelecaoCargo";
            this.cbSelecaoCargo.Size = new System.Drawing.Size(238, 24);
            this.cbSelecaoCargo.TabIndex = 7;
            this.cbSelecaoCargo.SelectedIndexChanged += new System.EventHandler(this.cbSelecaoCargo_SelectedIndexChanged);
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.Location = new System.Drawing.Point(230, 583);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(133, 13);
            this.lblRodape.TabIndex = 5;
            this.lblRodape.Text = "Feito com 🖤 e CSharp por";
            // 
            // lblComboBox
            // 
            this.lblComboBox.AutoSize = true;
            this.lblComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblComboBox.Location = new System.Drawing.Point(28, 31);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(148, 19);
            this.lblComboBox.TabIndex = 0;
            this.lblComboBox.Text = "Selecione o seu cargo:";
            // 
            // groupBoxBotoesCampos
            // 
            this.groupBoxBotoesCampos.Controls.Add(this.btLimpar);
            this.groupBoxBotoesCampos.Controls.Add(this.btSimular);
            this.groupBoxBotoesCampos.Controls.Add(this.groupBoxResultados);
            this.groupBoxBotoesCampos.Controls.Add(this.lblMeta);
            this.groupBoxBotoesCampos.Controls.Add(this.txtMeta);
            this.groupBoxBotoesCampos.Controls.Add(this.lblVendas);
            this.groupBoxBotoesCampos.Controls.Add(this.txtVendas);
            this.groupBoxBotoesCampos.Controls.Add(this.lblSalario);
            this.groupBoxBotoesCampos.Controls.Add(this.txtSalario);
            this.groupBoxBotoesCampos.Location = new System.Drawing.Point(17, 223);
            this.groupBoxBotoesCampos.Name = "groupBoxBotoesCampos";
            this.groupBoxBotoesCampos.Size = new System.Drawing.Size(580, 353);
            this.groupBoxBotoesCampos.TabIndex = 6;
            this.groupBoxBotoesCampos.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLimpar.Location = new System.Drawing.Point(301, 287);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(124, 41);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSimular
            // 
            this.btSimular.BackColor = System.Drawing.Color.Tomato;
            this.btSimular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSimular.Location = new System.Drawing.Point(159, 286);
            this.btSimular.Name = "btSimular";
            this.btSimular.Size = new System.Drawing.Size(124, 43);
            this.btSimular.TabIndex = 4;
            this.btSimular.Text = "SIMULAR";
            this.btSimular.UseVisualStyleBackColor = false;
            this.btSimular.Click += new System.EventHandler(this.btSimular_Click);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.lblResultados);
            this.groupBoxResultados.Controls.Add(this.lblResultadosComissao);
            this.groupBoxResultados.Location = new System.Drawing.Point(89, 120);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(400, 144);
            this.groupBoxResultados.TabIndex = 17;
            this.groupBoxResultados.TabStop = false;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultados.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblResultados.Location = new System.Drawing.Point(157, -4);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(94, 19);
            this.lblResultados.TabIndex = 17;
            this.lblResultados.Text = "RESULTADOS";
            // 
            // lblResultadosComissao
            // 
            this.lblResultadosComissao.AutoSize = true;
            this.lblResultadosComissao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultadosComissao.Location = new System.Drawing.Point(17, 30);
            this.lblResultadosComissao.Name = "lblResultadosComissao";
            this.lblResultadosComissao.Size = new System.Drawing.Size(187, 21);
            this.lblResultadosComissao.TabIndex = 16;
            this.lblResultadosComissao.Text = "{Resultado da comissão}";
            this.lblResultadosComissao.Visible = false;
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMeta.Location = new System.Drawing.Point(356, 70);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(52, 21);
            this.lblMeta.TabIndex = 14;
            this.lblMeta.Text = "Meta:";
            // 
            // txtMeta
            // 
            this.txtMeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtMeta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMeta.Location = new System.Drawing.Point(410, 70);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(119, 25);
            this.txtMeta.TabIndex = 13;
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblVendas.Location = new System.Drawing.Point(37, 70);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(66, 21);
            this.lblVendas.TabIndex = 10;
            this.lblVendas.Text = "Vendas:";
            // 
            // txtVendas
            // 
            this.txtVendas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtVendas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVendas.Location = new System.Drawing.Point(105, 70);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(245, 25);
            this.txtVendas.TabIndex = 9;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalario.Location = new System.Drawing.Point(40, 33);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(63, 21);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtSalario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSalario.Location = new System.Drawing.Point(105, 32);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(424, 25);
            this.txtSalario.TabIndex = 3;
            // 
            // groupComboBox
            // 
            this.groupComboBox.Controls.Add(this.lblLinhaHorizontal2);
            this.groupComboBox.Controls.Add(this.lblExplicacao);
            this.groupComboBox.Location = new System.Drawing.Point(17, 17);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(580, 200);
            this.groupComboBox.TabIndex = 7;
            this.groupComboBox.TabStop = false;
            // 
            // lblLinhaHorizontal2
            // 
            this.lblLinhaHorizontal2.AutoSize = true;
            this.lblLinhaHorizontal2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblLinhaHorizontal2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLinhaHorizontal2.Location = new System.Drawing.Point(14, 52);
            this.lblLinhaHorizontal2.Name = "lblLinhaHorizontal2";
            this.lblLinhaHorizontal2.Size = new System.Drawing.Size(553, 30);
            this.lblLinhaHorizontal2.TabIndex = 9;
            this.lblLinhaHorizontal2.Text = "____________________________________________________________";
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblExplicacao.Location = new System.Drawing.Point(10, 89);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(534, 95);
            this.lblExplicacao.TabIndex = 8;
            this.lblExplicacao.Text = resources.GetString("lblExplicacao.Text");
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Tomato;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(9, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(634, 37);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Concessionária Ômega - Simulação de Comissão";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.Tomato;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-1, -4);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(653, 111);
            this.pictureBoxTitulo.TabIndex = 10;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Tomato;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 16.24F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtitulo.Location = new System.Drawing.Point(172, 64);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(311, 30);
            this.lblSubtitulo.TabIndex = 12;
            this.lblSubtitulo.Text = "{Texto de cargo selecionado}";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSubtitulo.Visible = false;
            // 
            // lblLinhaHorizontal1
            // 
            this.lblLinhaHorizontal1.AutoSize = true;
            this.lblLinhaHorizontal1.BackColor = System.Drawing.Color.Tomato;
            this.lblLinhaHorizontal1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblLinhaHorizontal1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLinhaHorizontal1.Location = new System.Drawing.Point(132, 24);
            this.lblLinhaHorizontal1.Name = "lblLinhaHorizontal1";
            this.lblLinhaHorizontal1.Size = new System.Drawing.Size(391, 37);
            this.lblLinhaHorizontal1.TabIndex = 10;
            this.lblLinhaHorizontal1.Text = "__________________________________";
            // 
            // FormSimulacaoComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 731);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLinhaHorizontal1);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSimulacaoComissao";
            this.Text = "Concessionária Ômega | Simulação de Comissão";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxBotoesCampos.ResumeLayout(false);
            this.groupBoxBotoesCampos.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.groupComboBox.ResumeLayout(false);
            this.groupComboBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.ComboBox cbSelecaoCargo;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Label lblComboBox;
        private System.Windows.Forms.GroupBox groupBoxBotoesCampos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblResultadosComissao;
        private System.Windows.Forms.Button btSimular;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.TextBox txtMeta;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox groupComboBox;
        private System.Windows.Forms.Label lblLinhaHorizontal2;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblLinhaHorizontal1;
        private System.Windows.Forms.LinkLabel lblLinkJuletopi;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Label lblResultados;
    }
}

