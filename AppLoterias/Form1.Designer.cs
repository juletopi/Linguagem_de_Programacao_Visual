namespace AppLoterias
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            lblTitulo = new Label();
            lblTituloLinha = new Label();
            lblSubtitulo = new Label();
            picBoxTitulo = new PictureBox();
            groupBoxSecundaria = new GroupBox();
            btnSuperSete = new Button();
            btnDiaDeSorte = new Button();
            btnQuina = new Button();
            btnLotomania = new Button();
            btnMegaSena = new Button();
            btnLotoFacil = new Button();
            lblRodape = new Label();
            label1 = new Label();
            groupBoxPrincipal = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picBoxTitulo).BeginInit();
            groupBoxSecundaria.SuspendLayout();
            groupBoxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.DarkCyan;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(255, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 47);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "GeraSorte";
            // 
            // lblTituloLinha
            // 
            lblTituloLinha.AutoSize = true;
            lblTituloLinha.BackColor = Color.DarkCyan;
            lblTituloLinha.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTituloLinha.ForeColor = SystemColors.Control;
            lblTituloLinha.Location = new Point(218, 25);
            lblTituloLinha.Name = "lblTituloLinha";
            lblTituloLinha.Size = new Size(248, 37);
            lblTituloLinha.TabIndex = 8;
            lblTituloLinha.Text = "_____________________";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.DarkCyan;
            lblSubtitulo.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold);
            lblSubtitulo.ForeColor = SystemColors.Control;
            lblSubtitulo.Location = new Point(160, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(367, 35);
            lblSubtitulo.TabIndex = 9;
            lblSubtitulo.Text = "Gerador de Números da Sorte";
            // 
            // picBoxTitulo
            // 
            picBoxTitulo.BackColor = Color.DarkCyan;
            picBoxTitulo.Location = new Point(-3, -3);
            picBoxTitulo.Name = "picBoxTitulo";
            picBoxTitulo.Size = new Size(673, 114);
            picBoxTitulo.TabIndex = 6;
            picBoxTitulo.TabStop = false;
            // 
            // groupBoxSecundaria
            // 
            groupBoxSecundaria.Controls.Add(btnSuperSete);
            groupBoxSecundaria.Controls.Add(btnDiaDeSorte);
            groupBoxSecundaria.Controls.Add(btnQuina);
            groupBoxSecundaria.Controls.Add(btnLotomania);
            groupBoxSecundaria.Controls.Add(btnMegaSena);
            groupBoxSecundaria.Controls.Add(btnLotoFacil);
            groupBoxSecundaria.Location = new Point(27, 161);
            groupBoxSecundaria.Name = "groupBoxSecundaria";
            groupBoxSecundaria.Size = new Size(607, 416);
            groupBoxSecundaria.TabIndex = 10;
            groupBoxSecundaria.TabStop = false;
            // 
            // btnSuperSete
            // 
            btnSuperSete.BackColor = SystemColors.ControlLight;
            btnSuperSete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSuperSete.ForeColor = Color.DeepPink;
            btnSuperSete.Location = new Point(114, 288);
            btnSuperSete.Name = "btnSuperSete";
            btnSuperSete.Size = new Size(163, 61);
            btnSuperSete.TabIndex = 18;
            btnSuperSete.Text = "SUPER SETE";
            btnSuperSete.UseVisualStyleBackColor = false;
            btnSuperSete.Click += btnSuperSete_Click;
            // 
            // btnDiaDeSorte
            // 
            btnDiaDeSorte.BackColor = SystemColors.ControlLight;
            btnDiaDeSorte.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDiaDeSorte.ForeColor = Color.DarkMagenta;
            btnDiaDeSorte.Location = new Point(337, 288);
            btnDiaDeSorte.Name = "btnDiaDeSorte";
            btnDiaDeSorte.Size = new Size(163, 61);
            btnDiaDeSorte.TabIndex = 17;
            btnDiaDeSorte.Text = "DIA DE SORTE";
            btnDiaDeSorte.UseVisualStyleBackColor = false;
            btnDiaDeSorte.Click += btnDiaDeSorte_Click;
            // 
            // btnQuina
            // 
            btnQuina.BackColor = SystemColors.ControlLight;
            btnQuina.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnQuina.ForeColor = Color.DarkBlue;
            btnQuina.Location = new Point(114, 183);
            btnQuina.Name = "btnQuina";
            btnQuina.Size = new Size(163, 61);
            btnQuina.TabIndex = 15;
            btnQuina.Text = "QUINA";
            btnQuina.UseVisualStyleBackColor = false;
            btnQuina.Click += btnQuina_Click;
            // 
            // btnLotomania
            // 
            btnLotomania.BackColor = SystemColors.ControlLight;
            btnLotomania.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLotomania.ForeColor = Color.DarkOrange;
            btnLotomania.Location = new Point(337, 183);
            btnLotomania.Name = "btnLotomania";
            btnLotomania.Size = new Size(163, 61);
            btnLotomania.TabIndex = 14;
            btnLotomania.Text = "LOTOMANIA";
            btnLotomania.UseVisualStyleBackColor = false;
            btnLotomania.Click += btnLotomania_Click;
            // 
            // btnMegaSena
            // 
            btnMegaSena.BackColor = SystemColors.ControlLight;
            btnMegaSena.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMegaSena.ForeColor = Color.Green;
            btnMegaSena.Location = new Point(114, 88);
            btnMegaSena.Name = "btnMegaSena";
            btnMegaSena.Size = new Size(163, 61);
            btnMegaSena.TabIndex = 13;
            btnMegaSena.Text = "MEGASENA";
            btnMegaSena.UseVisualStyleBackColor = false;
            btnMegaSena.Click += btnMegaSena_Click;
            // 
            // btnLotoFacil
            // 
            btnLotoFacil.BackColor = SystemColors.ControlLight;
            btnLotoFacil.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLotoFacil.ForeColor = Color.Crimson;
            btnLotoFacil.Location = new Point(337, 88);
            btnLotoFacil.Name = "btnLotoFacil";
            btnLotoFacil.Size = new Size(163, 61);
            btnLotoFacil.TabIndex = 5;
            btnLotoFacil.Text = "LOTOFÁCIL";
            btnLotoFacil.UseVisualStyleBackColor = false;
            btnLotoFacil.Click += btnLotoFacil_Click;
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.ForeColor = SystemColors.ControlDark;
            lblRodape.Location = new Point(182, 466);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(286, 15);
            lblRodape.TabIndex = 11;
            lblRodape.Text = "Feito com \U0001f5a4 e CSharp por Kamily Dobis e Júlio Cézar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(270, 21);
            label1.TabIndex = 12;
            label1.Text = "• Selecione uma das opções abaixo:";
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Controls.Add(lblRodape);
            groupBoxPrincipal.Controls.Add(label1);
            groupBoxPrincipal.Location = new Point(12, 117);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(638, 490);
            groupBoxPrincipal.TabIndex = 18;
            groupBoxPrincipal.TabStop = false;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 615);
            Controls.Add(lblTitulo);
            Controls.Add(lblTituloLinha);
            Controls.Add(lblSubtitulo);
            Controls.Add(picBoxTitulo);
            Controls.Add(groupBoxSecundaria);
            Controls.Add(groupBoxPrincipal);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMenuPrincipal";
            Text = "GeraSorte | Menu Principal";
            ((System.ComponentModel.ISupportInitialize)picBoxTitulo).EndInit();
            groupBoxSecundaria.ResumeLayout(false);
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblTituloLinha;
        private Label lblSubtitulo;
        private PictureBox picBoxTitulo;
        private GroupBox groupBoxSecundaria;
        private Label lblRodape;
        private Button btnLotoFacil;
        private Label label1;
        private Button btnMegaSena;
        private Button btnDiaDeSorte;
        private Button btnQuina;
        private Button btnLotomania;
        private GroupBox groupBoxPrincipal;
        private Button btnSuperSete;
    }
}
