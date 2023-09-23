﻿
using FolhaDePagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_ValeTransporte : Form
    {
        public Form_ValeTransporte()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Folha ObjFolha = new Folha();
            double retorno = ObjFolha.ContabilizarValeTransporte(Convert.ToDouble(txtSalarioBase.Text), Convert.ToDouble(txtPassagem.Text), Convert.ToInt16(txtDias.Text));
            txtRetorno.Text = retorno.ToString();
        }

        private void doisPeríodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AgendarFerias objForm_DoisPeriodos = new Form_AgendarFerias();
            objForm_DoisPeriodos.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalarioBase.Clear();
            txtPassagem.Clear();
            txtDias.Clear();
            txtRetorno.Clear();
            txtSalarioBase.Focus();
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // Preciso incluir na verificação para quando ele der focus ele altomaticamente retirar os numeros da caixa pois esta quebrando a funcionalidade da caixa.
            string validacao = txtDias.Text.Trim();
            if (string.IsNullOrEmpty(validacao))
            {
                txtDias.Focus();return;
            }
            if(!int.TryParse(validacao, out int dias))
            {
                MessageBox.Show("Este campo não aceita letras ou caracteres.", "ATENÇÃO");
                txtDias.Focus();
                return;
            }
            if(dias > 22)
            {
                MessageBox.Show("Este campo não aceita valores acima de 22.", "ATENÇÃO");
                txtDias.Focus();
                return;
            }
        }
    }
}
