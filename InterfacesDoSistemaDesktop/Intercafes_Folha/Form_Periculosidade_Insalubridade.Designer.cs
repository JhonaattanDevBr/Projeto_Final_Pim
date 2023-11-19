namespace InterfacesDoSistemaDesktop
{
    partial class Form_Periculosidade_Insalubridade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Periculosidade_Insalubridade));
            this.gpbPericulosidadeInsalubridade = new System.Windows.Forms.GroupBox();
            this.gpbPericulosidade = new System.Windows.Forms.GroupBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtRetornoPericulosidade = new System.Windows.Forms.TextBox();
            this.lblRetornoPericulosidade = new System.Windows.Forms.Label();
            this.btnCalcularPericulosidade = new System.Windows.Forms.Button();
            this.btnLimparPericulosidade = new System.Windows.Forms.Button();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.gpbInsalubridade = new System.Windows.Forms.GroupBox();
            this.txtRetornoInsalubridade = new System.Windows.Forms.TextBox();
            this.lblRetornoInsalubridade = new System.Windows.Forms.Label();
            this.btnCalcularInsalubridade = new System.Windows.Forms.Button();
            this.btnLimparInsalubridade = new System.Windows.Forms.Button();
            this.rdbGrauGrave = new System.Windows.Forms.RadioButton();
            this.rdbGrauMedio = new System.Windows.Forms.RadioButton();
            this.rdbGrauLeve = new System.Windows.Forms.RadioButton();
            this.lblMensagemGrau = new System.Windows.Forms.Label();
            this.lblMensagemUm = new System.Windows.Forms.Label();
            this.rdbPericulosidade = new System.Windows.Forms.RadioButton();
            this.rdbInsalubridade = new System.Windows.Forms.RadioButton();
            this.lblBeneficio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbPericulosidadeInsalubridade.SuspendLayout();
            this.gpbPericulosidade.SuspendLayout();
            this.gpbInsalubridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPericulosidadeInsalubridade
            // 
            this.gpbPericulosidadeInsalubridade.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.btnCancelar);
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.btnAvancar);
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.btnVoltar);
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.gpbPericulosidade);
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.gpbInsalubridade);
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.rdbPericulosidade);
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.rdbInsalubridade);
            this.gpbPericulosidadeInsalubridade.Controls.Add(this.lblBeneficio);
            this.gpbPericulosidadeInsalubridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbPericulosidadeInsalubridade.Location = new System.Drawing.Point(12, 12);
            this.gpbPericulosidadeInsalubridade.Name = "gpbPericulosidadeInsalubridade";
            this.gpbPericulosidadeInsalubridade.Size = new System.Drawing.Size(839, 349);
            this.gpbPericulosidadeInsalubridade.TabIndex = 1;
            this.gpbPericulosidadeInsalubridade.TabStop = false;
            this.gpbPericulosidadeInsalubridade.Text = "Insalubridade e periculosidade";
            // 
            // gpbPericulosidade
            // 
            this.gpbPericulosidade.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbPericulosidade.Controls.Add(this.lblMensagem);
            this.gpbPericulosidade.Controls.Add(this.txtRetornoPericulosidade);
            this.gpbPericulosidade.Controls.Add(this.lblRetornoPericulosidade);
            this.gpbPericulosidade.Controls.Add(this.btnCalcularPericulosidade);
            this.gpbPericulosidade.Controls.Add(this.btnLimparPericulosidade);
            this.gpbPericulosidade.Controls.Add(this.txtSalarioBase);
            this.gpbPericulosidade.Controls.Add(this.lblSalarioBase);
            this.gpbPericulosidade.Location = new System.Drawing.Point(406, 58);
            this.gpbPericulosidade.Name = "gpbPericulosidade";
            this.gpbPericulosidade.Size = new System.Drawing.Size(427, 241);
            this.gpbPericulosidade.TabIndex = 4;
            this.gpbPericulosidade.TabStop = false;
            this.gpbPericulosidade.Text = "Periculosidade";
            this.gpbPericulosidade.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMensagem.Location = new System.Drawing.Point(6, 28);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(408, 15);
            this.lblMensagem.TabIndex = 6;
            this.lblMensagem.Text = "O cálculo de periculosidade é aplicado acrescentado 30% sobre o sálario";
            // 
            // txtRetornoPericulosidade
            // 
            this.txtRetornoPericulosidade.Enabled = false;
            this.txtRetornoPericulosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRetornoPericulosidade.Location = new System.Drawing.Point(203, 130);
            this.txtRetornoPericulosidade.Name = "txtRetornoPericulosidade";
            this.txtRetornoPericulosidade.ReadOnly = true;
            this.txtRetornoPericulosidade.Size = new System.Drawing.Size(100, 21);
            this.txtRetornoPericulosidade.TabIndex = 5;
            // 
            // lblRetornoPericulosidade
            // 
            this.lblRetornoPericulosidade.AutoSize = true;
            this.lblRetornoPericulosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRetornoPericulosidade.Location = new System.Drawing.Point(6, 133);
            this.lblRetornoPericulosidade.Name = "lblRetornoPericulosidade";
            this.lblRetornoPericulosidade.Size = new System.Drawing.Size(191, 15);
            this.lblRetornoPericulosidade.TabIndex = 4;
            this.lblRetornoPericulosidade.Text = "Valor a receber de periculosidade";
            // 
            // btnCalcularPericulosidade
            // 
            this.btnCalcularPericulosidade.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcularPericulosidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularPericulosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcularPericulosidade.Location = new System.Drawing.Point(90, 87);
            this.btnCalcularPericulosidade.Name = "btnCalcularPericulosidade";
            this.btnCalcularPericulosidade.Size = new System.Drawing.Size(75, 30);
            this.btnCalcularPericulosidade.TabIndex = 3;
            this.btnCalcularPericulosidade.Text = "Calcular";
            this.btnCalcularPericulosidade.UseVisualStyleBackColor = false;
            this.btnCalcularPericulosidade.Click += new System.EventHandler(this.btnCalcularPericulosidade_Click);
            // 
            // btnLimparPericulosidade
            // 
            this.btnLimparPericulosidade.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimparPericulosidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparPericulosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimparPericulosidade.Location = new System.Drawing.Point(9, 87);
            this.btnLimparPericulosidade.Name = "btnLimparPericulosidade";
            this.btnLimparPericulosidade.Size = new System.Drawing.Size(75, 30);
            this.btnLimparPericulosidade.TabIndex = 2;
            this.btnLimparPericulosidade.Text = "Limpar";
            this.btnLimparPericulosidade.UseVisualStyleBackColor = false;
            this.btnLimparPericulosidade.Click += new System.EventHandler(this.btnLimparPericulosidade_Click);
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.Color.LightBlue;
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSalarioBase.Location = new System.Drawing.Point(88, 52);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 21);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSalarioBase.Location = new System.Drawing.Point(6, 55);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(76, 15);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "Salário base";
            // 
            // gpbInsalubridade
            // 
            this.gpbInsalubridade.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbInsalubridade.Controls.Add(this.txtRetornoInsalubridade);
            this.gpbInsalubridade.Controls.Add(this.lblRetornoInsalubridade);
            this.gpbInsalubridade.Controls.Add(this.btnCalcularInsalubridade);
            this.gpbInsalubridade.Controls.Add(this.btnLimparInsalubridade);
            this.gpbInsalubridade.Controls.Add(this.rdbGrauGrave);
            this.gpbInsalubridade.Controls.Add(this.rdbGrauMedio);
            this.gpbInsalubridade.Controls.Add(this.rdbGrauLeve);
            this.gpbInsalubridade.Controls.Add(this.lblMensagemGrau);
            this.gpbInsalubridade.Controls.Add(this.lblMensagemUm);
            this.gpbInsalubridade.Location = new System.Drawing.Point(6, 58);
            this.gpbInsalubridade.Name = "gpbInsalubridade";
            this.gpbInsalubridade.Size = new System.Drawing.Size(394, 241);
            this.gpbInsalubridade.TabIndex = 3;
            this.gpbInsalubridade.TabStop = false;
            this.gpbInsalubridade.Text = "Insalubridade";
            // 
            // txtRetornoInsalubridade
            // 
            this.txtRetornoInsalubridade.Enabled = false;
            this.txtRetornoInsalubridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRetornoInsalubridade.Location = new System.Drawing.Point(197, 205);
            this.txtRetornoInsalubridade.Name = "txtRetornoInsalubridade";
            this.txtRetornoInsalubridade.ReadOnly = true;
            this.txtRetornoInsalubridade.Size = new System.Drawing.Size(100, 21);
            this.txtRetornoInsalubridade.TabIndex = 8;
            // 
            // lblRetornoInsalubridade
            // 
            this.lblRetornoInsalubridade.AutoSize = true;
            this.lblRetornoInsalubridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRetornoInsalubridade.Location = new System.Drawing.Point(6, 210);
            this.lblRetornoInsalubridade.Name = "lblRetornoInsalubridade";
            this.lblRetornoInsalubridade.Size = new System.Drawing.Size(185, 15);
            this.lblRetornoInsalubridade.TabIndex = 7;
            this.lblRetornoInsalubridade.Text = "Valor a receber de insalubridade";
            // 
            // btnCalcularInsalubridade
            // 
            this.btnCalcularInsalubridade.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcularInsalubridade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularInsalubridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcularInsalubridade.Location = new System.Drawing.Point(90, 167);
            this.btnCalcularInsalubridade.Name = "btnCalcularInsalubridade";
            this.btnCalcularInsalubridade.Size = new System.Drawing.Size(75, 30);
            this.btnCalcularInsalubridade.TabIndex = 6;
            this.btnCalcularInsalubridade.Text = "Calcular";
            this.btnCalcularInsalubridade.UseVisualStyleBackColor = false;
            this.btnCalcularInsalubridade.Click += new System.EventHandler(this.btnCalcularInsalubridade_Click);
            // 
            // btnLimparInsalubridade
            // 
            this.btnLimparInsalubridade.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimparInsalubridade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparInsalubridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimparInsalubridade.Location = new System.Drawing.Point(9, 167);
            this.btnLimparInsalubridade.Name = "btnLimparInsalubridade";
            this.btnLimparInsalubridade.Size = new System.Drawing.Size(75, 30);
            this.btnLimparInsalubridade.TabIndex = 5;
            this.btnLimparInsalubridade.Text = "Limpar";
            this.btnLimparInsalubridade.UseVisualStyleBackColor = false;
            this.btnLimparInsalubridade.Click += new System.EventHandler(this.btnLimparInsalubridade_Click);
            // 
            // rdbGrauGrave
            // 
            this.rdbGrauGrave.AutoSize = true;
            this.rdbGrauGrave.Location = new System.Drawing.Point(9, 139);
            this.rdbGrauGrave.Name = "rdbGrauGrave";
            this.rdbGrauGrave.Size = new System.Drawing.Size(106, 21);
            this.rdbGrauGrave.TabIndex = 4;
            this.rdbGrauGrave.Text = "Gráve 40%";
            this.rdbGrauGrave.UseVisualStyleBackColor = true;
            // 
            // rdbGrauMedio
            // 
            this.rdbGrauMedio.AutoSize = true;
            this.rdbGrauMedio.Location = new System.Drawing.Point(9, 111);
            this.rdbGrauMedio.Name = "rdbGrauMedio";
            this.rdbGrauMedio.Size = new System.Drawing.Size(105, 21);
            this.rdbGrauMedio.TabIndex = 3;
            this.rdbGrauMedio.Text = "Médio 20%";
            this.rdbGrauMedio.UseVisualStyleBackColor = true;
            // 
            // rdbGrauLeve
            // 
            this.rdbGrauLeve.AutoSize = true;
            this.rdbGrauLeve.Checked = true;
            this.rdbGrauLeve.Location = new System.Drawing.Point(9, 83);
            this.rdbGrauLeve.Name = "rdbGrauLeve";
            this.rdbGrauLeve.Size = new System.Drawing.Size(97, 21);
            this.rdbGrauLeve.TabIndex = 2;
            this.rdbGrauLeve.TabStop = true;
            this.rdbGrauLeve.Text = "Leve 10%";
            this.rdbGrauLeve.UseVisualStyleBackColor = true;
            // 
            // lblMensagemGrau
            // 
            this.lblMensagemGrau.AutoSize = true;
            this.lblMensagemGrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMensagemGrau.Location = new System.Drawing.Point(6, 55);
            this.lblMensagemGrau.Name = "lblMensagemGrau";
            this.lblMensagemGrau.Size = new System.Drawing.Size(182, 15);
            this.lblMensagemGrau.TabIndex = 1;
            this.lblMensagemGrau.Text = "Informe o grau de insalubridade";
            // 
            // lblMensagemUm
            // 
            this.lblMensagemUm.AutoSize = true;
            this.lblMensagemUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMensagemUm.Location = new System.Drawing.Point(6, 28);
            this.lblMensagemUm.Name = "lblMensagemUm";
            this.lblMensagemUm.Size = new System.Drawing.Size(342, 15);
            this.lblMensagemUm.TabIndex = 0;
            this.lblMensagemUm.Text = "O cálculo de insalubridade é aplicado sobre o sálario mínimo";
            // 
            // rdbPericulosidade
            // 
            this.rdbPericulosidade.AutoSize = true;
            this.rdbPericulosidade.Location = new System.Drawing.Point(267, 31);
            this.rdbPericulosidade.Name = "rdbPericulosidade";
            this.rdbPericulosidade.Size = new System.Drawing.Size(133, 21);
            this.rdbPericulosidade.TabIndex = 2;
            this.rdbPericulosidade.Text = "Periculosidade";
            this.rdbPericulosidade.UseVisualStyleBackColor = true;
            // 
            // rdbInsalubridade
            // 
            this.rdbInsalubridade.AutoSize = true;
            this.rdbInsalubridade.Checked = true;
            this.rdbInsalubridade.Location = new System.Drawing.Point(137, 31);
            this.rdbInsalubridade.Name = "rdbInsalubridade";
            this.rdbInsalubridade.Size = new System.Drawing.Size(124, 21);
            this.rdbInsalubridade.TabIndex = 1;
            this.rdbInsalubridade.TabStop = true;
            this.rdbInsalubridade.Text = "Insalubridade";
            this.rdbInsalubridade.UseVisualStyleBackColor = true;
            this.rdbInsalubridade.CheckedChanged += new System.EventHandler(this.rdbInsalubridade_CheckedChanged);
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.AutoSize = true;
            this.lblBeneficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblBeneficio.Location = new System.Drawing.Point(6, 34);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(125, 15);
            this.lblBeneficio.TabIndex = 0;
            this.lblBeneficio.Text = "Selecione o benefício";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(667, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 16;
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
            this.btnAvancar.TabIndex = 15;
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
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form_Periculosidade_Insalubridade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(863, 373);
            this.Controls.Add(this.gpbPericulosidadeInsalubridade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Periculosidade_Insalubridade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insalubridade e Periculosidade";
            this.gpbPericulosidadeInsalubridade.ResumeLayout(false);
            this.gpbPericulosidadeInsalubridade.PerformLayout();
            this.gpbPericulosidade.ResumeLayout(false);
            this.gpbPericulosidade.PerformLayout();
            this.gpbInsalubridade.ResumeLayout(false);
            this.gpbInsalubridade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbPericulosidadeInsalubridade;
        private System.Windows.Forms.Label lblBeneficio;
        private System.Windows.Forms.GroupBox gpbPericulosidade;
        private System.Windows.Forms.GroupBox gpbInsalubridade;
        private System.Windows.Forms.RadioButton rdbPericulosidade;
        private System.Windows.Forms.RadioButton rdbInsalubridade;
        private System.Windows.Forms.TextBox txtRetornoPericulosidade;
        private System.Windows.Forms.Label lblRetornoPericulosidade;
        private System.Windows.Forms.Button btnCalcularPericulosidade;
        private System.Windows.Forms.Button btnLimparPericulosidade;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblMensagemUm;
        private System.Windows.Forms.RadioButton rdbGrauGrave;
        private System.Windows.Forms.RadioButton rdbGrauMedio;
        private System.Windows.Forms.RadioButton rdbGrauLeve;
        private System.Windows.Forms.Label lblMensagemGrau;
        private System.Windows.Forms.TextBox txtRetornoInsalubridade;
        private System.Windows.Forms.Label lblRetornoInsalubridade;
        private System.Windows.Forms.Button btnCalcularInsalubridade;
        private System.Windows.Forms.Button btnLimparInsalubridade;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
    }
}