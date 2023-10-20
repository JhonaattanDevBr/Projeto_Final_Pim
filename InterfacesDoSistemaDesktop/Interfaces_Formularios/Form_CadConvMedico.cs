using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanoSaude;
using ConexaoBaseDados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_CadConvMedico : Form
    {
        ConvenioMedico conMedico = new ConvenioMedico();
        crud_PlanoSaude _crud_PlanoSaude = new crud_PlanoSaude();

        public Form_CadConvMedico()
        {
            InitializeComponent();
        }

        private void btnCadastrarConvMedico_Click(object sender, EventArgs e)
        {
            bool retornoCadastro;
            // Preciso replicar isso no CadConvenioMedico
            if (txtValorConvMedico.Text == "")
            {
                conMedico.ValorConvMedico = "0";
                conMedico.PorcentagemConvMedico = txtPorcentagemConvMedico.Text;
            }
            else
            {
                conMedico.PorcentagemConvMedico = "0";
                conMedico.ValorConvMedico = txtValorConvMedico.Text;
            }
            conMedico.CnpjConvMedico = mskCnpjConvMedico.Text;
            conMedico.NomeConvMedico = txtNomeConvMedico.Text;

            retornoCadastro = conMedico.AutenticarCadConvMedico();
            if (retornoCadastro)
            {
                bool incluirConvMedico = _crud_PlanoSaude.CadastrarConvMedico(conMedico);
                if (incluirConvMedico)
                {
                    // a mensagem esta ao contrario.
                    DialogResult sair =  MessageBox.Show("Cadastro realizado com sucesso!\nDeseja inserir um novo convênio ?", "Operação concluida!", MessageBoxButtons.YesNo);
                    if (sair == DialogResult.Yes)
                    {
                        txtNomeConvMedico.Clear();
                        mskCnpjConvMedico.Clear();
                        txtValorConvMedico.Clear();
                        txtPorcentagemConvMedico.Clear();
                        txtNomeConvMedico.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(conMedico.MensagemErro, "Falha na operação!");
            }
        }

        private void txtValorConvMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int) e.KeyChar;
            if(!char.IsDigit(e.KeyChar) && valorDigitado != 08 && valorDigitado != 46 && valorDigitado != 44 )
            {
                e.Handled = true;
            }
        }

        private void txtValorConvMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbValorFixado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbValorFixado.Checked)
            {
                txtPorcentagemConvMedico.Clear();
                lblValorConvMedico.Enabled = true;
                txtValorConvMedico.Enabled = true;
                lblPorcentagemConvMedico.Enabled = false;
                txtPorcentagemConvMedico.Enabled = false;
                //txtPorcentagemConvOdonto.Text = "0";
            }
        }

        private void rdbPercentual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPercentual.Checked)
            {
                txtValorConvMedico.Clear();
                lblPorcentagemConvMedico.Enabled = true;
                txtPorcentagemConvMedico.Enabled = true;
                lblValorConvMedico.Enabled = false;
                txtValorConvMedico.Enabled = false;
                //txtValorConvOdonto.Text = "0";
            }
        }

        private void txtPorcentagemConvMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08 && valorDigitado != 46 && valorDigitado != 44)
            {
                e.Handled = true;
            }
        }
    }
}
