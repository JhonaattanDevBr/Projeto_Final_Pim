using BaseDeDados;
using FuncionariosEmpresas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Intercafes_Folha
{
    public partial class Form_SelFuncionarioGerarFolha : Form
    {
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();
        Funcionarios _funcionarios = new Funcionarios();

        public string IdEmpresa { get; set; }
        public string IdFuncionario { get; set; }
        public Form_SelFuncionarioGerarFolha()
        {
            InitializeComponent();
        }

        private void Form_SelFuncionarioGerarFolha_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> popularListaEmpresas = _crud_FolhaDePagamento.PopularCaixaListarEmpresas();
            cmbListarFuncionarios.Items.Clear();
            foreach (var empresas in popularListaEmpresas)
            {
                cmbListarFuncionarios.Items.Add(empresas);
            }
            cmbListarFuncionarios.ValueMember = "Key";
            cmbListarFuncionarios.DisplayMember = "Value";
            cmbListarFuncionarios.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string refEmpresa = cmbListarFuncionarios.SelectedItem.ToString();
            refEmpresa = refEmpresa.Replace("[", "").Replace("]", "").Replace(",", " ");
            string[] id = refEmpresa.Split(' ');
            IdEmpresa = id[0];

            dgvFolhaNaoGerada.DataSource = null; 

            dgvFolhaNaoGerada.Columns.Clear();
            DataTable funcionarioParaGerarFolha = _crud_FolhaDePagamento.ListarFuncionariosParaGerarFolha(IdEmpresa);
            dgvFolhaNaoGerada.DataSource = funcionarioParaGerarFolha;

            dgvFolhaNaoGerada.Columns[0].Width = 70;
            dgvFolhaNaoGerada.Columns[1].Width = 100;
            dgvFolhaNaoGerada.Columns[2].Width = 150;
            dgvFolhaNaoGerada.Columns[3].Width = 60;
            dgvFolhaNaoGerada.Columns[4].Width = 100;
            dgvFolhaNaoGerada.Columns[5].Width = 80; 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Deseja fechar?", "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fechar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void AtualizarTabela()
        {
            dgvFolhaNaoGerada.DataSource = null;

            dgvFolhaNaoGerada.Columns.Clear();
            DataTable funcionarioParaGerarFolha = _crud_FolhaDePagamento.ListarFuncionariosParaGerarFolha(IdEmpresa);
            dgvFolhaNaoGerada.DataSource = funcionarioParaGerarFolha;

            dgvFolhaNaoGerada.Columns[0].Width = 70;
            dgvFolhaNaoGerada.Columns[1].Width = 100;
            dgvFolhaNaoGerada.Columns[2].Width = 150;
            dgvFolhaNaoGerada.Columns[3].Width = 60;
            dgvFolhaNaoGerada.Columns[4].Width = 100;
            dgvFolhaNaoGerada.Columns[5].Width = 80;
        }

        private void dgvFolhaNaoGerada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView tabelaEmpresas = (DataGridView)sender;
                DataGridViewRow linhaSelecionada = tabelaEmpresas.Rows[e.RowIndex];

                string idFuncionario = linhaSelecionada.Cells["Código"].Value.ToString();
                IdFuncionario = idFuncionario;
            }
        }

        private void btnGerarFolha_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdFuncionario))
            {
                DialogResult agendar = MessageBox.Show("Deseja gerar a folha de pagamento do funcionário? ", "ATENÇÂO!", MessageBoxButtons.YesNo);
                if (agendar == DialogResult.Yes)
                {
                    Form_AdiantamentoQuinzenal _adiantamentoQuinzenal = new Form_AdiantamentoQuinzenal(IdFuncionario);
                    _adiantamentoQuinzenal.ShowDialog();
                    AtualizarTabela();
                }
            }
            IdFuncionario = "";
        }
    }
}
