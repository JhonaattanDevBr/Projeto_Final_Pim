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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVisualizarEmpresa = new System.Windows.Forms.DataGridView();
            this.gpbEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEmpresas
            // 
            this.gpbEmpresas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbEmpresas.Controls.Add(this.btnFechar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEmpresas;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVisualizarEmpresa;
    }
}