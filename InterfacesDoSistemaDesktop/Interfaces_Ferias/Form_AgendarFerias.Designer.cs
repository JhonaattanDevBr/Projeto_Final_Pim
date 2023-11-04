namespace InterfacesDoSistemaDesktop
{
    partial class Form_AgendarFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgendarFerias));
            this.gpbAgendarFerias = new System.Windows.Forms.GroupBox();
            this.cmbTerceiroPeriodo = new System.Windows.Forms.ComboBox();
            this.txtTerceiroPeriodoDias = new System.Windows.Forms.TextBox();
            this.lblTerceiroPeriodoDias = new System.Windows.Forms.Label();
            this.lblTerceiroPeriodo = new System.Windows.Forms.Label();
            this.txtSegundoPeriodoDias = new System.Windows.Forms.TextBox();
            this.txtPrimeiroPeriodoDias = new System.Windows.Forms.TextBox();
            this.lblSegundoPeriodoDias = new System.Windows.Forms.Label();
            this.lblPrimeiroPeriodoDias = new System.Windows.Forms.Label();
            this.cmbSegundoPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbPrimeiroPeriodo = new System.Windows.Forms.ComboBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblSegundoPeriodo = new System.Windows.Forms.Label();
            this.lblPrimeiroPeriodo = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.lblVenda = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblEscolhaBeneficio = new System.Windows.Forms.Label();
            this.rdbPeriodoCompleto = new System.Windows.Forms.RadioButton();
            this.rdbDoisPeriodos = new System.Windows.Forms.RadioButton();
            this.rdbTresPeriodos = new System.Windows.Forms.RadioButton();
            this.gpbAgendarFerias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAgendarFerias
            // 
            this.gpbAgendarFerias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbAgendarFerias.Controls.Add(this.rdbTresPeriodos);
            this.gpbAgendarFerias.Controls.Add(this.rdbDoisPeriodos);
            this.gpbAgendarFerias.Controls.Add(this.rdbPeriodoCompleto);
            this.gpbAgendarFerias.Controls.Add(this.lblEscolhaBeneficio);
            this.gpbAgendarFerias.Controls.Add(this.btnConcluir);
            this.gpbAgendarFerias.Controls.Add(this.cmbTerceiroPeriodo);
            this.gpbAgendarFerias.Controls.Add(this.txtTerceiroPeriodoDias);
            this.gpbAgendarFerias.Controls.Add(this.lblTerceiroPeriodoDias);
            this.gpbAgendarFerias.Controls.Add(this.lblTerceiroPeriodo);
            this.gpbAgendarFerias.Controls.Add(this.txtSegundoPeriodoDias);
            this.gpbAgendarFerias.Controls.Add(this.txtPrimeiroPeriodoDias);
            this.gpbAgendarFerias.Controls.Add(this.lblSegundoPeriodoDias);
            this.gpbAgendarFerias.Controls.Add(this.lblPrimeiroPeriodoDias);
            this.gpbAgendarFerias.Controls.Add(this.cmbSegundoPeriodo);
            this.gpbAgendarFerias.Controls.Add(this.cmbPrimeiroPeriodo);
            this.gpbAgendarFerias.Controls.Add(this.btnAgendar);
            this.gpbAgendarFerias.Controls.Add(this.lblSegundoPeriodo);
            this.gpbAgendarFerias.Controls.Add(this.lblPrimeiroPeriodo);
            this.gpbAgendarFerias.Controls.Add(this.txtQuantidade);
            this.gpbAgendarFerias.Controls.Add(this.lblQuantidade);
            this.gpbAgendarFerias.Controls.Add(this.rdbNao);
            this.gpbAgendarFerias.Controls.Add(this.rdbSim);
            this.gpbAgendarFerias.Controls.Add(this.lblVenda);
            this.gpbAgendarFerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gpbAgendarFerias.ForeColor = System.Drawing.Color.Black;
            this.gpbAgendarFerias.Location = new System.Drawing.Point(12, 12);
            this.gpbAgendarFerias.Name = "gpbAgendarFerias";
            this.gpbAgendarFerias.Size = new System.Drawing.Size(490, 352);
            this.gpbAgendarFerias.TabIndex = 0;
            this.gpbAgendarFerias.TabStop = false;
            this.gpbAgendarFerias.Text = "Agendamento de férias";
            this.gpbAgendarFerias.Enter += new System.EventHandler(this.gpbDoisPeriodos_Enter);
            // 
            // cmbTerceiroPeriodo
            // 
            this.cmbTerceiroPeriodo.BackColor = System.Drawing.Color.LightBlue;
            this.cmbTerceiroPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerceiroPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTerceiroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTerceiroPeriodo.FormattingEnabled = true;
            this.cmbTerceiroPeriodo.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbTerceiroPeriodo.Location = new System.Drawing.Point(187, 252);
            this.cmbTerceiroPeriodo.Name = "cmbTerceiroPeriodo";
            this.cmbTerceiroPeriodo.Size = new System.Drawing.Size(181, 23);
            this.cmbTerceiroPeriodo.TabIndex = 18;
            // 
            // txtTerceiroPeriodoDias
            // 
            this.txtTerceiroPeriodoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTerceiroPeriodoDias.Location = new System.Drawing.Point(412, 254);
            this.txtTerceiroPeriodoDias.Name = "txtTerceiroPeriodoDias";
            this.txtTerceiroPeriodoDias.Size = new System.Drawing.Size(46, 21);
            this.txtTerceiroPeriodoDias.TabIndex = 17;
            // 
            // lblTerceiroPeriodoDias
            // 
            this.lblTerceiroPeriodoDias.AutoSize = true;
            this.lblTerceiroPeriodoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTerceiroPeriodoDias.Location = new System.Drawing.Point(374, 254);
            this.lblTerceiroPeriodoDias.Name = "lblTerceiroPeriodoDias";
            this.lblTerceiroPeriodoDias.Size = new System.Drawing.Size(32, 15);
            this.lblTerceiroPeriodoDias.TabIndex = 15;
            this.lblTerceiroPeriodoDias.Text = "Dias";
            // 
            // lblTerceiroPeriodo
            // 
            this.lblTerceiroPeriodo.AutoSize = true;
            this.lblTerceiroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTerceiroPeriodo.Location = new System.Drawing.Point(6, 254);
            this.lblTerceiroPeriodo.Name = "lblTerceiroPeriodo";
            this.lblTerceiroPeriodo.Size = new System.Drawing.Size(174, 15);
            this.lblTerceiroPeriodo.TabIndex = 14;
            this.lblTerceiroPeriodo.Text = "Informe o 3º periodo das férias";
            // 
            // txtSegundoPeriodoDias
            // 
            this.txtSegundoPeriodoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSegundoPeriodoDias.Location = new System.Drawing.Point(412, 215);
            this.txtSegundoPeriodoDias.Name = "txtSegundoPeriodoDias";
            this.txtSegundoPeriodoDias.Size = new System.Drawing.Size(46, 21);
            this.txtSegundoPeriodoDias.TabIndex = 13;
            // 
            // txtPrimeiroPeriodoDias
            // 
            this.txtPrimeiroPeriodoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPrimeiroPeriodoDias.Location = new System.Drawing.Point(412, 177);
            this.txtPrimeiroPeriodoDias.Name = "txtPrimeiroPeriodoDias";
            this.txtPrimeiroPeriodoDias.Size = new System.Drawing.Size(46, 21);
            this.txtPrimeiroPeriodoDias.TabIndex = 12;
            // 
            // lblSegundoPeriodoDias
            // 
            this.lblSegundoPeriodoDias.AutoSize = true;
            this.lblSegundoPeriodoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSegundoPeriodoDias.Location = new System.Drawing.Point(374, 218);
            this.lblSegundoPeriodoDias.Name = "lblSegundoPeriodoDias";
            this.lblSegundoPeriodoDias.Size = new System.Drawing.Size(32, 15);
            this.lblSegundoPeriodoDias.TabIndex = 11;
            this.lblSegundoPeriodoDias.Text = "Dias";
            // 
            // lblPrimeiroPeriodoDias
            // 
            this.lblPrimeiroPeriodoDias.AutoSize = true;
            this.lblPrimeiroPeriodoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPrimeiroPeriodoDias.Location = new System.Drawing.Point(374, 180);
            this.lblPrimeiroPeriodoDias.Name = "lblPrimeiroPeriodoDias";
            this.lblPrimeiroPeriodoDias.Size = new System.Drawing.Size(32, 15);
            this.lblPrimeiroPeriodoDias.TabIndex = 10;
            this.lblPrimeiroPeriodoDias.Text = "Dias";
            // 
            // cmbSegundoPeriodo
            // 
            this.cmbSegundoPeriodo.BackColor = System.Drawing.Color.LightBlue;
            this.cmbSegundoPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSegundoPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSegundoPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbSegundoPeriodo.FormattingEnabled = true;
            this.cmbSegundoPeriodo.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbSegundoPeriodo.Location = new System.Drawing.Point(187, 215);
            this.cmbSegundoPeriodo.Name = "cmbSegundoPeriodo";
            this.cmbSegundoPeriodo.Size = new System.Drawing.Size(181, 23);
            this.cmbSegundoPeriodo.TabIndex = 9;
            // 
            // cmbPrimeiroPeriodo
            // 
            this.cmbPrimeiroPeriodo.BackColor = System.Drawing.Color.LightBlue;
            this.cmbPrimeiroPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimeiroPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPrimeiroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbPrimeiroPeriodo.FormattingEnabled = true;
            this.cmbPrimeiroPeriodo.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbPrimeiroPeriodo.Location = new System.Drawing.Point(187, 177);
            this.cmbPrimeiroPeriodo.Name = "cmbPrimeiroPeriodo";
            this.cmbPrimeiroPeriodo.Size = new System.Drawing.Size(181, 23);
            this.cmbPrimeiroPeriodo.TabIndex = 8;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnAgendar.Location = new System.Drawing.Point(9, 299);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 30);
            this.btnAgendar.TabIndex = 7;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblSegundoPeriodo
            // 
            this.lblSegundoPeriodo.AutoSize = true;
            this.lblSegundoPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSegundoPeriodo.Location = new System.Drawing.Point(6, 218);
            this.lblSegundoPeriodo.Name = "lblSegundoPeriodo";
            this.lblSegundoPeriodo.Size = new System.Drawing.Size(174, 15);
            this.lblSegundoPeriodo.TabIndex = 6;
            this.lblSegundoPeriodo.Text = "Informe o 2º periodo das férias";
            // 
            // lblPrimeiroPeriodo
            // 
            this.lblPrimeiroPeriodo.AutoSize = true;
            this.lblPrimeiroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPrimeiroPeriodo.Location = new System.Drawing.Point(6, 180);
            this.lblPrimeiroPeriodo.Name = "lblPrimeiroPeriodo";
            this.lblPrimeiroPeriodo.Size = new System.Drawing.Size(174, 15);
            this.lblPrimeiroPeriodo.TabIndex = 5;
            this.lblPrimeiroPeriodo.Text = "Informe o 1º periodo das férias";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtQuantidade.Location = new System.Drawing.Point(178, 68);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(38, 21);
            this.txtQuantidade.TabIndex = 4;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Enabled = false;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblQuantidade.Location = new System.Drawing.Point(6, 69);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(166, 15);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade de dias vendidos";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Checked = true;
            this.rdbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rdbNao.Location = new System.Drawing.Point(307, 30);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(55, 21);
            this.rdbNao.TabIndex = 2;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rdbSim.Location = new System.Drawing.Point(249, 30);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(52, 21);
            this.rdbSim.TabIndex = 1;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblVenda.Location = new System.Drawing.Point(6, 34);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(237, 15);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "O funcionário solicitou a venda das férias?";
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.LightBlue;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnConcluir.Location = new System.Drawing.Point(105, 299);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 30);
            this.btnConcluir.TabIndex = 4;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblEscolhaBeneficio
            // 
            this.lblEscolhaBeneficio.AutoSize = true;
            this.lblEscolhaBeneficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblEscolhaBeneficio.Location = new System.Drawing.Point(6, 105);
            this.lblEscolhaBeneficio.Name = "lblEscolhaBeneficio";
            this.lblEscolhaBeneficio.Size = new System.Drawing.Size(284, 15);
            this.lblEscolhaBeneficio.TabIndex = 19;
            this.lblEscolhaBeneficio.Text = "Como o funcionário optou por receber o benefício?";
            // 
            // rdbPeriodoCompleto
            // 
            this.rdbPeriodoCompleto.AutoSize = true;
            this.rdbPeriodoCompleto.Location = new System.Drawing.Point(6, 133);
            this.rdbPeriodoCompleto.Name = "rdbPeriodoCompleto";
            this.rdbPeriodoCompleto.Size = new System.Drawing.Size(152, 21);
            this.rdbPeriodoCompleto.TabIndex = 20;
            this.rdbPeriodoCompleto.TabStop = true;
            this.rdbPeriodoCompleto.Text = "Período completo";
            this.rdbPeriodoCompleto.UseVisualStyleBackColor = true;
            // 
            // rdbDoisPeriodos
            // 
            this.rdbDoisPeriodos.AutoSize = true;
            this.rdbDoisPeriodos.Location = new System.Drawing.Point(164, 133);
            this.rdbDoisPeriodos.Name = "rdbDoisPeriodos";
            this.rdbDoisPeriodos.Size = new System.Drawing.Size(126, 21);
            this.rdbDoisPeriodos.TabIndex = 21;
            this.rdbDoisPeriodos.TabStop = true;
            this.rdbDoisPeriodos.Text = "Dois períodos";
            this.rdbDoisPeriodos.UseVisualStyleBackColor = true;
            // 
            // rdbTresPeriodos
            // 
            this.rdbTresPeriodos.AutoSize = true;
            this.rdbTresPeriodos.Location = new System.Drawing.Point(296, 133);
            this.rdbTresPeriodos.Name = "rdbTresPeriodos";
            this.rdbTresPeriodos.Size = new System.Drawing.Size(127, 21);
            this.rdbTresPeriodos.TabIndex = 22;
            this.rdbTresPeriodos.TabStop = true;
            this.rdbTresPeriodos.Text = "Três períodos";
            this.rdbTresPeriodos.UseVisualStyleBackColor = true;
            // 
            // Form_AgendarFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(514, 376);
            this.Controls.Add(this.gpbAgendarFerias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AgendarFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Férias";
            this.gpbAgendarFerias.ResumeLayout(false);
            this.gpbAgendarFerias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAgendarFerias;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblSegundoPeriodo;
        private System.Windows.Forms.Label lblPrimeiroPeriodo;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.ComboBox cmbSegundoPeriodo;
        private System.Windows.Forms.ComboBox cmbPrimeiroPeriodo;
        private System.Windows.Forms.TextBox txtSegundoPeriodoDias;
        private System.Windows.Forms.TextBox txtPrimeiroPeriodoDias;
        private System.Windows.Forms.Label lblSegundoPeriodoDias;
        private System.Windows.Forms.Label lblPrimeiroPeriodoDias;
        private System.Windows.Forms.TextBox txtTerceiroPeriodoDias;
        private System.Windows.Forms.Label lblTerceiroPeriodoDias;
        private System.Windows.Forms.Label lblTerceiroPeriodo;
        private System.Windows.Forms.ComboBox cmbTerceiroPeriodo;
        private System.Windows.Forms.Label lblEscolhaBeneficio;
        private System.Windows.Forms.RadioButton rdbPeriodoCompleto;
        private System.Windows.Forms.RadioButton rdbDoisPeriodos;
        private System.Windows.Forms.RadioButton rdbTresPeriodos;
    }
}