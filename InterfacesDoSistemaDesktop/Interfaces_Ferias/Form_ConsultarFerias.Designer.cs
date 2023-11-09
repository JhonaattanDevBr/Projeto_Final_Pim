namespace InterfacesDoSistemaDesktop.Interfaces_Ferias
{
    partial class Form_ConsultarFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConsultarFerias));
            this.gpbConsultarFerias = new System.Windows.Forms.GroupBox();
            this.dgvConsultarFerias = new System.Windows.Forms.DataGridView();
            this.cmbListarEmpresas = new System.Windows.Forms.ComboBox();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.gpbConsultarFerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFerias)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultarFerias
            // 
            this.gpbConsultarFerias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbConsultarFerias.Controls.Add(this.btnListar);
            this.gpbConsultarFerias.Controls.Add(this.dgvConsultarFerias);
            this.gpbConsultarFerias.Controls.Add(this.cmbListarEmpresas);
            this.gpbConsultarFerias.Controls.Add(this.lblConsultar);
            this.gpbConsultarFerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbConsultarFerias.Location = new System.Drawing.Point(12, 12);
            this.gpbConsultarFerias.Name = "gpbConsultarFerias";
            this.gpbConsultarFerias.Size = new System.Drawing.Size(960, 537);
            this.gpbConsultarFerias.TabIndex = 0;
            this.gpbConsultarFerias.TabStop = false;
            this.gpbConsultarFerias.Text = "Consultar funcionarios com férias disponíveis";
            // 
            // dgvConsultarFerias
            // 
            this.dgvConsultarFerias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConsultarFerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFerias.Location = new System.Drawing.Point(9, 53);
            this.dgvConsultarFerias.Name = "dgvConsultarFerias";
            this.dgvConsultarFerias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarFerias.Size = new System.Drawing.Size(777, 478);
            this.dgvConsultarFerias.TabIndex = 2;
            this.dgvConsultarFerias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarFerias_CellClick);
            // 
            // cmbListarEmpresas
            // 
            this.cmbListarEmpresas.BackColor = System.Drawing.Color.LightBlue;
            this.cmbListarEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbListarEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbListarEmpresas.FormattingEnabled = true;
            this.cmbListarEmpresas.Location = new System.Drawing.Point(383, 24);
            this.cmbListarEmpresas.Name = "cmbListarEmpresas";
            this.cmbListarEmpresas.Size = new System.Drawing.Size(300, 23);
            this.cmbListarEmpresas.TabIndex = 1;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblConsultar.Location = new System.Drawing.Point(6, 29);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(371, 15);
            this.lblConsultar.TabIndex = 0;
            this.lblConsultar.Text = "Selecione uma empresa para listar seus funcionários benefíciados\r\n";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.LightBlue;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnListar.Location = new System.Drawing.Point(711, 17);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 30);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form_ConsultarFerias
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
            this.Name = "Form_ConsultarFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Férias";
            this.Load += new System.EventHandler(this.Form_ConsultarFerias_Load);
            this.gpbConsultarFerias.ResumeLayout(false);
            this.gpbConsultarFerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFerias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsultarFerias;
        private System.Windows.Forms.ComboBox cmbListarEmpresas;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.DataGridView dgvConsultarFerias;
        private System.Windows.Forms.Button btnListar;
    }
}