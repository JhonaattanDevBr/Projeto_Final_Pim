using BaseDeDados;
using PlanoOdontologico;
using PlanoSaude;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Interfaces_AtualizarDados
{
    public partial class Form_AtualizarConvOdonto : Form
    {
        ConvenioOdontologico _convenioOdontologico = new ConvenioOdontologico();
        crud_PlanoOdontologico _crud_PlanoOdontologico = new crud_PlanoOdontologico();

        public Form_AtualizarConvOdonto(string id)
        {
            InitializeComponent();
            string registro = id;
            _convenioOdontologico.Id = registro;
        }

        private void Form_AtualizarConvOdonto_Load(object sender, EventArgs e)
        {
            List<ConvenioOdontologico> listaRegistro = new List<ConvenioOdontologico>();
            listaRegistro = _crud_PlanoOdontologico.BuscarConvMedicoEspecifico(_convenioOdontologico);

            string nome = _convenioOdontologico.NomeConvOdonto,
                   cnpj = _convenioOdontologico.CnpjConvOdonto,
                   valor = _convenioOdontologico.ValorConvOdonto,
                   porcentagem = _convenioOdontologico.PorcentagemConvOdonto;

            txtNomeConvOdonto.Text = nome;
            mskCnpjConvOdonto.Text = cnpj;

            if (valor != "0")
            {
                rdbValorFixado.Checked = true;
                lblvalorFixado.Enabled = true;
                txtValorConvOdonto.Enabled = true;
                txtValorConvOdonto.Text = valor;

                txtPorcentagemConvOdonto.Clear();
                lblPercentual.Enabled = false;
                txtPorcentagemConvOdonto.Enabled = false;
            }
            else if (porcentagem != "0")
            {
                rdbPercentual.Checked = true;
                lblPercentual.Enabled = true;
                txtPorcentagemConvOdonto.Enabled = true;
                txtPorcentagemConvOdonto.Text = porcentagem;

                txtValorConvOdonto.Clear();
                lblvalorFixado.Enabled = false;
                txtValorConvOdonto.Enabled = false;
            }
        }

        private void rdbValorFixado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbValorFixado.Checked)
            {
                txtPorcentagemConvOdonto.Clear();
                lblPercentual.Enabled = false;
                txtPorcentagemConvOdonto.Enabled = false;
                lblvalorFixado.Enabled = true;
                txtValorConvOdonto.Enabled = true;
            }
        }

        private void rdbPercentual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPercentual.Checked)
            {
                txtValorConvOdonto.Clear();
                txtValorConvOdonto.Enabled = false;
                lblvalorFixado.Enabled = false;
                lblPercentual.Enabled = true;
                txtPorcentagemConvOdonto.Enabled = true;
            }
        }

        private void btnAtualizarConvOdonto_Click(object sender, EventArgs e)
        {
            if (txtValorConvOdonto.Text == "")
            {
                _convenioOdontologico.ValorConvOdonto = "0";
                _convenioOdontologico.PorcentagemConvOdonto = txtPorcentagemConvOdonto.Text;
            }
            else
            {
                _convenioOdontologico.PorcentagemConvOdonto = "0";
                _convenioOdontologico.ValorConvOdonto = txtValorConvOdonto.Text;
            }
            _convenioOdontologico.NomeConvOdonto = txtNomeConvOdonto.Text;
            _convenioOdontologico.CnpjConvOdonto = mskCnpjConvOdonto.Text;

            bool retornoAutenticacao = _convenioOdontologico.AutenticarCadConvOdontologico();
            if (retornoAutenticacao)
            {
                bool retornoExclusao = _crud_PlanoOdontologico.AlterarConvOdontologico(_convenioOdontologico);
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
                MessageBox.Show(_convenioOdontologico.MensagemErro, "Falha na operação");
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
