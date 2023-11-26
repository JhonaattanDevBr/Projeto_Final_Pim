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
using System.Threading;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Interfaces_Acesso
{
    public partial class Form_Acesso : Form
    {
        Thread entrarNoSistema;
        Personal _Personal = new Personal();
        crud_AcessoPersonalD _crud_AcessoPersonalD = new crud_AcessoPersonalD();

        public string NomeFuncionario { get; set; }
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
            informacoesLogin[2] = _crud_AcessoPersonalD.ColetarNomeFuncionario(_Personal, informacoesLogin[0]);
            _Personal.Usuario = "";
            _Personal.Senha = "";

            if (txtUsuario.Text == informacoesLogin[0] && txtSenha.Text == informacoesLogin[1])
            {
                NomeFuncionario = informacoesLogin[2];

                this.Close(); // fechou a interface atual
                entrarNoSistema = new Thread(AcessarSistema); // Aqui eu crio uma Thread que recebe como parametro o método AcessarSistema
                entrarNoSistema.SetApartmentState(ApartmentState.STA); // Aqui eu chamo o método SetApartmentState do objeto da Thread,
                                                                       // ele configura o estado apartment de um thread antes dela ser iniciada
                                                                       // Depois dentro dos parametros eu chamo o método apartmentState. e chamo o atributo STA de single thread (
                entrarNoSistema.Start(); // Aqui eu execulto a Thread.
            }
            else
            {
                MessageBox.Show("Os dados inseridos estão incorretos", "Falha ao realizar login");
            }
        }

        private void AcessarSistema (object obj) // Método q eu vou usar para selecionar a interface desejada.
        {
            Application.Run(new Form_AreaRestrita(NomeFuncionario));
        }
    }
}
