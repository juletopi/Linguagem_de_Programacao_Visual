namespace Menu_de_Forms_WinForms
{
    partial class FormAppMenudeConversores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppMenudeConversores));
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.btnConversorHecteAlqu = new System.Windows.Forms.Button();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblSelecionarOpc = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnConversorHecteKmQuadrado = new System.Windows.Forms.Button();
            this.btnConversorHoraseMinutos = new System.Windows.Forms.Button();
            this.btnConversorMetroseKilometros = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSeta1 = new System.Windows.Forms.Label();
            this.lblSeta2 = new System.Windows.Forms.Label();
            this.lblSeta3 = new System.Windows.Forms.Label();
            this.lblSeta4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-46, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 20;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // btnConversorHecteAlqu
            // 
            this.btnConversorHecteAlqu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnConversorHecteAlqu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConversorHecteAlqu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConversorHecteAlqu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversorHecteAlqu.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConversorHecteAlqu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConversorHecteAlqu.Location = new System.Drawing.Point(180, 29);
            this.btnConversorHecteAlqu.Name = "btnConversorHecteAlqu";
            this.btnConversorHecteAlqu.Size = new System.Drawing.Size(186, 72);
            this.btnConversorHecteAlqu.TabIndex = 21;
            this.btnConversorHecteAlqu.Text = "Conversor     Hectare ⇆ Alquere";
            this.btnConversorHecteAlqu.UseCompatibleTextRendering = true;
            this.btnConversorHecteAlqu.UseVisualStyleBackColor = false;
            this.btnConversorHecteAlqu.Click += new System.EventHandler(this.btnConversorHecteAlqu_Click);
            this.btnConversorHecteAlqu.MouseEnter += new System.EventHandler(this.btnConversorHecteAlqu_MouseEnter);
            this.btnConversorHecteAlqu.MouseLeave += new System.EventHandler(this.btnConversorHecteAlqu_MouseLeave);
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
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
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblSelecionarOpc);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 78);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 27;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lblSelecionarOpc
            // 
            this.lblSelecionarOpc.AutoSize = true;
            this.lblSelecionarOpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarOpc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSelecionarOpc.Location = new System.Drawing.Point(17, 27);
            this.lblSelecionarOpc.Name = "lblSelecionarOpc";
            this.lblSelecionarOpc.Size = new System.Drawing.Size(283, 18);
            this.lblSelecionarOpc.TabIndex = 25;
            this.lblSelecionarOpc.Text = "• Selecione uma das opções abaixo:";
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnConversorHecteKmQuadrado);
            this.groupBoxBotoes.Controls.Add(this.btnConversorHoraseMinutos);
            this.groupBoxBotoes.Controls.Add(this.btnConversorMetroseKilometros);
            this.groupBoxBotoes.Controls.Add(this.btnConversorHecteAlqu);
            this.groupBoxBotoes.Controls.Add(this.lblSeta1);
            this.groupBoxBotoes.Controls.Add(this.lblSeta2);
            this.groupBoxBotoes.Controls.Add(this.lblSeta3);
            this.groupBoxBotoes.Controls.Add(this.lblSeta4);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 44);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 421);
            this.groupBoxBotoes.TabIndex = 28;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnConversorHecteKmQuadrado
            // 
            this.btnConversorHecteKmQuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnConversorHecteKmQuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConversorHecteKmQuadrado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConversorHecteKmQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversorHecteKmQuadrado.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConversorHecteKmQuadrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConversorHecteKmQuadrado.Location = new System.Drawing.Point(180, 323);
            this.btnConversorHecteKmQuadrado.Name = "btnConversorHecteKmQuadrado";
            this.btnConversorHecteKmQuadrado.Size = new System.Drawing.Size(186, 72);
            this.btnConversorHecteKmQuadrado.TabIndex = 24;
            this.btnConversorHecteKmQuadrado.Text = "Conversor       Hectare → Km²";
            this.btnConversorHecteKmQuadrado.UseCompatibleTextRendering = true;
            this.btnConversorHecteKmQuadrado.UseVisualStyleBackColor = false;
            this.btnConversorHecteKmQuadrado.Click += new System.EventHandler(this.btnConversorHecteKmQuadrado_Click);
            this.btnConversorHecteKmQuadrado.MouseEnter += new System.EventHandler(this.btnConversorHecteKmQuadrado_MouseEnter);
            this.btnConversorHecteKmQuadrado.MouseLeave += new System.EventHandler(this.btnConversorHecteKmQuadrado_MouseLeave);
            // 
            // btnConversorHoraseMinutos
            // 
            this.btnConversorHoraseMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnConversorHoraseMinutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConversorHoraseMinutos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConversorHoraseMinutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversorHoraseMinutos.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConversorHoraseMinutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConversorHoraseMinutos.Location = new System.Drawing.Point(180, 224);
            this.btnConversorHoraseMinutos.Name = "btnConversorHoraseMinutos";
            this.btnConversorHoraseMinutos.Size = new System.Drawing.Size(186, 72);
            this.btnConversorHoraseMinutos.TabIndex = 23;
            this.btnConversorHoraseMinutos.Text = "Conversor              h ⇆ min.";
            this.btnConversorHoraseMinutos.UseCompatibleTextRendering = true;
            this.btnConversorHoraseMinutos.UseVisualStyleBackColor = false;
            this.btnConversorHoraseMinutos.Click += new System.EventHandler(this.btnConversorHoraseMinutos_Click);
            this.btnConversorHoraseMinutos.MouseEnter += new System.EventHandler(this.btnConversorHoraseMinutos_MouseEnter);
            this.btnConversorHoraseMinutos.MouseLeave += new System.EventHandler(this.btnConversorHoraseMinutos_MouseLeave);
            // 
            // btnConversorMetroseKilometros
            // 
            this.btnConversorMetroseKilometros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnConversorMetroseKilometros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConversorMetroseKilometros.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConversorMetroseKilometros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversorMetroseKilometros.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnConversorMetroseKilometros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConversorMetroseKilometros.Location = new System.Drawing.Point(180, 126);
            this.btnConversorMetroseKilometros.Name = "btnConversorMetroseKilometros";
            this.btnConversorMetroseKilometros.Size = new System.Drawing.Size(186, 72);
            this.btnConversorMetroseKilometros.TabIndex = 22;
            this.btnConversorMetroseKilometros.Text = "Conversor             m ⇆ Km";
            this.btnConversorMetroseKilometros.UseCompatibleTextRendering = true;
            this.btnConversorMetroseKilometros.UseVisualStyleBackColor = false;
            this.btnConversorMetroseKilometros.Click += new System.EventHandler(this.btnConversorMetroseKilometros_Click);
            this.btnConversorMetroseKilometros.MouseEnter += new System.EventHandler(this.btnConversorMetroseKilometros_MouseEnter);
            this.btnConversorMetroseKilometros.MouseLeave += new System.EventHandler(this.btnConversorMetroseKilometros_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(117, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(376, 47);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Menu de Conversores";
            // 
            // lblSeta1
            // 
            this.lblSeta1.AutoSize = true;
            this.lblSeta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(56)))));
            this.lblSeta1.Location = new System.Drawing.Point(123, 22);
            this.lblSeta1.Name = "lblSeta1";
            this.lblSeta1.Size = new System.Drawing.Size(80, 73);
            this.lblSeta1.TabIndex = 29;
            this.lblSeta1.Text = "⇥";
            this.lblSeta1.Visible = false;
            // 
            // lblSeta2
            // 
            this.lblSeta2.AutoSize = true;
            this.lblSeta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.lblSeta2.Location = new System.Drawing.Point(123, 120);
            this.lblSeta2.Name = "lblSeta2";
            this.lblSeta2.Size = new System.Drawing.Size(80, 73);
            this.lblSeta2.TabIndex = 30;
            this.lblSeta2.Text = "⇥";
            this.lblSeta2.Visible = false;
            // 
            // lblSeta3
            // 
            this.lblSeta3.AutoSize = true;
            this.lblSeta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.lblSeta3.Location = new System.Drawing.Point(123, 220);
            this.lblSeta3.Name = "lblSeta3";
            this.lblSeta3.Size = new System.Drawing.Size(80, 73);
            this.lblSeta3.TabIndex = 31;
            this.lblSeta3.Text = "⇥";
            this.lblSeta3.Visible = false;
            // 
            // lblSeta4
            // 
            this.lblSeta4.AutoSize = true;
            this.lblSeta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeta4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.lblSeta4.Location = new System.Drawing.Point(123, 319);
            this.lblSeta4.Name = "lblSeta4";
            this.lblSeta4.Size = new System.Drawing.Size(80, 73);
            this.lblSeta4.TabIndex = 32;
            this.lblSeta4.Text = "⇥";
            this.lblSeta4.Visible = false;
            // 
            // FormAppMenudeConversores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(614, 583);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAppMenudeConversores";
            this.Text = "Menu de Conversores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxBotoes.ResumeLayout(false);
            this.groupBoxBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Button btnConversorHecteAlqu;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Label lblSelecionarOpc;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConversorHecteKmQuadrado;
        private System.Windows.Forms.Button btnConversorHoraseMinutos;
        private System.Windows.Forms.Button btnConversorMetroseKilometros;
        private System.Windows.Forms.Label lblSeta1;
        private System.Windows.Forms.Label lblSeta4;
        private System.Windows.Forms.Label lblSeta2;
        private System.Windows.Forms.Label lblSeta3;
    }
}

