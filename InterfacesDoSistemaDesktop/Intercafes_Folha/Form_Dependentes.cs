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
    public partial class Form_Dependentes : Form
    {
        public Form_Dependentes()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Folha folhaPG = new Folha();
            double retorno = folhaPG.CalcularDependencia(Convert.ToInt16(txtDependentes.Text));
            txtRetorno.Text = retorno.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDependentes.Clear();
            txtRetorno.Clear();
            txtDependentes.Focus();
        }
    }
}
