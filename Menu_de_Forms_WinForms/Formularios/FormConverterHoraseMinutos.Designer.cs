namespace Menu_de_Forms_WinForms.Formularios
{
    partial class FormConverterHoraseMinutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConverterHoraseMinutos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblValorMinutos = new System.Windows.Forms.Label();
            this.lblValorHoras = new System.Windows.Forms.Label();
            this.txtValorMinutos = new System.Windows.Forms.TextBox();
            this.txtValorHoras = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblResultadoMinutosParaHoras = new System.Windows.Forms.Label();
            this.lblResultadoHoras = new System.Windows.Forms.Label();
            this.lblResultadoMinutos = new System.Windows.Forms.Label();
            this.lblResultadoHorasParaMinutos = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnConverteMinutosParaHoras = new System.Windows.Forms.Button();
            this.btnConverterHorasParaMinutos = new System.Windows.Forms.Button();
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
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(62, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(481, 47);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Conversor Horas ⇆ Minutos";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-31, -3);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 32;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblValorMinutos);
            this.groupBoxPrincipal.Controls.Add(this.lblValorHoras);
            this.groupBoxPrincipal.Controls.Add(this.txtValorMinutos);
            this.groupBoxPrincipal.Controls.Add(this.txtValorHoras);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(15, 77);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 33;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblValorMinutos
            // 
            this.lblValorMinutos.AutoSize = true;
            this.lblValorMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMinutos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorMinutos.Location = new System.Drawing.Point(21, 117);
            this.lblValorMinutos.Name = "lblValorMinutos";
            this.lblValorMinutos.Size = new System.Drawing.Size(158, 20);
            this.lblValorMinutos.TabIndex = 45;
            this.lblValorMinutos.Text = "Insira um valor (min.):";
            // 
            // lblValorHoras
            // 
            this.lblValorHoras.AutoSize = true;
            this.lblValorHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHoras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorHoras.Location = new System.Drawing.Point(21, 42);
            this.lblValorHoras.Name = "lblValorHoras";
            this.lblValorHoras.Size = new System.Drawing.Size(138, 20);
            this.lblValorHoras.TabIndex = 44;
            this.lblValorHoras.Text = "Insira um valor (h):";
            // 
            // txtValorMinutos
            // 
            this.txtValorMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorMinutos.Location = new System.Drawing.Point(19, 138);
            this.txtValorMinutos.Name = "txtValorMinutos";
            this.txtValorMinutos.Size = new System.Drawing.Size(201, 24);
            this.txtValorMinutos.TabIndex = 43;
            // 
            // txtValorHoras
            // 
            this.txtValorHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorHoras.Location = new System.Drawing.Point(19, 63);
            this.txtValorHoras.Name = "txtValorHoras";
            this.txtValorHoras.Size = new System.Drawing.Size(201, 24);
            this.txtValorHoras.TabIndex = 42;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblHoras);
            this.groupBoxResultado.Controls.Add(this.lblMinutos);
            this.groupBoxResultado.Controls.Add(this.lblResultadoMinutosParaHoras);
            this.groupBoxResultado.Controls.Add(this.lblResultadoHoras);
            this.groupBoxResultado.Controls.Add(this.lblResultadoMinutos);
            this.groupBoxResultado.Controls.Add(this.lblResultadoHorasParaMinutos);
            this.groupBoxResultado.Controls.Add(this.lblLine);
            this.groupBoxResultado.Location = new System.Drawing.Point(237, 27);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(334, 159);
            this.groupBoxResultado.TabIndex = 41;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHoras.Location = new System.Drawing.Point(125, 90);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(26, 17);
            this.lblHoras.TabIndex = 40;
            this.lblHoras.Text = "(h)";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMinutos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMinutos.Location = new System.Drawing.Point(123, 23);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 17);
            this.lblMinutos.TabIndex = 39;
            this.lblMinutos.Text = "(min.)";
            // 
            // lblResultadoMinutosParaHoras
            // 
            this.lblResultadoMinutosParaHoras.AutoSize = true;
            this.lblResultadoMinutosParaHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoMinutosParaHoras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoMinutosParaHoras.Location = new System.Drawing.Point(144, 98);
            this.lblResultadoMinutosParaHoras.Name = "lblResultadoMinutosParaHoras";
            this.lblResultadoMinutosParaHoras.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoMinutosParaHoras.TabIndex = 37;
            this.lblResultadoMinutosParaHoras.Text = "0";
            // 
            // lblResultadoHoras
            // 
            this.lblResultadoHoras.AutoSize = true;
            this.lblResultadoHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultadoHoras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoHoras.Location = new System.Drawing.Point(20, 101);
            this.lblResultadoHoras.Name = "lblResultadoHoras";
            this.lblResultadoHoras.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoHoras.TabIndex = 36;
            this.lblResultadoHoras.Text = "Resultado:";
            // 
            // lblResultadoMinutos
            // 
            this.lblResultadoMinutos.AutoSize = true;
            this.lblResultadoMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultadoMinutos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoMinutos.Location = new System.Drawing.Point(20, 35);
            this.lblResultadoMinutos.Name = "lblResultadoMinutos";
            this.lblResultadoMinutos.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoMinutos.TabIndex = 34;
            this.lblResultadoMinutos.Text = "Resultado:";
            // 
            // lblResultadoHorasParaMinutos
            // 
            this.lblResultadoHorasParaMinutos.AutoSize = true;
            this.lblResultadoHorasParaMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoHorasParaMinutos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoHorasParaMinutos.Location = new System.Drawing.Point(159, 31);
            this.lblResultadoHorasParaMinutos.Name = "lblResultadoHorasParaMinutos";
            this.lblResultadoHorasParaMinutos.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoHorasParaMinutos.TabIndex = 35;
            this.lblResultadoHorasParaMinutos.Text = "0";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLine.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLine.Location = new System.Drawing.Point(21, 60);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(287, 25);
            this.lblLine.TabIndex = 38;
            this.lblLine.Text = "_________________________";
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnConverteMinutosParaHoras);
            this.groupBoxBotoes.Controls.Add(this.btnConverterHorasParaMinutos);
            this.groupBoxBotoes.Controls.Add(this.btnLimpar);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 204);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 261);
            this.groupBoxBotoes.TabIndex = 40;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnConverteMinutosParaHoras
            // 
            this.btnConverteMinutosParaHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.btnConverteMinutosParaHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverteMinutosParaHoras.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverteMinutosParaHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverteMinutosParaHoras.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConverteMinutosParaHoras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverteMinutosParaHoras.Location = new System.Drawing.Point(289, 69);
            this.btnConverteMinutosParaHoras.Name = "btnConverteMinutosParaHoras";
            this.btnConverteMinutosParaHoras.Size = new System.Drawing.Size(154, 68);
            this.btnConverteMinutosParaHoras.TabIndex = 25;
            this.btnConverteMinutosParaHoras.Text = "Converter MINUTOS";
            this.btnConverteMinutosParaHoras.UseCompatibleTextRendering = true;
            this.btnConverteMinutosParaHoras.UseVisualStyleBackColor = false;
            this.btnConverteMinutosParaHoras.Click += new System.EventHandler(this.btnConverteMinutosParaHoras_Click);
            // 
            // btnConverterHorasParaMinutos
            // 
            this.btnConverterHorasParaMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.btnConverterHorasParaMinutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverterHorasParaMinutos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConverterHorasParaMinutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterHorasParaMinutos.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConverterHorasParaMinutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterHorasParaMinutos.Location = new System.Drawing.Point(113, 69);
            this.btnConverterHorasParaMinutos.Name = "btnConverterHorasParaMinutos";
            this.btnConverterHorasParaMinutos.Size = new System.Drawing.Size(154, 68);
            this.btnConverterHorasParaMinutos.TabIndex = 24;
            this.btnConverterHorasParaMinutos.Text = "Converter HORAS";
            this.btnConverterHorasParaMinutos.UseCompatibleTextRendering = true;
            this.btnConverterHorasParaMinutos.UseVisualStyleBackColor = false;
            this.btnConverterHorasParaMinutos.Click += new System.EventHandler(this.btnConverterHorasParaMinutos_Click);
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
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
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
            // FormConverterHoraseMinutos
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
            this.Name = "FormConverterHoraseMinutos";
            this.Text = "Conversor | Horas ⇆ Minutos";
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
        private System.Windows.Forms.Label lblValorMinutos;
        private System.Windows.Forms.Label lblValorHoras;
        private System.Windows.Forms.TextBox txtValorMinutos;
        private System.Windows.Forms.TextBox txtValorHoras;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblResultadoMinutosParaHoras;
        private System.Windows.Forms.Label lblResultadoHoras;
        private System.Windows.Forms.Label lblResultadoHorasParaMinutos;
        private System.Windows.Forms.Label lblResultadoMinutos;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnConverteMinutosParaHoras;
        private System.Windows.Forms.Button btnConverterHorasParaMinutos;
        private System.Windows.Forms.Button btnLimpar;
    }
}