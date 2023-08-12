namespace AppExemplo2.Formularios
{
    partial class FormExemploAlerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExemploAlerta));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lbllValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoDivisao = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(167, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 47);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Calcular Divisão";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-33, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 35;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lbllValor2);
            this.groupBoxPrincipal.Controls.Add(this.lblValor1);
            this.groupBoxPrincipal.Controls.Add(this.txtValor2);
            this.groupBoxPrincipal.Controls.Add(this.txtValor1);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(14, 78);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 36;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // lbllValor2
            // 
            this.lbllValor2.AutoSize = true;
            this.lbllValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllValor2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbllValor2.Location = new System.Drawing.Point(20, 109);
            this.lbllValor2.Name = "lbllValor2";
            this.lbllValor2.Size = new System.Drawing.Size(121, 20);
            this.lbllValor2.TabIndex = 33;
            this.lbllValor2.Text = "Insira o 2º valor:";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValor1.Location = new System.Drawing.Point(20, 34);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(121, 20);
            this.lblValor1.TabIndex = 32;
            this.lblValor1.Text = "Insira o 1º valor:";
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValor2.Location = new System.Drawing.Point(19, 130);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(178, 24);
            this.txtValor2.TabIndex = 31;
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValor1.Location = new System.Drawing.Point(19, 55);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(178, 24);
            this.txtValor1.TabIndex = 30;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblResultadoDivisao);
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Location = new System.Drawing.Point(226, 36);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(345, 130);
            this.groupBoxResultado.TabIndex = 29;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblResultadoDivisao
            // 
            this.lblResultadoDivisao.AutoSize = true;
            this.lblResultadoDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultadoDivisao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultadoDivisao.Location = new System.Drawing.Point(146, 49);
            this.lblResultadoDivisao.Name = "lblResultadoDivisao";
            this.lblResultadoDivisao.Size = new System.Drawing.Size(32, 36);
            this.lblResultadoDivisao.TabIndex = 35;
            this.lblResultadoDivisao.Text = "0";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(20, 52);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(128, 29);
            this.lblResultado.TabIndex = 34;
            this.lblResultado.Text = "Resultado:";
            // 
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
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
            this.groupBoxBotoes.Controls.Add(this.btnCalcular);
            this.groupBoxBotoes.Controls.Add(this.btnLimpar);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 191);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 269);
            this.groupBoxBotoes.TabIndex = 28;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
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
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12.22F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(178, 145);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(213, 44);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormExemploAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 587);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormExemploAlerta";
            this.Text = "Exemplo com Alerta";
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
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lbllValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoDivisao;
    }
}