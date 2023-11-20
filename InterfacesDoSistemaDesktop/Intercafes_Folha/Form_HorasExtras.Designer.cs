namespace InterfacesDoSistemaDesktop
{
    partial class Form_HorasExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HorasExtras));
            this.gpbHorasExtras = new System.Windows.Forms.GroupBox();
            this.txtTotalHorasConvertidas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbPorcentagem = new System.Windows.Forms.GroupBox();
            this.rdbCem = new System.Windows.Forms.RadioButton();
            this.rdbCinquenta = new System.Windows.Forms.RadioButton();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.lblTotalHoras = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.gpbHorasExtras.SuspendLayout();
            this.gpbPorcentagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbHorasExtras
            // 
            this.gpbHorasExtras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbHorasExtras.Controls.Add(this.txtTotalHorasConvertidas);
            this.gpbHorasExtras.Controls.Add(this.label1);
            this.gpbHorasExtras.Controls.Add(this.btnCancelar);
            this.gpbHorasExtras.Controls.Add(this.btnAvancar);
            this.gpbHorasExtras.Controls.Add(this.btnVoltar);
            this.gpbHorasExtras.Controls.Add(this.gpbPorcentagem);
            this.gpbHorasExtras.Controls.Add(this.btnLimpar);
            this.gpbHorasExtras.Controls.Add(this.btnCalcular);
            this.gpbHorasExtras.Controls.Add(this.lblRetorno);
            this.gpbHorasExtras.Controls.Add(this.txtRetorno);
            this.gpbHorasExtras.Controls.Add(this.txtTotalHoras);
            this.gpbHorasExtras.Controls.Add(this.lblTotalHoras);
            this.gpbHorasExtras.Controls.Add(this.txtSalarioBase);
            this.gpbHorasExtras.Controls.Add(this.lblSalarioBase);
            this.gpbHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbHorasExtras.Location = new System.Drawing.Point(12, 12);
            this.gpbHorasExtras.Name = "gpbHorasExtras";
            this.gpbHorasExtras.Size = new System.Drawing.Size(839, 349);
            this.gpbHorasExtras.TabIndex = 1;
            this.gpbHorasExtras.TabStop = false;
            this.gpbHorasExtras.Text = "Horas extras";
            // 
            // txtTotalHorasConvertidas
            // 
            this.txtTotalHorasConvertidas.Enabled = false;
            this.txtTotalHorasConvertidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHorasConvertidas.Location = new System.Drawing.Point(162, 101);
            this.txtTotalHorasConvertidas.Name = "txtTotalHorasConvertidas";
            this.txtTotalHorasConvertidas.ReadOnly = true;
            this.txtTotalHorasConvertidas.Size = new System.Drawing.Size(100, 21);
            this.txtTotalHorasConvertidas.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total de horas convertidas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(667, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 22;
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
            this.btnAvancar.TabIndex = 21;
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
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbPorcentagem
            // 
            this.gpbPorcentagem.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbPorcentagem.Controls.Add(this.rdbCem);
            this.gpbPorcentagem.Controls.Add(this.rdbCinquenta);
            this.gpbPorcentagem.Controls.Add(this.lblPorcentagem);
            this.gpbPorcentagem.Location = new System.Drawing.Point(455, 22);
            this.gpbPorcentagem.Name = "gpbPorcentagem";
            this.gpbPorcentagem.Size = new System.Drawing.Size(378, 84);
            this.gpbPorcentagem.TabIndex = 19;
            this.gpbPorcentagem.TabStop = false;
            this.gpbPorcentagem.Text = "Porcentagem de horas extras";
            // 
            // rdbCem
            // 
            this.rdbCem.AutoSize = true;
            this.rdbCem.Location = new System.Drawing.Point(72, 54);
            this.rdbCem.Name = "rdbCem";
            this.rdbCem.Size = new System.Drawing.Size(66, 21);
            this.rdbCem.TabIndex = 11;
            this.rdbCem.Text = "100%";
            this.rdbCem.UseVisualStyleBackColor = true;
            // 
            // rdbCinquenta
            // 
            this.rdbCinquenta.AutoSize = true;
            this.rdbCinquenta.Checked = true;
            this.rdbCinquenta.Location = new System.Drawing.Point(9, 54);
            this.rdbCinquenta.Name = "rdbCinquenta";
            this.rdbCinquenta.Size = new System.Drawing.Size(57, 21);
            this.rdbCinquenta.TabIndex = 10;
            this.rdbCinquenta.TabStop = true;
            this.rdbCinquenta.Text = "50%";
            this.rdbCinquenta.UseVisualStyleBackColor = true;
            this.rdbCinquenta.CheckedChanged += new System.EventHandler(this.rdbCinquenta_CheckedChanged);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPorcentagem.Location = new System.Drawing.Point(6, 25);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(351, 15);
            this.lblPorcentagem.TabIndex = 9;
            this.lblPorcentagem.Text = "Sobre qual porcentagem devem ser calculadas as horas extras";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimpar.Location = new System.Drawing.Point(90, 166);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcular.Location = new System.Drawing.Point(9, 166);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRetorno.Location = new System.Drawing.Point(6, 137);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(203, 15);
            this.lblRetorno.TabIndex = 12;
            this.lblRetorno.Text = "Valor total a receber de horas extras";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Enabled = false;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetorno.Location = new System.Drawing.Point(215, 136);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(100, 21);
            this.txtRetorno.TabIndex = 11;
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.Enabled = false;
            this.txtTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotalHoras.Location = new System.Drawing.Point(97, 66);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.ReadOnly = true;
            this.txtTotalHoras.Size = new System.Drawing.Size(100, 21);
            this.txtTotalHoras.TabIndex = 7;
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.AutoSize = true;
            this.lblTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTotalHoras.Location = new System.Drawing.Point(6, 68);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(85, 15);
            this.lblTotalHoras.TabIndex = 6;
            this.lblTotalHoras.Text = "Total de horas";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.Color.LightBlue;
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSalarioBase.Location = new System.Drawing.Point(88, 33);
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
            // Form_HorasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(863, 373);
            this.Controls.Add(this.gpbHorasExtras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_HorasExtras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horas Extras";
            this.gpbHorasExtras.ResumeLayout(false);
            this.gpbHorasExtras.PerformLayout();
            this.gpbPorcentagem.ResumeLayout(false);
            this.gpbPorcentagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbHorasExtras;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Label lblTotalHoras;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpbPorcentagem;
        private System.Windows.Forms.RadioButton rdbCem;
        private System.Windows.Forms.RadioButton rdbCinquenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtTotalHorasConvertidas;
        private System.Windows.Forms.Label label1;
    }
}