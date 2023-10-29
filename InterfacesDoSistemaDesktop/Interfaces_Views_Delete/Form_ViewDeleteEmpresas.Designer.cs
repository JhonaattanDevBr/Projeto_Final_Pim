namespace InterfacesDoSistemaDesktop.Interfaces_Views_Delete
{
    partial class Form_ViewDeleteEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewDeleteEmpresas));
            this.gpbEmpresas = new System.Windows.Forms.GroupBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.rdbCnpj = new System.Windows.Forms.RadioButton();
            this.rdbSegmento = new System.Windows.Forms.RadioButton();
            this.rdbRazaoSocial = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.mskPesquisaCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtPesquisaNomeFantasia = new System.Windows.Forms.TextBox();
            this.cmbCampoPesquisa = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVisualizarEmpresa = new System.Windows.Forms.DataGridView();
            this.gpbEmpresas.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEmpresas
            // 
            this.gpbEmpresas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbEmpresas.Controls.Add(this.gpbFiltro);
            this.gpbEmpresas.Controls.Add(this.gpbPesquisa);
            this.gpbEmpresas.Controls.Add(this.btnSair);
            this.gpbEmpresas.Controls.Add(this.btnExcluirRegistro);
            this.gpbEmpresas.Controls.Add(this.btnAlterarDados);
            this.gpbEmpresas.Controls.Add(this.btnPesquisar);
            this.gpbEmpresas.Controls.Add(this.dgvVisualizarEmpresa);
            this.gpbEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbEmpresas.Location = new System.Drawing.Point(12, 12);
            this.gpbEmpresas.Name = "gpbEmpresas";
            this.gpbEmpresas.Size = new System.Drawing.Size(1260, 657);
            this.gpbEmpresas.TabIndex = 0;
            this.gpbEmpresas.TabStop = false;
            this.gpbEmpresas.Text = "Empresas";
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.btnLimparFiltro);
            this.gpbFiltro.Controls.Add(this.rdbCnpj);
            this.gpbFiltro.Controls.Add(this.rdbSegmento);
            this.gpbFiltro.Controls.Add(this.rdbRazaoSocial);
            this.gpbFiltro.Location = new System.Drawing.Point(1023, 156);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(230, 137);
            this.gpbFiltro.TabIndex = 6;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimparFiltro.Location = new System.Drawing.Point(133, 104);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(91, 27);
            this.btnLimparFiltro.TabIndex = 3;
            this.btnLimparFiltro.Text = "Limpar filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = false;
            // 
            // rdbCnpj
            // 
            this.rdbCnpj.AutoSize = true;
            this.rdbCnpj.Location = new System.Drawing.Point(7, 79);
            this.rdbCnpj.Name = "rdbCnpj";
            this.rdbCnpj.Size = new System.Drawing.Size(65, 21);
            this.rdbCnpj.TabIndex = 2;
            this.rdbCnpj.TabStop = true;
            this.rdbCnpj.Text = "CNPJ";
            this.rdbCnpj.UseVisualStyleBackColor = true;
            // 
            // rdbSegmento
            // 
            this.rdbSegmento.AutoSize = true;
            this.rdbSegmento.Location = new System.Drawing.Point(7, 51);
            this.rdbSegmento.Name = "rdbSegmento";
            this.rdbSegmento.Size = new System.Drawing.Size(98, 21);
            this.rdbSegmento.TabIndex = 1;
            this.rdbSegmento.TabStop = true;
            this.rdbSegmento.Text = "Segmento";
            this.rdbSegmento.UseVisualStyleBackColor = true;
            // 
            // rdbRazaoSocial
            // 
            this.rdbRazaoSocial.AutoSize = true;
            this.rdbRazaoSocial.Location = new System.Drawing.Point(7, 23);
            this.rdbRazaoSocial.Name = "rdbRazaoSocial";
            this.rdbRazaoSocial.Size = new System.Drawing.Size(119, 21);
            this.rdbRazaoSocial.TabIndex = 0;
            this.rdbRazaoSocial.TabStop = true;
            this.rdbRazaoSocial.Text = "Razao social";
            this.rdbRazaoSocial.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.mskPesquisaCnpj);
            this.gpbPesquisa.Controls.Add(this.lblCnpj);
            this.gpbPesquisa.Controls.Add(this.lblNomeFantasia);
            this.gpbPesquisa.Controls.Add(this.txtPesquisaNomeFantasia);
            this.gpbPesquisa.Controls.Add(this.cmbCampoPesquisa);
            this.gpbPesquisa.Location = new System.Drawing.Point(1023, 22);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(230, 118);
            this.gpbPesquisa.TabIndex = 5;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa rápida";
            // 
            // mskPesquisaCnpj
            // 
            this.mskPesquisaCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.mskPesquisaCnpj.Location = new System.Drawing.Point(100, 87);
            this.mskPesquisaCnpj.Mask = "00,000,000/0000-00";
            this.mskPesquisaCnpj.Name = "mskPesquisaCnpj";
            this.mskPesquisaCnpj.Size = new System.Drawing.Size(124, 20);
            this.mskPesquisaCnpj.TabIndex = 4;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCnpj.Location = new System.Drawing.Point(56, 90);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(38, 15);
            this.lblCnpj.TabIndex = 3;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNomeFantasia.Location = new System.Drawing.Point(7, 56);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(87, 15);
            this.lblNomeFantasia.TabIndex = 2;
            this.lblNomeFantasia.Text = "Nome fantasia";
            // 
            // txtPesquisaNomeFantasia
            // 
            this.txtPesquisaNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtPesquisaNomeFantasia.Location = new System.Drawing.Point(100, 56);
            this.txtPesquisaNomeFantasia.Name = "txtPesquisaNomeFantasia";
            this.txtPesquisaNomeFantasia.Size = new System.Drawing.Size(124, 20);
            this.txtPesquisaNomeFantasia.TabIndex = 1;
            // 
            // cmbCampoPesquisa
            // 
            this.cmbCampoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCampoPesquisa.FormattingEnabled = true;
            this.cmbCampoPesquisa.Items.AddRange(new object[] {
            "Nome",
            "CNPJ"});
            this.cmbCampoPesquisa.Location = new System.Drawing.Point(7, 23);
            this.cmbCampoPesquisa.Name = "cmbCampoPesquisa";
            this.cmbCampoPesquisa.Size = new System.Drawing.Size(217, 24);
            this.cmbCampoPesquisa.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnSair.Location = new System.Drawing.Point(1083, 513);
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
            this.btnExcluirRegistro.Location = new System.Drawing.Point(1083, 463);
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
            this.btnAlterarDados.Location = new System.Drawing.Point(1083, 416);
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
            this.btnPesquisar.Location = new System.Drawing.Point(1083, 369);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 30);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dgvVisualizarEmpresa
            // 
            this.dgvVisualizarEmpresa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVisualizarEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarEmpresa.Location = new System.Drawing.Point(6, 22);
            this.dgvVisualizarEmpresa.Name = "dgvVisualizarEmpresa";
            this.dgvVisualizarEmpresa.ReadOnly = true;
            this.dgvVisualizarEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarEmpresa.Size = new System.Drawing.Size(1011, 629);
            this.dgvVisualizarEmpresa.TabIndex = 0;
            this.dgvVisualizarEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarEmpresa_CellClick);
            // 
            // Form_ViewDeleteEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.gpbEmpresas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewDeleteEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minhas Empresas";
            this.Load += new System.EventHandler(this.Form_ViewDeleteEmpresas_Load);
            this.gpbEmpresas.ResumeLayout(false);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEmpresas;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.MaskedTextBox mskPesquisaCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtPesquisaNomeFantasia;
        private System.Windows.Forms.ComboBox cmbCampoPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVisualizarEmpresa;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.RadioButton rdbCnpj;
        private System.Windows.Forms.RadioButton rdbSegmento;
        private System.Windows.Forms.RadioButton rdbRazaoSocial;
    }
}