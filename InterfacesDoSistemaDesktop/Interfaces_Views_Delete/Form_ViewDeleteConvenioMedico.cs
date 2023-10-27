using BaseDeDados;
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
        public string Id { get; set; }

        public Form_ViewDeleteConvenioMedico()
        {
            InitializeComponent();
        }

        private void Form_ViewDeleteConvenioMedico_Load(object sender, EventArgs e)
        {
            dgvVisualizaConvMedico.Columns.Clear();
            DataTable tabelaConvenioMedico = _crud_PlanoSaude.buscarConvenioMedico();
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
            DataGridView tabelaConvMedico = (DataGridView)sender; // Aqui eu crio um objeto da classe datagrid para manipular a datagridview.
            DataGridViewRow linhaSelecionada = tabelaConvMedico.Rows[e.RowIndex]; //Aqui eu crio um objeto um objetodo tipo datagridrow para manipular as linhas da tabela e passo a tabela.rows(linha)

            string id = linhaSelecionada.Cells["Código"].Value.ToString(); // Aqui eu crio uma string para receber o valor que estiver na celula da linha selecionada da tabela.
            //MessageBox.Show(id, "O Id é"); // aqui eu crio uma messagebox para testar se o dado foi capturado.
            Id = id;
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
        {
            if(Id != "")
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
        }

        private void AtualizarTabela()
        {
            dgvVisualizaConvMedico.Columns.Clear();
            DataTable tabelaConvenioMedico = _crud_PlanoSaude.buscarConvenioMedico();
            dgvVisualizaConvMedico.DataSource = tabelaConvenioMedico;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizaConvMedico.Columns[0].Width = 70;
            dgvVisualizaConvMedico.Columns[1].Width = 210;
            dgvVisualizaConvMedico.Columns[2].Width = 168;
            dgvVisualizaConvMedico.Columns[3].Width = 100;
            dgvVisualizaConvMedico.Columns[4].Width = 120;
        }
    }
}
