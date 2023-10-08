using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionariosEmpresas;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_CadFuncionarios : Form
    {
        Funcionarios _funcionarios = new Funcionarios();

        public Form_CadFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCadMuitoVeiculo_Click(object sender, EventArgs e)
        {
            _funcionarios.Nome = txtNomeFunc.Text;
            _funcionarios.Sobrenome = txtSobrenomeFunc.Text;
            _funcionarios.Idade = txtIdadeFunc.Text;
            _funcionarios.SexoMasculino = rdbSexoMasculino.Text;
            _funcionarios.SexoFeminino = rdbSexoFeminino.Text;
            _funcionarios.Rg = mskRgFunc.Text;
            _funcionarios.Cpf = mskCpfFunc.Text;
            _funcionarios.Email = txtEmailFunc.Text;
            _funcionarios.EmailSecundario = txtEmailSecundarioFunc.Text;
            _funcionarios.CelularPrincipal = mskCelularPrincipalFunc.Text;
            _funcionarios.CelularSecundario = mskCelularSecundarioFunc.Text;
            _funcionarios.NumeroRegistro = txtRegistroFunc.Text;
            _funcionarios.Empregador = cmbEmpregadorFunc.Text;
            _funcionarios.Cargo = txtCargoFunc.Text;
            _funcionarios.DataAdmisao = mskDataAdmissaoFunc.Text;
            _funcionarios.Salario = txtSalarioFunc.Text;
            _funcionarios.ConvenioMedico = cmbConvMedico.Text;
            _funcionarios.ConvenioOdontologico = cmbConvOdontoFunc.Text;
            _funcionarios.Dependentes = txtDependentesFunc.Text;
            _funcionarios.Cidade = txtCidadeFunc.Text;
            _funcionarios.Estado = txtEstadoFunc.Text;
            _funcionarios.Bairro = txtBairroFunc.Text;
            _funcionarios.Rua = txtRuaFunc.Text;
            _funcionarios.Numero = txtNumeroFunc.Text;
        }
    }
}
