using System;
using PlanoSaude;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDados;
using System.Security.Cryptography.X509Certificates;
using InterfacesDoSistemaDesktop.Interfaces_Views_Delete;

namespace InterfacesDoSistemaDesktop.Interfaces_AtualizarDados
{
    public partial class Form_AtualizarConvMedico : Form
    {
        ConvenioMedico _convenioMedico = new ConvenioMedico();
        crud_PlanoSaude _crud_PlanoSaude = new crud_PlanoSaude();

        public Form_AtualizarConvMedico(string id)
        {
            InitializeComponent();
            string registro = id;
            _convenioMedico.Id = registro;
        }

        private void Form_AtualizarConvMedico_Load(object sender, EventArgs e)
        {
            List<ConvenioMedico> listaRegistro = new List<ConvenioMedico>();
            listaRegistro = _crud_PlanoSaude.BuscarConvMedicoEspecifico(_convenioMedico);

            string nome = _convenioMedico.NomeConvMedico,
                   cnpj = _convenioMedico.CnpjConvMedico,
                   valor = _convenioMedico.ValorConvMedico,
                   porcentagem = _convenioMedico.PorcentagemConvMedico;

            txtNomeConvMedico.Text = nome;
            mskCnpjConvMedico.Text = cnpj;
            
            if(valor != "0")
            {
                rdbValorFixado.Checked = true;
                lblValorConvMedico.Enabled = true;
                txtValorConvMedico.Enabled = true;
                txtValorConvMedico.Text = valor;
                
                txtPorcentagemConvMedico.Clear();
                lblPorcentagemConvMedico.Enabled = false;
                txtPorcentagemConvMedico.Enabled = false;
            }
            else if(porcentagem != "0")
            {
                rdbPercentual.Checked = true;
                lblPorcentagemConvMedico.Enabled = true;
                txtPorcentagemConvMedico.Enabled = true;
                txtPorcentagemConvMedico.Text = porcentagem;

                txtValorConvMedico.Clear();
                lblValorConvMedico.Enabled = false;
                txtValorConvMedico.Enabled = false;
            }
        }

        private void rdbValorFixado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbValorFixado.Checked)
            {
                txtPorcentagemConvMedico.Clear();
                lblPorcentagemConvMedico.Enabled = false;
                txtPorcentagemConvMedico.Enabled = false;
                lblValorConvMedico.Enabled = true;
                txtValorConvMedico.Enabled = true;
            }
        }

        private void rdbPercentual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPercentual.Checked)
            {
                txtValorConvMedico.Clear();
                txtValorConvMedico.Enabled = false;
                lblValorConvMedico.Enabled = false;
                lblPorcentagemConvMedico.Enabled = true;
                txtPorcentagemConvMedico.Enabled = true;
            }
        }

        private void btnCadastrarConvMedico_Click(object sender, EventArgs e)
        {
            if (txtValorConvMedico.Text == "")
            {
                _convenioMedico.ValorConvMedico = "0";
                _convenioMedico.PorcentagemConvMedico = txtPorcentagemConvMedico.Text;
            }
            else
            {
                _convenioMedico.PorcentagemConvMedico = "0";
                _convenioMedico.ValorConvMedico = txtValorConvMedico.Text;
            }
            _convenioMedico.NomeConvMedico = txtNomeConvMedico.Text;
            _convenioMedico.CnpjConvMedico = mskCnpjConvMedico.Text;

            bool retornoAutenticacao = _convenioMedico.AutenticarCadConvMedico();
            if (retornoAutenticacao)
            {
                bool retornoExclusao = _crud_PlanoSaude.AlterarConvMedico(_convenioMedico);
                if (retornoExclusao)
                {
                    MessageBox.Show("O Registro foi alterado.", "Operação concluida.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar o registro.", "Falha na operação ");
                }
            }
            else
            {
                MessageBox.Show(_convenioMedico.MensagemErro, "Falha na operação");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja cancelar a operação?", "CANCELAR", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
