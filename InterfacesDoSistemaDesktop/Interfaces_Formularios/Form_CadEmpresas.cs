using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresasClientes;
using ConexaoBaseDados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_CadEmpresas : Form
    {
        Empresas empresasCli = new Empresas();
        crud_Empresas _crud_Empresas = new crud_Empresas();

        public Form_CadEmpresas()
        {
            InitializeComponent();
        }

        private void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            bool retornoCadastro;
            empresasCli.RazaoSocial = txtRazaoSocial.Text;
            empresasCli.NomeFantasia = txtNomeFantasia.Text;
            empresasCli.Nascionalidade = txtNascionalidade.Text;
            empresasCli.Cnpj = mskCnpj.Text;
            empresasCli.Email = txtEmail.Text;
            empresasCli.Dominio = cmbDominio.Text;
            empresasCli.Telefone = mskTelefone.Text;
            empresasCli.Ceo = txtCeo.Text;
            empresasCli.Fundacao = dtmDataFundacao.Text;
            empresasCli.Segmento = txtSegmento.Text;
            empresasCli.Cidade = txtCidade.Text;
            empresasCli.Estado = txtEstado.Text;
            empresasCli.Bairro = txtBairro.Text;
            empresasCli.Rua = txtRua.Text;
            empresasCli.Numero = txtNumero.Text;

            retornoCadastro = empresasCli.AutenticarCadastroEmpresas();
            if (retornoCadastro == true)
            {
                bool[] solicitarCadastro = new bool[2];
                solicitarCadastro[0] = _crud_Empresas.incluirEnderecoEmpresa(empresasCli);
                solicitarCadastro[1] = _crud_Empresas.incluirEmpresa(empresasCli);
                if (solicitarCadastro[0] && solicitarCadastro[1])
                {
                    MessageBox.Show("Cadastro realizado com sucesso.", "Operação concluida!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show(empresasCli.MensagemErro, "Falha na operação!");

            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            int letra = (int) e.KeyChar;
            if(letra == 64 || letra == 32)
            {
                e.Handled = true;
            }
        }

        private void cmbDominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDominio.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cmbDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
