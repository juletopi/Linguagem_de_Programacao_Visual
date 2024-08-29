namespace AppLoterias.Formularios
{
    partial class FormSuperSete
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuperSete));
            lblRodape = new Label();
            lblTitulo = new Label();
            lblTituloLinha = new Label();
            lblSubtitulo = new Label();
            picBoxTitulo = new PictureBox();
            groupBoxPrincipal = new GroupBox();
            lblClass = new Label();
            lblImpar = new Label();
            lblPar = new Label();
            groupBoxSecudaria = new GroupBox();
            label1 = new Label();
            lblNumerosDaSorte = new Label();
            dgvNumeros = new DataGridView();
            NumeroDaSorte = new DataGridViewTextBoxColumn();
            btnLimpar = new Button();
            btnGerarNumeros = new Button();
            groupBoxPrincipa = new GroupBox();
            lblExplicacao = new Label();
            lblLinhaHorizontal = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxTitulo).BeginInit();
            groupBoxPrincipal.SuspendLayout();
            groupBoxSecudaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNumeros).BeginInit();
            SuspendLayout();
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.ForeColor = SystemColors.ControlDark;
            lblRodape.Location = new Point(197, 586);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(286, 15);
            lblRodape.TabIndex = 16;
            lblRodape.Text = "Feito com \U0001f5a4 e CSharp por Kamily Dobis e Júlio Cézar";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.DeepPink;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(248, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 47);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "SuperSete";
            // 
            // lblTituloLinha
            // 
            lblTituloLinha.AutoSize = true;
            lblTituloLinha.BackColor = Color.DeepPink;
            lblTituloLinha.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTituloLinha.ForeColor = SystemColors.Control;
            lblTituloLinha.Location = new Point(219, 26);
            lblTituloLinha.Name = "lblTituloLinha";
            lblTituloLinha.Size = new Size(248, 37);
            lblTituloLinha.TabIndex = 13;
            lblTituloLinha.Text = "_____________________";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.DeepPink;
            lblSubtitulo.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold);
            lblSubtitulo.ForeColor = SystemColors.Control;
            lblSubtitulo.Location = new Point(135, 63);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(424, 35);
            lblSubtitulo.TabIndex = 14;
            lblSubtitulo.Text = "Gerador de Números da SuperSete";
            // 
            // picBoxTitulo
            // 
            picBoxTitulo.BackColor = Color.DeepPink;
            picBoxTitulo.Location = new Point(-2, -2);
            picBoxTitulo.Name = "picBoxTitulo";
            picBoxTitulo.Size = new Size(673, 114);
            picBoxTitulo.TabIndex = 11;
            picBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Controls.Add(lblClass);
            groupBoxPrincipal.Controls.Add(lblImpar);
            groupBoxPrincipal.Controls.Add(lblPar);
            groupBoxPrincipal.Controls.Add(groupBoxSecudaria);
            groupBoxPrincipal.Controls.Add(lblNumerosDaSorte);
            groupBoxPrincipal.Controls.Add(dgvNumeros);
            groupBoxPrincipal.Controls.Add(btnLimpar);
            groupBoxPrincipal.Controls.Add(btnGerarNumeros);
            groupBoxPrincipal.Location = new Point(28, 135);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(602, 446);
            groupBoxPrincipal.TabIndex = 15;
            groupBoxPrincipal.TabStop = false;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClass.ForeColor = Color.DeepPink;
            lblClass.Location = new Point(43, 265);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(114, 21);
            lblClass.TabIndex = 12;
            lblClass.Text = "Classificação...";
            // 
            // lblImpar
            // 
            lblImpar.AutoSize = true;
            lblImpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImpar.ForeColor = Color.DeepPink;
            lblImpar.Location = new Point(44, 215);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(81, 21);
            lblImpar.TabIndex = 11;
            lblImpar.Text = "Impares...";
            // 
            // lblPar
            // 
            lblPar.AutoSize = true;
            lblPar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPar.ForeColor = Color.DeepPink;
            lblPar.Location = new Point(45, 170);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(61, 21);
            lblPar.TabIndex = 10;
            lblPar.Text = "Pares...";
            // 
            // groupBoxSecudaria
            // 
            groupBoxSecudaria.Controls.Add(lblExplicacao);
            groupBoxSecudaria.Controls.Add(lblLinhaHorizontal);
            groupBoxSecudaria.Controls.Add(label1);
            groupBoxSecudaria.Location = new Point(30, 139);
            groupBoxSecudaria.Name = "groupBoxSecudaria";
            groupBoxSecudaria.Size = new Size(310, 291);
            groupBoxSecudaria.TabIndex = 14;
            groupBoxSecudaria.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(106, -3);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 15;
            label1.Text = "RESULTADO:";
            // 
            // lblNumerosDaSorte
            // 
            lblNumerosDaSorte.AutoSize = true;
            lblNumerosDaSorte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumerosDaSorte.Location = new Point(401, 44);
            lblNumerosDaSorte.Name = "lblNumerosDaSorte";
            lblNumerosDaSorte.Size = new Size(147, 21);
            lblNumerosDaSorte.TabIndex = 13;
            lblNumerosDaSorte.Text = "Números da Sorte";
            // 
            // dgvNumeros
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dgvNumeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNumeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNumeros.Columns.AddRange(new DataGridViewColumn[] { NumeroDaSorte });
            dgvNumeros.Location = new Point(378, 75);
            dgvNumeros.Name = "dgvNumeros";
            dgvNumeros.Size = new Size(197, 355);
            dgvNumeros.TabIndex = 5;
            // 
            // NumeroDaSorte
            // 
            NumeroDaSorte.DataPropertyName = "Numero";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NumeroDaSorte.DefaultCellStyle = dataGridViewCellStyle2;
            NumeroDaSorte.HeaderText = "NÚMERO";
            NumeroDaSorte.Name = "NumeroDaSorte";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ControlDark;
            btnLimpar.Font = new Font("Segoe UI", 12F);
            btnLimpar.Location = new Point(236, 53);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 49);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnGerarNumeros
            // 
            btnGerarNumeros.BackColor = Color.DeepPink;
            btnGerarNumeros.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGerarNumeros.ForeColor = SystemColors.Control;
            btnGerarNumeros.Location = new Point(30, 53);
            btnGerarNumeros.Name = "btnGerarNumeros";
            btnGerarNumeros.Size = new Size(172, 49);
            btnGerarNumeros.TabIndex = 4;
            btnGerarNumeros.Text = "GERAR NÚMEROS";
            btnGerarNumeros.UseVisualStyleBackColor = false;
            btnGerarNumeros.Click += btnGerarNumeros_Click;
            // 
            // groupBoxPrincipa
            // 
            groupBoxPrincipa.Location = new Point(15, 118);
            groupBoxPrincipa.Name = "groupBoxPrincipa";
            groupBoxPrincipa.Size = new Size(638, 491);
            groupBoxPrincipa.TabIndex = 17;
            groupBoxPrincipa.TabStop = false;
            // 
            // lblExplicacao
            // 
            lblExplicacao.AutoSize = true;
            lblExplicacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblExplicacao.Location = new Point(18, 213);
            lblExplicacao.Name = "lblExplicacao";
            lblExplicacao.Size = new Size(249, 42);
            lblExplicacao.TabIndex = 21;
            lblExplicacao.Text = "Números envolvidos: 7 números \r\nsorteados entre 1 e 9.";
            // 
            // lblLinhaHorizontal
            // 
            lblLinhaHorizontal.AutoSize = true;
            lblLinhaHorizontal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLinhaHorizontal.ForeColor = SystemColors.ControlDark;
            lblLinhaHorizontal.Location = new Point(24, 171);
            lblLinhaHorizontal.Name = "lblLinhaHorizontal";
            lblLinhaHorizontal.Size = new Size(269, 21);
            lblLinhaHorizontal.TabIndex = 22;
            lblLinhaHorizontal.Text = "_____________________________________";
            // 
            // FormSuperSete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 621);
            Controls.Add(lblRodape);
            Controls.Add(lblTitulo);
            Controls.Add(lblTituloLinha);
            Controls.Add(lblSubtitulo);
            Controls.Add(picBoxTitulo);
            Controls.Add(groupBoxPrincipal);
            Controls.Add(groupBoxPrincipa);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormSuperSete";
            Text = "SuperSete | Gerador de Números da Sorte";
            ((System.ComponentModel.ISupportInitialize)picBoxTitulo).EndInit();
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxPrincipal.PerformLayout();
            groupBoxSecudaria.ResumeLayout(false);
            groupBoxSecudaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNumeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRodape;
        private Label lblTitulo;
        private Label lblTituloLinha;
        private Label lblSubtitulo;
        private PictureBox picBoxTitulo;
        private GroupBox groupBoxPrincipal;
        private Label lblClass;
        private Label lblImpar;
        private Label lblPar;
        private GroupBox groupBoxSecudaria;
        private Label label1;
        private Label lblNumerosDaSorte;
        private DataGridView dgvNumeros;
        private DataGridViewTextBoxColumn NumeroDaSorte;
        private Button btnLimpar;
        private Button btnGerarNumeros;
        private GroupBox groupBoxPrincipa;
        private Label lblExplicacao;
        private Label lblLinhaHorizontal;
    }
}