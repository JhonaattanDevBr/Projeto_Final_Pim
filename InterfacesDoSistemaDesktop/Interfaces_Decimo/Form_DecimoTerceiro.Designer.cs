namespace InterfacesDoSistemaDesktop
{
    partial class Form_DecimoTerceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DecimoTerceiro));
            this.gpbDecimoTerceiro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbCalcular = new System.Windows.Forms.GroupBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.gpbInssIrrf = new System.Windows.Forms.GroupBox();
            this.lblValorInss = new System.Windows.Forms.Label();
            this.lblValorIrrf = new System.Windows.Forms.Label();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.txtIrrf = new System.Windows.Forms.TextBox();
            this.rdbSemBeneficio = new System.Windows.Forms.RadioButton();
            this.rdbSegundaParcela = new System.Windows.Forms.RadioButton();
            this.rdbPrimeiraParcela = new System.Windows.Forms.RadioButton();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gpbDecimoTerceiro.SuspendLayout();
            this.gpbCalcular.SuspendLayout();
            this.gpbInssIrrf.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDecimoTerceiro
            // 
            this.gpbDecimoTerceiro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbDecimoTerceiro.Controls.Add(this.btnCancelar);
            this.gpbDecimoTerceiro.Controls.Add(this.btnAvancar);
            this.gpbDecimoTerceiro.Controls.Add(this.btnVoltar);
            this.gpbDecimoTerceiro.Controls.Add(this.gpbCalcular);
            this.gpbDecimoTerceiro.Controls.Add(this.gpbInssIrrf);
            this.gpbDecimoTerceiro.Controls.Add(this.rdbSemBeneficio);
            this.gpbDecimoTerceiro.Controls.Add(this.rdbSegundaParcela);
            this.gpbDecimoTerceiro.Controls.Add(this.rdbPrimeiraParcela);
            this.gpbDecimoTerceiro.Controls.Add(this.lblMensagem);
            this.gpbDecimoTerceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbDecimoTerceiro.Location = new System.Drawing.Point(12, 12);
            this.gpbDecimoTerceiro.Name = "gpbDecimoTerceiro";
            this.gpbDecimoTerceiro.Size = new System.Drawing.Size(839, 349);
            this.gpbDecimoTerceiro.TabIndex = 1;
            this.gpbDecimoTerceiro.TabStop = false;
            this.gpbDecimoTerceiro.Text = "Decimo terceiro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(667, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAvancar.Enabled = false;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAvancar.Location = new System.Drawing.Point(758, 313);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 30);
            this.btnAvancar.TabIndex = 48;
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
            this.btnVoltar.TabIndex = 47;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbCalcular
            // 
            this.gpbCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbCalcular.Controls.Add(this.lblSalarioBase);
            this.gpbCalcular.Controls.Add(this.txtSalarioBase);
            this.gpbCalcular.Controls.Add(this.btnCalcular);
            this.gpbCalcular.Controls.Add(this.lblMesesTrabalhados);
            this.gpbCalcular.Controls.Add(this.btnLimpar);
            this.gpbCalcular.Controls.Add(this.txtMesesTrabalhados);
            this.gpbCalcular.Controls.Add(this.txtRetorno);
            this.gpbCalcular.Controls.Add(this.lblRetorno);
            this.gpbCalcular.Location = new System.Drawing.Point(9, 105);
            this.gpbCalcular.Name = "gpbCalcular";
            this.gpbCalcular.Size = new System.Drawing.Size(317, 167);
            this.gpbCalcular.TabIndex = 27;
            this.gpbCalcular.TabStop = false;
            this.gpbCalcular.Text = "Calcular";
            this.gpbCalcular.Visible = false;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSalarioBase.Location = new System.Drawing.Point(6, 30);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(76, 15);
            this.lblSalarioBase.TabIndex = 16;
            this.lblSalarioBase.Text = "Salário base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.Color.LightBlue;
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSalarioBase.Location = new System.Drawing.Point(88, 28);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 21);
            this.txtSalarioBase.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcular.Location = new System.Drawing.Point(90, 92);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(6, 60);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(112, 15);
            this.lblMesesTrabalhados.TabIndex = 18;
            this.lblMesesTrabalhados.Text = "Meses trabalhados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimpar.Location = new System.Drawing.Point(9, 92);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Enabled = false;
            this.txtMesesTrabalhados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(124, 58);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.ReadOnly = true;
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(61, 21);
            this.txtMesesTrabalhados.TabIndex = 19;
            this.txtMesesTrabalhados.Text = "12";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Enabled = false;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRetorno.Location = new System.Drawing.Point(207, 133);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(100, 21);
            this.txtRetorno.TabIndex = 23;
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRetorno.Location = new System.Drawing.Point(6, 134);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(195, 15);
            this.lblRetorno.TabIndex = 22;
            this.lblRetorno.Text = "Valor a receber de décimo terceiro";
            // 
            // gpbInssIrrf
            // 
            this.gpbInssIrrf.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbInssIrrf.Controls.Add(this.lblValorInss);
            this.gpbInssIrrf.Controls.Add(this.lblValorIrrf);
            this.gpbInssIrrf.Controls.Add(this.txtInss);
            this.gpbInssIrrf.Controls.Add(this.txtIrrf);
            this.gpbInssIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbInssIrrf.Location = new System.Drawing.Point(372, 105);
            this.gpbInssIrrf.Name = "gpbInssIrrf";
            this.gpbInssIrrf.Size = new System.Drawing.Size(200, 100);
            this.gpbInssIrrf.TabIndex = 26;
            this.gpbInssIrrf.TabStop = false;
            this.gpbInssIrrf.Text = "Informe o INSS e IRRF";
            this.gpbInssIrrf.Visible = false;
            // 
            // lblValorInss
            // 
            this.lblValorInss.AutoSize = true;
            this.lblValorInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblValorInss.Location = new System.Drawing.Point(6, 30);
            this.lblValorInss.Name = "lblValorInss";
            this.lblValorInss.Size = new System.Drawing.Size(83, 15);
            this.lblValorInss.TabIndex = 7;
            this.lblValorInss.Text = "Valor do INSS";
            // 
            // lblValorIrrf
            // 
            this.lblValorIrrf.AutoSize = true;
            this.lblValorIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblValorIrrf.Location = new System.Drawing.Point(6, 64);
            this.lblValorIrrf.Name = "lblValorIrrf";
            this.lblValorIrrf.Size = new System.Drawing.Size(83, 15);
            this.lblValorIrrf.TabIndex = 8;
            this.lblValorIrrf.Text = "Valor do IRRF";
            // 
            // txtInss
            // 
            this.txtInss.Enabled = false;
            this.txtInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtInss.Location = new System.Drawing.Point(95, 28);
            this.txtInss.Name = "txtInss";
            this.txtInss.ReadOnly = true;
            this.txtInss.Size = new System.Drawing.Size(100, 21);
            this.txtInss.TabIndex = 9;
            // 
            // txtIrrf
            // 
            this.txtIrrf.Enabled = false;
            this.txtIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIrrf.Location = new System.Drawing.Point(95, 61);
            this.txtIrrf.Name = "txtIrrf";
            this.txtIrrf.ReadOnly = true;
            this.txtIrrf.Size = new System.Drawing.Size(100, 21);
            this.txtIrrf.TabIndex = 10;
            // 
            // rdbSemBeneficio
            // 
            this.rdbSemBeneficio.AutoSize = true;
            this.rdbSemBeneficio.Checked = true;
            this.rdbSemBeneficio.Location = new System.Drawing.Point(6, 67);
            this.rdbSemBeneficio.Name = "rdbSemBeneficio";
            this.rdbSemBeneficio.Size = new System.Drawing.Size(128, 21);
            this.rdbSemBeneficio.TabIndex = 4;
            this.rdbSemBeneficio.TabStop = true;
            this.rdbSemBeneficio.Text = "Sem benefício";
            this.rdbSemBeneficio.UseVisualStyleBackColor = true;
            this.rdbSemBeneficio.CheckedChanged += new System.EventHandler(this.rdbSemBeneficio_CheckedChanged);
            // 
            // rdbSegundaParcela
            // 
            this.rdbSegundaParcela.AutoSize = true;
            this.rdbSegundaParcela.Location = new System.Drawing.Point(291, 67);
            this.rdbSegundaParcela.Name = "rdbSegundaParcela";
            this.rdbSegundaParcela.Size = new System.Drawing.Size(149, 21);
            this.rdbSegundaParcela.TabIndex = 3;
            this.rdbSegundaParcela.Text = "Segunda parcela";
            this.rdbSegundaParcela.UseVisualStyleBackColor = true;
            this.rdbSegundaParcela.CheckedChanged += new System.EventHandler(this.rdbSegundaParcela_CheckedChanged);
            // 
            // rdbPrimeiraParcela
            // 
            this.rdbPrimeiraParcela.AutoSize = true;
            this.rdbPrimeiraParcela.Location = new System.Drawing.Point(140, 67);
            this.rdbPrimeiraParcela.Name = "rdbPrimeiraParcela";
            this.rdbPrimeiraParcela.Size = new System.Drawing.Size(145, 21);
            this.rdbPrimeiraParcela.TabIndex = 2;
            this.rdbPrimeiraParcela.Text = "Primeira parcela";
            this.rdbPrimeiraParcela.UseVisualStyleBackColor = true;
            this.rdbPrimeiraParcela.CheckedChanged += new System.EventHandler(this.rdbPrimeiraParcela_CheckedChanged);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMensagem.Location = new System.Drawing.Point(6, 34);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(527, 15);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "O funcionário ira receber o beneficio do décimo terceiro? Se sim informe qual mod" +
    "o  de calculo";
            // 
            // Form_DecimoTerceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(863, 373);
            this.Controls.Add(this.gpbDecimoTerceiro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_DecimoTerceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decimo Terceiro";
            this.gpbDecimoTerceiro.ResumeLayout(false);
            this.gpbDecimoTerceiro.PerformLayout();
            this.gpbCalcular.ResumeLayout(false);
            this.gpbCalcular.PerformLayout();
            this.gpbInssIrrf.ResumeLayout(false);
            this.gpbInssIrrf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbDecimoTerceiro;
        private System.Windows.Forms.RadioButton rdbSemBeneficio;
        private System.Windows.Forms.RadioButton rdbSegundaParcela;
        private System.Windows.Forms.RadioButton rdbPrimeiraParcela;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox gpbInssIrrf;
        private System.Windows.Forms.Label lblValorInss;
        private System.Windows.Forms.Label lblValorIrrf;
        private System.Windows.Forms.TextBox txtInss;
        private System.Windows.Forms.TextBox txtIrrf;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.GroupBox gpbCalcular;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
    }
}