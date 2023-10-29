namespace InterfacesDoSistemaDesktop.Interfaces_Views_Delete
{
    partial class Form_ViewDeleteConvenioOdontologico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewDeleteConvenioOdontologico));
            this.gpbConvenioOdonto = new System.Windows.Forms.GroupBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.rdbCnpjConvOdonto = new System.Windows.Forms.RadioButton();
            this.rdbNomeConvenioOdonto = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.mskPesquisaCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblNomeConvenioOdonto = new System.Windows.Forms.Label();
            this.txtPesquisaConvenioOdonto = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVisualizarConvOdonto = new System.Windows.Forms.DataGridView();
            this.gpbConvenioOdonto.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarConvOdonto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConvenioOdonto
            // 
            this.gpbConvenioOdonto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbConvenioOdonto.Controls.Add(this.gpbFiltro);
            this.gpbConvenioOdonto.Controls.Add(this.gpbPesquisa);
            this.gpbConvenioOdonto.Controls.Add(this.btnSair);
            this.gpbConvenioOdonto.Controls.Add(this.btnExcluirRegistro);
            this.gpbConvenioOdonto.Controls.Add(this.btnAlterarDados);
            this.gpbConvenioOdonto.Controls.Add(this.btnPesquisar);
            this.gpbConvenioOdonto.Controls.Add(this.dgvVisualizarConvOdonto);
            this.gpbConvenioOdonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbConvenioOdonto.Location = new System.Drawing.Point(13, 12);
            this.gpbConvenioOdonto.Name = "gpbConvenioOdonto";
            this.gpbConvenioOdonto.Size = new System.Drawing.Size(959, 657);
            this.gpbConvenioOdonto.TabIndex = 2;
            this.gpbConvenioOdonto.TabStop = false;
            this.gpbConvenioOdonto.Text = "Convênio odontológico";
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.btnLimparFiltro);
            this.gpbFiltro.Controls.Add(this.rdbCnpjConvOdonto);
            this.gpbFiltro.Controls.Add(this.rdbNomeConvenioOdonto);
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
            // rdbCnpjConvOdonto
            // 
            this.rdbCnpjConvOdonto.AutoSize = true;
            this.rdbCnpjConvOdonto.Location = new System.Drawing.Point(6, 50);
            this.rdbCnpjConvOdonto.Name = "rdbCnpjConvOdonto";
            this.rdbCnpjConvOdonto.Size = new System.Drawing.Size(65, 21);
            this.rdbCnpjConvOdonto.TabIndex = 2;
            this.rdbCnpjConvOdonto.TabStop = true;
            this.rdbCnpjConvOdonto.Text = "CNPJ";
            this.rdbCnpjConvOdonto.UseVisualStyleBackColor = true;
            // 
            // rdbNomeConvenioOdonto
            // 
            this.rdbNomeConvenioOdonto.AutoSize = true;
            this.rdbNomeConvenioOdonto.Location = new System.Drawing.Point(7, 23);
            this.rdbNomeConvenioOdonto.Name = "rdbNomeConvenioOdonto";
            this.rdbNomeConvenioOdonto.Size = new System.Drawing.Size(67, 21);
            this.rdbNomeConvenioOdonto.TabIndex = 0;
            this.rdbNomeConvenioOdonto.TabStop = true;
            this.rdbNomeConvenioOdonto.Text = "Nome";
            this.rdbNomeConvenioOdonto.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.mskPesquisaCnpj);
            this.gpbPesquisa.Controls.Add(this.lblCnpj);
            this.gpbPesquisa.Controls.Add(this.lblNomeConvenioOdonto);
            this.gpbPesquisa.Controls.Add(this.txtPesquisaConvenioOdonto);
            this.gpbPesquisa.Location = new System.Drawing.Point(723, 22);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(230, 98);
            this.gpbPesquisa.TabIndex = 5;
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
            // lblNomeConvenioOdonto
            // 
            this.lblNomeConvenioOdonto.AutoSize = true;
            this.lblNomeConvenioOdonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNomeConvenioOdonto.Location = new System.Drawing.Point(6, 33);
            this.lblNomeConvenioOdonto.Name = "lblNomeConvenioOdonto";
            this.lblNomeConvenioOdonto.Size = new System.Drawing.Size(41, 15);
            this.lblNomeConvenioOdonto.TabIndex = 2;
            this.lblNomeConvenioOdonto.Text = "Nome";
            // 
            // txtPesquisaConvenioOdonto
            // 
            this.txtPesquisaConvenioOdonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtPesquisaConvenioOdonto.Location = new System.Drawing.Point(53, 33);
            this.txtPesquisaConvenioOdonto.Name = "txtPesquisaConvenioOdonto";
            this.txtPesquisaConvenioOdonto.Size = new System.Drawing.Size(124, 20);
            this.txtPesquisaConvenioOdonto.TabIndex = 1;
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
            this.btnExcluirRegistro.Click += new System.EventHandler(this.btnExcluirRegistro_Click);
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
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
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
            // dgvVisualizarConvOdonto
            // 
            this.dgvVisualizarConvOdonto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVisualizarConvOdonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarConvOdonto.Location = new System.Drawing.Point(6, 22);
            this.dgvVisualizarConvOdonto.Name = "dgvVisualizarConvOdonto";
            this.dgvVisualizarConvOdonto.Size = new System.Drawing.Size(711, 629);
            this.dgvVisualizarConvOdonto.TabIndex = 0;
            this.dgvVisualizarConvOdonto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarConvOdonto_CellClick);
            // 
            // Form_ViewDeleteConvenioOdontologico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.gpbConvenioOdonto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewDeleteConvenioOdontologico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convênio Oodontológico";
            this.Load += new System.EventHandler(this.Form_ViewDeleteConvenioOdontologico_Load);
            this.gpbConvenioOdonto.ResumeLayout(false);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarConvOdonto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConvenioOdonto;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.RadioButton rdbCnpjConvOdonto;
        private System.Windows.Forms.RadioButton rdbNomeConvenioOdonto;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.MaskedTextBox mskPesquisaCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblNomeConvenioOdonto;
        private System.Windows.Forms.TextBox txtPesquisaConvenioOdonto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVisualizarConvOdonto;
    }
}