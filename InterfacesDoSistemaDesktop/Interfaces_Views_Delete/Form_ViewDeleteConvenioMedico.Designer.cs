namespace InterfacesDoSistemaDesktop.Interfaces_Views_Delete
{
    partial class Form_ViewDeleteConvenioMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewDeleteConvenioMedico));
            this.gpbConvenioMedico = new System.Windows.Forms.GroupBox();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.mskPesquisaCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblNomeConvenioMedico = new System.Windows.Forms.Label();
            this.txtPesquisaConvenioMedico = new System.Windows.Forms.TextBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.rdbCnpj = new System.Windows.Forms.RadioButton();
            this.rdbNomeConvenioMedico = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVisualizaConvMedico = new System.Windows.Forms.DataGridView();
            this.gpbConvenioMedico.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaConvMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConvenioMedico
            // 
            this.gpbConvenioMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbConvenioMedico.Controls.Add(this.gpbPesquisa);
            this.gpbConvenioMedico.Controls.Add(this.gpbFiltro);
            this.gpbConvenioMedico.Controls.Add(this.btnSair);
            this.gpbConvenioMedico.Controls.Add(this.btnExcluirRegistro);
            this.gpbConvenioMedico.Controls.Add(this.btnAlterarDados);
            this.gpbConvenioMedico.Controls.Add(this.btnPesquisar);
            this.gpbConvenioMedico.Controls.Add(this.dgvVisualizaConvMedico);
            this.gpbConvenioMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbConvenioMedico.Location = new System.Drawing.Point(13, 12);
            this.gpbConvenioMedico.Name = "gpbConvenioMedico";
            this.gpbConvenioMedico.Size = new System.Drawing.Size(959, 657);
            this.gpbConvenioMedico.TabIndex = 2;
            this.gpbConvenioMedico.TabStop = false;
            this.gpbConvenioMedico.Text = "Convênio médico";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.mskPesquisaCnpj);
            this.gpbPesquisa.Controls.Add(this.lblCnpj);
            this.gpbPesquisa.Controls.Add(this.lblNomeConvenioMedico);
            this.gpbPesquisa.Controls.Add(this.txtPesquisaConvenioMedico);
            this.gpbPesquisa.Location = new System.Drawing.Point(723, 22);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(230, 98);
            this.gpbPesquisa.TabIndex = 6;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa rápida";
            // 
            // mskPesquisaCnpj
            // 
            this.mskPesquisaCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.mskPesquisaCnpj.Location = new System.Drawing.Point(53, 64);
            this.mskPesquisaCnpj.Mask = "00,000,000/0000-00";
            this.mskPesquisaCnpj.Name = "mskPesquisaCnpj";
            this.mskPesquisaCnpj.Size = new System.Drawing.Size(124, 20);
            this.mskPesquisaCnpj.TabIndex = 4;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCnpj.Location = new System.Drawing.Point(9, 67);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(38, 15);
            this.lblCnpj.TabIndex = 3;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblNomeConvenioMedico
            // 
            this.lblNomeConvenioMedico.AutoSize = true;
            this.lblNomeConvenioMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNomeConvenioMedico.Location = new System.Drawing.Point(6, 33);
            this.lblNomeConvenioMedico.Name = "lblNomeConvenioMedico";
            this.lblNomeConvenioMedico.Size = new System.Drawing.Size(41, 15);
            this.lblNomeConvenioMedico.TabIndex = 2;
            this.lblNomeConvenioMedico.Text = "Nome";
            // 
            // txtPesquisaConvenioMedico
            // 
            this.txtPesquisaConvenioMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtPesquisaConvenioMedico.Location = new System.Drawing.Point(53, 33);
            this.txtPesquisaConvenioMedico.Name = "txtPesquisaConvenioMedico";
            this.txtPesquisaConvenioMedico.Size = new System.Drawing.Size(124, 20);
            this.txtPesquisaConvenioMedico.TabIndex = 1;
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.btnLimparFiltro);
            this.gpbFiltro.Controls.Add(this.rdbCnpj);
            this.gpbFiltro.Controls.Add(this.rdbNomeConvenioMedico);
            this.gpbFiltro.Location = new System.Drawing.Point(723, 138);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(230, 113);
            this.gpbFiltro.TabIndex = 6;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimparFiltro.Location = new System.Drawing.Point(133, 76);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(91, 27);
            this.btnLimparFiltro.TabIndex = 3;
            this.btnLimparFiltro.Text = "Limpar filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = false;
            // 
            // rdbCnpj
            // 
            this.rdbCnpj.AutoSize = true;
            this.rdbCnpj.Location = new System.Drawing.Point(6, 50);
            this.rdbCnpj.Name = "rdbCnpj";
            this.rdbCnpj.Size = new System.Drawing.Size(65, 21);
            this.rdbCnpj.TabIndex = 2;
            this.rdbCnpj.TabStop = true;
            this.rdbCnpj.Text = "CNPJ";
            this.rdbCnpj.UseVisualStyleBackColor = true;
            // 
            // rdbNomeConvenioMedico
            // 
            this.rdbNomeConvenioMedico.AutoSize = true;
            this.rdbNomeConvenioMedico.Location = new System.Drawing.Point(7, 23);
            this.rdbNomeConvenioMedico.Name = "rdbNomeConvenioMedico";
            this.rdbNomeConvenioMedico.Size = new System.Drawing.Size(67, 21);
            this.rdbNomeConvenioMedico.TabIndex = 0;
            this.rdbNomeConvenioMedico.TabStop = true;
            this.rdbNomeConvenioMedico.Text = "Nome";
            this.rdbNomeConvenioMedico.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnSair.Location = new System.Drawing.Point(782, 513);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnExcluirRegistro
            // 
            this.btnExcluirRegistro.BackColor = System.Drawing.Color.LightBlue;
            this.btnExcluirRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnExcluirRegistro.Location = new System.Drawing.Point(782, 463);
            this.btnExcluirRegistro.Name = "btnExcluirRegistro";
            this.btnExcluirRegistro.Size = new System.Drawing.Size(108, 30);
            this.btnExcluirRegistro.TabIndex = 3;
            this.btnExcluirRegistro.Text = "Excluir Registro";
            this.btnExcluirRegistro.UseVisualStyleBackColor = false;
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.Color.LightBlue;
            this.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAlterarDados.Location = new System.Drawing.Point(782, 416);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(108, 30);
            this.btnAlterarDados.TabIndex = 2;
            this.btnAlterarDados.Text = "Alterar Dados";
            this.btnAlterarDados.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.LightBlue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnPesquisar.Location = new System.Drawing.Point(782, 369);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 30);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dgvVisualizaConvMedico
            // 
            this.dgvVisualizaConvMedico.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVisualizaConvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizaConvMedico.Location = new System.Drawing.Point(6, 22);
            this.dgvVisualizaConvMedico.Name = "dgvVisualizaConvMedico";
            this.dgvVisualizaConvMedico.ReadOnly = true;
            this.dgvVisualizaConvMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizaConvMedico.Size = new System.Drawing.Size(711, 629);
            this.dgvVisualizaConvMedico.TabIndex = 0;
            // 
            // Form_ViewDeleteConvenioMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.gpbConvenioMedico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewDeleteConvenioMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convênio Médico";
            this.Load += new System.EventHandler(this.Form_ViewDeleteConvenioMedico_Load);
            this.gpbConvenioMedico.ResumeLayout(false);
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaConvMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConvenioMedico;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.MaskedTextBox mskPesquisaCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblNomeConvenioMedico;
        private System.Windows.Forms.TextBox txtPesquisaConvenioMedico;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.RadioButton rdbCnpj;
        private System.Windows.Forms.RadioButton rdbNomeConvenioMedico;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVisualizaConvMedico;
    }
}