﻿using InterfacesDoSistemaDesktop.Interfaces_Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Interfaces_Acesso
{
    public partial class Form_Acesso : Form
    {
        public Form_Acesso()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente encerrar a aplicação ?", "Atenção!", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Form_Accesskey form_Accesskey = new Form_Accesskey();
            form_Accesskey.ShowDialog();
        }
    }
}
