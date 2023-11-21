namespace InterfacesDoSistemaDesktop
{
    partial class Form_Atrasos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Atrasos));
            this.gpbAtrasos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.txtTotalHorasConvertidas = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtJornada = new System.Windows.Forms.TextBox();
            this.lblTotalHorasConvertidas = new System.Windows.Forms.Label();
            this.lblJornada = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.txtTotalHorasAtraso = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.lblTotalHorasAtraso = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.gpbAtrasos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAtrasos
            // 
            this.gpbAtrasos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbAtrasos.Controls.Add(this.btnCancelar);
            this.gpbAtrasos.Controls.Add(this.btnAvancar);
            this.gpbAtrasos.Controls.Add(this.txtTotalHorasConvertidas);
            this.gpbAtrasos.Controls.Add(this.btnVoltar);
            this.gpbAtrasos.Controls.Add(this.txtJornada);
            this.gpbAtrasos.Controls.Add(this.lblTotalHorasConvertidas);
            this.gpbAtrasos.Controls.Add(this.lblJornada);
            this.gpbAtrasos.Controls.Add(this.btnCalcular);
            this.gpbAtrasos.Controls.Add(this.btnLimpar);
            this.gpbAtrasos.Controls.Add(this.txtRetorno);
            this.gpbAtrasos.Controls.Add(this.txtTotalHorasAtraso);
            this.gpbAtrasos.Controls.Add(this.txtSalarioBase);
            this.gpbAtrasos.Controls.Add(this.lblRetorno);
            this.gpbAtrasos.Controls.Add(this.lblTotalHorasAtraso);
            this.gpbAtrasos.Controls.Add(this.lblSalarioBase);
            this.gpbAtrasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbAtrasos.Location = new System.Drawing.Point(12, 12);
            this.gpbAtrasos.Name = "gpbAtrasos";
            this.gpbAtrasos.Size = new System.Drawing.Size(839, 349);
            this.gpbAtrasos.TabIndex = 1;
            this.gpbAtrasos.TabStop = false;
            this.gpbAtrasos.Text = "Atrasos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(667, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 40;
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
            this.btnAvancar.TabIndex = 39;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // txtTotalHorasConvertidas
            // 
            this.txtTotalHorasConvertidas.Enabled = false;
            this.txtTotalHorasConvertidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotalHorasConvertidas.Location = new System.Drawing.Point(162, 136);
            this.txtTotalHorasConvertidas.Name = "txtTotalHorasConvertidas";
            this.txtTotalHorasConvertidas.ReadOnly = true;
            this.txtTotalHorasConvertidas.Size = new System.Drawing.Size(100, 21);
            this.txtTotalHorasConvertidas.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVoltar.Location = new System.Drawing.Point(574, 313);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 30);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtJornada
            // 
            this.txtJornada.Enabled = false;
            this.txtJornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtJornada.Location = new System.Drawing.Point(129, 67);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.ReadOnly = true;
            this.txtJornada.Size = new System.Drawing.Size(100, 21);
            this.txtJornada.TabIndex = 13;
            // 
            // lblTotalHorasConvertidas
            // 
            this.lblTotalHorasConvertidas.AutoSize = true;
            this.lblTotalHorasConvertidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTotalHorasConvertidas.Location = new System.Drawing.Point(6, 136);
            this.lblTotalHorasConvertidas.Name = "lblTotalHorasConvertidas";
            this.lblTotalHorasConvertidas.Size = new System.Drawing.Size(150, 15);
            this.lblTotalHorasConvertidas.TabIndex = 1;
            this.lblTotalHorasConvertidas.Text = "Total de horas convertidas";
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblJornada.Location = new System.Drawing.Point(6, 68);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(117, 15);
            this.lblJornada.TabIndex = 12;
            this.lblJornada.Text = "Jornada de trabalho";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCalcular.Location = new System.Drawing.Point(90, 169);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimpar.Location = new System.Drawing.Point(9, 169);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Enabled = false;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRetorno.Location = new System.Drawing.Point(208, 214);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(100, 21);
            this.txtRetorno.TabIndex = 6;
            // 
            // txtTotalHorasAtraso
            // 
            this.txtTotalHorasAtraso.Enabled = false;
            this.txtTotalHorasAtraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotalHorasAtraso.Location = new System.Drawing.Point(155, 101);
            this.txtTotalHorasAtraso.Name = "txtTotalHorasAtraso";
            this.txtTotalHorasAtraso.ReadOnly = true;
            this.txtTotalHorasAtraso.Size = new System.Drawing.Size(100, 21);
            this.txtTotalHorasAtraso.TabIndex = 5;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.Color.LightBlue;
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSalarioBase.Location = new System.Drawing.Point(89, 34);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 21);
            this.txtSalarioBase.TabIndex = 4;
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRetorno.Location = new System.Drawing.Point(6, 215);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(195, 15);
            this.lblRetorno.TabIndex = 3;
            this.lblRetorno.Text = "Total a ser descontado por atrasos";
            // 
            // lblTotalHorasAtraso
            // 
            this.lblTotalHorasAtraso.AutoSize = true;
            this.lblTotalHorasAtraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTotalHorasAtraso.Location = new System.Drawing.Point(6, 101);
            this.lblTotalHorasAtraso.Name = "lblTotalHorasAtraso";
            this.lblTotalHorasAtraso.Size = new System.Drawing.Size(143, 15);
            this.lblTotalHorasAtraso.TabIndex = 2;
            this.lblTotalHorasAtraso.Text = "Total de horas em atraso";
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
            // Form_Atrasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(863, 373);
            this.Controls.Add(this.gpbAtrasos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Atrasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atrasos";
            this.gpbAtrasos.ResumeLayout(false);
            this.gpbAtrasos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbAtrasos;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Label lblTotalHorasAtraso;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.TextBox txtTotalHorasAtraso;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblTotalHorasConvertidas;
        private System.Windows.Forms.TextBox txtTotalHorasConvertidas;
        private System.Windows.Forms.TextBox txtJornada;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
    }
}