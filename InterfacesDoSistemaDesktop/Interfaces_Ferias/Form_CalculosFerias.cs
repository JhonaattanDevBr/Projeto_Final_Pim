using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeneficioDasFerias;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_CalculosFerias : Form
    {
        Ferias Obj_ferias = new Ferias();

        public Form_CalculosFerias()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double retorno;
            bool vdd = true;
            retorno = Obj_ferias.FormulaCalculoDeFerias(Convert.ToDouble(txtSalarioBase.Text), vdd, Convert.ToInt32(txtDiasPrimeiroPeriodo.Text));
            txtRetorno.Text = $"R$ {retorno:f2}".ToString();
        }

        private void btnCalcularAbono_Click(object sender, EventArgs e)
        {
            double valorFerias = Obj_ferias.FormulaVendaDasFerias(Convert.ToDouble(txtSalarioBase.Text), Convert.ToInt32(txtDiasVendidos.Text));
            txtAbonoPecuniario.Text = $"R$ {valorFerias:f2}".ToString();
        }
    }
}
