namespace InterfacesDoSistemaDesktop
{
    partial class Form_AdiantamentoQuinzenal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdiantamentoQuinzenal));
            this.gpbAdiantamento = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.gpbAdiantamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAdiantamento
            // 
            this.gpbAdiantamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbAdiantamento.Controls.Add(this.btnCancelar);
            this.gpbAdiantamento.Controls.Add(this.txtRetorno);
            this.gpbAdiantamento.Controls.Add(this.btnAvancar);
            this.gpbAdiantamento.Controls.Add(this.lblValor);
            this.gpbAdiantamento.Controls.Add(this.btnLimpar);
            this.gpbAdiantamento.Controls.Add(this.btnCalcular);
            this.gpbAdiantamento.Controls.Add(this.txtSalarioBase);
            this.gpbAdiantamento.Controls.Add(this.lblSalarioBase);
            this.gpbAdiantamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbAdiantamento.Location = new System.Drawing.Point(12, 12);
            this.gpbAdiantamento.Name = "gpbAdiantamento";
            this.gpbAdiantamento.Size = new System.Drawing.Size(754, 263);
            this.gpbAdiantamento.TabIndex = 0;
            this.gpbAdiantamento.TabStop = false;
            this.gpbAdiantamento.Text = "Adiantamento quinzenal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(582, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Enabled = false;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRetorno.Location = new System.Drawing.Point(143, 106);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(100, 21);
            this.txtRetorno.TabIndex = 5;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAvancar.Location = new System.Drawing.Point(673, 227);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 30);
            this.btnAvancar.TabIndex = 1;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblValor.Location = new System.Drawing.Point(6, 109);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(131, 15);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor do adiantamento";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimpar.Location = new System.Drawing.Point(90, 65);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcular.Location = new System.Drawing.Point(9, 65);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.Color.LightBlue;
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSalarioBase.Location = new System.Drawing.Point(88, 31);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 21);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSalarioBase.Location = new System.Drawing.Point(6, 34);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(76, 15);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "Salário base";
            // 
            // Form_AdiantamentoQuinzenal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(778, 287);
            this.Controls.Add(this.gpbAdiantamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AdiantamentoQuinzenal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adiantamento Quinzenal";
            this.Load += new System.EventHandler(this.Form_AdiantamentoQuinzenal_Load);
            this.gpbAdiantamento.ResumeLayout(false);
            this.gpbAdiantamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAdiantamento;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCancelar;
    }
}