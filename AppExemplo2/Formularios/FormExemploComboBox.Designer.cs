namespace AppExemplo2.Formularios
{
    partial class FormExemploComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExemploComboBox));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblPercDesconto = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.lblValorcom = new System.Windows.Forms.Label();
            this.txtPercDesconto = new System.Windows.Forms.TextBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
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
            this.lblTitulo.Location = new System.Drawing.Point(130, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 47);
            this.lblTitulo.TabIndex = 43;
            this.lblTitulo.Text = "Sistema de Descontos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-33, -3);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 41;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.cbTipoCliente);
            this.groupBoxPrincipal.Controls.Add(this.lblPercDesconto);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxResultado);
            this.groupBoxPrincipal.Controls.Add(this.txtPercDesconto);
            this.groupBoxPrincipal.Controls.Add(this.lblValorCompra);
            this.groupBoxPrincipal.Controls.Add(this.lblTipoCliente);
            this.groupBoxPrincipal.Controls.Add(this.txtValorCompra);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(14, 77);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 42;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Items.AddRange(new object[] {
            "Cliente Diamante (25%)",
            "Cliente Ouro (20%)",
            "Cliente VIP (15%)",
            "Cliente Comum (10%)",
            "Cliente Aleatório (5%)"});
            this.cbTipoCliente.Location = new System.Drawing.Point(17, 56);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(202, 26);
            this.cbTipoCliente.TabIndex = 38;
            this.cbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbTipoCliente_SelectedIndexChanged);
            // 
            // lblPercDesconto
            // 
            this.lblPercDesconto.AutoSize = true;
            this.lblPercDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercDesconto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPercDesconto.Location = new System.Drawing.Point(18, 153);
            this.lblPercDesconto.Name = "lblPercDesconto";
            this.lblPercDesconto.Size = new System.Drawing.Size(142, 20);
            this.lblPercDesconto.TabIndex = 41;
            this.lblPercDesconto.Text = "Perc(%) Desconto:";
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblDesconto);
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Controls.Add(this.lblResultadoTitulo);
            this.groupBoxResultado.Controls.Add(this.lblValorcom);
            this.groupBoxResultado.Location = new System.Drawing.Point(236, 33);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(333, 165);
            this.groupBoxResultado.TabIndex = 41;
            this.groupBoxResultado.TabStop = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDesconto.Location = new System.Drawing.Point(16, 79);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(95, 24);
            this.lblDesconto.TabIndex = 39;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(114, 70);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(88, 26);
            this.lblResultado.TabIndex = 38;
            this.lblResultado.Text = "R$ 0,00";
            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.AutoSize = true;
            this.lblResultadoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTitulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultadoTitulo.Location = new System.Drawing.Point(109, -5);
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.Size = new System.Drawing.Size(124, 24);
            this.lblResultadoTitulo.TabIndex = 37;
            this.lblResultadoTitulo.Text = "RESULTADO";
            // 
            // lblValorcom
            // 
            this.lblValorcom.AutoSize = true;
            this.lblValorcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorcom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorcom.Location = new System.Drawing.Point(16, 55);
            this.lblValorcom.Name = "lblValorcom";
            this.lblValorcom.Size = new System.Drawing.Size(96, 24);
            this.lblValorcom.TabIndex = 36;
            this.lblValorcom.Text = "Valor com";
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPercDesconto.Location = new System.Drawing.Point(17, 174);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Size = new System.Drawing.Size(178, 24);
            this.txtPercDesconto.TabIndex = 40;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorCompra.Location = new System.Drawing.Point(18, 92);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(132, 20);
            this.lblValorCompra.TabIndex = 45;
            this.lblValorCompra.Text = "Valor da Compra:";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTipoCliente.Location = new System.Drawing.Point(18, 33);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(201, 20);
            this.lblTipoCliente.TabIndex = 44;
            this.lblTipoCliente.Text = "Selecione o tipo de Cliente:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtValorCompra.Location = new System.Drawing.Point(17, 113);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(178, 24);
            this.txtValorCompra.TabIndex = 43;
            this.txtValorCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorCompra_KeyDown);
            this.txtValorCompra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorCompra_KeyUp);
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.btnCalcular);
            this.groupBoxBotoes.Controls.Add(this.btnNovo);
            this.groupBoxBotoes.Location = new System.Drawing.Point(17, 221);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 238);
            this.groupBoxBotoes.TabIndex = 40;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
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
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
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
            this.labeltxtdeco.Text = "Feito com 💙 e C# por";
            // 
            // FormExemploComboBox
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
            this.Name = "FormExemploComboBox";
            this.Text = "Exemplo com Combo-Box";
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
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.Label lblValorcom;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblPercDesconto;
        private System.Windows.Forms.TextBox txtPercDesconto;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblResultado;
    }
}