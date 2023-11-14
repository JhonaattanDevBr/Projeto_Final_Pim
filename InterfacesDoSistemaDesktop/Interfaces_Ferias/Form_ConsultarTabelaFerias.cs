using BaseDeDados;
using BeneficioDasFerias;
using FuncionariosEmpresas;
using InterfacesDoSistemaDesktop.Interfaces_AtualizarDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Interfaces_Ferias
{
    public partial class Form_ConsultarTabelaFerias : Form
    {
        AgendamentoFerias _agendamentoFerias = new AgendamentoFerias();
        Crud_AgendamentoFerias _crud_AgendamentoFerias = new Crud_AgendamentoFerias();
        Funcionarios _funcionarios = new Funcionarios();

        public string Id { get; set; }
        public string IdEmpresa { get; set; }
        public string IdAgendamento { get; set; }

        public Form_ConsultarTabelaFerias()
        {
            InitializeComponent();
        }

        private void Form_ConsultarTabelaFerias_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> popularListaEmpresas = _crud_AgendamentoFerias.PopularCaixaListarEmpresas();
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

            dgvFuncionarios.DataSource = null; // Define DataSource como null para limpar as colunas existentes, se houver.

            dgvFuncionarios.Columns.Clear();
            DataTable tabelaPeriodoAquisitivo = _crud_AgendamentoFerias.ListarFuncionariosParaAgendarFerias(IdEmpresa);
            dgvFuncionarios.DataSource = tabelaPeriodoAquisitivo;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvFuncionarios.Columns[0].Width = 70; // ferias
            dgvFuncionarios.Columns[1].Width = 100; // primeiro mes
            dgvFuncionarios.Columns[2].Width = 70; // primeiro mes dias
            dgvFuncionarios.Columns[3].Width = 100; // segundo mes
            dgvFuncionarios.Columns[4].Width = 70; // segundo mes dias
            dgvFuncionarios.Columns[5].Width = 100; //terceiro mes
            dgvFuncionarios.Columns[6].Width = 70; // terceiro mes dias
            dgvFuncionarios.Columns[7].Width = 100; // dias restantres
            dgvFuncionarios.Columns[8].Width = 90; // dias vendidos
            dgvFuncionarios.Columns[9].Width = 120; // decimo
            dgvFuncionarios.Columns[10].Width = 150; // nome
            dgvFuncionarios.Columns[11].Width = 100; // codigo
            dgvFuncionarios.Columns[12].Width = 100; // data
            dgvFuncionarios.Columns[13].Width = 70; // folha
            

        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView tabelaEmpresas = (DataGridView)sender;
                DataGridViewRow linhaSelecionada = tabelaEmpresas.Rows[e.RowIndex];

                string id = linhaSelecionada.Cells["Cód. Funcionário"].Value.ToString();
                string idAgendamento = linhaSelecionada.Cells["Cód. Férias"].Value.ToString();
                Id = id;
                IdAgendamento = idAgendamento;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                DialogResult agendar = MessageBox.Show("Deseja agendar um registro de férias para o funcionário? ", "ATENÇÂO!", MessageBoxButtons.YesNo);
                if (agendar == DialogResult.Yes)
                {
                    _funcionarios.Id = Id;
                    Form_AgendarFerias _form_AgendarFerias = new Form_AgendarFerias(Id); ;
                    _form_AgendarFerias.ShowDialog();
                    AtualizarTabela();
                }
            }
            Id = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                DialogResult alterar = MessageBox.Show("Deseja realmente alterar os dados do registro?", "ATENÇÂO!", MessageBoxButtons.YesNo);
                if (alterar == DialogResult.Yes)
                {
                    _funcionarios.Id = Id;
                    Form_AtualizarRegistroFerias _atualizarRegistroFerias = new Form_AtualizarRegistroFerias(Id);
                    _atualizarRegistroFerias.ShowDialog();
                    AtualizarTabela();
                }
            }
            Id = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                DialogResult deletar = MessageBox.Show("Deseja realmente excluir o registro?\n\nApós um registro ser excluido os dados serão perdidos permanentemente, " +
                                                   "não podendo ser restaurados.\n\nDeseja continuar?",
                                                   "ATENÇÂO!",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
                if (deletar == DialogResult.Yes)
                {
                    bool retornoExclusao = _crud_AgendamentoFerias.ExcluirRegistroFerias(IdAgendamento);
                    if (retornoExclusao)
                    {
                        MessageBox.Show("O Registro foi excluido.", "Operação concluida.");
                        AtualizarTabela();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o registro.", "Falha na operação ");
                    }
                }
            }
            Id = "";
        }

        private void AtualizarTabela()
        {
            dgvFuncionarios.DataSource = null; // Define DataSource como null para limpar as colunas existentes, se houver.

            dgvFuncionarios.Columns.Clear();
            DataTable tabelaPeriodoAquisitivo = _crud_AgendamentoFerias.ListarFuncionariosParaAgendarFerias(IdEmpresa);
            dgvFuncionarios.DataSource = tabelaPeriodoAquisitivo;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvFuncionarios.Columns[0].Width = 70;
            dgvFuncionarios.Columns[1].Width = 180;
            dgvFuncionarios.Columns[2].Width = 100;
            dgvFuncionarios.Columns[3].Width = 100;
            dgvFuncionarios.Columns[4].Width = 70;
            dgvFuncionarios.Columns[5].Width = 100;
            dgvFuncionarios.Columns[6].Width = 70;
            dgvFuncionarios.Columns[7].Width = 100;
            dgvFuncionarios.Columns[8].Width = 70;
            dgvFuncionarios.Columns[9].Width = 80;
            dgvFuncionarios.Columns[10].Width = 80;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Deseja fechar?", "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fechar == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
