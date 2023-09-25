namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    partial class Form_Accesskey
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
            this.lblAccessKey = new System.Windows.Forms.Label();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccessKey
            // 
            this.lblAccessKey.AutoSize = true;
            this.lblAccessKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAccessKey.Location = new System.Drawing.Point(23, 27);
            this.lblAccessKey.Name = "lblAccessKey";
            this.lblAccessKey.Size = new System.Drawing.Size(288, 15);
            this.lblAccessKey.TabIndex = 0;
            this.lblAccessKey.Text = "Para prosseguir é necessario informar a access key";
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(52, 55);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(227, 20);
            this.txtAccessKey.TabIndex = 1;
            this.txtAccessKey.UseSystemPasswordChar = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightBlue;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(182, 89);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.LightBlue;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProsseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnProsseguir.Location = new System.Drawing.Point(263, 89);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(75, 30);
            this.btnProsseguir.TabIndex = 3;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // Form_Accesskey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(350, 124);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtAccessKey);
            this.Controls.Add(this.lblAccessKey);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Accesskey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccessKey;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProsseguir;
    }
}