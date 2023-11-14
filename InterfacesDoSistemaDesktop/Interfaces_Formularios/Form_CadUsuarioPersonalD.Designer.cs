namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    partial class Form_CadUsuarioPersonalD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadUsuarioPersonalD));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmacaoSenha = new System.Windows.Forms.Label();
            this.btnCriarUsuario = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.gpbCadUsuarioPersonalD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbCadUsuarioPersonalD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNome.Location = new System.Drawing.Point(6, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Primeiro nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCargo.Location = new System.Drawing.Point(6, 87);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(40, 15);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSetor.Location = new System.Drawing.Point(6, 138);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(36, 15);
            this.lblSetor.TabIndex = 2;
            this.lblSetor.Text = "Setor";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblUsuario.Location = new System.Drawing.Point(6, 192);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 15);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nome de usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSenha.Location = new System.Drawing.Point(6, 247);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 15);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmacaoSenha
            // 
            this.lblConfirmacaoSenha.AutoSize = true;
            this.lblConfirmacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblConfirmacaoSenha.Location = new System.Drawing.Point(6, 304);
            this.lblConfirmacaoSenha.Name = "lblConfirmacaoSenha";
            this.lblConfirmacaoSenha.Size = new System.Drawing.Size(117, 15);
            this.lblConfirmacaoSenha.TabIndex = 5;
            this.lblConfirmacaoSenha.Text = "Confirme sua senha";
            // 
            // btnCriarUsuario
            // 
            this.btnCriarUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.btnCriarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCriarUsuario.Location = new System.Drawing.Point(73, 371);
            this.btnCriarUsuario.Name = "btnCriarUsuario";
            this.btnCriarUsuario.Size = new System.Drawing.Size(101, 30);
            this.btnCriarUsuario.TabIndex = 6;
            this.btnCriarUsuario.Text = "Criar Usuário";
            this.btnCriarUsuario.UseVisualStyleBackColor = false;
            this.btnCriarUsuario.Click += new System.EventHandler(this.btnCriarUsuario_Click);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtNome.Location = new System.Drawing.Point(6, 50);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtCargo
            // 
            this.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtCargo.Location = new System.Drawing.Point(6, 105);
            this.txtCargo.MaxLength = 40;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(244, 20);
            this.txtCargo.TabIndex = 8;
            // 
            // txtSetor
            // 
            this.txtSetor.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtSetor.Location = new System.Drawing.Point(6, 156);
            this.txtSetor.MaxLength = 40;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(244, 20);
            this.txtSetor.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.CausesValidation = false;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtUsuario.Location = new System.Drawing.Point(6, 210);
            this.txtUsuario.MaxLength = 40;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(244, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtSenha.Location = new System.Drawing.Point(6, 265);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(244, 20);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(6, 322);
            this.txtConfirmacaoSenha.MaxLength = 15;
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(244, 20);
            this.txtConfirmacaoSenha.TabIndex = 12;
            this.txtConfirmacaoSenha.UseSystemPasswordChar = true;
            // 
            // gpbCadUsuarioPersonalD
            // 
            this.gpbCadUsuarioPersonalD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbCadUsuarioPersonalD.Controls.Add(this.btnCancelar);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.txtNome);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.txtConfirmacaoSenha);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.lblNome);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.txtSenha);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.lblCargo);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.txtUsuario);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.lblSetor);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.txtSetor);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.lblUsuario);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.txtCargo);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.lblSenha);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.lblConfirmacaoSenha);
            this.gpbCadUsuarioPersonalD.Controls.Add(this.btnCriarUsuario);
            this.gpbCadUsuarioPersonalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbCadUsuarioPersonalD.Location = new System.Drawing.Point(12, 12);
            this.gpbCadUsuarioPersonalD.Name = "gpbCadUsuarioPersonalD";
            this.gpbCadUsuarioPersonalD.Size = new System.Drawing.Size(444, 426);
            this.gpbCadUsuarioPersonalD.TabIndex = 13;
            this.gpbCadUsuarioPersonalD.TabStop = false;
            this.gpbCadUsuarioPersonalD.Text = "Cadastro de usuário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(189, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form_CadUsuarioPersonalD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.gpbCadUsuarioPersonalD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CadUsuarioPersonalD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários Personal Dynamic";
            this.gpbCadUsuarioPersonalD.ResumeLayout(false);
            this.gpbCadUsuarioPersonalD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmacaoSenha;
        private System.Windows.Forms.Button btnCriarUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.GroupBox gpbCadUsuarioPersonalD;
        private System.Windows.Forms.Button btnCancelar;
    }
}