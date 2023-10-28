namespace InterfacesDoSistemaDesktop.Interfaces_AtualizarDados
{
    partial class Form_AtualizarConvMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AtualizarConvMedico));
            this.gpbConvMedico = new System.Windows.Forms.GroupBox();
            this.lblModoDesconto = new System.Windows.Forms.Label();
            this.rdbPercentual = new System.Windows.Forms.RadioButton();
            this.rdbValorFixado = new System.Windows.Forms.RadioButton();
            this.btnCadastrarConvMedico = new System.Windows.Forms.Button();
            this.txtPorcentagemConvMedico = new System.Windows.Forms.TextBox();
            this.txtValorConvMedico = new System.Windows.Forms.TextBox();
            this.mskCnpjConvMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeConvMedico = new System.Windows.Forms.TextBox();
            this.lblPorcentagemConvMedico = new System.Windows.Forms.Label();
            this.lblValorConvMedico = new System.Windows.Forms.Label();
            this.lblCnpjConvMedico = new System.Windows.Forms.Label();
            this.lblNomeConvMedico = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbConvMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConvMedico
            // 
            this.gpbConvMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbConvMedico.Controls.Add(this.btnCancelar);
            this.gpbConvMedico.Controls.Add(this.lblModoDesconto);
            this.gpbConvMedico.Controls.Add(this.rdbPercentual);
            this.gpbConvMedico.Controls.Add(this.rdbValorFixado);
            this.gpbConvMedico.Controls.Add(this.btnCadastrarConvMedico);
            this.gpbConvMedico.Controls.Add(this.txtPorcentagemConvMedico);
            this.gpbConvMedico.Controls.Add(this.txtValorConvMedico);
            this.gpbConvMedico.Controls.Add(this.mskCnpjConvMedico);
            this.gpbConvMedico.Controls.Add(this.txtNomeConvMedico);
            this.gpbConvMedico.Controls.Add(this.lblPorcentagemConvMedico);
            this.gpbConvMedico.Controls.Add(this.lblValorConvMedico);
            this.gpbConvMedico.Controls.Add(this.lblCnpjConvMedico);
            this.gpbConvMedico.Controls.Add(this.lblNomeConvMedico);
            this.gpbConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbConvMedico.Location = new System.Drawing.Point(12, 12);
            this.gpbConvMedico.Name = "gpbConvMedico";
            this.gpbConvMedico.Size = new System.Drawing.Size(328, 405);
            this.gpbConvMedico.TabIndex = 1;
            this.gpbConvMedico.TabStop = false;
            this.gpbConvMedico.Text = "Convênio médico";
            // 
            // lblModoDesconto
            // 
            this.lblModoDesconto.AutoSize = true;
            this.lblModoDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblModoDesconto.Location = new System.Drawing.Point(6, 150);
            this.lblModoDesconto.Name = "lblModoDesconto";
            this.lblModoDesconto.Size = new System.Drawing.Size(227, 15);
            this.lblModoDesconto.TabIndex = 11;
            this.lblModoDesconto.Text = "Selecione a forma de desconto aplicada";
            // 
            // rdbPercentual
            // 
            this.rdbPercentual.AutoSize = true;
            this.rdbPercentual.Location = new System.Drawing.Point(88, 168);
            this.rdbPercentual.Name = "rdbPercentual";
            this.rdbPercentual.Size = new System.Drawing.Size(104, 21);
            this.rdbPercentual.TabIndex = 10;
            this.rdbPercentual.Text = "Percentual";
            this.rdbPercentual.UseVisualStyleBackColor = true;
            // 
            // rdbValorFixado
            // 
            this.rdbValorFixado.AutoSize = true;
            this.rdbValorFixado.Checked = true;
            this.rdbValorFixado.Location = new System.Drawing.Point(9, 168);
            this.rdbValorFixado.Name = "rdbValorFixado";
            this.rdbValorFixado.Size = new System.Drawing.Size(73, 21);
            this.rdbValorFixado.TabIndex = 9;
            this.rdbValorFixado.TabStop = true;
            this.rdbValorFixado.Text = "Fixado";
            this.rdbValorFixado.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarConvMedico
            // 
            this.btnCadastrarConvMedico.BackColor = System.Drawing.Color.LightBlue;
            this.btnCadastrarConvMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCadastrarConvMedico.Location = new System.Drawing.Point(70, 327);
            this.btnCadastrarConvMedico.Name = "btnCadastrarConvMedico";
            this.btnCadastrarConvMedico.Size = new System.Drawing.Size(186, 30);
            this.btnCadastrarConvMedico.TabIndex = 8;
            this.btnCadastrarConvMedico.Text = "Atualizar Convênio Médico";
            this.btnCadastrarConvMedico.UseVisualStyleBackColor = false;
            // 
            // txtPorcentagemConvMedico
            // 
            this.txtPorcentagemConvMedico.Enabled = false;
            this.txtPorcentagemConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPorcentagemConvMedico.Location = new System.Drawing.Point(9, 277);
            this.txtPorcentagemConvMedico.Name = "txtPorcentagemConvMedico";
            this.txtPorcentagemConvMedico.Size = new System.Drawing.Size(100, 21);
            this.txtPorcentagemConvMedico.TabIndex = 7;
            // 
            // txtValorConvMedico
            // 
            this.txtValorConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValorConvMedico.Location = new System.Drawing.Point(9, 219);
            this.txtValorConvMedico.MaxLength = 5;
            this.txtValorConvMedico.Name = "txtValorConvMedico";
            this.txtValorConvMedico.Size = new System.Drawing.Size(150, 21);
            this.txtValorConvMedico.TabIndex = 6;
            this.txtValorConvMedico.Tag = "";
            // 
            // mskCnpjConvMedico
            // 
            this.mskCnpjConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskCnpjConvMedico.Location = new System.Drawing.Point(9, 111);
            this.mskCnpjConvMedico.Mask = "00,000,000/0000-00";
            this.mskCnpjConvMedico.Name = "mskCnpjConvMedico";
            this.mskCnpjConvMedico.Size = new System.Drawing.Size(150, 21);
            this.mskCnpjConvMedico.TabIndex = 5;
            // 
            // txtNomeConvMedico
            // 
            this.txtNomeConvMedico.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNomeConvMedico.Location = new System.Drawing.Point(9, 53);
            this.txtNomeConvMedico.MaxLength = 60;
            this.txtNomeConvMedico.Name = "txtNomeConvMedico";
            this.txtNomeConvMedico.Size = new System.Drawing.Size(200, 21);
            this.txtNomeConvMedico.TabIndex = 4;
            // 
            // lblPorcentagemConvMedico
            // 
            this.lblPorcentagemConvMedico.AutoSize = true;
            this.lblPorcentagemConvMedico.Enabled = false;
            this.lblPorcentagemConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPorcentagemConvMedico.Location = new System.Drawing.Point(6, 259);
            this.lblPorcentagemConvMedico.Name = "lblPorcentagemConvMedico";
            this.lblPorcentagemConvMedico.Size = new System.Drawing.Size(94, 15);
            this.lblPorcentagemConvMedico.TabIndex = 3;
            this.lblPorcentagemConvMedico.Text = "Desconto em %";
            // 
            // lblValorConvMedico
            // 
            this.lblValorConvMedico.AutoSize = true;
            this.lblValorConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblValorConvMedico.Location = new System.Drawing.Point(6, 201);
            this.lblValorConvMedico.Name = "lblValorConvMedico";
            this.lblValorConvMedico.Size = new System.Drawing.Size(71, 15);
            this.lblValorConvMedico.TabIndex = 2;
            this.lblValorConvMedico.Text = "Valor fixado";
            // 
            // lblCnpjConvMedico
            // 
            this.lblCnpjConvMedico.AutoSize = true;
            this.lblCnpjConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCnpjConvMedico.Location = new System.Drawing.Point(6, 93);
            this.lblCnpjConvMedico.Name = "lblCnpjConvMedico";
            this.lblCnpjConvMedico.Size = new System.Drawing.Size(38, 15);
            this.lblCnpjConvMedico.TabIndex = 1;
            this.lblCnpjConvMedico.Text = "CNPJ";
            // 
            // lblNomeConvMedico
            // 
            this.lblNomeConvMedico.AutoSize = true;
            this.lblNomeConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNomeConvMedico.Location = new System.Drawing.Point(6, 35);
            this.lblNomeConvMedico.Name = "lblNomeConvMedico";
            this.lblNomeConvMedico.Size = new System.Drawing.Size(154, 15);
            this.lblNomeConvMedico.TabIndex = 0;
            this.lblNomeConvMedico.Text = "Nome do convênio médico";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(127, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Form_AtualizarConvMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(352, 429);
            this.Controls.Add(this.gpbConvMedico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AtualizarConvMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Dados";
            this.gpbConvMedico.ResumeLayout(false);
            this.gpbConvMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConvMedico;
        private System.Windows.Forms.Label lblModoDesconto;
        private System.Windows.Forms.RadioButton rdbPercentual;
        private System.Windows.Forms.RadioButton rdbValorFixado;
        private System.Windows.Forms.Button btnCadastrarConvMedico;
        private System.Windows.Forms.TextBox txtPorcentagemConvMedico;
        private System.Windows.Forms.TextBox txtValorConvMedico;
        private System.Windows.Forms.MaskedTextBox mskCnpjConvMedico;
        private System.Windows.Forms.TextBox txtNomeConvMedico;
        private System.Windows.Forms.Label lblPorcentagemConvMedico;
        private System.Windows.Forms.Label lblValorConvMedico;
        private System.Windows.Forms.Label lblCnpjConvMedico;
        private System.Windows.Forms.Label lblNomeConvMedico;
        private System.Windows.Forms.Button btnCancelar;
    }
}