using AcessoPersonalD;
using ProjetoContaPersonal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_CadUsuarioPersonalD : Form
    {
        
        ContaPersonalD personalD = new ContaPersonalD();

        Controle controleReq = new Controle();

        public Form_CadUsuarioPersonalD()
        {
            InitializeComponent();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            bool retornoCadastro;
            personalD.Nome = txtNome.Text;
            personalD.Setor = txtSetor.Text;
            personalD.Cargo = txtCargo.Text;
            personalD.Usuario = txtUsuario.Text;
            personalD.Senha = txtSenha.Text;
            personalD.ConfirmacaoSenha = txtConfirmacaoSenha.Text;
            
            retornoCadastro = personalD.PegarValoresParaValidarCadastro();

            if (retornoCadastro == true)
            {
                MessageBox.Show("Cadastro realizado com sucesso.", "Operação concluida!");
                Close();
            }
            else
            {
                MessageBox.Show(personalD.MensagemErro, "Falha na operação!");
            }
            
        }
    }
}
