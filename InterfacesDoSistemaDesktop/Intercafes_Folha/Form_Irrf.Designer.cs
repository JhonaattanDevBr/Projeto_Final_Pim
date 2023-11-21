namespace InterfacesDoSistemaDesktop
{
    partial class Form_Irrf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Irrf));
            this.gpbIRRF = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbMensagem = new System.Windows.Forms.GroupBox();
            this.lblMensagemFormaDeCalculo = new System.Windows.Forms.Label();
            this.lblMensagemPorcentagem = new System.Windows.Forms.Label();
            this.lblMensagamFaixa = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.gpbIRRF.SuspendLayout();
            this.gpbMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIRRF
            // 
            this.gpbIRRF.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbIRRF.Controls.Add(this.btnCancelar);
            this.gpbIRRF.Controls.Add(this.btnAvancar);
            this.gpbIRRF.Controls.Add(this.btnVoltar);
            this.gpbIRRF.Controls.Add(this.gpbMensagem);
            this.gpbIRRF.Controls.Add(this.btnLimpar);
            this.gpbIRRF.Controls.Add(this.btnCalcular);
            this.gpbIRRF.Controls.Add(this.lblRetorno);
            this.gpbIRRF.Controls.Add(this.txtRetorno);
            this.gpbIRRF.Controls.Add(this.txtSalarioBase);
            this.gpbIRRF.Controls.Add(this.lblSalarioBase);
            this.gpbIRRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbIRRF.Location = new System.Drawing.Point(12, 12);
            this.gpbIRRF.Name = "gpbIRRF";
            this.gpbIRRF.Size = new System.Drawing.Size(839, 349);
            this.gpbIRRF.TabIndex = 1;
            this.gpbIRRF.TabStop = false;
            this.gpbIRRF.Text = "IRFF";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(667, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 46;
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
            this.btnAvancar.TabIndex = 45;
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
            this.btnVoltar.TabIndex = 44;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbMensagem
            // 
            this.gpbMensagem.BackColor = System.Drawing.Color.LightBlue;
            this.gpbMensagem.Controls.Add(this.lblMensagemFormaDeCalculo);
            this.gpbMensagem.Controls.Add(this.lblMensagemPorcentagem);
            this.gpbMensagem.Controls.Add(this.lblMensagamFaixa);
            this.gpbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gpbMensagem.Location = new System.Drawing.Point(9, 143);
            this.gpbMensagem.Name = "gpbMensagem";
            this.gpbMensagem.Size = new System.Drawing.Size(501, 134);
            this.gpbMensagem.TabIndex = 6;
            this.gpbMensagem.TabStop = false;
            this.gpbMensagem.Text = "Importante";
            this.gpbMensagem.Visible = false;
            // 
            // lblMensagemFormaDeCalculo
            // 
            this.lblMensagemFormaDeCalculo.AutoSize = true;
            this.lblMensagemFormaDeCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblMensagemFormaDeCalculo.Location = new System.Drawing.Point(6, 94);
            this.lblMensagemFormaDeCalculo.Name = "lblMensagemFormaDeCalculo";
            this.lblMensagemFormaDeCalculo.Size = new System.Drawing.Size(44, 16);
            this.lblMensagemFormaDeCalculo.TabIndex = 2;
            this.lblMensagemFormaDeCalculo.Text = "label1";
            this.lblMensagemFormaDeCalculo.Visible = false;
            // 
            // lblMensagemPorcentagem
            // 
            this.lblMensagemPorcentagem.AutoSize = true;
            this.lblMensagemPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblMensagemPorcentagem.Location = new System.Drawing.Point(6, 64);
            this.lblMensagemPorcentagem.Name = "lblMensagemPorcentagem";
            this.lblMensagemPorcentagem.Size = new System.Drawing.Size(44, 16);
            this.lblMensagemPorcentagem.TabIndex = 1;
            this.lblMensagemPorcentagem.Text = "label4";
            this.lblMensagemPorcentagem.Visible = false;
            // 
            // lblMensagamFaixa
            // 
            this.lblMensagamFaixa.AutoSize = true;
            this.lblMensagamFaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblMensagamFaixa.Location = new System.Drawing.Point(7, 35);
            this.lblMensagamFaixa.Name = "lblMensagamFaixa";
            this.lblMensagamFaixa.Size = new System.Drawing.Size(44, 16);
            this.lblMensagamFaixa.TabIndex = 0;
            this.lblMensagamFaixa.Text = "label3";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimpar.Location = new System.Drawing.Point(90, 66);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcular.Location = new System.Drawing.Point(9, 66);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRetorno.Location = new System.Drawing.Point(6, 108);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(204, 15);
            this.lblRetorno.TabIndex = 3;
            this.lblRetorno.Text = "Valor de desconto em folha do IRRF";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Enabled = false;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRetorno.Location = new System.Drawing.Point(216, 106);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(100, 21);
            this.txtRetorno.TabIndex = 2;
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
            this.lblSalarioBase.Location = new System.Drawing.Point(6, 32);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(76, 15);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "Salário base";
            // 
            // Form_Irrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(863, 373);
            this.Controls.Add(this.gpbIRRF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Irrf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Irrf";
            this.gpbIRRF.ResumeLayout(false);
            this.gpbIRRF.PerformLayout();
            this.gpbMensagem.ResumeLayout(false);
            this.gpbMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbIRRF;
        private System.Windows.Forms.GroupBox gpbMensagem;
        private System.Windows.Forms.Label lblMensagemPorcentagem;
        private System.Windows.Forms.Label lblMensagamFaixa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblMensagemFormaDeCalculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
    }
}