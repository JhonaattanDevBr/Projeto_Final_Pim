using PlanoOdontologico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoBaseDados;
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
            conOdonto.NomeConvOdonto = txtNomeConvOdonto.Text;
            conOdonto.CnpjConvOdonto = mskCnpjConvOdonto.Text;
            conOdonto.ValorConvOdonto = txtValorConvOdonto.Text;
            conOdonto.PorcentagemConvOdonto = txtPorcentagemConvOdonto.Text;

            retornoCadastro = conOdonto.AutenticarCadConvOdontologico();
            if (retornoCadastro)
            {
                bool incluirConvOdontologico = _crud_PlanoOdontologico.CadastrarConvOdontologico(conOdonto);
                if (incluirConvOdontologico)
                {
                    MessageBox.Show("Cadastro realizado com sucesso.", "Operação concluida!");
                    Close();
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
    }
}
