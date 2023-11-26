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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVisualizarConvOdonto = new System.Windows.Forms.DataGridView();
            this.gpbConvenioOdonto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarConvOdonto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConvenioOdonto
            // 
            this.gpbConvenioOdonto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbConvenioOdonto.Controls.Add(this.btnFechar);
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
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LightBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnFechar.Location = new System.Drawing.Point(782, 513);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarConvOdonto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConvenioOdonto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVisualizarConvOdonto;
    }
}