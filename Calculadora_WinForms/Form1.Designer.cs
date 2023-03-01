namespace Calculadora_WinForms
{
    partial class Calculadora_Simples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora_Simples));
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultadoNum = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValor4 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblValor4 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-28, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 1;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.label1);
            this.groupBoxPrincipal.Controls.Add(this.btnLimpar);
            this.groupBoxPrincipal.Controls.Add(this.lblResultadoNum);
            this.groupBoxPrincipal.Controls.Add(this.lblResultado);
            this.groupBoxPrincipal.Controls.Add(this.txtValor4);
            this.groupBoxPrincipal.Controls.Add(this.txtValor3);
            this.groupBoxPrincipal.Controls.Add(this.txtValor2);
            this.groupBoxPrincipal.Controls.Add(this.txtValor1);
            this.groupBoxPrincipal.Controls.Add(this.lblValor4);
            this.groupBoxPrincipal.Controls.Add(this.lblValor3);
            this.groupBoxPrincipal.Controls.Add(this.lblValor2);
            this.groupBoxPrincipal.Controls.Add(this.lblValor1);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxButtons);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 78);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(776, 360);
            this.groupBoxPrincipal.TabIndex = 2;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.linkJuletopi.Location = new System.Drawing.Point(430, 338);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 18;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(40)))), ((int)(((byte)(28)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Feito com 💚 e C# por";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLimpar.Location = new System.Drawing.Point(344, 263);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 52);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultadoNum
            // 
            this.lblResultadoNum.AutoSize = true;
            this.lblResultadoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblResultadoNum.Location = new System.Drawing.Point(585, 61);
            this.lblResultadoNum.Name = "lblResultadoNum";
            this.lblResultadoNum.Size = new System.Drawing.Size(35, 38);
            this.lblResultadoNum.TabIndex = 13;
            this.lblResultadoNum.Text = "0";
            this.lblResultadoNum.Click += new System.EventHandler(this.lblResultadoNum_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultado.Location = new System.Drawing.Point(470, 68);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 24);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtValor4
            // 
            this.txtValor4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValor4.Location = new System.Drawing.Point(221, 102);
            this.txtValor4.Name = "txtValor4";
            this.txtValor4.Size = new System.Drawing.Size(144, 23);
            this.txtValor4.TabIndex = 7;
            // 
            // txtValor3
            // 
            this.txtValor3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValor3.Location = new System.Drawing.Point(221, 39);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(144, 23);
            this.txtValor3.TabIndex = 6;
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValor2.Location = new System.Drawing.Point(10, 102);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(144, 23);
            this.txtValor2.TabIndex = 5;
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValor1.Location = new System.Drawing.Point(10, 39);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(144, 23);
            this.txtValor1.TabIndex = 4;
            // 
            // lblValor4
            // 
            this.lblValor4.AutoSize = true;
            this.lblValor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblValor4.Location = new System.Drawing.Point(217, 79);
            this.lblValor4.Name = "lblValor4";
            this.lblValor4.Size = new System.Drawing.Size(104, 20);
            this.lblValor4.TabIndex = 3;
            this.lblValor4.Text = "Quarto Valor";
            this.lblValor4.Click += new System.EventHandler(this.lblValor4_Click);
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblValor3.Location = new System.Drawing.Point(217, 16);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(115, 20);
            this.lblValor3.TabIndex = 2;
            this.lblValor3.Text = "Terceiro Valor";
            this.lblValor3.Click += new System.EventHandler(this.lblValor3_Click);
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblValor2.Location = new System.Drawing.Point(6, 79);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(118, 20);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Segundo Valor";
            this.lblValor2.Click += new System.EventHandler(this.lblValor2_Click);
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblValor1.Location = new System.Drawing.Point(6, 16);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(116, 20);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Primeiro Valor";
            this.lblValor1.Click += new System.EventHandler(this.lblValor1_Click);
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Location = new System.Drawing.Point(442, 39);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(310, 86);
            this.groupBoxResultado.TabIndex = 15;
            this.groupBoxResultado.TabStop = false;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnDividir);
            this.groupBoxButtons.Controls.Add(this.btnSomar);
            this.groupBoxButtons.Controls.Add(this.btnSubtrair);
            this.groupBoxButtons.Controls.Add(this.btnMultiplicar);
            this.groupBoxButtons.Location = new System.Drawing.Point(26, 148);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(727, 184);
            this.groupBoxButtons.TabIndex = 16;
            this.groupBoxButtons.TabStop = false;
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnDividir.Location = new System.Drawing.Point(556, 33);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(147, 42);
            this.btnDividir.TabIndex = 11;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSomar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSomar.Location = new System.Drawing.Point(25, 33);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(147, 42);
            this.btnSomar.TabIndex = 8;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(35)))));
            this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtrair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSubtrair.Location = new System.Drawing.Point(202, 33);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(147, 42);
            this.btnSubtrair.TabIndex = 9;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(71)))), ((int)(((byte)(212)))));
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnMultiplicar.Location = new System.Drawing.Point(379, 33);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(147, 42);
            this.btnMultiplicar.TabIndex = 10;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(243, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(352, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Simples";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.UseMnemonic = false;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // Calculadora_Simples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora_Simples";
            this.Text = "Calculadora Simples";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtValor4;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblValor4;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultadoNum;
    }
}

