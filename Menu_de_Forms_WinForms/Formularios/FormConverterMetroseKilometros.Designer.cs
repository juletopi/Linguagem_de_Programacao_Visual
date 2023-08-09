namespace Menu_de_Forms_WinForms.Formularios
{
    partial class FormConverterMetroseKilometros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConverterMetroseKilometros));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblValorAlqueire = new System.Windows.Forms.Label();
            this.lblValorHectare = new System.Windows.Forms.Label();
            this.txtValorKm = new System.Windows.Forms.TextBox();
            this.txtValorMetros = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblResultadoKmParaMetros = new System.Windows.Forms.Label();
            this.lblResultadoMetros = new System.Windows.Forms.Label();
            this.lblResultadoMetrosParaKm = new System.Windows.Forms.Label();
            this.lblResultadoKm = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnConverterKmParaMetros = new System.Windows.Forms.Button();
            this.btnConverterMetrosParaKm = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(35, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(545, 47);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Conversor Metros ⇆ Kilometros";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-5, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(624, 74);
            this.pictureBoxTitulo.TabIndex = 32;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblValorAlqueire);
            this.groupBoxPrincipal.Controls.Add(this.lblValorHectare);
            this.groupBoxPrincipal.Controls.Add(this.txtValorKm);
            this.groupBoxPrincipal.Controls.Add(this.txtValorMetros);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(13, 78);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 33;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblValorAlqueire
            // 
            this.lblValorAlqueire.AutoSize = true;
            this.lblValorAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAlqueire.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorAlqueire.Location = new System.Drawing.Point(21, 117);
            this.lblValorAlqueire.Name = "lblValorAlqueire";
            this.lblValorAlqueire.Size = new System.Drawing.Size(152, 20);
            this.lblValorAlqueire.TabIndex = 39;
            this.lblValorAlqueire.Text = "Insira um valor (Km):";
            // 
            // lblValorHectare
            // 
            this.lblValorHectare.AutoSize = true;
            this.lblValorHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHectare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorHectare.Location = new System.Drawing.Point(21, 42);
            this.lblValorHectare.Name = "lblValorHectare";
            this.lblValorHectare.Size = new System.Drawing.Size(142, 20);
            this.lblValorHectare.TabIndex = 38;
            this.lblValorHectare.Text = "Insira um valor (m):";
            // 
            // txtValorKm
            // 
            this.txtValorKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorKm.Location = new System.Drawing.Point(19, 138);
            this.txtValorKm.Name = "txtValorKm";
            this.txtValorKm.Size = new System.Drawing.Size(201, 24);
            this.txtValorKm.TabIndex = 37;
            // 
            // txtValorMetros
            // 
            this.txtValorMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorMetros.Location = new System.Drawing.Point(19, 63);
            this.txtValorMetros.Name = "txtValorMetros";
            this.txtValorMetros.Size = new System.Drawing.Size(201, 24);
            this.txtValorMetros.TabIndex = 36;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblMetros);
            this.groupBoxResultado.Controls.Add(this.lblKm);
            this.groupBoxResultado.Controls.Add(this.lblResultadoKmParaMetros);
            this.groupBoxResultado.Controls.Add(this.lblResultadoMetros);
            this.groupBoxResultado.Controls.Add(this.lblResultadoMetrosParaKm);
            this.groupBoxResultado.Controls.Add(this.lblResultadoKm);
            this.groupBoxResultado.Controls.Add(this.lblLine);
            this.groupBoxResultado.Location = new System.Drawing.Point(237, 27);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(334, 159);
            this.groupBoxResultado.TabIndex = 35;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMetros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMetros.Location = new System.Drawing.Point(123, 90);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(29, 17);
            this.lblMetros.TabIndex = 40;
            this.lblMetros.Text = "(m)";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblKm.Location = new System.Drawing.Point(123, 23);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(38, 17);
            this.lblKm.TabIndex = 39;
            this.lblKm.Text = "(Km)";
            // 
            // lblResultadoKmParaMetros
            // 
            this.lblResultadoKmParaMetros.AutoSize = true;
            this.lblResultadoKmParaMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoKmParaMetros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoKmParaMetros.Location = new System.Drawing.Point(146, 98);
            this.lblResultadoKmParaMetros.Name = "lblResultadoKmParaMetros";
            this.lblResultadoKmParaMetros.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoKmParaMetros.TabIndex = 37;
            this.lblResultadoKmParaMetros.Text = "0";
            // 
            // lblResultadoMetros
            // 
            this.lblResultadoMetros.AutoSize = true;
            this.lblResultadoMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultadoMetros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoMetros.Location = new System.Drawing.Point(20, 101);
            this.lblResultadoMetros.Name = "lblResultadoMetros";
            this.lblResultadoMetros.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoMetros.TabIndex = 36;
            this.lblResultadoMetros.Text = "Resultado:";
            // 
            // lblResultadoMetrosParaKm
            // 
            this.lblResultadoMetrosParaKm.AutoSize = true;
            this.lblResultadoMetrosParaKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoMetrosParaKm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoMetrosParaKm.Location = new System.Drawing.Point(155, 31);
            this.lblResultadoMetrosParaKm.Name = "lblResultadoMetrosParaKm";
            this.lblResultadoMetrosParaKm.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoMetrosParaKm.TabIndex = 35;
            this.lblResultadoMetrosParaKm.Text = "0";
            // 
            // lblResultadoKm
            // 
            this.lblResultadoKm.AutoSize = true;
            this.lblResultadoKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultadoKm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoKm.Location = new System.Drawing.Point(20, 35);
            this.lblResultadoKm.Name = "lblResultadoKm";
            this.lblResultadoKm.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoKm.TabIndex = 34;
            this.lblResultadoKm.Text = "Resultado:";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLine.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLine.Location = new System.Drawing.Point(21, 61);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(287, 25);
            this.lblLine.TabIndex = 38;
            this.lblLine.Text = "_________________________";
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnConverterKmParaMetros);
            this.groupBoxBotoes.Controls.Add(this.btnConverterMetrosParaKm);
            this.groupBoxBotoes.Controls.Add(this.btnLimpar);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 204);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 261);
            this.groupBoxBotoes.TabIndex = 34;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnConverterKmParaMetros
            // 
            this.btnConverterKmParaMetros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnConverterKmParaMetros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterKmParaMetros.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterKmParaMetros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterKmParaMetros.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConverterKmParaMetros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterKmParaMetros.Location = new System.Drawing.Point(289, 69);
            this.btnConverterKmParaMetros.Name = "btnConverterKmParaMetros";
            this.btnConverterKmParaMetros.Size = new System.Drawing.Size(154, 68);
            this.btnConverterKmParaMetros.TabIndex = 25;
            this.btnConverterKmParaMetros.Text = "Converter KILOMETROS";
            this.btnConverterKmParaMetros.UseCompatibleTextRendering = true;
            this.btnConverterKmParaMetros.UseVisualStyleBackColor = false;
            this.btnConverterKmParaMetros.Click += new System.EventHandler(this.btnConverterKmParaMetros_Click);
            // 
            // btnConverterMetrosParaKm
            // 
            this.btnConverterMetrosParaKm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnConverterMetrosParaKm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterMetrosParaKm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterMetrosParaKm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterMetrosParaKm.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConverterMetrosParaKm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterMetrosParaKm.Location = new System.Drawing.Point(113, 69);
            this.btnConverterMetrosParaKm.Name = "btnConverterMetrosParaKm";
            this.btnConverterMetrosParaKm.Size = new System.Drawing.Size(154, 68);
            this.btnConverterMetrosParaKm.TabIndex = 24;
            this.btnConverterMetrosParaKm.Text = "Converter METROS";
            this.btnConverterMetrosParaKm.UseCompatibleTextRendering = true;
            this.btnConverterMetrosParaKm.UseVisualStyleBackColor = false;
            this.btnConverterMetrosParaKm.Click += new System.EventHandler(this.btnConverterMetrosParaKm_Click);
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
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
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
            // FormConverterMetroseKilometros
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
            this.Name = "FormConverterMetroseKilometros";
            this.Text = "Conversor | Metros ⇆ Kilometros";
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
        private System.Windows.Forms.Label lblValorAlqueire;
        private System.Windows.Forms.Label lblValorHectare;
        private System.Windows.Forms.TextBox txtValorKm;
        private System.Windows.Forms.TextBox txtValorMetros;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblResultadoKmParaMetros;
        private System.Windows.Forms.Label lblResultadoMetros;
        private System.Windows.Forms.Label lblResultadoMetrosParaKm;
        private System.Windows.Forms.Label lblResultadoKm;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnConverterKmParaMetros;
        private System.Windows.Forms.Button btnConverterMetrosParaKm;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblKm;
    }
}