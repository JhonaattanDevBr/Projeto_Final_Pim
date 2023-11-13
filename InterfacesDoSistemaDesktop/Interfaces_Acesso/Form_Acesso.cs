using InterfacesDoSistemaDesktop.Interfaces_Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDados;
using ContaPersonal;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Interfaces_Acesso
{
    public partial class Form_Acesso : Form
    {
        Personal _Personal = new Personal();
        crud_AcessoPersonalD _crud_AcessoPersonalD = new crud_AcessoPersonalD();
        public Form_Acesso()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente encerrar a aplicação ?", "Atenção!", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Form_Accesskey form_Accesskey = new Form_Accesskey();
            form_Accesskey.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            _Personal.Usuario = txtUsuario.Text;
            _Personal.Senha = txtSenha.Text;

            string[] informacoesLogin = new string[3];
            informacoesLogin[0] = _crud_AcessoPersonalD.ColetarLogin(_Personal);
            informacoesLogin[1] = _crud_AcessoPersonalD.ColetarSenha(_Personal);
            informacoesLogin[2] = _crud_AcessoPersonalD.ColetarNomeFuncionario(_Personal);
            _Personal.Usuario = "";
            _Personal.Senha = "";

            if (txtUsuario.Text == informacoesLogin[0] && txtSenha.Text == informacoesLogin[1])
            {
                MessageBox.Show("Cadastro realizado", "Funcionou");
                Form_AreaRestrita _form_AreaRestrita = new Form_AreaRestrita(informacoesLogin[2]);
                _form_AreaRestrita.ShowDialog();
            }
            else
            {
                MessageBox.Show("Os dados inseridos estão incorretos", "Falha ao realizar login");
            }
        }
    }
}
