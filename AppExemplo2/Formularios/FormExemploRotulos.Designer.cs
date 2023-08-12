namespace AppExemplo2.Formularios
{
    partial class FormExemploRotulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExemploRotulos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.lblSalarioAtual = new System.Windows.Forms.Label();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblTitulo.Location = new System.Drawing.Point(172, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 47);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "Reajuste Salarial";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-33, -3);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 38;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.lblPercentual);
            this.groupBoxPrincipal.Controls.Add(this.lblSalarioAtual);
            this.groupBoxPrincipal.Controls.Add(this.txtPercentual);
            this.groupBoxPrincipal.Controls.Add(this.txtSalarioAtual);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(14, 77);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 39;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
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
            this.labeltxtdeco.Text = "Feito com 💙 e C# por";
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPercentual.Location = new System.Drawing.Point(20, 108);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(137, 20);
            this.lblPercentual.TabIndex = 39;
            this.lblPercentual.Text = "Perc(%) Reajuste:";
            // 
            // lblSalarioAtual
            // 
            this.lblSalarioAtual.AutoSize = true;
            this.lblSalarioAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioAtual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSalarioAtual.Location = new System.Drawing.Point(20, 33);
            this.lblSalarioAtual.Name = "lblSalarioAtual";
            this.lblSalarioAtual.Size = new System.Drawing.Size(101, 20);
            this.lblSalarioAtual.TabIndex = 38;
            this.lblSalarioAtual.Text = "Salário atual:";
            // 
            // txtPercentual
            // 
            this.txtPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPercentual.Location = new System.Drawing.Point(19, 129);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(178, 24);
            this.txtPercentual.TabIndex = 37;
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtSalarioAtual.Location = new System.Drawing.Point(19, 54);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.Size = new System.Drawing.Size(178, 24);
            this.txtSalarioAtual.TabIndex = 36;
            this.txtSalarioAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalarioAtual_KeyDown);
            this.txtSalarioAtual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalarioAtual_KeyUp);
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.label1);
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Location = new System.Drawing.Point(231, 39);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(345, 130);
            this.groupBoxResultado.TabIndex = 35;
            this.groupBoxResultado.TabStop = false;
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnCalcular);
            this.groupBoxBotoes.Controls.Add(this.btnNovo);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 190);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 269);
            this.groupBoxBotoes.TabIndex = 34;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(178, 71);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(213, 44);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseCompatibleTextRendering = true;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 12.22F);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Location = new System.Drawing.Point(178, 145);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(213, 44);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseCompatibleTextRendering = true;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(8, 55);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(181, 24);
            this.lblResultado.TabIndex = 36;
            this.lblResultado.Text = "Salário Reajustado...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(109, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "RESULTADO";
            // 
            // FormExemploRotulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 587);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormExemploRotulos";
            this.Text = "Exemplo com Alteração de Rótulo";
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
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Label lblSalarioAtual;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.TextBox txtSalarioAtual;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}