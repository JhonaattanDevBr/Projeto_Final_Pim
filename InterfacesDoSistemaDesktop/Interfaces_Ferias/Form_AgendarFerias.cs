using BeneficioDasFerias;
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
        AgendamentoFerias _agendamentoFerias = new AgendamentoFerias();

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

        private void txtPrimeiroPeriodoDias_TextChanged(object sender, EventArgs e)
        {
            string validacao = txtPrimeiroPeriodoDias.Text.Trim();
            if (string.IsNullOrEmpty(validacao))
            {
                txtPrimeiroPeriodoDias.Focus();
                return;
            }
            if (!int.TryParse(txtPrimeiroPeriodoDias.Text, out int venda))
            {
                MessageBox.Show("Este campo não aceita letras ou caracteres.", "ATENÇÃO");
                txtPrimeiroPeriodoDias.Clear();
                txtPrimeiroPeriodoDias.Focus();
                return;
            }
            if (venda > 30)
            {
                txtPrimeiroPeriodoDias.Clear();
                txtPrimeiroPeriodoDias.Focus();
                MessageBox.Show("Este campo não aceita valores acima de 30.", "ATENÇÃO");
                return;
            }
        }

        private void txtSegundoPeriodoDias_TextChanged(object sender, EventArgs e)
        {
            string validacao = txtSegundoPeriodoDias.Text.Trim();
            if (string.IsNullOrEmpty(validacao))
            {
                txtSegundoPeriodoDias.Focus();
                return;
            }
            if (!int.TryParse(txtSegundoPeriodoDias.Text, out int venda))
            {
                MessageBox.Show("Este campo não aceita letras ou caracteres.", "ATENÇÃO");
                txtSegundoPeriodoDias.Clear();
                txtSegundoPeriodoDias.Focus();
                return;
            }
            if (venda > 30)
            {
                txtSegundoPeriodoDias.Clear();
                txtSegundoPeriodoDias.Focus();
                MessageBox.Show("Este campo não aceita valores acima de 30.", "ATENÇÃO");
                return;
            }
        }

        private void txtTerceiroPeriodoDias_TextChanged(object sender, EventArgs e)
        {
            string validacao = txtTerceiroPeriodoDias.Text.Trim();
            if (string.IsNullOrEmpty(validacao))
            {
                txtTerceiroPeriodoDias.Focus();
                return;
            }
            if (!int.TryParse(txtTerceiroPeriodoDias.Text, out int venda))
            {
                MessageBox.Show("Este campo não aceita letras ou caracteres.", "ATENÇÃO");
                txtTerceiroPeriodoDias.Clear();
                txtTerceiroPeriodoDias.Focus();
                return;
            }
            if (venda > 30)
            {
                txtTerceiroPeriodoDias.Clear();
                txtTerceiroPeriodoDias.Focus();
                MessageBox.Show("Este campo não aceita valores acima de 30.", "ATENÇÃO");
                return;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                _agendamentoFerias.DiasVendidos = "0";
            }
            else
            {
                _agendamentoFerias.DiasVendidos = txtQuantidade.Text;
            }

            if (rdbDecimoTSim.Checked)
            {
                _agendamentoFerias.PrimeiraParcelaDecimo = rdbDecimoTSim.Text;
            }
            else
            {
                _agendamentoFerias.PrimeiraParcelaDecimo = rdbDecimoTNao.Text;
            }

            if (rdbPeriodoCompleto.Checked)
            {
                _agendamentoFerias.SegundoMes = "****";
                _agendamentoFerias.SegundoPeriodo = "0";
                _agendamentoFerias.TerceiroMes = "*****";
                _agendamentoFerias.TerceiroPeriodo = "0";
            }
            else if (rdbDoisPeriodos.Checked)
            {
                _agendamentoFerias.SegundoMes = cmbSegundoPeriodo.SelectedItem.ToString();
                _agendamentoFerias.SegundoPeriodo = txtSegundoPeriodoDias.Text;
                _agendamentoFerias.TerceiroMes = "*****";
                _agendamentoFerias.TerceiroPeriodo = "0";
            }
            else if (rdbTresPeriodos.Checked)
            {
                _agendamentoFerias.SegundoMes = cmbSegundoPeriodo.SelectedItem.ToString();
                _agendamentoFerias.SegundoPeriodo = txtSegundoPeriodoDias.Text;
                _agendamentoFerias.TerceiroMes = cmbTerceiroPeriodo.SelectedItem.ToString();
                _agendamentoFerias.TerceiroPeriodo = txtTerceiroPeriodoDias.Text;
            }

            if(cmbPrimeiroPeriodo.SelectedItem != null && !string.IsNullOrEmpty(txtPrimeiroPeriodoDias.Text))
            {
                _agendamentoFerias.PrimeiroMes = cmbPrimeiroPeriodo.SelectedItem.ToString();
                _agendamentoFerias.PrimeiroPeriodo = txtPrimeiroPeriodoDias.Text;

                bool retornoAutenticacao = _agendamentoFerias.AuntenticarAgendamentoFerias();
                if (retornoAutenticacao)
                {
                    MessageBox.Show("Agendamento realizado com sucesso.", "Operação concluida!");
                }
                else
                {
                    MessageBox.Show(_agendamentoFerias.MensagemErro, "Falha na operação");
                }
            }
        }
    }
}
