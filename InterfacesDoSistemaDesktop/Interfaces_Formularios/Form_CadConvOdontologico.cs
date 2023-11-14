using PlanoOdontologico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDados;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_CadConvOdontologico : Form
    {
        ConvenioOdontologico conOdonto = new ConvenioOdontologico();
        crud_PlanoOdontologico _crud_PlanoOdontologico = new crud_PlanoOdontologico();

        public Form_CadConvOdontologico()
        {
            InitializeComponent();
        }

        private void btnCadastrarConvOdonto_Click(object sender, EventArgs e)
        {
            bool retornoCadastro;
            
            if (txtValorConvOdonto.Text == "")
            {
                conOdonto.ValorConvOdonto = "0";
                conOdonto.PorcentagemConvOdonto = txtPorcentagemConvOdonto.Text;
            }
            else
            {
                conOdonto.PorcentagemConvOdonto = "0";
                conOdonto.ValorConvOdonto = txtValorConvOdonto.Text;
            }
            conOdonto.NomeConvOdonto = txtNomeConvOdonto.Text;
            conOdonto.CnpjConvOdonto = mskCnpjConvOdonto.Text;

            retornoCadastro = conOdonto.AutenticarCadConvOdontologico();
            if (retornoCadastro)
            {
                bool incluirConvOdontologico = _crud_PlanoOdontologico.CadastrarConvOdontologico(conOdonto);
                if (incluirConvOdontologico)
                {
                    DialogResult sair = MessageBox.Show("Cadastro realizado com sucesso!\nDeseja inserir um novo convênio ?", "Operação concluida!", MessageBoxButtons.YesNo);
                    if (sair == DialogResult.Yes)
                    {
                        txtNomeConvOdonto.Clear();
                        mskCnpjConvOdonto.Clear();
                        txtValorConvOdonto.Clear();
                        txtPorcentagemConvOdonto.Clear();
                        txtNomeConvOdonto.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(conOdonto.MensagemErro, "Falha na operação!");
            }
        }

        private void txtValorConvOdonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08 && valorDigitado != 46 && valorDigitado != 44)
            {
                e.Handled = true;
            }
        }

        private void rdbValorFixado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbValorFixado.Checked)
            {
                txtPorcentagemConvOdonto.Clear();
                lblvalorFixado.Enabled = true;
                txtValorConvOdonto.Enabled = true;
                lblPercentual.Enabled = false;
                txtPorcentagemConvOdonto.Enabled = false;
                //txtPorcentagemConvOdonto.Text = "0";
            }
        }

        private void rdbPercentual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPercentual.Checked)
            {
                txtValorConvOdonto.Clear();
                lblPercentual.Enabled = true;
                txtPorcentagemConvOdonto.Enabled = true;
                lblvalorFixado.Enabled = false;
                txtValorConvOdonto.Enabled = false;
                //txtValorConvOdonto.Text = "0";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Deseja fechar?", "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fechar == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
