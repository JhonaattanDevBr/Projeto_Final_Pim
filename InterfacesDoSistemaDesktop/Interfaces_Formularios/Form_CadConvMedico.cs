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
            conMedico.NomeConvMedico = txtNomeConvMedico.Text;
            conMedico.CnpjConvMedico = mskCnpjConvMedico.Text;
            conMedico.ValorConvMedico = txtValorConvMedico.Text;
            conMedico.PorcentagemConvMedico = txtPorcentagemConvMedico.Text;

            retornoCadastro = conMedico.AutenticarCadConvMedico();
            if (retornoCadastro)
            {
                bool incluirConvMedico = _crud_PlanoSaude.CadastrarConvMedico(conMedico);
                if (incluirConvMedico)
                {
                    MessageBox.Show("Cadastro realizado com sucesso.", "Operação concluida!");
                    Close();
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
    }
}
