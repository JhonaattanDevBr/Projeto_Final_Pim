using AcessoPersonalD;
using ConexaoBaseDados;
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
        ConexaoDeDados cnnDados = new ConexaoDeDados();
        ContaPersonalD personalD = new ContaPersonalD();

        public Form_CadUsuarioPersonalD()
        {
            InitializeComponent();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            bool retornoCadastro;
            
            /*
            retornoCadastro = cnnDados.CadastrarFuncPersonalD(txtNome.Text, txtCargo.Text, txtSetor.Text, txtUsuario.Text, txtSenha.Text, txtConfirmacaoSenha.Text);
            if(retornoCadastro == true)
            {
                MessageBox.Show("Cadastro realizado com sucesso.", "Operação concluida!");
                Close();
            }
            else if (retornoCadastro == false)
            {
                MessageBox.Show("Não foi possivel realizar o cadastro.", "Falha na operação!");
                Close();
            }*/

            
            retornoCadastro = personalD.PegarValoresParaValidarCadastro(txtNome.Text, txtCargo.Text, txtSetor.Text, txtUsuario.Text, txtSenha.Text, txtConfirmacaoSenha.Text);
                if (retornoCadastro == true)
                {
                    MessageBox.Show("Parabens todos os dados estão corretos.", "Operação concluida!");
                }
                else
                {
                    MessageBox.Show(personalD.MensagemErro, "Falha na operação!");
                }
            
        }
    }
}
