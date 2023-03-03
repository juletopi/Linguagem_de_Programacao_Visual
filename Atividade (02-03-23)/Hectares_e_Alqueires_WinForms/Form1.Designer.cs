namespace Hectares_e_Alqueire_WinForms
{
    partial class Hectares_e_Alqueire_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hectares_e_Alqueire_WinForms));
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.txtAlqueire = new System.Windows.Forms.TextBox();
            this.llbAlqueire = new System.Windows.Forms.Label();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.txtHectare = new System.Windows.Forms.TextBox();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.lblHectare = new System.Windows.Forms.Label();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnConverterHectare = new System.Windows.Forms.Button();
            this.btnConverterAlqueire = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblResultadoNum2 = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lblResultadoNum1 = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.txtAlqueire);
            this.groupBoxPrincipal.Controls.Add(this.llbAlqueire);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.txtHectare);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.lblHectare);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxButtons);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 74);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(632, 427);
            this.groupBoxPrincipal.TabIndex = 9;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // txtAlqueire
            // 
            this.txtAlqueire.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAlqueire.Location = new System.Drawing.Point(23, 122);
            this.txtAlqueire.Name = "txtAlqueire";
            this.txtAlqueire.Size = new System.Drawing.Size(205, 23);
            this.txtAlqueire.TabIndex = 22;
            // 
            // llbAlqueire
            // 
            this.llbAlqueire.AutoSize = true;
            this.llbAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.llbAlqueire.Location = new System.Drawing.Point(21, 101);
            this.llbAlqueire.Name = "llbAlqueire";
            this.llbAlqueire.Size = new System.Drawing.Size(150, 20);
            this.llbAlqueire.TabIndex = 21;
            this.llbAlqueire.Text = "Informe o Alqueire:";
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(151)))), ((int)(((byte)(45)))));
            this.linkJuletopi.Location = new System.Drawing.Point(344, 402);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 20;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(110)))), ((int)(((byte)(21)))));
            // 
            // txtHectare
            // 
            this.txtHectare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtHectare.Location = new System.Drawing.Point(24, 65);
            this.txtHectare.Name = "txtHectare";
            this.txtHectare.Size = new System.Drawing.Size(205, 23);
            this.txtHectare.TabIndex = 5;
            this.txtHectare.TextChanged += new System.EventHandler(this.txtHectare_TextChanged);
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
            // lblHectare
            // 
            this.lblHectare.AutoSize = true;
            this.lblHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHectare.Location = new System.Drawing.Point(21, 43);
            this.lblHectare.Name = "lblHectare";
            this.lblHectare.Size = new System.Drawing.Size(149, 20);
            this.lblHectare.TabIndex = 4;
            this.lblHectare.Text = "Informe o Hectare:";
            this.lblHectare.Click += new System.EventHandler(this.lblHectare_Click);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnConverterHectare);
            this.groupBoxButtons.Controls.Add(this.btnConverterAlqueire);
            this.groupBoxButtons.Controls.Add(this.btnLimpar);
            this.groupBoxButtons.Location = new System.Drawing.Point(15, 179);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(598, 213);
            this.groupBoxButtons.TabIndex = 17;
            this.groupBoxButtons.TabStop = false;
            // 
            // btnConverterHectare
            // 
            this.btnConverterHectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(151)))), ((int)(((byte)(45)))));
            this.btnConverterHectare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterHectare.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterHectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConverterHectare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConverterHectare.Location = new System.Drawing.Point(309, 60);
            this.btnConverterHectare.Name = "btnConverterHectare";
            this.btnConverterHectare.Size = new System.Drawing.Size(181, 65);
            this.btnConverterHectare.TabIndex = 21;
            this.btnConverterHectare.Text = "Converter   Hectare";
            this.btnConverterHectare.UseVisualStyleBackColor = false;
            this.btnConverterHectare.Click += new System.EventHandler(this.btnConverterHectare_Click);
            // 
            // btnConverterAlqueire
            // 
            this.btnConverterAlqueire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(151)))), ((int)(((byte)(45)))));
            this.btnConverterAlqueire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterAlqueire.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterAlqueire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConverterAlqueire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConverterAlqueire.Location = new System.Drawing.Point(115, 60);
            this.btnConverterAlqueire.Name = "btnConverterAlqueire";
            this.btnConverterAlqueire.Size = new System.Drawing.Size(172, 65);
            this.btnConverterAlqueire.TabIndex = 20;
            this.btnConverterAlqueire.Text = "Converter Alqueire";
            this.btnConverterAlqueire.UseVisualStyleBackColor = false;
            this.btnConverterAlqueire.Click += new System.EventHandler(this.btnConverterAlqueire_Click);
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
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblLine);
            this.groupBoxResultado.Controls.Add(this.lblResultadoNum2);
            this.groupBoxResultado.Controls.Add(this.lblResultado2);
            this.groupBoxResultado.Controls.Add(this.lblResultadoNum1);
            this.groupBoxResultado.Controls.Add(this.lblResultado1);
            this.groupBoxResultado.Location = new System.Drawing.Point(259, 32);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(354, 130);
            this.groupBoxResultado.TabIndex = 16;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLine.ForeColor = System.Drawing.Color.Silver;
            this.lblLine.Location = new System.Drawing.Point(18, 48);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(320, 24);
            this.lblLine.TabIndex = 17;
            this.lblLine.Text = "_______________________________";
            // 
            // lblResultadoNum2
            // 
            this.lblResultadoNum2.AutoSize = true;
            this.lblResultadoNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblResultadoNum2.Location = new System.Drawing.Point(99, 78);
            this.lblResultadoNum2.Name = "lblResultadoNum2";
            this.lblResultadoNum2.Size = new System.Drawing.Size(29, 31);
            this.lblResultadoNum2.TabIndex = 16;
            this.lblResultadoNum2.Text = "0";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultado2.Location = new System.Drawing.Point(18, 83);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(81, 24);
            this.lblResultado2.TabIndex = 15;
            this.lblResultado2.Text = "Hectare:";
            this.lblResultado2.Click += new System.EventHandler(this.lblResultado2_Click);
            // 
            // lblResultadoNum1
            // 
            this.lblResultadoNum1.AutoSize = true;
            this.lblResultadoNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblResultadoNum1.Location = new System.Drawing.Point(99, 22);
            this.lblResultadoNum1.Name = "lblResultadoNum1";
            this.lblResultadoNum1.Size = new System.Drawing.Size(29, 31);
            this.lblResultadoNum1.TabIndex = 14;
            this.lblResultadoNum1.Text = "0";
            this.lblResultadoNum1.Click += new System.EventHandler(this.lblResultadoNum_Click);
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultado1.Location = new System.Drawing.Point(16, 26);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(86, 24);
            this.lblResultado1.TabIndex = 13;
            this.lblResultado1.Text = "Alqueire:";
            this.lblResultado1.Click += new System.EventHandler(this.lblResultado1_Click);
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(151)))), ((int)(((byte)(45)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-5, -5);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(668, 74);
            this.pictureBoxTitulo.TabIndex = 10;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(151)))), ((int)(((byte)(45)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(30, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(599, 47);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Convertor de Hectares ⇄ Alqueires";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.UseMnemonic = false;
            // 
            // Hectares_e_Alqueire_WinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(658, 510);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hectares_e_Alqueire_WinForms";
            this.Text = "Convertor de Hectares ⇄ Alqueires";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.TextBox txtHectare;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.Label lblHectare;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnConverterAlqueire;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoNum1;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConverterHectare;
        private System.Windows.Forms.TextBox txtAlqueire;
        private System.Windows.Forms.Label llbAlqueire;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label lblResultadoNum2;
        private System.Windows.Forms.Label lblLine;
    }
}

