namespace InterfacesDoSistemaDesktop.Interfaces_Ferias
{
    partial class Form_ConsultarTabelaFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConsultarTabelaFerias));
            this.gpbConsultarFerias = new System.Windows.Forms.GroupBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbListarFuncionarios = new System.Windows.Forms.ComboBox();
            this.gpbConsultarFerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultarFerias
            // 
            this.gpbConsultarFerias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbConsultarFerias.Controls.Add(this.cmbListarFuncionarios);
            this.gpbConsultarFerias.Controls.Add(this.btnSair);
            this.gpbConsultarFerias.Controls.Add(this.btnExcluir);
            this.gpbConsultarFerias.Controls.Add(this.btnAtualizar);
            this.gpbConsultarFerias.Controls.Add(this.btnAgendar);
            this.gpbConsultarFerias.Controls.Add(this.lblEmpresa);
            this.gpbConsultarFerias.Controls.Add(this.btnListar);
            this.gpbConsultarFerias.Controls.Add(this.dgvFuncionarios);
            this.gpbConsultarFerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbConsultarFerias.Location = new System.Drawing.Point(12, 12);
            this.gpbConsultarFerias.Name = "gpbConsultarFerias";
            this.gpbConsultarFerias.Size = new System.Drawing.Size(960, 537);
            this.gpbConsultarFerias.TabIndex = 0;
            this.gpbConsultarFerias.TabStop = false;
            this.gpbConsultarFerias.Text = "Consultar tabela de férias";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(6, 56);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(800, 475);
            this.dgvFuncionarios.TabIndex = 0;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.LightBlue;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnListar.Location = new System.Drawing.Point(735, 20);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(107, 30);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblEmpresa.Location = new System.Drawing.Point(6, 29);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(398, 15);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Selecione uma empresa para listar os funcionários com direito as férias";
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAgendar.Location = new System.Drawing.Point(830, 169);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(107, 30);
            this.btnAgendar.TabIndex = 3;
            this.btnAgendar.Text = "Agendar Férias";
            this.btnAgendar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAtualizar.Location = new System.Drawing.Point(830, 220);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(107, 30);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar Férias";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnExcluir.Location = new System.Drawing.Point(830, 266);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir Férias";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnSair.Location = new System.Drawing.Point(830, 319);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 30);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // cmbListarFuncionarios
            // 
            this.cmbListarFuncionarios.BackColor = System.Drawing.Color.LightBlue;
            this.cmbListarFuncionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListarFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbListarFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbListarFuncionarios.FormattingEnabled = true;
            this.cmbListarFuncionarios.Location = new System.Drawing.Point(410, 24);
            this.cmbListarFuncionarios.Name = "cmbListarFuncionarios";
            this.cmbListarFuncionarios.Size = new System.Drawing.Size(300, 23);
            this.cmbListarFuncionarios.TabIndex = 7;
            // 
            // Form_ConsultarTabelaFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.gpbConsultarFerias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ConsultarTabelaFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Férias";
            this.Load += new System.EventHandler(this.Form_ConsultarTabelaFerias_Load);
            this.gpbConsultarFerias.ResumeLayout(false);
            this.gpbConsultarFerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsultarFerias;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.ComboBox cmbListarFuncionarios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button btnListar;
    }
}