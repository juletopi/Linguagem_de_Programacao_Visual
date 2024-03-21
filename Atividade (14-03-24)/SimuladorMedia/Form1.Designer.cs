namespace SimuladorMedia
{
    partial class FormSimuladorMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimuladorMedia));
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.btVerificarMedia = new System.Windows.Forms.Button();
            this.btNotaMinima = new System.Windows.Forms.Button();
            this.lblTextoMenu = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblDivisorTitulo = new System.Windows.Forms.Label();
            this.lblRodape = new System.Windows.Forms.Label();
            this.groupBoxPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.btSimularMedia);
            this.groupBoxPrincipal.Controls.Add(this.btVerificarMedia);
            this.groupBoxPrincipal.Controls.Add(this.btNotaMinima);
            this.groupBoxPrincipal.Controls.Add(this.lblTextoMenu);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(15, 107);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(618, 421);
            this.groupBoxPrincipal.TabIndex = 8;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.BackColor = System.Drawing.Color.DarkGray;
            this.btSimularMedia.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btSimularMedia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSimularMedia.Location = new System.Drawing.Point(215, 93);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(186, 70);
            this.btSimularMedia.TabIndex = 6;
            this.btSimularMedia.Text = "Simular Média";
            this.btSimularMedia.UseVisualStyleBackColor = false;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // btVerificarMedia
            // 
            this.btVerificarMedia.BackColor = System.Drawing.Color.DarkGray;
            this.btVerificarMedia.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btVerificarMedia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btVerificarMedia.Location = new System.Drawing.Point(215, 285);
            this.btVerificarMedia.Name = "btVerificarMedia";
            this.btVerificarMedia.Size = new System.Drawing.Size(186, 70);
            this.btVerificarMedia.TabIndex = 5;
            this.btVerificarMedia.Text = "Verificar Média";
            this.btVerificarMedia.UseVisualStyleBackColor = false;
            this.btVerificarMedia.Click += new System.EventHandler(this.btVerificarMedia_Click);
            // 
            // btNotaMinima
            // 
            this.btNotaMinima.BackColor = System.Drawing.Color.DarkGray;
            this.btNotaMinima.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btNotaMinima.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNotaMinima.Location = new System.Drawing.Point(215, 189);
            this.btNotaMinima.Name = "btNotaMinima";
            this.btNotaMinima.Size = new System.Drawing.Size(186, 70);
            this.btNotaMinima.TabIndex = 4;
            this.btNotaMinima.Text = "Nota Mínima";
            this.btNotaMinima.UseVisualStyleBackColor = false;
            this.btNotaMinima.Click += new System.EventHandler(this.btNotaMinima_Click);
            // 
            // lblTextoMenu
            // 
            this.lblTextoMenu.AutoSize = true;
            this.lblTextoMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoMenu.Location = new System.Drawing.Point(13, 25);
            this.lblTextoMenu.Name = "lblTextoMenu";
            this.lblTextoMenu.Size = new System.Drawing.Size(270, 21);
            this.lblTextoMenu.TabIndex = 0;
            this.lblTextoMenu.Text = "• Selecione uma das opções abaixo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(149, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 47);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Simulador de Média";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-3, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(653, 103);
            this.pictureBoxTitulo.TabIndex = 7;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.DarkGray;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtitulo.Location = new System.Drawing.Point(219, 57);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(210, 37);
            this.lblSubtitulo.TabIndex = 9;
            this.lblSubtitulo.Text = "Menu Principal";
            // 
            // lblDivisorTitulo
            // 
            this.lblDivisorTitulo.AutoSize = true;
            this.lblDivisorTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.lblDivisorTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblDivisorTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDivisorTitulo.Location = new System.Drawing.Point(170, 23);
            this.lblDivisorTitulo.Name = "lblDivisorTitulo";
            this.lblDivisorTitulo.Size = new System.Drawing.Size(314, 37);
            this.lblDivisorTitulo.TabIndex = 10;
            this.lblDivisorTitulo.Text = "___________________________";
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.Location = new System.Drawing.Point(221, 540);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(221, 26);
            this.lblRodape.TabIndex = 6;
            this.lblRodape.Text = "Feito com CSharp por Júlio Cézar P. Camargo\r\n             e Kamily C. de Almeida " +
    "Dobis\r\n";
            // 
            // FormSimuladorMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 574);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDivisorTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSimuladorMedia";
            this.Text = "Simulador de Média | Menu Principal";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Button btNotaMinima;
        private System.Windows.Forms.Label lblTextoMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblDivisorTitulo;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.Button btVerificarMedia;
    }
}

