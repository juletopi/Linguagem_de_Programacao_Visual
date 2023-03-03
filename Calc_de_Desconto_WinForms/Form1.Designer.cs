namespace Calc_de_Desconto_WinForms
{
    partial class Calc_de_Desconto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc_de_Desconto));
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblReais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoNum = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnCalcularDesconto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPercDeDesconto = new System.Windows.Forms.Label();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.txtPercDeDesconto = new System.Windows.Forms.TextBox();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.txtValorDaCompra = new System.Windows.Forms.TextBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(221)))), ((int)(((byte)(71)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-6, -1);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(668, 74);
            this.pictureBoxTitulo.TabIndex = 2;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(221)))), ((int)(((byte)(71)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(114, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(429, 47);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Calculadora de Desconto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.UseMnemonic = false;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblReais);
            this.groupBoxResultado.Controls.Add(this.label1);
            this.groupBoxResultado.Controls.Add(this.lblResultadoNum);
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Location = new System.Drawing.Point(238, 32);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(375, 125);
            this.groupBoxResultado.TabIndex = 16;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold);
            this.lblReais.Location = new System.Drawing.Point(112, 45);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(45, 29);
            this.lblReais.TabIndex = 16;
            this.lblReais.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desconto:";
            // 
            // lblResultadoNum
            // 
            this.lblResultadoNum.AutoSize = true;
            this.lblResultadoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblResultadoNum.Location = new System.Drawing.Point(154, 43);
            this.lblResultadoNum.Name = "lblResultadoNum";
            this.lblResultadoNum.Size = new System.Drawing.Size(29, 31);
            this.lblResultadoNum.TabIndex = 14;
            this.lblResultadoNum.Text = "0";
            this.lblResultadoNum.Click += new System.EventHandler(this.lblResultadoNum_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultado.Location = new System.Drawing.Point(14, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 24);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Valor com";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnCalcularDesconto);
            this.groupBoxButtons.Controls.Add(this.btnLimpar);
            this.groupBoxButtons.Location = new System.Drawing.Point(15, 179);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(598, 213);
            this.groupBoxButtons.TabIndex = 17;
            this.groupBoxButtons.TabStop = false;
            // 
            // btnCalcularDesconto
            // 
            this.btnCalcularDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(221)))), ((int)(((byte)(71)))));
            this.btnCalcularDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularDesconto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCalcularDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCalcularDesconto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcularDesconto.Location = new System.Drawing.Point(191, 59);
            this.btnCalcularDesconto.Name = "btnCalcularDesconto";
            this.btnCalcularDesconto.Size = new System.Drawing.Size(211, 49);
            this.btnCalcularDesconto.TabIndex = 20;
            this.btnCalcularDesconto.Text = "Calcular Desconto";
            this.btnCalcularDesconto.UseVisualStyleBackColor = false;
            this.btnCalcularDesconto.Click += new System.EventHandler(this.btnCalcularDesconto_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLimpar.Location = new System.Drawing.Point(244, 141);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 52);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPercDeDesconto
            // 
            this.lblPercDeDesconto.AutoSize = true;
            this.lblPercDeDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPercDeDesconto.Location = new System.Drawing.Point(11, 98);
            this.lblPercDeDesconto.Name = "lblPercDeDesconto";
            this.lblPercDeDesconto.Size = new System.Drawing.Size(180, 20);
            this.lblPercDeDesconto.TabIndex = 4;
            this.lblPercDeDesconto.Text = "(%) Perc. de Desconto";
            this.lblPercDeDesconto.Click += new System.EventHandler(this.lblPercDeDesconto_Click);
            // 
            // labeltxtdeco
            // 
            this.labeltxtdeco.AutoSize = true;
            this.labeltxtdeco.Location = new System.Drawing.Point(235, 402);
            this.labeltxtdeco.Name = "labeltxtdeco";
            this.labeltxtdeco.Size = new System.Drawing.Size(112, 13);
            this.labeltxtdeco.TabIndex = 18;
            this.labeltxtdeco.Text = "Feito com 💚 e C# por";
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblValorDaCompra.Location = new System.Drawing.Point(11, 32);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(173, 20);
            this.lblValorDaCompra.TabIndex = 6;
            this.lblValorDaCompra.Text = "(R$) Valor da Compra";
            this.lblValorDaCompra.Click += new System.EventHandler(this.lblValorDaCompra_Click);
            // 
            // txtPercDeDesconto
            // 
            this.txtPercDeDesconto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPercDeDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPercDeDesconto.Location = new System.Drawing.Point(15, 121);
            this.txtPercDeDesconto.Name = "txtPercDeDesconto";
            this.txtPercDeDesconto.Size = new System.Drawing.Size(205, 23);
            this.txtPercDeDesconto.TabIndex = 5;
            this.txtPercDeDesconto.TextChanged += new System.EventHandler(this.txtPercDeDesconto_TextChanged);
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(186)))), ((int)(((byte)(30)))));
            this.linkJuletopi.Location = new System.Drawing.Point(344, 402);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 20;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(30)))));
            // 
            // txtValorDaCompra
            // 
            this.txtValorDaCompra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValorDaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValorDaCompra.Location = new System.Drawing.Point(15, 55);
            this.txtValorDaCompra.Name = "txtValorDaCompra";
            this.txtValorDaCompra.Size = new System.Drawing.Size(205, 23);
            this.txtValorDaCompra.TabIndex = 7;
            this.txtValorDaCompra.TextChanged += new System.EventHandler(this.txtValorDaCompra_TextChanged);
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.txtValorDaCompra);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.txtPercDeDesconto);
            this.groupBoxPrincipal.Controls.Add(this.lblValorDaCompra);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.lblPercDeDesconto);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxButtons);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 79);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(632, 427);
            this.groupBoxPrincipal.TabIndex = 8;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // Calc_de_Desconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(656, 518);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calc_de_Desconto";
            this.Text = "Calculadora de Desconto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoNum;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnCalcularDesconto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPercDeDesconto;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.TextBox txtPercDeDesconto;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.TextBox txtValorDaCompra;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
    }
}

