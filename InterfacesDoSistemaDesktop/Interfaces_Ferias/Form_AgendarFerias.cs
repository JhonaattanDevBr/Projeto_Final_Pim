using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_AgendarFerias : Form
    {
        public Form_AgendarFerias()
        {
            InitializeComponent();
        }

        // Preciso colocar uma validação onde nenhum dos tres campos possa ser maior q 30

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                lblQuantidade.Enabled = true;
                txtQuantidade.Enabled = true;
            }
            else if (rdbSim.Checked == false)
            {
                lblQuantidade.Enabled = false;
                txtQuantidade.Enabled = false;
                txtQuantidade.Clear();
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("As férias foram agendadas com sucesso!", "Atividade concluida");
            Close();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            string validacao = txtQuantidade.Text.Trim();
            if (string.IsNullOrEmpty(validacao))
            {
                txtQuantidade.Focus();
                return;
            }
            if(!int.TryParse(txtQuantidade.Text, out int venda))
            {
                MessageBox.Show("Este campo não aceita letras ou caracteres.", "ATENÇÃO");
                txtQuantidade.Clear();
                txtQuantidade.Focus();
                return;
            }
            if(venda > 10)
            {
                txtQuantidade.Clear();
                txtQuantidade.Focus();
                MessageBox.Show("Este campo não aceita valores acima de 10.", "ATENÇÃO");
                return;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08)
            {
                e.Handled = true;
            }            
        }

        private void rdbPeriodoCompleto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPeriodoCompleto.Checked) 
            {
                cmbPrimeiroPeriodo.Enabled = true;
                txtPrimeiroPeriodoDias.Enabled = true;
                cmbSegundoPeriodo.Enabled = false;
                txtSegundoPeriodoDias.Enabled = false;
                cmbSegundoPeriodo.SelectedIndex = -1;
                txtSegundoPeriodoDias.Clear();
                cmbTerceiroPeriodo.Enabled = false;
                txtTerceiroPeriodoDias.Enabled = false;
                cmbTerceiroPeriodo.SelectedIndex = -1;
                txtTerceiroPeriodoDias.Clear();
            }
        }

        private void rdbDoisPeriodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDoisPeriodos.Checked)
            {
                cmbPrimeiroPeriodo.Enabled = true;
                txtPrimeiroPeriodoDias.Enabled = true;
                cmbSegundoPeriodo.Enabled = true;
                txtSegundoPeriodoDias.Enabled = true;
                cmbTerceiroPeriodo.Enabled = false;
                txtTerceiroPeriodoDias.Enabled = false;
                cmbTerceiroPeriodo.SelectedIndex = -1;
                txtTerceiroPeriodoDias.Clear();
            }
        }

        private void rdbTresPeriodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTresPeriodos.Checked)
            {
                cmbPrimeiroPeriodo.Enabled = true;
                txtPrimeiroPeriodoDias.Enabled = true;
                cmbSegundoPeriodo.Enabled = true;
                txtSegundoPeriodoDias.Enabled = true;
                cmbTerceiroPeriodo.Enabled = true;
                txtTerceiroPeriodoDias.Enabled = true;
            }
        }
    }
}
