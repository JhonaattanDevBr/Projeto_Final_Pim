using BaseDeDados;
using EmpresasClientes;
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

namespace InterfacesDoSistemaDesktop.Interfaces_Views_Delete
{
    public partial class Form_ViewDeleteFuncionarios : Form
    {
        crud_Funcionarios _crud_Funcionarios = new crud_Funcionarios();
        Funcionarios _funcionarios = new Funcionarios();
        public string Id { get; set; }
        public string IdEmpresa { get; set; }
        public string IdConvMedico { get; set; }
        public string IdConvOdonto { get; set; }
        public string IdEndereco { get; set; }
        public string CodEmpresa { get; set; }

        public Form_ViewDeleteFuncionarios()
        {
            InitializeComponent();
        }

        private void Form_ViewDeleteFuncionarios_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> popularListaEmpresas = _crud_Funcionarios.PopularCaixaListarEmpresas();
            cmbListarEmpresas.Items.Clear();
            if (popularListaEmpresas.Count == 0)
            {
                cmbListarEmpresas.Enabled = false;
                _funcionarios.ConvenioOdontologico = "0";
            }
            else
            {
                foreach (var empresas in popularListaEmpresas)
                {
                    cmbListarEmpresas.Items.Add(empresas);
                }
                cmbListarEmpresas.ValueMember = "Key";
                cmbListarEmpresas.DisplayMember = "Value";
                cmbListarEmpresas.SelectedIndex = 0;
            }
        }

        private void dgvVisualizarFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView tabelaEmpresas = (DataGridView)sender;
                DataGridViewRow linhaSelecionada = tabelaEmpresas.Rows[e.RowIndex];

                string id = linhaSelecionada.Cells["Código"].Value.ToString();
                string idEndereco = linhaSelecionada.Cells["Cód. Endereco"].Value.ToString();
                string idEmpresa = linhaSelecionada.Cells["Cód. Empresa"].Value.ToString();
                Id = id;
                IdEndereco = idEndereco;
                IdEmpresa = idEmpresa;
            }
        }

        private void AtualizarTabela()
        {
            dgvVisualizarFuncionarios.Columns.Clear();
            DataTable tabelaFuncionarios = _crud_Funcionarios.BuscarFuncionarios(IdEmpresa);
            dgvVisualizarFuncionarios.DataSource = tabelaFuncionarios;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizarFuncionarios.Columns[0].Width = 70;
            dgvVisualizarFuncionarios.Columns[1].Width = 210;
            dgvVisualizarFuncionarios.Columns[2].Width = 168;
            dgvVisualizarFuncionarios.Columns[3].Width = 120;
            dgvVisualizarFuncionarios.Columns[4].Width = 160;
            dgvVisualizarFuncionarios.Columns[5].Width = 140;
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
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
                    bool retornoExclusao = _crud_Funcionarios.ExcluirFuncionario(Id);
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

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(Id))
            {
                DialogResult alterar = MessageBox.Show("Deseja realmente alterar os dados do registro? ", "ATENÇÂO!", MessageBoxButtons.YesNo);
                if (alterar == DialogResult.Yes)
                {
                    _funcionarios.Id = Id;
                    _funcionarios.IdEmpresa = IdEndereco;
                    Form_AtualizarFuncionarios _AtualizarFuncionarios = new Form_AtualizarFuncionarios(Id, IdEndereco, IdEmpresa);
                    _AtualizarFuncionarios.ShowDialog();
                    AtualizarTabela();
                }
            }
            Id = "";
            IdEndereco = "";
            IdEmpresa = "";
        }

        private void cmbListarEmpresas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string refEmpresa = cmbListarEmpresas.SelectedItem.ToString();
            refEmpresa = refEmpresa.Replace("[", "").Replace("]", "").Replace(",", " ");
            string[] id = refEmpresa.Split(' ');
            CodEmpresa = id[0];

            dgvVisualizarFuncionarios.DataSource = null; // Define DataSource como null para limpar as colunas existentes, se houver.

            DataTable tabelaFUncionarios = _crud_Funcionarios.BuscarFuncionarios(CodEmpresa);
            dgvVisualizarFuncionarios.DataSource = tabelaFUncionarios;

            // Definindo o valor padrão da largura das colunas após definir o DataSource.
            dgvVisualizarFuncionarios.Columns[0].Width = 70;
            dgvVisualizarFuncionarios.Columns[1].Width = 210;
            dgvVisualizarFuncionarios.Columns[2].Width = 168;
            dgvVisualizarFuncionarios.Columns[3].Width = 120;
            dgvVisualizarFuncionarios.Columns[4].Width = 160;
            dgvVisualizarFuncionarios.Columns[5].Width = 140;
            
        }
    }
}
