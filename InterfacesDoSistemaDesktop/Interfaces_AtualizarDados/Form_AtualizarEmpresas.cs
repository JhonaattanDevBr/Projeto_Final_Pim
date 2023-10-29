using BaseDeDados;
using EmpresasClientes;
using PlanoOdontologico;
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
    public partial class Form_AtualizarEmpresas : Form
    {
        crud_Empresas _crud_Empresas = new crud_Empresas();
        Empresas _empresas = new Empresas();

        public Form_AtualizarEmpresas(string id, string idEndereco)
        {
            InitializeComponent();
            string registro = id;
            _empresas.Id = registro; // vou arrumar isso pra ele receber o valor direto.
            _empresas.IdEndereco = idEndereco;
        }

        private void Form_AtualizarEmpresas_Load(object sender, EventArgs e)
        {
            List<Empresas> listaRegistroEmpresariais = new List<Empresas>();
            listaRegistroEmpresariais = _crud_Empresas.BuscarInfoEmpresarialEmpresas(_empresas);
            string razaoSocial = _empresas.RazaoSocial,
                   nomeFantasia = _empresas.NomeFantasia,
                   nascionalidade = _empresas.Nascionalidade,
                   cnpj = _empresas.Cnpj,
                   email = _empresas.Email,
                   telefone = _empresas.Telefone,
                   ceo = _empresas.Ceo,
                   fundacao = _empresas.Fundacao,
                   segmento = _empresas.Segmento;
                   
            txtRazaoSocial.Text = razaoSocial;
            txtNomeFantasia.Text = nomeFantasia;
            txtNascionalidade.Text = nascionalidade;
            mskCnpj.Text = cnpj;
            txtEmail.Text = email;
            mskTelefone.Text = telefone;
            txtCeo.Text = ceo;
            dtmDataFundacao.Text = fundacao;
            txtSegmento.Text = segmento;

            List<Empresas> listaRegistroEndereco = new List<Empresas>();
            listaRegistroEndereco = _crud_Empresas.BuscarEnderecoEmpresas(_empresas);
            string cidade = _empresas.Cidade,
                   estado = _empresas.Estado,
                   bairro = _empresas.Bairro,
                   rua = _empresas.Rua,
                   numero = _empresas.Numero;

            txtCidade.Text = cidade;
            txtEstado.Text = estado;
            txtBairro.Text = bairro;
            txtRua.Text = rua;
            txtNumero.Text = numero;

        }

        private void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            _empresas.RazaoSocial = txtRazaoSocial.Text;
            _empresas.NomeFantasia = txtNomeFantasia.Text;
            _empresas.Nascionalidade = txtNascionalidade.Text;
            _empresas.Cnpj = mskCnpj.Text;
            _empresas.Email = txtEmail.Text;
            _empresas.Telefone = mskTelefone.Text;
            _empresas.Ceo = txtCeo.Text;
            _empresas.Fundacao = dtmDataFundacao.Text;
            _empresas.Segmento = txtSegmento.Text;
            _empresas.Cidade = txtCidade.Text;
            _empresas.Estado = txtEstado.Text;
            _empresas.Bairro = txtBairro.Text;
            _empresas.Rua = txtRua.Text;
            _empresas.Numero = txtNumero.Text;

            bool retornoAutenticacao = _empresas.AutenticarCadastroEmpresas();
            if (retornoAutenticacao)
            {
                bool[] retornoAtualizacao = new bool[2];
                retornoAtualizacao[0] = _crud_Empresas.AtualizarEnderecoEmpresas(_empresas);
                retornoAtualizacao[1] = _crud_Empresas.AtualizarRegistroEmpresas(_empresas);
                
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
                MessageBox.Show(_empresas.MensagemErro, "Falha na operação");
            }
        }
    }
}
