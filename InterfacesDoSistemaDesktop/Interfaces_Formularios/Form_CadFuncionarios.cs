﻿using FuncionariosEmpresas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoBaseDados;

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
            _funcionarios.Empregador = cmbEmpregadorFunc.Text;
            _funcionarios.Cargo = txtCargoFunc.Text;
            _funcionarios.DataAdmisao = mskDataAdmissaoFunc.Text;
            _funcionarios.Salario = txtSalarioFunc.Text;
            _funcionarios.ConvenioMedico = cmbConvMedico.ValueMember;
            _funcionarios.ConvenioOdontologico = cmbConvOdontoFunc.Text;
            _funcionarios.Dependentes = txtDependentesFunc.Text;
            _funcionarios.Cidade = txtCidadeFunc.Text;
            _funcionarios.Estado = txtEstadoFunc.Text;
            _funcionarios.Bairro = txtBairroFunc.Text;
            _funcionarios.Rua = txtRuaFunc.Text;
            _funcionarios.Numero = textBox14.Text;

            bool retornoCadastro = _funcionarios.SolicitarCadastroFuncionario();
            if (retornoCadastro)
            {
                MessageBox.Show("Cadastro realizado com sucesso.", "Operação concluida!");
                Close();
            }
            else
            {
                MessageBox.Show(_funcionarios.MensagemErro, "Falha na operação!");
            }
        }

        private void rdbSexoMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSexoMasculino.Checked)
            {
                _funcionarios.Sexo = rdbSexoMasculino.Text;
            }
        }

        private void rdbSexoFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSexoFeminino.Checked)
            {
                _funcionarios.Sexo = rdbSexoFeminino.Text;
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

        private void Form_CadFuncionarios_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> popularComboBox = _crud_Funcionarios.PopularCaixaConvenioMedico();

            // Limpar os itens existentes no ComboBox
            cmbConvMedico.Items.Clear();

            // Adicionar os valores ao ComboBox
            foreach (var item in popularComboBox)
            {
                cmbConvMedico.Items.Add(item);
            }

            // Definir a propriedade ValueMember para a chave (Id_saude)
            cmbConvMedico.ValueMember = "Key";

            // Definir a propriedade DisplayMember para o nome
            cmbConvMedico.DisplayMember = "Value";

            // Selecionar o primeiro item no ComboBox
            cmbConvMedico.SelectedIndex = 0;

        }
    }
}
