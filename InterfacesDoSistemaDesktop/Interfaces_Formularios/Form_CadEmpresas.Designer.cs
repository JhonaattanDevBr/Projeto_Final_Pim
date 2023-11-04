namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    partial class Form_CadEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadEmpresas));
            this.gpbCadEmpresas = new System.Windows.Forms.GroupBox();
            this.btnCadastrarEmpresa = new System.Windows.Forms.Button();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.gpbEmpresa = new System.Windows.Forms.GroupBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtNascionalidade = new System.Windows.Forms.TextBox();
            this.lblNascionalidade = new System.Windows.Forms.Label();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCeo = new System.Windows.Forms.TextBox();
            this.lblCeo = new System.Windows.Forms.Label();
            this.dtmDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.lblDataFundacao = new System.Windows.Forms.Label();
            this.txtSegmento = new System.Windows.Forms.TextBox();
            this.lblSegmento = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gpbCadEmpresas.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.gpbEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadEmpresas
            // 
            this.gpbCadEmpresas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbCadEmpresas.Controls.Add(this.btnCadastrarEmpresa);
            this.gpbCadEmpresas.Controls.Add(this.gpbEndereco);
            this.gpbCadEmpresas.Controls.Add(this.gpbEmpresa);
            this.gpbCadEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbCadEmpresas.Location = new System.Drawing.Point(13, 13);
            this.gpbCadEmpresas.Name = "gpbCadEmpresas";
            this.gpbCadEmpresas.Size = new System.Drawing.Size(818, 525);
            this.gpbCadEmpresas.TabIndex = 0;
            this.gpbCadEmpresas.TabStop = false;
            this.gpbCadEmpresas.Text = "Cadastro de empresa";
            // 
            // btnCadastrarEmpresa
            // 
            this.btnCadastrarEmpresa.BackColor = System.Drawing.Color.LightBlue;
            this.btnCadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnCadastrarEmpresa.Location = new System.Drawing.Point(333, 469);
            this.btnCadastrarEmpresa.Name = "btnCadastrarEmpresa";
            this.btnCadastrarEmpresa.Size = new System.Drawing.Size(142, 30);
            this.btnCadastrarEmpresa.TabIndex = 2;
            this.btnCadastrarEmpresa.Text = "Cadastrar Empresa";
            this.btnCadastrarEmpresa.UseVisualStyleBackColor = false;
            this.btnCadastrarEmpresa.Click += new System.EventHandler(this.btnCadastrarEmpresa_Click);
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Controls.Add(this.lblRua);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.txtEstado);
            this.gpbEndereco.Controls.Add(this.lblEstado);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Location = new System.Drawing.Point(15, 266);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(724, 174);
            this.gpbEndereco.TabIndex = 1;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // gpbEmpresa
            // 
            this.gpbEmpresa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbEmpresa.Controls.Add(this.txtSegmento);
            this.gpbEmpresa.Controls.Add(this.lblSegmento);
            this.gpbEmpresa.Controls.Add(this.dtmDataFundacao);
            this.gpbEmpresa.Controls.Add(this.lblDataFundacao);
            this.gpbEmpresa.Controls.Add(this.txtCeo);
            this.gpbEmpresa.Controls.Add(this.lblCeo);
            this.gpbEmpresa.Controls.Add(this.mskTelefone);
            this.gpbEmpresa.Controls.Add(this.lblTelefone);
            this.gpbEmpresa.Controls.Add(this.txtEmail);
            this.gpbEmpresa.Controls.Add(this.lblEmail);
            this.gpbEmpresa.Controls.Add(this.mskCnpj);
            this.gpbEmpresa.Controls.Add(this.lblCnpj);
            this.gpbEmpresa.Controls.Add(this.txtNascionalidade);
            this.gpbEmpresa.Controls.Add(this.lblNascionalidade);
            this.gpbEmpresa.Controls.Add(this.txtNomeFantasia);
            this.gpbEmpresa.Controls.Add(this.lblNomeFantasia);
            this.gpbEmpresa.Controls.Add(this.txtRazaoSocial);
            this.gpbEmpresa.Controls.Add(this.lblRazaoSocial);
            this.gpbEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpbEmpresa.Location = new System.Drawing.Point(15, 34);
            this.gpbEmpresa.Name = "gpbEmpresa";
            this.gpbEmpresa.Size = new System.Drawing.Size(786, 213);
            this.gpbEmpresa.TabIndex = 0;
            this.gpbEmpresa.TabStop = false;
            this.gpbEmpresa.Text = "Dados da empresa";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BackColor = System.Drawing.SystemColors.Window;
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRazaoSocial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtRazaoSocial.Location = new System.Drawing.Point(13, 47);
            this.txtRazaoSocial.MaxLength = 255;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(200, 21);
            this.txtRazaoSocial.TabIndex = 11;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRazaoSocial.Location = new System.Drawing.Point(10, 29);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(78, 15);
            this.lblRazaoSocial.TabIndex = 10;
            this.lblRazaoSocial.Text = "Razão social";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNomeFantasia.Location = new System.Drawing.Point(13, 106);
            this.txtNomeFantasia.MaxLength = 255;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(200, 21);
            this.txtNomeFantasia.TabIndex = 13;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNomeFantasia.Location = new System.Drawing.Point(10, 88);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(87, 15);
            this.lblNomeFantasia.TabIndex = 12;
            this.lblNomeFantasia.Text = "Nome fantasia";
            // 
            // txtNascionalidade
            // 
            this.txtNascionalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNascionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNascionalidade.Location = new System.Drawing.Point(13, 166);
            this.txtNascionalidade.MaxLength = 60;
            this.txtNascionalidade.Name = "txtNascionalidade";
            this.txtNascionalidade.Size = new System.Drawing.Size(150, 21);
            this.txtNascionalidade.TabIndex = 15;
            // 
            // lblNascionalidade
            // 
            this.lblNascionalidade.AutoSize = true;
            this.lblNascionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNascionalidade.Location = new System.Drawing.Point(10, 148);
            this.lblNascionalidade.Name = "lblNascionalidade";
            this.lblNascionalidade.Size = new System.Drawing.Size(93, 15);
            this.lblNascionalidade.TabIndex = 14;
            this.lblNascionalidade.Text = "Nascionalidade";
            // 
            // mskCnpj
            // 
            this.mskCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskCnpj.Location = new System.Drawing.Point(296, 47);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(150, 21);
            this.mskCnpj.TabIndex = 17;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCnpj.Location = new System.Drawing.Point(293, 29);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(38, 15);
            this.lblCnpj.TabIndex = 16;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmail.Location = new System.Drawing.Point(296, 106);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 21);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblEmail.Location = new System.Drawing.Point(293, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 15);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E-mail";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskTelefone.Location = new System.Drawing.Point(293, 166);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(120, 21);
            this.mskTelefone.TabIndex = 21;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTelefone.Location = new System.Drawing.Point(290, 148);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 15);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtCeo
            // 
            this.txtCeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCeo.Location = new System.Drawing.Point(536, 47);
            this.txtCeo.MaxLength = 100;
            this.txtCeo.Name = "txtCeo";
            this.txtCeo.Size = new System.Drawing.Size(200, 21);
            this.txtCeo.TabIndex = 23;
            // 
            // lblCeo
            // 
            this.lblCeo.AutoSize = true;
            this.lblCeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCeo.Location = new System.Drawing.Point(533, 29);
            this.lblCeo.Name = "lblCeo";
            this.lblCeo.Size = new System.Drawing.Size(32, 15);
            this.lblCeo.TabIndex = 22;
            this.lblCeo.Text = "CEO";
            // 
            // dtmDataFundacao
            // 
            this.dtmDataFundacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtmDataFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDataFundacao.Location = new System.Drawing.Point(538, 106);
            this.dtmDataFundacao.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtmDataFundacao.Name = "dtmDataFundacao";
            this.dtmDataFundacao.Size = new System.Drawing.Size(110, 23);
            this.dtmDataFundacao.TabIndex = 24;
            this.dtmDataFundacao.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.dtmDataFundacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmDataFundacao_KeyPress);
            // 
            // lblDataFundacao
            // 
            this.lblDataFundacao.AutoSize = true;
            this.lblDataFundacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblDataFundacao.Location = new System.Drawing.Point(533, 88);
            this.lblDataFundacao.Name = "lblDataFundacao";
            this.lblDataFundacao.Size = new System.Drawing.Size(104, 15);
            this.lblDataFundacao.TabIndex = 25;
            this.lblDataFundacao.Text = "Data de fundação";
            // 
            // txtSegmento
            // 
            this.txtSegmento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSegmento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSegmento.Location = new System.Drawing.Point(536, 166);
            this.txtSegmento.MaxLength = 100;
            this.txtSegmento.Name = "txtSegmento";
            this.txtSegmento.Size = new System.Drawing.Size(150, 21);
            this.txtSegmento.TabIndex = 27;
            // 
            // lblSegmento
            // 
            this.lblSegmento.AutoSize = true;
            this.lblSegmento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSegmento.Location = new System.Drawing.Point(533, 148);
            this.lblSegmento.Name = "lblSegmento";
            this.lblSegmento.Size = new System.Drawing.Size(64, 15);
            this.lblSegmento.TabIndex = 26;
            this.lblSegmento.Text = "Segmento";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCidade.Location = new System.Drawing.Point(13, 52);
            this.txtCidade.MaxLength = 40;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(150, 21);
            this.txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCidade.Location = new System.Drawing.Point(10, 34);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 15);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEstado.Location = new System.Drawing.Point(293, 52);
            this.txtEstado.MaxLength = 40;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(150, 21);
            this.txtEstado.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblEstado.Location = new System.Drawing.Point(290, 34);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBairro.Location = new System.Drawing.Point(536, 52);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(150, 21);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblBairro.Location = new System.Drawing.Point(533, 34);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 15);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRua.Location = new System.Drawing.Point(13, 115);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(200, 21);
            this.txtRua.TabIndex = 13;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRua.Location = new System.Drawing.Point(10, 97);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 15);
            this.lblRua.TabIndex = 12;
            this.lblRua.Text = "Rua";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumero.Location = new System.Drawing.Point(293, 115);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 21);
            this.txtNumero.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNumero.Location = new System.Drawing.Point(290, 97);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 15);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Número";
            // 
            // Form_CadEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(843, 550);
            this.Controls.Add(this.gpbCadEmpresas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CadEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Empresas";
            this.gpbCadEmpresas.ResumeLayout(false);
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbEmpresa.ResumeLayout(false);
            this.gpbEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadEmpresas;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.GroupBox gpbEmpresa;
        private System.Windows.Forms.Button btnCadastrarEmpresa;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtNascionalidade;
        private System.Windows.Forms.Label lblNascionalidade;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCeo;
        private System.Windows.Forms.Label lblCeo;
        private System.Windows.Forms.DateTimePicker dtmDataFundacao;
        private System.Windows.Forms.Label lblDataFundacao;
        private System.Windows.Forms.TextBox txtSegmento;
        private System.Windows.Forms.Label lblSegmento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
    }
}