using InterfacesDoSistemaDesktop.Interfaces_Acesso;
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
    public partial class Form_AreaRestrita : Form
    {
        public Form_AreaRestrita(string nomeFuncionario)
        {
            InitializeComponent();
            lblUsuario.Text = nomeFuncionario;
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            btnBotaoUm.Visible = true;
            btnBotaoUm.Text = "Cadastrar Nova Empresa";
            btnBotaoDois.Visible = true;
            btnBotaoDois.Text = "Cadastrar Novo Convênio Médico";
            btnBotaoTres.Visible = true;
            btnBotaoTres.Text = "Cadastrar Novo Convênio Odontológico";
            btnBotaoQuatro.Visible = true;
            btnBotaoQuatro.Text = "Cadastrar Novo Funcionário";
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            btnBotaoUm.Visible = true;
            btnBotaoUm.Text = "Consultar Minhas Empresas";
            btnBotaoDois.Visible = true;
            btnBotaoDois.Text = "Consultar Meus Convênios Médicos";
            btnBotaoTres.Visible = true;
            btnBotaoTres.Text = "Consultar Meus Convênios Odontológicos";
            btnBotaoQuatro.Visible = true;
            btnBotaoQuatro.Text = "Consultar Meus Funcionários";
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {
            btnBotaoUm.Visible = true;
            btnBotaoUm.Text = "Consultar Tabela de Férias";
            btnBotaoDois.Visible = true;
            btnBotaoDois.Text = "Gerar Recibo de Férias";
            btnBotaoTres.Visible = false;
            btnBotaoQuatro.Visible = false;
        }

        private void btnFolhaDePagamento_Click(object sender, EventArgs e)
        {
            btnBotaoUm.Visible = true;
            btnBotaoUm.Text = "Consultar Lista de Pagamentos";
            btnBotaoDois.Visible = true;
            btnBotaoDois.Text = "Gerar Folha de Pagamento";
            btnBotaoTres.Visible = false;
            btnBotaoQuatro.Visible = false;
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            Form_Ajuda _form_Ajuda = new Form_Ajuda();
            _form_Ajuda.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente fechar o sistema?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente fechar o sistema?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
