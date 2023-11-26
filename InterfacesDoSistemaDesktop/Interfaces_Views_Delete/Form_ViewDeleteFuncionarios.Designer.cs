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
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbListarEmpresas = new System.Windows.Forms.ComboBox();
            this.lblSelecionarEmpresa = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVisualizarFuncionarios = new System.Windows.Forms.DataGridView();
            this.gpbFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbFuncionarios.Controls.Add(this.btnListar);
            this.gpbFuncionarios.Controls.Add(this.cmbListarEmpresas);
            this.gpbFuncionarios.Controls.Add(this.lblSelecionarEmpresa);
            this.gpbFuncionarios.Controls.Add(this.btnFechar);
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
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.LightBlue;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnListar.Location = new System.Drawing.Point(646, 16);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 30);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbListarEmpresas
            // 
            this.cmbListarEmpresas.BackColor = System.Drawing.Color.LightBlue;
            this.cmbListarEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListarEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListarEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbListarEmpresas.FormattingEnabled = true;
            this.cmbListarEmpresas.Location = new System.Drawing.Point(313, 23);
            this.cmbListarEmpresas.Name = "cmbListarEmpresas";
            this.cmbListarEmpresas.Size = new System.Drawing.Size(300, 23);
            this.cmbListarEmpresas.TabIndex = 8;
            this.cmbListarEmpresas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbListarEmpresas_KeyPress);
            // 
            // lblSelecionarEmpresa
            // 
            this.lblSelecionarEmpresa.AutoSize = true;
            this.lblSelecionarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSelecionarEmpresa.Location = new System.Drawing.Point(7, 23);
            this.lblSelecionarEmpresa.Name = "lblSelecionarEmpresa";
            this.lblSelecionarEmpresa.Size = new System.Drawing.Size(300, 15);
            this.lblSelecionarEmpresa.TabIndex = 7;
            this.lblSelecionarEmpresa.Text = "Selecione uma empresa para listas seus funcionários";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LightBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnFechar.Location = new System.Drawing.Point(1083, 513);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 30);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.dgvVisualizarFuncionarios.Location = new System.Drawing.Point(6, 52);
            this.dgvVisualizarFuncionarios.Name = "dgvVisualizarFuncionarios";
            this.dgvVisualizarFuncionarios.ReadOnly = true;
            this.dgvVisualizarFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarFuncionarios.Size = new System.Drawing.Size(1011, 599);
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
            this.gpbFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVisualizarFuncionarios;
        private System.Windows.Forms.ComboBox cmbListarEmpresas;
        private System.Windows.Forms.Label lblSelecionarEmpresa;
        private System.Windows.Forms.Button btnListar;
    }
}