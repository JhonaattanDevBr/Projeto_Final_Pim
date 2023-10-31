using BaseDeDados;
using EmpresasClientes;
using InterfacesDoSistemaDesktop.Interfaces_AtualizarDados;
using PlanoSaude;
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
    public partial class Form_ViewDeleteEmpresas : Form
    {
        crud_Empresas _crud_Empresas = new crud_Empresas();
        Empresas _empresas = new Empresas();
        public string Id { get; set; }
        public string IdEmpresa { get; set; }

        public Form_ViewDeleteEmpresas()
        {
            InitializeComponent();
        }

        private void Form_ViewDeleteEmpresas_Load(object sender, EventArgs e)
        {
            dgvVisualizarEmpresa.Columns.Clear();
            DataTable tabelaConvenioMedico = _crud_Empresas.BuscarEmpresas();
            dgvVisualizarEmpresa.DataSource = tabelaConvenioMedico;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizarEmpresa.Columns[0].Width = 70;
            dgvVisualizarEmpresa.Columns[1].Width = 210;
            dgvVisualizarEmpresa.Columns[2].Width = 168;
            dgvVisualizarEmpresa.Columns[3].Width = 120;
            dgvVisualizarEmpresa.Columns[4].Width = 160;
            dgvVisualizarEmpresa.Columns[5].Width = 140;

        }

        private void dgvVisualizarEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tabelaEmpresas = (DataGridView)sender; 
            DataGridViewRow linhaSelecionada = tabelaEmpresas.Rows[e.RowIndex]; 

            string id = linhaSelecionada.Cells["Código"].Value.ToString(); 
            string idEndereco = linhaSelecionada.Cells["Cód. Endereco"].Value.ToString();
            Id = id;
            IdEmpresa = idEndereco;
        }

        private void AtualizarTabela()
        {
            dgvVisualizarEmpresa.Columns.Clear();
            DataTable tabelaConvenioMedico = _crud_Empresas.BuscarEmpresas();
            dgvVisualizarEmpresa.DataSource = tabelaConvenioMedico;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizarEmpresa.Columns[0].Width = 70;
            dgvVisualizarEmpresa.Columns[1].Width = 210;
            dgvVisualizarEmpresa.Columns[2].Width = 168;
            dgvVisualizarEmpresa.Columns[3].Width = 120;
            dgvVisualizarEmpresa.Columns[4].Width = 160;
            dgvVisualizarEmpresa.Columns[5].Width = 140;
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
        {
            if (Id != "")
            {
                DialogResult deletar = MessageBox.Show("Deseja realmente excluir o registro?\n\nApós um registro ser excluido os dados serão perdidos permanentemente, " +
                                                   "não podendo ser restaurados.\n\nDeseja continuar?",
                                                   "ATENÇÂO!",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
                if (deletar == DialogResult.Yes)
                {
                    bool retornoExclusao = _crud_Empresas.ExcluirEmpresa(Id);
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
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            if (Id != "")
            {
                DialogResult alterar = MessageBox.Show("Deseja realmente alterar os dados do registro? ", "ATENÇÂO!", MessageBoxButtons.YesNo);
                if (alterar == DialogResult.Yes)
                {
                    _empresas.Id = Id;
                    Form_AtualizarEmpresas _AtualizarEmpresas = new Form_AtualizarEmpresas(Id, IdEmpresa); 
                    _AtualizarEmpresas.ShowDialog();
                    AtualizarTabela();
                }
            }
        }
    }
}
