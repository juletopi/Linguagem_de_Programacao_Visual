namespace SimuladorMedia.Formularios
{
    partial class FormNotaMinima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaMinima));
            this.lblRodape = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btVerificarNotaMinima = new System.Windows.Forms.Button();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoTexto = new System.Windows.Forms.Label();
            this.lblNotaParaPassar = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.Location = new System.Drawing.Point(225, 494);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(221, 26);
            this.lblRodape.TabIndex = 15;
            this.lblRodape.Text = "Feito com CSharp por Júlio Cézar P. Camargo\r\n             e Kamily C. de Almeida " +
    "Dobis\r\n";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(208, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 47);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Nota Mínima";
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.btLimpar);
            this.groupBoxPrincipal.Controls.Add(this.btVerificarNotaMinima);
            this.groupBoxPrincipal.Controls.Add(this.txtNomeAluno);
            this.groupBoxPrincipal.Controls.Add(this.lblTexto1);
            this.groupBoxPrincipal.Controls.Add(this.lblTexto2);
            this.groupBoxPrincipal.Controls.Add(this.txtMediaFinal);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(15, 80);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(628, 451);
            this.groupBoxPrincipal.TabIndex = 18;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btLimpar.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLimpar.Location = new System.Drawing.Point(332, 288);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(157, 57);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btVerificarNotaMinima
            // 
            this.btVerificarNotaMinima.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btVerificarNotaMinima.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btVerificarNotaMinima.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btVerificarNotaMinima.Location = new System.Drawing.Point(121, 283);
            this.btVerificarNotaMinima.Name = "btVerificarNotaMinima";
            this.btVerificarNotaMinima.Size = new System.Drawing.Size(177, 66);
            this.btVerificarNotaMinima.TabIndex = 5;
            this.btVerificarNotaMinima.Text = "Verificar Nota Mínima";
            this.btVerificarNotaMinima.UseVisualStyleBackColor = false;
            this.btVerificarNotaMinima.Click += new System.EventHandler(this.btVerificarNotaMinima_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNomeAluno.Location = new System.Drawing.Point(14, 44);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(250, 29);
            this.txtNomeAluno.TabIndex = 14;
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTexto1.Location = new System.Drawing.Point(10, 18);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(221, 20);
            this.lblTexto1.TabIndex = 13;
            this.lblTexto1.Text = "• Digite o nome do(a) aluno(a):";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTexto2.Location = new System.Drawing.Point(9, 82);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(183, 20);
            this.lblTexto2.TabIndex = 15;
            this.lblTexto2.Text = "• Digite a sua média final:";
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaFinal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMediaFinal.Location = new System.Drawing.Point(12, 108);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(250, 29);
            this.txtMediaFinal.TabIndex = 16;
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Location = new System.Drawing.Point(14, 219);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(600, 188);
            this.groupBoxBotoes.TabIndex = 12;
            this.groupBoxBotoes.TabStop = false;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblResultadoTexto);
            this.groupBoxResultado.Controls.Add(this.lblNotaParaPassar);
            this.groupBoxResultado.Location = new System.Drawing.Point(295, 18);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(318, 186);
            this.groupBoxResultado.TabIndex = 19;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblResultadoTexto
            // 
            this.lblResultadoTexto.AutoSize = true;
            this.lblResultadoTexto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTexto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultadoTexto.Location = new System.Drawing.Point(123, -5);
            this.lblResultadoTexto.Name = "lblResultadoTexto";
            this.lblResultadoTexto.Size = new System.Drawing.Size(87, 21);
            this.lblResultadoTexto.TabIndex = 8;
            this.lblResultadoTexto.Text = "Resultado:";
            // 
            // lblNotaParaPassar
            // 
            this.lblNotaParaPassar.AutoSize = true;
            this.lblNotaParaPassar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaParaPassar.Location = new System.Drawing.Point(18, 70);
            this.lblNotaParaPassar.Name = "lblNotaParaPassar";
            this.lblNotaParaPassar.Size = new System.Drawing.Size(0, 21);
            this.lblNotaParaPassar.TabIndex = 20;
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-4, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(663, 72);
            this.pictureBoxTitulo.TabIndex = 17;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // FormNotaMinima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 545);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNotaMinima";
            this.Text = "Verificação de Nota Mínima";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btVerificarNotaMinima;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.TextBox txtMediaFinal;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoTexto;
        private System.Windows.Forms.Label lblNotaParaPassar;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
    }
}