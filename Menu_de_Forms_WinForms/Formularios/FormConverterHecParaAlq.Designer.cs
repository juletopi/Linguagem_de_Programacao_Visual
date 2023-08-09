namespace Menu_de_Forms_WinForms.Formularios
{
    partial class FormConverterHecteAlqu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConverterHecteAlqu));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblValorAlqueire = new System.Windows.Forms.Label();
            this.lblValorHectare = new System.Windows.Forms.Label();
            this.txtValorAlqueire = new System.Windows.Forms.TextBox();
            this.txtValorHectare = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblResultadoAlqueireParaHectare = new System.Windows.Forms.Label();
            this.lblResultadoAlqueire = new System.Windows.Forms.Label();
            this.lblResultadoHectareParaAlqueire = new System.Windows.Forms.Label();
            this.lblResultadoHectare = new System.Windows.Forms.Label();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnConverterAlquere = new System.Windows.Forms.Button();
            this.btnConverterHectare = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblHectares = new System.Windows.Forms.Label();
            this.lblAlqueires = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(47, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(518, 47);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Conversor Hectare ⇆ Alqueire";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-33, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 29;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblValorAlqueire);
            this.groupBoxPrincipal.Controls.Add(this.lblValorHectare);
            this.groupBoxPrincipal.Controls.Add(this.txtValorAlqueire);
            this.groupBoxPrincipal.Controls.Add(this.txtValorHectare);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(13, 78);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 37;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblValorAlqueire
            // 
            this.lblValorAlqueire.AutoSize = true;
            this.lblValorAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAlqueire.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorAlqueire.Location = new System.Drawing.Point(16, 112);
            this.lblValorAlqueire.Name = "lblValorAlqueire";
            this.lblValorAlqueire.Size = new System.Drawing.Size(186, 20);
            this.lblValorAlqueire.TabIndex = 33;
            this.lblValorAlqueire.Text = "Insira o valor do Alqueire:";
            // 
            // lblValorHectare
            // 
            this.lblValorHectare.AutoSize = true;
            this.lblValorHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHectare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorHectare.Location = new System.Drawing.Point(14, 37);
            this.lblValorHectare.Name = "lblValorHectare";
            this.lblValorHectare.Size = new System.Drawing.Size(185, 20);
            this.lblValorHectare.TabIndex = 32;
            this.lblValorHectare.Text = "Insira o valor do Hectare:";
            // 
            // txtValorAlqueire
            // 
            this.txtValorAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorAlqueire.Location = new System.Drawing.Point(19, 133);
            this.txtValorAlqueire.Name = "txtValorAlqueire";
            this.txtValorAlqueire.Size = new System.Drawing.Size(201, 24);
            this.txtValorAlqueire.TabIndex = 31;
            // 
            // txtValorHectare
            // 
            this.txtValorHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorHectare.Location = new System.Drawing.Point(19, 58);
            this.txtValorHectare.Name = "txtValorHectare";
            this.txtValorHectare.Size = new System.Drawing.Size(201, 24);
            this.txtValorHectare.TabIndex = 30;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblHectares);
            this.groupBoxResultado.Controls.Add(this.lblAlqueires);
            this.groupBoxResultado.Controls.Add(this.lblResultadoAlqueireParaHectare);
            this.groupBoxResultado.Controls.Add(this.lblResultadoAlqueire);
            this.groupBoxResultado.Controls.Add(this.lblResultadoHectareParaAlqueire);
            this.groupBoxResultado.Controls.Add(this.lblResultadoHectare);
            this.groupBoxResultado.Controls.Add(this.lblLine);
            this.groupBoxResultado.Location = new System.Drawing.Point(237, 22);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(334, 159);
            this.groupBoxResultado.TabIndex = 29;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLine.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLine.Location = new System.Drawing.Point(21, 59);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(287, 25);
            this.lblLine.TabIndex = 38;
            this.lblLine.Text = "_________________________";
            // 
            // lblResultadoAlqueireParaHectare
            // 
            this.lblResultadoAlqueireParaHectare.AutoSize = true;
            this.lblResultadoAlqueireParaHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoAlqueireParaHectare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoAlqueireParaHectare.Location = new System.Drawing.Point(151, 98);
            this.lblResultadoAlqueireParaHectare.Name = "lblResultadoAlqueireParaHectare";
            this.lblResultadoAlqueireParaHectare.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoAlqueireParaHectare.TabIndex = 37;
            this.lblResultadoAlqueireParaHectare.Text = "0";
            // 
            // lblResultadoAlqueire
            // 
            this.lblResultadoAlqueire.AutoSize = true;
            this.lblResultadoAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultadoAlqueire.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoAlqueire.Location = new System.Drawing.Point(20, 101);
            this.lblResultadoAlqueire.Name = "lblResultadoAlqueire";
            this.lblResultadoAlqueire.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoAlqueire.TabIndex = 36;
            this.lblResultadoAlqueire.Text = "Resultado:";
            // 
            // lblResultadoHectareParaAlqueire
            // 
            this.lblResultadoHectareParaAlqueire.AutoSize = true;
            this.lblResultadoHectareParaAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoHectareParaAlqueire.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoHectareParaAlqueire.Location = new System.Drawing.Point(151, 32);
            this.lblResultadoHectareParaAlqueire.Name = "lblResultadoHectareParaAlqueire";
            this.lblResultadoHectareParaAlqueire.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoHectareParaAlqueire.TabIndex = 35;
            this.lblResultadoHectareParaAlqueire.Text = "0";
            // 
            // lblResultadoHectare
            // 
            this.lblResultadoHectare.AutoSize = true;
            this.lblResultadoHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultadoHectare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoHectare.Location = new System.Drawing.Point(20, 35);
            this.lblResultadoHectare.Name = "lblResultadoHectare";
            this.lblResultadoHectare.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoHectare.TabIndex = 34;
            this.lblResultadoHectare.Text = "Resultado:";
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
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
            this.groupBoxBotoes.Controls.Add(this.btnConverterAlquere);
            this.groupBoxBotoes.Controls.Add(this.btnConverterHectare);
            this.groupBoxBotoes.Controls.Add(this.btnLimpar);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 199);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 261);
            this.groupBoxBotoes.TabIndex = 28;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnConverterAlquere
            // 
            this.btnConverterAlquere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
            this.btnConverterAlquere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterAlquere.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterAlquere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterAlquere.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConverterAlquere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterAlquere.Location = new System.Drawing.Point(289, 69);
            this.btnConverterAlquere.Name = "btnConverterAlquere";
            this.btnConverterAlquere.Size = new System.Drawing.Size(154, 68);
            this.btnConverterAlquere.TabIndex = 25;
            this.btnConverterAlquere.Text = "Converter ALQUEIRE";
            this.btnConverterAlquere.UseCompatibleTextRendering = true;
            this.btnConverterAlquere.UseVisualStyleBackColor = false;
            this.btnConverterAlquere.Click += new System.EventHandler(this.btnConverterAlquere_Click);
            // 
            // btnConverterHectare
            // 
            this.btnConverterHectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
            this.btnConverterHectare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterHectare.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterHectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterHectare.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConverterHectare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterHectare.Location = new System.Drawing.Point(113, 69);
            this.btnConverterHectare.Name = "btnConverterHectare";
            this.btnConverterHectare.Size = new System.Drawing.Size(154, 68);
            this.btnConverterHectare.TabIndex = 24;
            this.btnConverterHectare.Text = "Converter HECTARE";
            this.btnConverterHectare.UseCompatibleTextRendering = true;
            this.btnConverterHectare.UseVisualStyleBackColor = false;
            this.btnConverterHectare.Click += new System.EventHandler(this.btnConverterHectare_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12.22F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(207, 167);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 44);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblHectares
            // 
            this.lblHectares.AutoSize = true;
            this.lblHectares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHectares.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHectares.Location = new System.Drawing.Point(104, 87);
            this.lblHectares.Name = "lblHectares";
            this.lblHectares.Size = new System.Drawing.Size(51, 17);
            this.lblHectares.TabIndex = 42;
            this.lblHectares.Text = "(Hect.)";
            // 
            // lblAlqueires
            // 
            this.lblAlqueires.AutoSize = true;
            this.lblAlqueires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAlqueires.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAlqueires.Location = new System.Drawing.Point(105, 20);
            this.lblAlqueires.Name = "lblAlqueires";
            this.lblAlqueires.Size = new System.Drawing.Size(50, 17);
            this.lblAlqueires.TabIndex = 41;
            this.lblAlqueires.Text = "(Alqu.)";
            // 
            // FormConverterHecteAlqu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 583);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConverterHecteAlqu";
            this.Text = "Conversor | Hectare ⇆ Alquere";
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
        private System.Windows.Forms.Label lblValorAlqueire;
        private System.Windows.Forms.Label lblValorHectare;
        private System.Windows.Forms.TextBox txtValorAlqueire;
        private System.Windows.Forms.TextBox txtValorHectare;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoHectareParaAlqueire;
        private System.Windows.Forms.Label lblResultadoHectare;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnConverterHectare;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblResultadoAlqueireParaHectare;
        private System.Windows.Forms.Label lblResultadoAlqueire;
        private System.Windows.Forms.Button btnConverterAlquere;
        private System.Windows.Forms.Label lblHectares;
        private System.Windows.Forms.Label lblAlqueires;
    }
}