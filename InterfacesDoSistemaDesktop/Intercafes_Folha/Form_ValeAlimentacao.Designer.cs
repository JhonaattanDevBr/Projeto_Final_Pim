namespace InterfacesDoSistemaDesktop
{
    partial class Form_ValeAlimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ValeAlimentacao));
            this.gpbValeAlimentacao = new System.Windows.Forms.GroupBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalculcar = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtValeAlimentacao = new System.Windows.Forms.TextBox();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblValeAlimentacao = new System.Windows.Forms.Label();
            this.gpbValeAlimentacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbValeAlimentacao
            // 
            this.gpbValeAlimentacao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbValeAlimentacao.Controls.Add(this.txtSalarioBase);
            this.gpbValeAlimentacao.Controls.Add(this.lblSalarioBase);
            this.gpbValeAlimentacao.Controls.Add(this.btnCancelar);
            this.gpbValeAlimentacao.Controls.Add(this.btnAvancar);
            this.gpbValeAlimentacao.Controls.Add(this.btnVoltar);
            this.gpbValeAlimentacao.Controls.Add(this.lblValor);
            this.gpbValeAlimentacao.Controls.Add(this.btnLimpar);
            this.gpbValeAlimentacao.Controls.Add(this.btnCalculcar);
            this.gpbValeAlimentacao.Controls.Add(this.txtRetorno);
            this.gpbValeAlimentacao.Controls.Add(this.txtPercentual);
            this.gpbValeAlimentacao.Controls.Add(this.txtDias);
            this.gpbValeAlimentacao.Controls.Add(this.txtValeAlimentacao);
            this.gpbValeAlimentacao.Controls.Add(this.lblPercentual);
            this.gpbValeAlimentacao.Controls.Add(this.lblDias);
            this.gpbValeAlimentacao.Controls.Add(this.lblValeAlimentacao);
            this.gpbValeAlimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbValeAlimentacao.Location = new System.Drawing.Point(12, 12);
            this.gpbValeAlimentacao.Name = "gpbValeAlimentacao";
            this.gpbValeAlimentacao.Size = new System.Drawing.Size(839, 349);
            this.gpbValeAlimentacao.TabIndex = 3;
            this.gpbValeAlimentacao.TabStop = false;
            this.gpbValeAlimentacao.Text = "Vale Alimentação";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.Color.LightBlue;
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSalarioBase.Location = new System.Drawing.Point(89, 32);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 21);
            this.txtSalarioBase.TabIndex = 30;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSalarioBase.Location = new System.Drawing.Point(6, 33);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(77, 15);
            this.lblSalarioBase.TabIndex = 29;
            this.lblSalarioBase.Text = "Salario Base";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(667, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAvancar.Location = new System.Drawing.Point(758, 313);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 30);
            this.btnAvancar.TabIndex = 27;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVoltar.Location = new System.Drawing.Point(574, 313);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 30);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblValor.Location = new System.Drawing.Point(6, 209);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(148, 15);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor do vale alimentação";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimpar.Location = new System.Drawing.Point(90, 167);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalculcar
            // 
            this.btnCalculcar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalculcar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalculcar.Location = new System.Drawing.Point(9, 167);
            this.btnCalculcar.Name = "btnCalculcar";
            this.btnCalculcar.Size = new System.Drawing.Size(75, 30);
            this.btnCalculcar.TabIndex = 9;
            this.btnCalculcar.Text = "Calcular";
            this.btnCalculcar.UseVisualStyleBackColor = false;
            this.btnCalculcar.Click += new System.EventHandler(this.btnCalculcar_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Enabled = false;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRetorno.Location = new System.Drawing.Point(160, 208);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(105, 21);
            this.txtRetorno.TabIndex = 8;
            // 
            // txtPercentual
            // 
            this.txtPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPercentual.Location = new System.Drawing.Point(78, 131);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(56, 21);
            this.txtPercentual.TabIndex = 7;
            this.txtPercentual.TextChanged += new System.EventHandler(this.txtPercentual_TextChanged);
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDias.Location = new System.Drawing.Point(73, 96);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(56, 21);
            this.txtDias.TabIndex = 6;
            // 
            // txtValeAlimentacao
            // 
            this.txtValeAlimentacao.BackColor = System.Drawing.SystemColors.Control;
            this.txtValeAlimentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValeAlimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValeAlimentacao.Location = new System.Drawing.Point(260, 61);
            this.txtValeAlimentacao.MaxLength = 6;
            this.txtValeAlimentacao.Name = "txtValeAlimentacao";
            this.txtValeAlimentacao.Size = new System.Drawing.Size(100, 21);
            this.txtValeAlimentacao.TabIndex = 5;
            this.txtValeAlimentacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeAlimentacao_KeyPress);
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPercentual.Location = new System.Drawing.Point(6, 133);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(66, 15);
            this.lblPercentual.TabIndex = 3;
            this.lblPercentual.Text = "Percentual";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblDias.Location = new System.Drawing.Point(6, 98);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(61, 15);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias uteis";
            // 
            // lblValeAlimentacao
            // 
            this.lblValeAlimentacao.AutoSize = true;
            this.lblValeAlimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblValeAlimentacao.Location = new System.Drawing.Point(6, 63);
            this.lblValeAlimentacao.Name = "lblValeAlimentacao";
            this.lblValeAlimentacao.Size = new System.Drawing.Size(248, 15);
            this.lblValeAlimentacao.TabIndex = 1;
            this.lblValeAlimentacao.Text = "Valor do vale refeição/alimentação diario R$";
            // 
            // Form_ValeAlimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(863, 373);
            this.Controls.Add(this.gpbValeAlimentacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ValeAlimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vale Alimentacao";
            this.gpbValeAlimentacao.ResumeLayout(false);
            this.gpbValeAlimentacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbValeAlimentacao;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblValeAlimentacao;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Button btnCalculcar;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtValeAlimentacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
    }
}