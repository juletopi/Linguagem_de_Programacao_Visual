namespace SimuladorMedia.Formularios
{
    partial class FormSimularMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimularMedia));
            this.lblRodape = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.btVerificarMedia = new System.Windows.Forms.Button();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblTexto3 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblResultadoTexto = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblAprovadoReprovado = new System.Windows.Forms.Label();
            this.lblResultadoNota = new System.Windows.Forms.Label();
            this.groupBoxPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.Location = new System.Drawing.Point(222, 494);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(221, 26);
            this.lblRodape.TabIndex = 11;
            this.lblRodape.Text = "Feito com CSharp por Júlio Cézar P. Camargo\r\n             e Kamily C. de Almeida " +
    "Dobis\r\n";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(150, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 47);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Simulador de Média";
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.btLimpar);
            this.groupBoxPrincipal.Controls.Add(this.btVerificarMedia);
            this.groupBoxPrincipal.Controls.Add(this.txtNomeAluno);
            this.groupBoxPrincipal.Controls.Add(this.lblTexto1);
            this.groupBoxPrincipal.Controls.Add(this.txtNota2);
            this.groupBoxPrincipal.Controls.Add(this.lblTexto3);
            this.groupBoxPrincipal.Controls.Add(this.lblTexto2);
            this.groupBoxPrincipal.Controls.Add(this.txtNota1);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 80);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(628, 451);
            this.groupBoxPrincipal.TabIndex = 14;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // btVerificarMedia
            // 
            this.btVerificarMedia.BackColor = System.Drawing.Color.DarkOrange;
            this.btVerificarMedia.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btVerificarMedia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btVerificarMedia.Location = new System.Drawing.Point(121, 288);
            this.btVerificarMedia.Name = "btVerificarMedia";
            this.btVerificarMedia.Size = new System.Drawing.Size(177, 57);
            this.btVerificarMedia.TabIndex = 5;
            this.btVerificarMedia.Text = "Verificar Média";
            this.btVerificarMedia.UseVisualStyleBackColor = false;
            this.btVerificarMedia.Click += new System.EventHandler(this.btVerificarMedia_Click);
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-2, -1);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(653, 72);
            this.pictureBoxTitulo.TabIndex = 13;
            this.pictureBoxTitulo.TabStop = false;
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
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Location = new System.Drawing.Point(14, 219);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(600, 188);
            this.groupBoxBotoes.TabIndex = 12;
            this.groupBoxBotoes.TabStop = false;
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
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNota2.Location = new System.Drawing.Point(11, 175);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(250, 29);
            this.txtNota2.TabIndex = 18;
            // 
            // lblTexto3
            // 
            this.lblTexto3.AutoSize = true;
            this.lblTexto3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTexto3.Location = new System.Drawing.Point(10, 149);
            this.lblTexto3.Name = "lblTexto3";
            this.lblTexto3.Size = new System.Drawing.Size(263, 20);
            this.lblTexto3.TabIndex = 17;
            this.lblTexto3.Text = "• Digite a sua nota da segunda etapa:";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTexto2.Location = new System.Drawing.Point(9, 82);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(263, 20);
            this.lblTexto2.TabIndex = 15;
            this.lblTexto2.Text = "• Digite a sua nota da primeira etapa:";
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNota1.Location = new System.Drawing.Point(11, 108);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(250, 29);
            this.txtNota1.TabIndex = 16;
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
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblAprovadoReprovado);
            this.groupBoxResultado.Controls.Add(this.lblResultadoTexto);
            this.groupBoxResultado.Controls.Add(this.lblResultadoNota);
            this.groupBoxResultado.Location = new System.Drawing.Point(295, 18);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(318, 186);
            this.groupBoxResultado.TabIndex = 19;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblAprovadoReprovado
            // 
            this.lblAprovadoReprovado.AutoSize = true;
            this.lblAprovadoReprovado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprovadoReprovado.Location = new System.Drawing.Point(16, 103);
            this.lblAprovadoReprovado.Name = "lblAprovadoReprovado";
            this.lblAprovadoReprovado.Size = new System.Drawing.Size(0, 21);
            this.lblAprovadoReprovado.TabIndex = 21;
            // 
            // lblResultadoNota
            // 
            this.lblResultadoNota.AutoSize = true;
            this.lblResultadoNota.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNota.Location = new System.Drawing.Point(15, 66);
            this.lblResultadoNota.Name = "lblResultadoNota";
            this.lblResultadoNota.Size = new System.Drawing.Size(0, 21);
            this.lblResultadoNota.TabIndex = 20;
            // 
            // FormSimularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 541);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Controls.Add(this.pictureBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSimularMedia";
            this.Text = "Simulador de Média";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Button btVerificarMedia;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblTexto3;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoTexto;
        private System.Windows.Forms.Label lblAprovadoReprovado;
        private System.Windows.Forms.Label lblResultadoNota;
    }
}