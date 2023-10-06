﻿namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    partial class Form_CadConvMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadConvMedico));
            this.gpbConvMedico = new System.Windows.Forms.GroupBox();
            this.btnCadastrarConvMedico = new System.Windows.Forms.Button();
            this.txtPorcentagemConvMedico = new System.Windows.Forms.TextBox();
            this.txtValorConvMedico = new System.Windows.Forms.TextBox();
            this.mskCnpjConvMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeConvMedico = new System.Windows.Forms.TextBox();
            this.lblPorcentagemConvMedico = new System.Windows.Forms.Label();
            this.lblValorConvMedico = new System.Windows.Forms.Label();
            this.lblCnpjConvMedico = new System.Windows.Forms.Label();
            this.lblNomeConvMedico = new System.Windows.Forms.Label();
            this.gpbConvMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConvMedico
            // 
            this.gpbConvMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.gpbConvMedico.Size = new System.Drawing.Size(304, 331);
            this.gpbConvMedico.TabIndex = 0;
            this.gpbConvMedico.TabStop = false;
            this.gpbConvMedico.Text = "Cadastro de convênio médico";
            // 
            // btnCadastrarConvMedico
            // 
            this.btnCadastrarConvMedico.BackColor = System.Drawing.Color.LightBlue;
            this.btnCadastrarConvMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCadastrarConvMedico.Location = new System.Drawing.Point(55, 276);
            this.btnCadastrarConvMedico.Name = "btnCadastrarConvMedico";
            this.btnCadastrarConvMedico.Size = new System.Drawing.Size(186, 30);
            this.btnCadastrarConvMedico.TabIndex = 8;
            this.btnCadastrarConvMedico.Text = "Cadastrar Convênio Médico";
            this.btnCadastrarConvMedico.UseVisualStyleBackColor = false;
            this.btnCadastrarConvMedico.Click += new System.EventHandler(this.btnCadastrarConvMedico_Click);
            // 
            // txtPorcentagemConvMedico
            // 
            this.txtPorcentagemConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtPorcentagemConvMedico.Location = new System.Drawing.Point(9, 228);
            this.txtPorcentagemConvMedico.Name = "txtPorcentagemConvMedico";
            this.txtPorcentagemConvMedico.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentagemConvMedico.TabIndex = 7;
            // 
            // txtValorConvMedico
            // 
            this.txtValorConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtValorConvMedico.Location = new System.Drawing.Point(9, 170);
            this.txtValorConvMedico.Name = "txtValorConvMedico";
            this.txtValorConvMedico.Size = new System.Drawing.Size(150, 20);
            this.txtValorConvMedico.TabIndex = 6;
            this.txtValorConvMedico.Tag = "";
            this.txtValorConvMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorConvMedico_KeyPress);
            // 
            // mskCnpjConvMedico
            // 
            this.mskCnpjConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.mskCnpjConvMedico.Location = new System.Drawing.Point(9, 111);
            this.mskCnpjConvMedico.Mask = "00,000,000/0000-00";
            this.mskCnpjConvMedico.Name = "mskCnpjConvMedico";
            this.mskCnpjConvMedico.Size = new System.Drawing.Size(150, 20);
            this.mskCnpjConvMedico.TabIndex = 5;
            // 
            // txtNomeConvMedico
            // 
            this.txtNomeConvMedico.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtNomeConvMedico.Location = new System.Drawing.Point(9, 53);
            this.txtNomeConvMedico.MaxLength = 60;
            this.txtNomeConvMedico.Name = "txtNomeConvMedico";
            this.txtNomeConvMedico.Size = new System.Drawing.Size(200, 20);
            this.txtNomeConvMedico.TabIndex = 4;
            // 
            // lblPorcentagemConvMedico
            // 
            this.lblPorcentagemConvMedico.AutoSize = true;
            this.lblPorcentagemConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPorcentagemConvMedico.Location = new System.Drawing.Point(6, 210);
            this.lblPorcentagemConvMedico.Name = "lblPorcentagemConvMedico";
            this.lblPorcentagemConvMedico.Size = new System.Drawing.Size(94, 15);
            this.lblPorcentagemConvMedico.TabIndex = 3;
            this.lblPorcentagemConvMedico.Text = "Desconto em %";
            // 
            // lblValorConvMedico
            // 
            this.lblValorConvMedico.AutoSize = true;
            this.lblValorConvMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblValorConvMedico.Location = new System.Drawing.Point(6, 152);
            this.lblValorConvMedico.Name = "lblValorConvMedico";
            this.lblValorConvMedico.Size = new System.Drawing.Size(83, 15);
            this.lblValorConvMedico.TabIndex = 2;
            this.lblValorConvMedico.Text = "Valor cobrado";
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
            // Form_CadConvMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(328, 355);
            this.Controls.Add(this.gpbConvMedico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CadConvMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Convênio Médico";
            this.gpbConvMedico.ResumeLayout(false);
            this.gpbConvMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConvMedico;
        private System.Windows.Forms.Label lblPorcentagemConvMedico;
        private System.Windows.Forms.Label lblValorConvMedico;
        private System.Windows.Forms.Label lblCnpjConvMedico;
        private System.Windows.Forms.Label lblNomeConvMedico;
        private System.Windows.Forms.TextBox txtNomeConvMedico;
        private System.Windows.Forms.MaskedTextBox mskCnpjConvMedico;
        private System.Windows.Forms.TextBox txtValorConvMedico;
        private System.Windows.Forms.TextBox txtPorcentagemConvMedico;
        private System.Windows.Forms.Button btnCadastrarConvMedico;
    }
}