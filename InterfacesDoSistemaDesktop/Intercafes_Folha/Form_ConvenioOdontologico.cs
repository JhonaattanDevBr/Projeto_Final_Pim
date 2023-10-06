using FolhaDePagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_ConvenioOdontologico : Form
    {
        // Provavelment nessa tela não vou precisar fazer calculo apenas fazer uma consulta no banco de dados e buscar qual o convenio do funcionario
        // e exibir em tela a o convenio e qual o valor cobrado pelo convenio.
        // A tela tera de ser repensada quando eu fizer a conexao com o BD já que não havera calculo.
        // Aqui eu vou precisar criar uma condição onde se o convenio tem um valor fixo ele ja seja atribuido diretamente
        // Caso ele cobre uma porcentagem eu vou precisar realizar um calculoe voltar em tela

        public Form_ConvenioOdontologico()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalarioBase.Clear();
            txtRetorno.Clear();
            txtSalarioBase.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Folha folhaPG = new Folha();
            double retorno; // Vou fazer essa variavel receber o retorno do valor calculado na formula.
        }
    }
}
