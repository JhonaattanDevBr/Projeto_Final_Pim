using BaseDeDados;
using InterfacesDoSistemaDesktop.Interfaces_AtualizarDados;
using PlanoOdontologico;
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
    public partial class Form_ViewDeleteConvenioOdontologico : Form
    {
        public Form_ViewDeleteConvenioOdontologico()
        {
            InitializeComponent();
        }

        crud_PlanoOdontologico _crud_PlanoOdontologico = new crud_PlanoOdontologico();
        ConvenioOdontologico _convenioOdontologico = new ConvenioOdontologico();

        string Id { get; set; }

        private void Form_ViewDeleteConvenioOdontologico_Load(object sender, EventArgs e)
        {
            dgvVisualizarConvOdonto.Columns.Clear();
            DataTable tabelaConvenioOdontologico = _crud_PlanoOdontologico.BuscarConveniOdontologico();
            dgvVisualizarConvOdonto.DataSource = tabelaConvenioOdontologico;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizarConvOdonto.Columns[0].Width = 70;
            dgvVisualizarConvOdonto.Columns[1].Width = 210;
            dgvVisualizarConvOdonto.Columns[2].Width = 168;
            dgvVisualizarConvOdonto.Columns[3].Width = 100;
            dgvVisualizarConvOdonto.Columns[4].Width = 120;
        }

        private void dgvVisualizarConvOdonto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView tabelaConvOdontologico = (DataGridView)sender;
                DataGridViewRow linhaSelecionada = tabelaConvOdontologico.Rows[e.RowIndex];

                string id = linhaSelecionada.Cells["Código"].Value.ToString();
                Id = id;
            }
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                DialogResult deletar = MessageBox.Show("Deseja realmente excluir o registro?\n\nApós um registro ser excluido os dados serão perdidos permanentemente, " +
                                                   "não podendo ser restaurados.",
                                                   "ATENÇÂO!",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
                if (deletar == DialogResult.Yes)
                {
                    bool retornoExclusao = _crud_PlanoOdontologico.ExcluirConvOdontologico(Id);
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
                    _convenioOdontologico.Id = Id;
                    Form_AtualizarConvOdonto _form_AtualizarConvOdonto = new Form_AtualizarConvOdonto(Id);
                    _form_AtualizarConvOdonto.ShowDialog();
                    AtualizarTabela();
                }
            }
            Id = "";
        }

        private void AtualizarTabela()
        {
            dgvVisualizarConvOdonto.Columns.Clear();
            DataTable tabelaConvenioOdontologico = _crud_PlanoOdontologico.BuscarConveniOdontologico();
            dgvVisualizarConvOdonto.DataSource = tabelaConvenioOdontologico;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizarConvOdonto.Columns[0].Width = 70;
            dgvVisualizarConvOdonto.Columns[1].Width = 210;
            dgvVisualizarConvOdonto.Columns[2].Width = 168;
            dgvVisualizarConvOdonto.Columns[3].Width = 100;
            dgvVisualizarConvOdonto.Columns[4].Width = 120;
        }

        
    }
}
