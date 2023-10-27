using FuncionariosEmpresas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDados;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_CadFuncionarios : Form
    {
        Funcionarios _funcionarios = new Funcionarios();
        crud_Funcionarios _crud_Funcionarios = new crud_Funcionarios();

        public Form_CadFuncionarios()
        {
            InitializeComponent();
        }

        //Preciso colocar o radiobutons para ativar os combobox do convenio medico e odontologico.

        private void Form_CadFuncionarios_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> popularComboBoxConvenioMedico = _crud_Funcionarios.PopularCaixaConvenioMedico();
            cmbConvMedico.Items.Clear(); // Limpar os itens existentes no ComboBox
            if (popularComboBoxConvenioMedico.Count == 0)
            {
                cmbConvMedico.Enabled = false;
                _funcionarios.ConvenioMedico = "0";
            }
            else
            {
                foreach (var convMedico in popularComboBoxConvenioMedico) // Adicionar os valores ao ComboBox
                {
                    cmbConvMedico.Items.Add(convMedico);
                }
                cmbConvMedico.ValueMember = "Key"; // Definir a propriedade ValueMember para a chave (Id_saude)
                cmbConvMedico.DisplayMember = "Value"; // Definir a propriedade DisplayMember para o nome
                cmbConvMedico.SelectedIndex = 0; // Selecionar o primeiro item no 
            }

            Dictionary<int, string> popularComboBoxConvenioOdontologico = _crud_Funcionarios.PopularCaixaConvenioOdontologico();
            cmbConvOdontoFunc.Items.Clear();
            if (popularComboBoxConvenioOdontologico.Count == 0)
            {
                cmbConvOdontoFunc.Enabled = false;
                _funcionarios.ConvenioOdontologico = "0";
            }
            else
            {
                foreach (var convOdontologico in popularComboBoxConvenioOdontologico)
                {
                    cmbConvOdontoFunc.Items.Add(convOdontologico);
                }
                cmbConvOdontoFunc.ValueMember = "Key";
                cmbConvOdontoFunc.DisplayMember = "Value";
                cmbConvOdontoFunc.SelectedIndex = 0;

            }

            // VOu modificar essa parte para verificar se as empresas ja foram cadastradas no banco de dados para só entao os funcionarios serem cadastrados.
            Dictionary<int, string> polularComboBoxEmpregador = _crud_Funcionarios.PopularCaixaEmpregador();
            cmbEmpregadorFunc.Items.Clear();
            if (polularComboBoxEmpregador.Count == 0)
            {
                cmbEmpregadorFunc.Enabled = false;
                _funcionarios.Empregador = "0";
            }
            else
            {
                foreach (var empregador in polularComboBoxEmpregador)
                {
                    cmbEmpregadorFunc.Items.Add(empregador);
                }
                cmbEmpregadorFunc.ValueMember = "Key";
                cmbEmpregadorFunc.DisplayMember = "Value";
                cmbEmpregadorFunc.SelectedIndex = 0;
            }
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            _funcionarios.Nome = txtNomeFunc.Text;
            _funcionarios.Sobrenome = txtSobrenomeFunc.Text;
            _funcionarios.Idade = txtIdadeFunc.Text;
            _funcionarios.Rg = mskRgFunc.Text;
            _funcionarios.Cpf = mskCpfFunc.Text;
            _funcionarios.Email = txtEmailFunc.Text;
            _funcionarios.DominioPrincipal = cmbDominioCaixaPrincipal.Text;
            _funcionarios.EmailSecundario = txtEmailSecundarioFunc.Text;
            _funcionarios.DominioSecundario = cmbDominioCaixaSecundaria.Text;
            _funcionarios.Telefone = mskTelefoneFunc.Text;
            _funcionarios.CelularPrincipal = mskCelularPrincipalFunc.Text;
            _funcionarios.CelularSecundario = mskCelularSecundarioFunc.Text;
            _funcionarios.NumeroRegistro = txtRegistroFunc.Text;
            _funcionarios.CargaHoraria = txtCargaHoraria.Text;
            _funcionarios.Cargo = txtCargoFunc.Text;
            _funcionarios.DataAdmisao = mskDataAdmissaoFunc.Text;
            _funcionarios.Salario = txtSalarioFunc.Text;
            _funcionarios.Dependentes = txtDependentesFunc.Text;
            _funcionarios.Cidade = txtCidadeFunc.Text;
            _funcionarios.Estado = txtEstadoFunc.Text;
            _funcionarios.Bairro = txtBairroFunc.Text;
            _funcionarios.Rua = txtRuaFunc.Text;
            _funcionarios.Numero = textBox14.Text;

            if (rdbSexoMasculino.Checked)
            {
                _funcionarios.Sexo = rdbSexoMasculino.Text;
            }

            if (rdbSexoFeminino.Checked)
            {
                _funcionarios.Sexo = rdbSexoFeminino.Text;
            }

            bool retornoAutenticacao = _funcionarios.AutenticarFuncionario();
            if (retornoAutenticacao)
            {
                bool[] cadastrarFuncionario = new bool[2];
                cadastrarFuncionario[0] =_crud_Funcionarios.IncluirEnderecoFuncioanario(_funcionarios);
                cadastrarFuncionario[1] = _crud_Funcionarios.IncluirFuncionario(_funcionarios);
                if (cadastrarFuncionario[0] && cadastrarFuncionario[1])
                {
                    DialogResult sair = MessageBox.Show("Cadastro realizado com sucesso.\n Deseja cadastrar um novo funcionario ?", "Operação concluida!", MessageBoxButtons.YesNo);
                    if (sair == DialogResult.Yes)
                    {
                        txtNomeFunc.Clear();
                        txtSobrenomeFunc.Clear();
                        txtIdadeFunc.Clear();
                        rdbSexoFeminino.Checked = false;
                        rdbSexoMasculino.Checked = false;
                        mskRgFunc.Clear();
                        mskCpfFunc.Clear();
                        txtEmailFunc.Clear();
                        cmbDominioCaixaPrincipal.SelectedIndex = 0;
                        txtEmailSecundarioFunc.Clear();
                        cmbDominioCaixaSecundaria.SelectedIndex = 0;
                        mskTelefoneFunc.Clear();
                        mskCelularPrincipalFunc.Clear();
                        mskCelularSecundarioFunc.Clear();
                        txtRegistroFunc.Clear();
                        txtCargaHoraria.Clear();
                        txtCargoFunc.Clear();
                        txtSalarioFunc.Clear();
                        txtDependentesFunc.Clear();
                        txtCidadeFunc.Clear();
                        txtEstadoFunc.Clear();
                        txtBairroFunc.Clear();
                        txtRuaFunc.Clear();
                        textBox14.Clear();
                        cmbEmpregadorFunc.SelectedIndex = 0;
                        txtNomeFunc.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ouve um erro ao conectar-se ao banco de dados.", "Falha na operação");
                }
            }
            else
            {
                MessageBox.Show(_funcionarios.MensagemErro, "Falha na operação!");
            }
        }

        private void mskDataAdmissaoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEmpregadorFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDominioCaixaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDominioCaixaSecundaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbConvMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbConvOdontoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRegistroFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08)
            {
                e.Handled = true;
            }
        }

        private void txtCargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08)
            {
                e.Handled = true;
            }
        }

        private void txtDependentesFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08)
            {
                e.Handled = true;
            }
        }

        private void txtIdadeFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08)
            {
                e.Handled = true;
            }
        }

        private void txtSalarioFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08 && valorDigitado != 46 && valorDigitado != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valorDigitado = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && valorDigitado != 08)
            {
                e.Handled = true;
            }
        }

        private void cmbConvMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cmbConvMedico.SelectedItem.ToString();
            _funcionarios.ConvenioMedico = valor;
        }

        private void cmbEmpregadorFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cmbEmpregadorFunc.SelectedItem.ToString();
            _funcionarios.Empregador = valor;
        }

        private void cmbConvOdontoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cmbConvOdontoFunc.SelectedItem.ToString();
            _funcionarios.ConvenioOdontologico = valor;
        }
    }
}
