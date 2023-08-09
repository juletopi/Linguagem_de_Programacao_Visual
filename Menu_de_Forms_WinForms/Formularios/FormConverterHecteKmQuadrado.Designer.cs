namespace Menu_de_Forms_WinForms.Formularios
{
    partial class FormConverterHecteKmQuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConverterHecteKmQuadrado));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblValorHoras = new System.Windows.Forms.Label();
            this.txtValorHectare = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoKmQuadrado = new System.Windows.Forms.Label();
            this.lblResultadoHectParaKmQuadrado = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnConverterHectParaKmQuadrado = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.lblKmQuadrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(83, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(444, 47);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Conversor Hectare → Km²";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-31, -3);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 35;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblValorHoras);
            this.groupBoxPrincipal.Controls.Add(this.txtValorHectare);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(15, 77);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 36;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblValorHoras
            // 
            this.lblValorHoras.AutoSize = true;
            this.lblValorHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHoras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorHoras.Location = new System.Drawing.Point(21, 75);
            this.lblValorHoras.Name = "lblValorHoras";
            this.lblValorHoras.Size = new System.Drawing.Size(185, 20);
            this.lblValorHoras.TabIndex = 50;
            this.lblValorHoras.Text = "Insira o valor do Hectare:";
            // 
            // txtValorHectare
            // 
            this.txtValorHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorHectare.Location = new System.Drawing.Point(19, 96);
            this.txtValorHectare.Name = "txtValorHectare";
            this.txtValorHectare.Size = new System.Drawing.Size(201, 24);
            this.txtValorHectare.TabIndex = 48;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblKmQuadrado);
            this.groupBoxResultado.Controls.Add(this.lblResultadoKmQuadrado);
            this.groupBoxResultado.Controls.Add(this.lblResultadoHectParaKmQuadrado);
            this.groupBoxResultado.Location = new System.Drawing.Point(237, 39);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(334, 129);
            this.groupBoxResultado.TabIndex = 47;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblResultadoKmQuadrado
            // 
            this.lblResultadoKmQuadrado.AutoSize = true;
            this.lblResultadoKmQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultadoKmQuadrado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoKmQuadrado.Location = new System.Drawing.Point(20, 52);
            this.lblResultadoKmQuadrado.Name = "lblResultadoKmQuadrado";
            this.lblResultadoKmQuadrado.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoKmQuadrado.TabIndex = 34;
            this.lblResultadoKmQuadrado.Text = "Resultado:";
            // 
            // lblResultadoHectParaKmQuadrado
            // 
            this.lblResultadoHectParaKmQuadrado.AutoSize = true;
            this.lblResultadoHectParaKmQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoHectParaKmQuadrado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoHectParaKmQuadrado.Location = new System.Drawing.Point(152, 49);
            this.lblResultadoHectParaKmQuadrado.Name = "lblResultadoHectParaKmQuadrado";
            this.lblResultadoHectParaKmQuadrado.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoHectParaKmQuadrado.TabIndex = 35;
            this.lblResultadoHectParaKmQuadrado.Text = "0";
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnConverterHectParaKmQuadrado);
            this.groupBoxBotoes.Controls.Add(this.btnLimpar);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 204);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 261);
            this.groupBoxBotoes.TabIndex = 46;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnConverterHectParaKmQuadrado
            // 
            this.btnConverterHectParaKmQuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.btnConverterHectParaKmQuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterHectParaKmQuadrado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterHectParaKmQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterHectParaKmQuadrado.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConverterHectParaKmQuadrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterHectParaKmQuadrado.Location = new System.Drawing.Point(200, 69);
            this.btnConverterHectParaKmQuadrado.Name = "btnConverterHectParaKmQuadrado";
            this.btnConverterHectParaKmQuadrado.Size = new System.Drawing.Size(154, 68);
            this.btnConverterHectParaKmQuadrado.TabIndex = 24;
            this.btnConverterHectParaKmQuadrado.Text = "Converter HECTARE";
            this.btnConverterHectParaKmQuadrado.UseCompatibleTextRendering = true;
            this.btnConverterHectParaKmQuadrado.UseVisualStyleBackColor = false;
            this.btnConverterHectParaKmQuadrado.Click += new System.EventHandler(this.btnConverterHectParaKmQuadrado_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12.22F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(208, 154);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 44);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.linkJuletopi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJuletopi_LinkClicked);
            // 
            // labeltxtdeco
            // 
            this.labeltxtdeco.AutoSize = true;
            this.labeltxtdeco.Location = new System.Drawing.Point(223, 471);
            this.labeltxtdeco.Name = "labeltxtdeco";
            this.labeltxtdeco.Size = new System.Drawing.Size(112, 13);
            this.labeltxtdeco.TabIndex = 25;
            this.labeltxtdeco.Text = "Feito com 💚 e C# por";
            // 
            // lblKmQuadrado
            // 
            this.lblKmQuadrado.AutoSize = true;
            this.lblKmQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKmQuadrado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblKmQuadrado.Location = new System.Drawing.Point(117, 36);
            this.lblKmQuadrado.Name = "lblKmQuadrado";
            this.lblKmQuadrado.Size = new System.Drawing.Size(43, 17);
            this.lblKmQuadrado.TabIndex = 41;
            this.lblKmQuadrado.Text = "(Km²)";
            // 
            // FormConverterHecteKmQuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 583);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConverterHecteKmQuadrado";
            this.Text = "Conversor | Hectare → Km²";
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
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.Label lblValorHoras;
        private System.Windows.Forms.TextBox txtValorHectare;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoKmQuadrado;
        private System.Windows.Forms.Label lblResultadoHectParaKmQuadrado;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnConverterHectParaKmQuadrado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblKmQuadrado;
    }
}