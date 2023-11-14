using BaseDeDados;
using InterfacesDoSistemaDesktop.Interfaces_AtualizarDados;
using PlanoSaude; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Interfaces_Views_Delete
{
    
    public partial class Form_ViewDeleteConvenioMedico : Form
    {
        crud_PlanoSaude _crud_PlanoSaude = new crud_PlanoSaude();
        ConvenioMedico _convenioMedico = new ConvenioMedico();
        public string Id { get; set; }

        public Form_ViewDeleteConvenioMedico()
        {
            InitializeComponent();
        }

        private void Form_ViewDeleteConvenioMedico_Load(object sender, EventArgs e)
        {
            dgvVisualizaConvMedico.Columns.Clear();
            DataTable tabelaConvenioMedico = _crud_PlanoSaude.BuscarConvenioMedico();
            dgvVisualizaConvMedico.DataSource = tabelaConvenioMedico;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizaConvMedico.Columns[0].Width = 70;
            dgvVisualizaConvMedico.Columns[1].Width = 210;
            dgvVisualizaConvMedico.Columns[2].Width = 168;
            dgvVisualizaConvMedico.Columns[3].Width = 100;
            dgvVisualizaConvMedico.Columns[4].Width = 120;
        }

        private void dgvVisualizaConvMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView tabelaConvMedico = (DataGridView)sender;
                DataGridViewRow linhaSelecionada = tabelaConvMedico.Rows[e.RowIndex];

                string id = linhaSelecionada.Cells["Código"].Value.ToString();
                Id = id;
            }
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Id))
            {
                DialogResult deletar = MessageBox.Show("Deseja realmente excluir o registro?\n\nApós um registro ser excluido os dados serão perdidos permanentemente, " +
                                                   "não podendo ser restaurados.",
                                                   "ATENÇÂO!",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
                if (deletar == DialogResult.Yes)
                {
                    bool retornoExclusao = _crud_PlanoSaude.ExcluirConvMedico(Id);
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
            dgvVisualizaConvMedico.Columns.Clear();
            DataTable tabelaConvenioMedico = _crud_PlanoSaude.BuscarConvenioMedico();
            dgvVisualizaConvMedico.DataSource = tabelaConvenioMedico;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizaConvMedico.Columns[0].Width = 70;
            dgvVisualizaConvMedico.Columns[1].Width = 210;
            dgvVisualizaConvMedico.Columns[2].Width = 168;
            dgvVisualizaConvMedico.Columns[3].Width = 100;
            dgvVisualizaConvMedico.Columns[4].Width = 120;
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                DialogResult alterar = MessageBox.Show("Deseja realmente alterar os dados do registro? ", "ATENÇÂO!", MessageBoxButtons.YesNo);
                if (alterar == DialogResult.Yes)
                {
                    _convenioMedico.Id = Id;
                    Form_AtualizarConvMedico _form_AtualizarConvMedico = new Form_AtualizarConvMedico(Id);
                    _form_AtualizarConvMedico.ShowDialog();
                    AtualizarTabela();
                }
            }
            Id = "";
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
