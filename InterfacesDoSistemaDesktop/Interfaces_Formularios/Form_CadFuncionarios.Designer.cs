namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    partial class Form_CadFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadFuncionarios));
            this.gpbCadastroFuncionarios = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gpbCadastroFuncionarios
            // 
            this.gpbCadastroFuncionarios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbCadastroFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbCadastroFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastroFuncionarios.Name = "gpbCadastroFuncionarios";
            this.gpbCadastroFuncionarios.Size = new System.Drawing.Size(960, 657);
            this.gpbCadastroFuncionarios.TabIndex = 0;
            this.gpbCadastroFuncionarios.TabStop = false;
            this.gpbCadastroFuncionarios.Text = "Cadastro de funcionários";
            // 
            // Form_CadFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.gpbCadastroFuncionarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CadFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastroFuncionarios;
    }
}