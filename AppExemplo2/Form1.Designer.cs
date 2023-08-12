namespace AppExemplo2
{
    partial class AppMenudeExemplos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMenudeExemplos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.lblSelecionarOpc = new System.Windows.Forms.Label();
            this.linkJuletopi = new System.Windows.Forms.LinkLabel();
            this.labeltxtdeco = new System.Windows.Forms.Label();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnExemploComboBox = new System.Windows.Forms.Button();
            this.btnExemploAltdeRotulo = new System.Windows.Forms.Button();
            this.btnExemploAlerta = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(161, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(297, 47);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Menu de Opções";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.pictureBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(-34, -2);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(877, 74);
            this.pictureBoxTitulo.TabIndex = 29;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.lblSelecionarOpc);
            this.groupBoxPrincipal.Controls.Add(this.linkJuletopi);
            this.groupBoxPrincipal.Controls.Add(this.labeltxtdeco);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxBotoes);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(13, 78);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(590, 493);
            this.groupBoxPrincipal.TabIndex = 30;
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
            // linkJuletopi
            // 
            this.linkJuletopi.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkJuletopi.AutoSize = true;
            this.linkJuletopi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkJuletopi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.linkJuletopi.Location = new System.Drawing.Point(331, 471);
            this.linkJuletopi.Name = "linkJuletopi";
            this.linkJuletopi.Size = new System.Drawing.Size(43, 13);
            this.linkJuletopi.TabIndex = 26;
            this.linkJuletopi.TabStop = true;
            this.linkJuletopi.Text = "Juletopi";
            this.linkJuletopi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkJuletopi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
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
            this.groupBoxBotoes.Controls.Add(this.btnExemploComboBox);
            this.groupBoxBotoes.Controls.Add(this.btnExemploAltdeRotulo);
            this.groupBoxBotoes.Controls.Add(this.btnExemploAlerta);
            this.groupBoxBotoes.Controls.Add(this.btnAlertas);
            this.groupBoxBotoes.Location = new System.Drawing.Point(19, 44);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(552, 421);
            this.groupBoxBotoes.TabIndex = 28;
            this.groupBoxBotoes.TabStop = false;
            // 
            // btnExemploComboBox
            // 
            this.btnExemploComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(97)))), ((int)(((byte)(167)))));
            this.btnExemploComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExemploComboBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExemploComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExemploComboBox.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnExemploComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExemploComboBox.Location = new System.Drawing.Point(77, 313);
            this.btnExemploComboBox.Name = "btnExemploComboBox";
            this.btnExemploComboBox.Size = new System.Drawing.Size(391, 44);
            this.btnExemploComboBox.TabIndex = 24;
            this.btnExemploComboBox.Text = "Exemplo com COMBO-BOX";
            this.btnExemploComboBox.UseCompatibleTextRendering = true;
            this.btnExemploComboBox.UseVisualStyleBackColor = false;
            this.btnExemploComboBox.Click += new System.EventHandler(this.btnExemploComboBox_Click);
            // 
            // btnExemploAltdeRotulo
            // 
            this.btnExemploAltdeRotulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(167)))), ((int)(((byte)(46)))));
            this.btnExemploAltdeRotulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExemploAltdeRotulo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExemploAltdeRotulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExemploAltdeRotulo.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnExemploAltdeRotulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExemploAltdeRotulo.Location = new System.Drawing.Point(77, 228);
            this.btnExemploAltdeRotulo.Name = "btnExemploAltdeRotulo";
            this.btnExemploAltdeRotulo.Size = new System.Drawing.Size(391, 44);
            this.btnExemploAltdeRotulo.TabIndex = 23;
            this.btnExemploAltdeRotulo.Text = "Exemplo com ALTERAÇÃO DE RÓTULO";
            this.btnExemploAltdeRotulo.UseCompatibleTextRendering = true;
            this.btnExemploAltdeRotulo.UseVisualStyleBackColor = false;
            this.btnExemploAltdeRotulo.Click += new System.EventHandler(this.btnExemploAltdeRotulo_Click);
            // 
            // btnExemploAlerta
            // 
            this.btnExemploAlerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.btnExemploAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExemploAlerta.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExemploAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExemploAlerta.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnExemploAlerta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExemploAlerta.Location = new System.Drawing.Point(77, 144);
            this.btnExemploAlerta.Name = "btnExemploAlerta";
            this.btnExemploAlerta.Size = new System.Drawing.Size(391, 44);
            this.btnExemploAlerta.TabIndex = 22;
            this.btnExemploAlerta.Text = "Exemplo com ALERTA";
            this.btnExemploAlerta.UseCompatibleTextRendering = true;
            this.btnExemploAlerta.UseVisualStyleBackColor = false;
            this.btnExemploAlerta.Click += new System.EventHandler(this.btnExemploAlerta_Click);
            // 
            // btnAlertas
            // 
            this.btnAlertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAlertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertas.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnAlertas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlertas.Location = new System.Drawing.Point(77, 60);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(391, 44);
            this.btnAlertas.TabIndex = 21;
            this.btnAlertas.Text = "ALERTAS";
            this.btnAlertas.UseCompatibleTextRendering = true;
            this.btnAlertas.UseVisualStyleBackColor = false;
            this.btnAlertas.Click += new System.EventHandler(this.btnAlertas_Click);
            // 
            // AppMenudeExemplos
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
            this.Name = "AppMenudeExemplos";
            this.Text = "Exemplos de Interação no Windows Forms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.groupBoxBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Label lblSelecionarOpc;
        private System.Windows.Forms.LinkLabel linkJuletopi;
        private System.Windows.Forms.Label labeltxtdeco;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button btnExemploAlerta;
        private System.Windows.Forms.Button btnAlertas;
        private System.Windows.Forms.Button btnExemploComboBox;
        private System.Windows.Forms.Button btnExemploAltdeRotulo;
    }
}

