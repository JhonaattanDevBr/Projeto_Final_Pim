using DecimoTerceiroSalario;
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
    public partial class Form_DecimoTerceiro : Form
    {
        DecimoTerceiro decimoTerceiro = new DecimoTerceiro();
        public Form_DecimoTerceiro()
        {
            InitializeComponent();
        }

        
        // Ainda não esta funcionando corretamente precisso arrumar 
        private void rdbSemBeneficio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSemBeneficio.Checked)
            {
                rdbPrimeiraParcela.Checked = false;
                rdbSegundaParcela.Checked = false;
                gpbCalcular.Visible = false;
                gpbInssIrrf.Visible = false;
            }
        }

        private void rdbPrimeiraParcela_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrimeiraParcela.Checked)
            {
                rdbSemBeneficio.Checked = false;
                rdbSegundaParcela.Checked = false;
                gpbCalcular.Visible = true;
                gpbInssIrrf.Visible = false;
            }
        }

        private void rdbSegundaParcela_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSegundaParcela.Checked)
            {
                rdbSemBeneficio.Checked = false;
                rdbPrimeiraParcela.Checked = false;
                gpbCalcular.Visible = true;
                gpbInssIrrf.Visible = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double retorno;
            if (rdbPrimeiraParcela.Checked)
            {
                retorno = decimoTerceiro.CalcularPrimeiraParcelaDoDecimoTerceiro(Convert.ToDouble(txtSalarioBase.Text), Convert.ToInt32(txtMesesTrabalhados.Text));
                txtRetorno.Text = $"{retorno:f2}".ToString();
            }
            else if (rdbSegundaParcela.Checked)
            {
                retorno = decimoTerceiro.CalcularSegundaParcelaDoDecimoTerceiro(Convert.ToDouble(txtSalarioBase.Text), Convert.ToInt32(txtMesesTrabalhados.Text), Convert.ToDouble(txtInss.Text), Convert.ToDouble(txtIrrf.Text));
                txtRetorno.Text = $"{retorno:f2}".ToString();
            }
        }
    }
}
