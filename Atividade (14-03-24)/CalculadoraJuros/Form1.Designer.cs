namespace CalculadoraJuros
{
    partial class CalculadoraJuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraJuros));
            this.lblRodape = new System.Windows.Forms.Label();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.cbTipoCalculo = new System.Windows.Forms.ComboBox();
            this.lblComboBox = new System.Windows.Forms.Label();
            this.groupBoxBotoesCampos = new System.Windows.Forms.GroupBox();
            this.lblResultadoJuros = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblJuros = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lblMontante = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.groupComboBox = new System.Windows.Forms.GroupBox();
            this.lblLinhaHorizontal = new System.Windows.Forms.Label();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblReais1 = new System.Windows.Forms.Label();
            this.lblReais2 = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxBotoesCampos.SuspendLayout();
            this.groupComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.Location = new System.Drawing.Point(206, 550);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(221, 26);
            this.lblRodape.TabIndex = 5;
            this.lblRodape.Text = "Feito com CSharp por Júlio Cézar P. Camargo\r\n             e Kamily C. de Almeida " +
    "Dobis\r\n";
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.cbTipoCalculo);
            this.groupBoxPrincipal.Controls.Add(this.lblRodape);
            this.groupBoxPrincipal.Controls.Add(this.lblComboBox);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoesCampos);
            this.groupBoxPrincipal.Controls.Add(this.groupComboBox);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(15, 81);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(618, 589);
            this.groupBoxPrincipal.TabIndex = 8;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // cbTipoCalculo
            // 
            this.cbTipoCalculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCalculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTipoCalculo.FormattingEnabled = true;
            this.cbTipoCalculo.Items.AddRange(new object[] {
            "Montante",
            "Tempo",
            "Capital",
            "Taxa"});
            this.cbTipoCalculo.Location = new System.Drawing.Point(30, 55);
            this.cbTipoCalculo.Name = "cbTipoCalculo";
            this.cbTipoCalculo.Size = new System.Drawing.Size(238, 24);
            this.cbTipoCalculo.TabIndex = 7;
            this.cbTipoCalculo.SelectedIndexChanged += new System.EventHandler(this.cbTipoCalculo_SelectedIndexChanged);
            // 
            // lblComboBox
            // 
            this.lblComboBox.AutoSize = true;
            this.lblComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblComboBox.Location = new System.Drawing.Point(28, 31);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(208, 19);
            this.lblComboBox.TabIndex = 0;
            this.lblComboBox.Text = "Selecione o que deseja calcular:";
            // 
            // groupBoxBotoesCampos
            // 
            this.groupBoxBotoesCampos.Controls.Add(this.lblPorcentagem);
            this.groupBoxBotoesCampos.Controls.Add(this.lblAnos);
            this.groupBoxBotoesCampos.Controls.Add(this.lblReais2);
            this.groupBoxBotoesCampos.Controls.Add(this.lblReais1);
            this.groupBoxBotoesCampos.Controls.Add(this.lblResultadoJuros);
            this.groupBoxBotoesCampos.Controls.Add(this.btLimpar);
            this.groupBoxBotoesCampos.Controls.Add(this.lblJuros);
            this.groupBoxBotoesCampos.Controls.Add(this.btCalcular);
            this.groupBoxBotoesCampos.Controls.Add(this.lblTempo);
            this.groupBoxBotoesCampos.Controls.Add(this.txtTempo);
            this.groupBoxBotoesCampos.Controls.Add(this.lblTaxa);
            this.groupBoxBotoesCampos.Controls.Add(this.txtTaxa);
            this.groupBoxBotoesCampos.Controls.Add(this.lblCapital);
            this.groupBoxBotoesCampos.Controls.Add(this.txtCapital);
            this.groupBoxBotoesCampos.Controls.Add(this.lblMontante);
            this.groupBoxBotoesCampos.Controls.Add(this.txtMontante);
            this.groupBoxBotoesCampos.Location = new System.Drawing.Point(17, 239);
            this.groupBoxBotoesCampos.Name = "groupBoxBotoesCampos";
            this.groupBoxBotoesCampos.Size = new System.Drawing.Size(580, 297);
            this.groupBoxBotoesCampos.TabIndex = 6;
            this.groupBoxBotoesCampos.TabStop = false;
            // 
            // lblResultadoJuros
            // 
            this.lblResultadoJuros.AutoSize = true;
            this.lblResultadoJuros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultadoJuros.Location = new System.Drawing.Point(269, 161);
            this.lblResultadoJuros.Name = "lblResultadoJuros";
            this.lblResultadoJuros.Size = new System.Drawing.Size(0, 21);
            this.lblResultadoJuros.TabIndex = 17;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLimpar.Location = new System.Drawing.Point(318, 210);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(124, 41);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblJuros.Location = new System.Drawing.Point(219, 160);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(52, 21);
            this.lblJuros.TabIndex = 16;
            this.lblJuros.Text = "Juros:";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.ForestGreen;
            this.btCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCalcular.Location = new System.Drawing.Point(157, 209);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(124, 43);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTempo.Location = new System.Drawing.Point(314, 39);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(54, 19);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "Tempo:";
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtTempo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTempo.Location = new System.Drawing.Point(374, 36);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(159, 25);
            this.txtTempo.TabIndex = 13;
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTaxa.Location = new System.Drawing.Point(328, 89);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(40, 19);
            this.lblTaxa.TabIndex = 12;
            this.lblTaxa.Text = "Taxa:";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtTaxa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTaxa.Location = new System.Drawing.Point(374, 86);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(159, 25);
            this.txtTaxa.TabIndex = 11;
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCapital.Location = new System.Drawing.Point(54, 86);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(56, 19);
            this.lblCapital.TabIndex = 10;
            this.lblCapital.Text = "Capital:";
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtCapital.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCapital.Location = new System.Drawing.Point(116, 86);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(159, 25);
            this.txtCapital.TabIndex = 9;
            // 
            // lblMontante
            // 
            this.lblMontante.AutoSize = true;
            this.lblMontante.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMontante.Location = new System.Drawing.Point(37, 39);
            this.lblMontante.Name = "lblMontante";
            this.lblMontante.Size = new System.Drawing.Size(73, 19);
            this.lblMontante.TabIndex = 8;
            this.lblMontante.Text = "Montante:";
            // 
            // txtMontante
            // 
            this.txtMontante.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtMontante.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMontante.Location = new System.Drawing.Point(116, 36);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(159, 25);
            this.txtMontante.TabIndex = 3;
            // 
            // groupComboBox
            // 
            this.groupComboBox.Controls.Add(this.lblLinhaHorizontal);
            this.groupComboBox.Controls.Add(this.lblExplicacao);
            this.groupComboBox.Location = new System.Drawing.Point(17, 17);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(580, 216);
            this.groupComboBox.TabIndex = 7;
            this.groupComboBox.TabStop = false;
            // 
            // lblLinhaHorizontal
            // 
            this.lblLinhaHorizontal.AutoSize = true;
            this.lblLinhaHorizontal.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblLinhaHorizontal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLinhaHorizontal.Location = new System.Drawing.Point(14, 52);
            this.lblLinhaHorizontal.Name = "lblLinhaHorizontal";
            this.lblLinhaHorizontal.Size = new System.Drawing.Size(553, 30);
            this.lblLinhaHorizontal.TabIndex = 9;
            this.lblLinhaHorizontal.Text = "____________________________________________________________";
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblExplicacao.Location = new System.Drawing.Point(10, 89);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(525, 114);
            this.lblExplicacao.TabIndex = 8;
            this.lblExplicacao.Text = resources.GetString("lblExplicacao.Text");
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(147, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(362, 47);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Calculadora de Juros";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-3, -3);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(653, 78);
            this.pictureBoxTitulo.TabIndex = 7;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblReais1
            // 
            this.lblReais1.AutoSize = true;
            this.lblReais1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblReais1.Location = new System.Drawing.Point(86, 25);
            this.lblReais1.Name = "lblReais1";
            this.lblReais1.Size = new System.Drawing.Size(29, 15);
            this.lblReais1.TabIndex = 18;
            this.lblReais1.Text = "(R$)";
            // 
            // lblReais2
            // 
            this.lblReais2.AutoSize = true;
            this.lblReais2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblReais2.Location = new System.Drawing.Point(86, 71);
            this.lblReais2.Name = "lblReais2";
            this.lblReais2.Size = new System.Drawing.Size(29, 15);
            this.lblReais2.TabIndex = 19;
            this.lblReais2.Text = "(R$)";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAnos.Location = new System.Drawing.Point(334, 25);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(40, 15);
            this.lblAnos.TabIndex = 20;
            this.lblAnos.Text = "(anos)";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPorcentagem.Location = new System.Drawing.Point(348, 76);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(25, 15);
            this.lblPorcentagem.TabIndex = 21;
            this.lblPorcentagem.Text = "(%)";
            // 
            // CalculadoraJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 682);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculadoraJuros";
            this.Text = "Calculadora de Juros";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxBotoesCampos.ResumeLayout(false);
            this.groupBoxBotoesCampos.PerformLayout();
            this.groupComboBox.ResumeLayout(false);
            this.groupComboBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.GroupBox groupBoxBotoesCampos;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.Label lblComboBox;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.ComboBox cbTipoCalculo;
        private System.Windows.Forms.GroupBox groupComboBox;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Label lblLinhaHorizontal;
        private System.Windows.Forms.Label lblMontante;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblResultadoJuros;
        private System.Windows.Forms.Label lblReais1;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.Label lblReais2;
    }
}

