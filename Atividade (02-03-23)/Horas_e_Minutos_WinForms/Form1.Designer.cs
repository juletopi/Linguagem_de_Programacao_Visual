namespace Horas_e_Minutos_WinForms
{
    partial class Horas_e_Minutos_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horas_e_Minutos_WinForms));
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.groupBoxButttons = new System.Windows.Forms.GroupBox();
            this.btnMintoH = new System.Windows.Forms.Button();
            this.btnHtoMin = new System.Windows.Forms.Button();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.lblResultadoNum2 = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lblResultadoNum1 = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxButttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.btnLimpar);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.txtMinutos);
            this.groupBoxPrincipal.Controls.Add(this.txtHoras);
            this.groupBoxPrincipal.Controls.Add(this.lblMinutos);
            this.groupBoxPrincipal.Controls.Add(this.lblHoras);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxButttons);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(7, 78);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(649, 422);
            this.groupBoxPrincipal.TabIndex = 27;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.linkJuletopi.Location = new System.Drawing.Point(357, 398);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 21;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            // 
            // labeltxtdeco
            // 
            this.labeltxtdeco.AutoSize = true;
            this.labeltxtdeco.Location = new System.Drawing.Point(248, 398);
            this.labeltxtdeco.Name = "labeltxtdeco";
            this.labeltxtdeco.Size = new System.Drawing.Size(112, 13);
            this.labeltxtdeco.TabIndex = 21;
            this.labeltxtdeco.Text = "Feito com 💚 e C# por";
            // 
            // groupBoxButttons
            // 
            this.groupBoxButttons.Controls.Add(this.btnMintoH);
            this.groupBoxButttons.Controls.Add(this.btnHtoMin);
            this.groupBoxButttons.Location = new System.Drawing.Point(16, 168);
            this.groupBoxButttons.Name = "groupBoxButttons";
            this.groupBoxButttons.Size = new System.Drawing.Size(616, 222);
            this.groupBoxButttons.TabIndex = 0;
            this.groupBoxButttons.TabStop = false;
            // 
            // btnMintoH
            // 
            this.btnMintoH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btnMintoH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMintoH.FlatAppearance.BorderSize = 0;
            this.btnMintoH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMintoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnMintoH.Location = new System.Drawing.Point(317, 57);
            this.btnMintoH.Name = "btnMintoH";
            this.btnMintoH.Size = new System.Drawing.Size(141, 61);
            this.btnMintoH.TabIndex = 1;
            this.btnMintoH.Text = "   Converter      min. ➔ h";
            this.btnMintoH.UseVisualStyleBackColor = false;
            this.btnMintoH.Click += new System.EventHandler(this.btnMintoH_Click);
            // 
            // btnHtoMin
            // 
            this.btnHtoMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btnHtoMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHtoMin.FlatAppearance.BorderSize = 0;
            this.btnHtoMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHtoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnHtoMin.Location = new System.Drawing.Point(151, 57);
            this.btnHtoMin.Name = "btnHtoMin";
            this.btnHtoMin.Size = new System.Drawing.Size(139, 61);
            this.btnHtoMin.TabIndex = 0;
            this.btnHtoMin.Text = "   Converter      h ➔ min.";
            this.btnHtoMin.UseVisualStyleBackColor = false;
            this.btnHtoMin.Click += new System.EventHandler(this.btnHtoMin_Click);
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-9, -1);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(687, 74);
            this.pictureBoxTitulo.TabIndex = 28;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(69, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(532, 47);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Convertor de Horas ⇄ Minutos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.UseMnemonic = false;
            // 
            // txtMinutos
            // 
            this.txtMinutos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtMinutos.Location = new System.Drawing.Point(25, 111);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(210, 23);
            this.txtMinutos.TabIndex = 25;
            this.txtMinutos.TextChanged += new System.EventHandler(this.txtMinutos_TextChanged);
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtHoras.Location = new System.Drawing.Point(25, 52);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(210, 23);
            this.txtHoras.TabIndex = 24;
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoras_TextChanged);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMinutos.Location = new System.Drawing.Point(21, 88);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(200, 20);
            this.lblMinutos.TabIndex = 23;
            this.lblMinutos.Text = "(Minutos) Insira um valor:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHoras.Location = new System.Drawing.Point(21, 29);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(187, 20);
            this.lblHoras.TabIndex = 22;
            this.lblHoras.Text = "(Horas) Insira um valor:";
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.labelLine);
            this.groupBoxResultado.Controls.Add(this.lblResultadoNum2);
            this.groupBoxResultado.Controls.Add(this.lblResultado2);
            this.groupBoxResultado.Controls.Add(this.lblResultadoNum1);
            this.groupBoxResultado.Controls.Add(this.lblResultado1);
            this.groupBoxResultado.Location = new System.Drawing.Point(259, 26);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(373, 130);
            this.groupBoxResultado.TabIndex = 26;
            this.groupBoxResultado.TabStop = false;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelLine.ForeColor = System.Drawing.Color.Silver;
            this.labelLine.Location = new System.Drawing.Point(15, 53);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(333, 20);
            this.labelLine.TabIndex = 18;
            this.labelLine.Text = "____________________________________";
            // 
            // lblResultadoNum2
            // 
            this.lblResultadoNum2.AutoSize = true;
            this.lblResultadoNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblResultadoNum2.Location = new System.Drawing.Point(82, 81);
            this.lblResultadoNum2.Name = "lblResultadoNum2";
            this.lblResultadoNum2.Size = new System.Drawing.Size(35, 38);
            this.lblResultadoNum2.TabIndex = 17;
            this.lblResultadoNum2.Text = "0";
            this.lblResultadoNum2.Click += new System.EventHandler(this.lblResultadoNum2_Click);
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultado2.Location = new System.Drawing.Point(19, 88);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(65, 24);
            this.lblResultado2.TabIndex = 16;
            this.lblResultado2.Text = "Horas:";
            // 
            // lblResultadoNum1
            // 
            this.lblResultadoNum1.AutoSize = true;
            this.lblResultadoNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblResultadoNum1.Location = new System.Drawing.Point(97, 20);
            this.lblResultadoNum1.Name = "lblResultadoNum1";
            this.lblResultadoNum1.Size = new System.Drawing.Size(35, 38);
            this.lblResultadoNum1.TabIndex = 15;
            this.lblResultadoNum1.Text = "0";
            this.lblResultadoNum1.Click += new System.EventHandler(this.lblResultadoNum1_Click);
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultado1.Location = new System.Drawing.Point(19, 27);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(81, 24);
            this.lblResultado1.TabIndex = 14;
            this.lblResultado1.Text = "Minutos:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLimpar.Location = new System.Drawing.Point(267, 306);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 52);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Horas_e_Minutos_WinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(668, 512);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Horas_e_Minutos_WinForms";
            this.Text = "Convertor de Horas ⇄ Minutos";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxButttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.GroupBox groupBoxButttons;
        private System.Windows.Forms.Button btnMintoH;
        private System.Windows.Forms.Button btnHtoMin;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label lblResultadoNum2;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label lblResultadoNum1;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}

