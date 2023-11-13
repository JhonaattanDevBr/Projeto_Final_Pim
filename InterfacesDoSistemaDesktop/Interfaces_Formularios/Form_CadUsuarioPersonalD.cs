using ProjetoContaPersonal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BaseDeDados;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using ContaPersonal;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_CadUsuarioPersonalD : Form
    {
        
        Personal _personalD = new Personal();
        crud_AcessoPersonalD _crud_AcessoPersonalD = new crud_AcessoPersonalD();

        public Form_CadUsuarioPersonalD()
        {
            InitializeComponent();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            _personalD.Nome = txtNome.Text;
            _personalD.Setor = txtSetor.Text;
            _personalD.Cargo = txtCargo.Text;
            _personalD.Usuario = txtUsuario.Text;
            _personalD.Senha = txtSenha.Text;
            _personalD.ConfirmacaoSenha = txtConfirmacaoSenha.Text;
            
            bool retornoAutenticacao = _personalD.PegarValoresParaValidarCadastro();

            if (retornoAutenticacao)
            {
                bool retornoCadastro = _crud_AcessoPersonalD.CadastrarFuncPersonalD(_personalD);
                if (retornoCadastro)
                {
                    MessageBox.Show("Cadastro realizado com sucesso.", "Operação concluida!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ouve um erro ao conectar-se ao banco de dados.", "Falha na operação");
                }
                
            }
            else
            {
                MessageBox.Show(_personalD.MensagemErro, "Falha na operação!");
            }
            
        }
    }
}
