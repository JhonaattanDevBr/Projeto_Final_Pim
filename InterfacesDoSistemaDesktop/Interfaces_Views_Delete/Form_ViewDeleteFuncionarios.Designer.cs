namespace InterfacesDoSistemaDesktop.Interfaces_Views_Delete
{
    partial class Form_ViewDeleteFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewDeleteFuncionarios));
            this.gpbFuncionarios = new System.Windows.Forms.GroupBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbRegistro = new System.Windows.Forms.RadioButton();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.rdbRg = new System.Windows.Forms.RadioButton();
            this.rdbCpf = new System.Windows.Forms.RadioButton();
            this.rdbNomeFuncionario = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.mskPesquisaRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtPesquisaNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVisualizarFuncionarios = new System.Windows.Forms.DataGridView();
            this.gpbFuncionarios.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbFuncionarios.Controls.Add(this.gpbFiltro);
            this.gpbFuncionarios.Controls.Add(this.gpbPesquisa);
            this.gpbFuncionarios.Controls.Add(this.btnSair);
            this.gpbFuncionarios.Controls.Add(this.btnExcluirRegistro);
            this.gpbFuncionarios.Controls.Add(this.btnAlterarDados);
            this.gpbFuncionarios.Controls.Add(this.btnPesquisar);
            this.gpbFuncionarios.Controls.Add(this.dgvVisualizarFuncionarios);
            this.gpbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbFuncionarios.Location = new System.Drawing.Point(13, 12);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(1259, 657);
            this.gpbFuncionarios.TabIndex = 1;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Funcionários";
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.rdbRegistro);
            this.gpbFiltro.Controls.Add(this.btnLimparFiltro);
            this.gpbFiltro.Controls.Add(this.rdbRg);
            this.gpbFiltro.Controls.Add(this.rdbCpf);
            this.gpbFiltro.Controls.Add(this.rdbNomeFuncionario);
            this.gpbFiltro.Location = new System.Drawing.Point(1023, 156);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(230, 169);
            this.gpbFiltro.TabIndex = 6;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // rdbRegistro
            // 
            this.rdbRegistro.AutoSize = true;
            this.rdbRegistro.Location = new System.Drawing.Point(6, 29);
            this.rdbRegistro.Name = "rdbRegistro";
            this.rdbRegistro.Size = new System.Drawing.Size(87, 21);
            this.rdbRegistro.TabIndex = 4;
            this.rdbRegistro.TabStop = true;
            this.rdbRegistro.Text = "Registro";
            this.rdbRegistro.UseVisualStyleBackColor = true;
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnLimparFiltro.Location = new System.Drawing.Point(133, 136);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(91, 27);
            this.btnLimparFiltro.TabIndex = 3;
            this.btnLimparFiltro.Text = "Limpar filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = false;
            // 
            // rdbRg
            // 
            this.rdbRg.AutoSize = true;
            this.rdbRg.Location = new System.Drawing.Point(6, 111);
            this.rdbRg.Name = "rdbRg";
            this.rdbRg.Size = new System.Drawing.Size(49, 21);
            this.rdbRg.TabIndex = 2;
            this.rdbRg.TabStop = true;
            this.rdbRg.Text = "RG";
            this.rdbRg.UseVisualStyleBackColor = true;
            // 
            // rdbCpf
            // 
            this.rdbCpf.AutoSize = true;
            this.rdbCpf.Location = new System.Drawing.Point(6, 83);
            this.rdbCpf.Name = "rdbCpf";
            this.rdbCpf.Size = new System.Drawing.Size(55, 21);
            this.rdbCpf.TabIndex = 1;
            this.rdbCpf.TabStop = true;
            this.rdbCpf.Text = "CPF";
            this.rdbCpf.UseVisualStyleBackColor = true;
            // 
            // rdbNomeFuncionario
            // 
            this.rdbNomeFuncionario.AutoSize = true;
            this.rdbNomeFuncionario.Location = new System.Drawing.Point(6, 56);
            this.rdbNomeFuncionario.Name = "rdbNomeFuncionario";
            this.rdbNomeFuncionario.Size = new System.Drawing.Size(67, 21);
            this.rdbNomeFuncionario.TabIndex = 0;
            this.rdbNomeFuncionario.TabStop = true;
            this.rdbNomeFuncionario.Text = "Nome";
            this.rdbNomeFuncionario.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.mskPesquisaRg);
            this.gpbPesquisa.Controls.Add(this.lblRg);
            this.gpbPesquisa.Controls.Add(this.lblNomeFuncionario);
            this.gpbPesquisa.Controls.Add(this.txtPesquisaNomeFuncionario);
            this.gpbPesquisa.Location = new System.Drawing.Point(1023, 22);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(230, 97);
            this.gpbPesquisa.TabIndex = 5;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa rápida";
            // 
            // mskPesquisaRg
            // 
            this.mskPesquisaRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.mskPesquisaRg.Location = new System.Drawing.Point(84, 61);
            this.mskPesquisaRg.Mask = "00.000.000-0";
            this.mskPesquisaRg.Name = "mskPesquisaRg";
            this.mskPesquisaRg.Size = new System.Drawing.Size(124, 20);
            this.mskPesquisaRg.TabIndex = 4;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRg.Location = new System.Drawing.Point(53, 64);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(25, 15);
            this.lblRg.TabIndex = 3;
            this.lblRg.Text = "RG";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNomeFuncionario.Location = new System.Drawing.Point(6, 30);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(72, 15);
            this.lblNomeFuncionario.TabIndex = 2;
            this.lblNomeFuncionario.Text = "Funcionário";
            // 
            // txtPesquisaNomeFuncionario
            // 
            this.txtPesquisaNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtPesquisaNomeFuncionario.Location = new System.Drawing.Point(84, 30);
            this.txtPesquisaNomeFuncionario.Name = "txtPesquisaNomeFuncionario";
            this.txtPesquisaNomeFuncionario.Size = new System.Drawing.Size(124, 20);
            this.txtPesquisaNomeFuncionario.TabIndex = 1;
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
            // dgvVisualizarFuncionarios
            // 
            this.dgvVisualizarFuncionarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVisualizarFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarFuncionarios.Location = new System.Drawing.Point(6, 22);
            this.dgvVisualizarFuncionarios.Name = "dgvVisualizarFuncionarios";
            this.dgvVisualizarFuncionarios.ReadOnly = true;
            this.dgvVisualizarFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarFuncionarios.Size = new System.Drawing.Size(1011, 629);
            this.dgvVisualizarFuncionarios.TabIndex = 0;
            this.dgvVisualizarFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarFuncionarios_CellClick);
            // 
            // Form_ViewDeleteFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.gpbFuncionarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewDeleteFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Form_ViewDeleteFuncionarios_Load);
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.RadioButton rdbRg;
        private System.Windows.Forms.RadioButton rdbCpf;
        private System.Windows.Forms.RadioButton rdbNomeFuncionario;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.MaskedTextBox mskPesquisaRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtPesquisaNomeFuncionario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVisualizarFuncionarios;
        private System.Windows.Forms.RadioButton rdbRegistro;
    }
}