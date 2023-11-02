using BaseDeDados;
using EmpresasClientes;
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

namespace InterfacesDoSistemaDesktop.Interfaces_AtualizarDados
{
    public partial class Form_AtualizarFuncionarios : Form
    {
        crud_Funcionarios _crud_Funcionarios = new crud_Funcionarios();
        Funcionarios _funcionarios = new Funcionarios();

        public Form_AtualizarFuncionarios(string id, string idEndereco, string idEmpresa)
        {
            InitializeComponent();
            _funcionarios.Id = id;
            _funcionarios.IdEndereco = idEndereco;
            //_funcionarios.IdConvMedico = idConvMedico;
           // _funcionarios.IdConvOdonto = idConvOdonto;
            _funcionarios.IdEmpresa = idEmpresa;
        }

        private void Form_AtualizarFuncionarios_Load(object sender, EventArgs e)
        {
            List<Funcionarios> listaRegistroFuncionario = new List<Funcionarios>();
            listaRegistroFuncionario = _crud_Funcionarios.BuscarInfoFuncionario(_funcionarios);
            string nome = _funcionarios.Nome,
                   sobrenome = _funcionarios.Sobrenome,
                   idade = _funcionarios.Idade,
                   sexo = _funcionarios.Sexo,
                   registro = _funcionarios.NumeroRegistro,
                   cargaHoraria = _funcionarios.CargaHoraria,
                   cpf = _funcionarios.Cpf,
                   rg = _funcionarios.Rg,
                   retornoEmailPrincipal = _funcionarios.Email,
                   retornoEmailSecundario = _funcionarios.EmailSecundario,
                   telefone = _funcionarios.Telefone,
                   cellularPrincipal = _funcionarios.CelularPrincipal,
                   cellularSecundario = _funcionarios.CelularSecundario,
                   dependentes = _funcionarios.Dependentes,
                   cargo = _funcionarios.Cargo,
                   salario = _funcionarios.Salario,
                   datAdmissao = _funcionarios.DataAdmisao,
                   cidade = _funcionarios.Cidade,
                   estado = _funcionarios.Estado,
                   bairro = _funcionarios.Bairro,
                   rua = _funcionarios.Rua,
                   numero = _funcionarios.Numero;

            string[] dominioEmailPrincipal = retornoEmailPrincipal.Split('@');
            string email = dominioEmailPrincipal[0];
            string dominioPrincipal = dominioEmailPrincipal[1];
            cmbDominioCaixaPrincipal.Text = dominioPrincipal;

            string[] dominioEmailSecundario = retornoEmailSecundario.Split('@');
            string emailSecundario = dominioEmailSecundario[0];
            string dominioSecundario = dominioEmailSecundario[1];
            cmbDominioCaixaSecundaria.Text = dominioSecundario;

            txtNomeFunc.Text = nome;
            txtSobrenomeFunc.Text = sobrenome;
            txtIdadeFunc.Text = idade;
            if (sexo == "M")
            {
                rdbSexoMasculino.Checked = true;
            }
            if (sexo == "F")
            {
                rdbSexoFeminino.Checked = true;
            }
            txtRegistroFunc.Text = registro;
            txtCargaHoraria.Text = cargaHoraria;
            mskCpfFunc.Text = cpf;
            mskRgFunc.Text = rg;
            txtEmailFunc.Text = email;
            txtEmailSecundarioFunc.Text = emailSecundario;
            mskTelefoneFunc.Text = telefone;
            mskCelularPrincipalFunc.Text = telefone;
            mskCelularPrincipalFunc.Text = cellularPrincipal;
            mskCelularSecundarioFunc.Text = cellularSecundario;
            txtDependentesFunc.Text = dependentes;
            txtCargoFunc.Text = cargo;
            txtSalarioFunc.Text = salario;
            dtmDataAdmissaoFunc.Text = datAdmissao;
            txtCidadeFunc.Text = cidade;
            txtEstadoFunc.Text = estado;
            txtBairroFunc.Text = bairro;
            txtRuaFunc.Text = rua;
            textBox14.Text = numero;

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

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            _funcionarios.Nome = txtNomeFunc.Text;
            _funcionarios.Sobrenome = txtSobrenomeFunc.Text;
            _funcionarios.Idade = txtIdadeFunc.Text;
            _funcionarios.Rg = mskRgFunc.Text;
            _funcionarios.Cpf = mskCpfFunc.Text;
            _funcionarios.Email = txtEmailFunc.Text;
            //_funcionarios.DominioPrincipal = cmbDominioCaixaPrincipal.Text;
            _funcionarios.EmailSecundario = txtEmailSecundarioFunc.Text;
            //_funcionarios.DominioSecundario = cmbDominioCaixaSecundaria.Text;
            _funcionarios.Telefone = mskTelefoneFunc.Text;
            _funcionarios.CelularPrincipal = mskCelularPrincipalFunc.Text;
            _funcionarios.CelularSecundario = mskCelularSecundarioFunc.Text;
            _funcionarios.NumeroRegistro = txtRegistroFunc.Text;
            _funcionarios.CargaHoraria = txtCargaHoraria.Text;
            _funcionarios.Cargo = txtCargoFunc.Text;
            _funcionarios.DataAdmisao = dtmDataAdmissaoFunc.Text;
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
                bool[] retornoAtualizacao = new bool[2];
                retornoAtualizacao[0] = _crud_Funcionarios.AtualizarEnderecoFuncionario(_funcionarios);
                retornoAtualizacao[1] = _crud_Funcionarios.AtualizarRegistroFuncionario(_funcionarios);

                if (retornoAtualizacao[0] && retornoAtualizacao[1])
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
                MessageBox.Show(_funcionarios.MensagemErro, "Falha na operação");
            }
        }

        private void dtmDataAdmissaoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEmpregadorFunc_KeyPress(object sender, KeyPressEventArgs e)
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
