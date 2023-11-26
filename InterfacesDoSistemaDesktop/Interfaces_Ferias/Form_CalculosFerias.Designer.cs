namespace InterfacesDoSistemaDesktop
{
    partial class Form_CalculosFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CalculosFerias));
            this.gpbCalculoFerias = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbVendaDasFerias = new System.Windows.Forms.GroupBox();
            this.btnCalcularAbono = new System.Windows.Forms.Button();
            this.txtAbonoPecuniario = new System.Windows.Forms.TextBox();
            this.txtDiasVendidos = new System.Windows.Forms.TextBox();
            this.lblDiasVendidos = new System.Windows.Forms.Label();
            this.lblPerguntaVendaDasFerias = new System.Windows.Forms.Label();
            this.txtDiasPrimeiroPeriodo = new System.Windows.Forms.TextBox();
            this.txtMesPrimeiroPeriodo = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.gpbCalculoFerias.SuspendLayout();
            this.gpbVendaDasFerias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCalculoFerias
            // 
            this.gpbCalculoFerias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbCalculoFerias.Controls.Add(this.btnCancelar);
            this.gpbCalculoFerias.Controls.Add(this.btnAvancar);
            this.gpbCalculoFerias.Controls.Add(this.btnVoltar);
            this.gpbCalculoFerias.Controls.Add(this.txtRetorno);
            this.gpbCalculoFerias.Controls.Add(this.lblRetorno);
            this.gpbCalculoFerias.Controls.Add(this.btnCalcular);
            this.gpbCalculoFerias.Controls.Add(this.btnLimpar);
            this.gpbCalculoFerias.Controls.Add(this.gpbVendaDasFerias);
            this.gpbCalculoFerias.Controls.Add(this.lblPerguntaVendaDasFerias);
            this.gpbCalculoFerias.Controls.Add(this.txtDiasPrimeiroPeriodo);
            this.gpbCalculoFerias.Controls.Add(this.txtMesPrimeiroPeriodo);
            this.gpbCalculoFerias.Controls.Add(this.txtSalarioBase);
            this.gpbCalculoFerias.Controls.Add(this.lblDias);
            this.gpbCalculoFerias.Controls.Add(this.lblMes);
            this.gpbCalculoFerias.Controls.Add(this.lblSalarioBase);
            this.gpbCalculoFerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbCalculoFerias.Location = new System.Drawing.Point(12, 12);
            this.gpbCalculoFerias.Name = "gpbCalculoFerias";
            this.gpbCalculoFerias.Size = new System.Drawing.Size(839, 349);
            this.gpbCalculoFerias.TabIndex = 1;
            this.gpbCalculoFerias.TabStop = false;
            this.gpbCalculoFerias.Text = "Calculo das férias";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(667, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 52;
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
            this.btnAvancar.TabIndex = 51;
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
            this.btnVoltar.TabIndex = 50;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Enabled = false;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetorno.Location = new System.Drawing.Point(152, 182);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(100, 21);
            this.txtRetorno.TabIndex = 21;
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRetorno.Location = new System.Drawing.Point(6, 184);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(140, 15);
            this.lblRetorno.TabIndex = 20;
            this.lblRetorno.Text = "Valor a receber de férias";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcular.Location = new System.Drawing.Point(90, 140);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimpar.Location = new System.Drawing.Point(9, 140);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpbVendaDasFerias
            // 
            this.gpbVendaDasFerias.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbVendaDasFerias.Controls.Add(this.btnCalcularAbono);
            this.gpbVendaDasFerias.Controls.Add(this.txtAbonoPecuniario);
            this.gpbVendaDasFerias.Controls.Add(this.txtDiasVendidos);
            this.gpbVendaDasFerias.Controls.Add(this.lblDiasVendidos);
            this.gpbVendaDasFerias.Location = new System.Drawing.Point(290, 47);
            this.gpbVendaDasFerias.Name = "gpbVendaDasFerias";
            this.gpbVendaDasFerias.Size = new System.Drawing.Size(242, 93);
            this.gpbVendaDasFerias.TabIndex = 17;
            this.gpbVendaDasFerias.TabStop = false;
            this.gpbVendaDasFerias.Text = "Venda das férias";
            // 
            // btnCalcularAbono
            // 
            this.btnCalcularAbono.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcularAbono.Enabled = false;
            this.btnCalcularAbono.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcularAbono.Location = new System.Drawing.Point(10, 51);
            this.btnCalcularAbono.Name = "btnCalcularAbono";
            this.btnCalcularAbono.Size = new System.Drawing.Size(109, 30);
            this.btnCalcularAbono.TabIndex = 4;
            this.btnCalcularAbono.Text = "Calcular abono";
            this.btnCalcularAbono.UseVisualStyleBackColor = false;
            this.btnCalcularAbono.Click += new System.EventHandler(this.btnCalcularAbono_Click);
            // 
            // txtAbonoPecuniario
            // 
            this.txtAbonoPecuniario.Enabled = false;
            this.txtAbonoPecuniario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAbonoPecuniario.Location = new System.Drawing.Point(129, 56);
            this.txtAbonoPecuniario.Name = "txtAbonoPecuniario";
            this.txtAbonoPecuniario.Size = new System.Drawing.Size(100, 21);
            this.txtAbonoPecuniario.TabIndex = 3;
            // 
            // txtDiasVendidos
            // 
            this.txtDiasVendidos.Enabled = false;
            this.txtDiasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtDiasVendidos.Location = new System.Drawing.Point(98, 22);
            this.txtDiasVendidos.Name = "txtDiasVendidos";
            this.txtDiasVendidos.ReadOnly = true;
            this.txtDiasVendidos.Size = new System.Drawing.Size(57, 20);
            this.txtDiasVendidos.TabIndex = 2;
            // 
            // lblDiasVendidos
            // 
            this.lblDiasVendidos.AutoSize = true;
            this.lblDiasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblDiasVendidos.Location = new System.Drawing.Point(7, 23);
            this.lblDiasVendidos.Name = "lblDiasVendidos";
            this.lblDiasVendidos.Size = new System.Drawing.Size(84, 15);
            this.lblDiasVendidos.TabIndex = 0;
            this.lblDiasVendidos.Text = "Dias vendidos";
            // 
            // lblPerguntaVendaDasFerias
            // 
            this.lblPerguntaVendaDasFerias.AutoSize = true;
            this.lblPerguntaVendaDasFerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPerguntaVendaDasFerias.Location = new System.Drawing.Point(287, 19);
            this.lblPerguntaVendaDasFerias.Name = "lblPerguntaVendaDasFerias";
            this.lblPerguntaVendaDasFerias.Size = new System.Drawing.Size(415, 15);
            this.lblPerguntaVendaDasFerias.TabIndex = 14;
            this.lblPerguntaVendaDasFerias.Text = "Clique em calcular abono caso o funcionário tenha feito a venda des férias.";
            // 
            // txtDiasPrimeiroPeriodo
            // 
            this.txtDiasPrimeiroPeriodo.Enabled = false;
            this.txtDiasPrimeiroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDiasPrimeiroPeriodo.Location = new System.Drawing.Point(43, 104);
            this.txtDiasPrimeiroPeriodo.Name = "txtDiasPrimeiroPeriodo";
            this.txtDiasPrimeiroPeriodo.ReadOnly = true;
            this.txtDiasPrimeiroPeriodo.Size = new System.Drawing.Size(57, 21);
            this.txtDiasPrimeiroPeriodo.TabIndex = 5;
            // 
            // txtMesPrimeiroPeriodo
            // 
            this.txtMesPrimeiroPeriodo.Enabled = false;
            this.txtMesPrimeiroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMesPrimeiroPeriodo.Location = new System.Drawing.Point(43, 69);
            this.txtMesPrimeiroPeriodo.Name = "txtMesPrimeiroPeriodo";
            this.txtMesPrimeiroPeriodo.ReadOnly = true;
            this.txtMesPrimeiroPeriodo.Size = new System.Drawing.Size(109, 21);
            this.txtMesPrimeiroPeriodo.TabIndex = 4;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.Color.LightBlue;
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(88, 34);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 21);
            this.txtSalarioBase.TabIndex = 3;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblDias.Location = new System.Drawing.Point(5, 105);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(32, 15);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMes.Location = new System.Drawing.Point(6, 69);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(31, 15);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mês";
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
            // Form_CalculosFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(863, 373);
            this.Controls.Add(this.gpbCalculoFerias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CalculosFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Férias";
            this.gpbCalculoFerias.ResumeLayout(false);
            this.gpbCalculoFerias.PerformLayout();
            this.gpbVendaDasFerias.ResumeLayout(false);
            this.gpbVendaDasFerias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCalculoFerias;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDiasPrimeiroPeriodo;
        private System.Windows.Forms.TextBox txtMesPrimeiroPeriodo;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.GroupBox gpbVendaDasFerias;
        private System.Windows.Forms.TextBox txtAbonoPecuniario;
        private System.Windows.Forms.TextBox txtDiasVendidos;
        private System.Windows.Forms.Label lblDiasVendidos;
        private System.Windows.Forms.Label lblPerguntaVendaDasFerias;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcularAbono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
    }
}