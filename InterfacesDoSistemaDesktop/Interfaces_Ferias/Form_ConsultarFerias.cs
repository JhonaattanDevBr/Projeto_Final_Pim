using BaseDeDados;
using BeneficioDasFerias;
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

namespace InterfacesDoSistemaDesktop.Interfaces_Ferias
{
    public partial class Form_ConsultarFerias : Form
    {

        AgendamentoFerias _agendamentoFerias = new AgendamentoFerias();
        Crud_AgendamentoFerias _crud_AgendamentoFerias = new Crud_AgendamentoFerias();

        public string Id { get; set; }
        public string IdEmpresa { get; set; }
        public Form_ConsultarFerias()
        {
            InitializeComponent();
        }

        private void Form_ConsultarFerias_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> popularListaEmpresas = _crud_AgendamentoFerias.PopularCaixaListarEmpresas();
            cmbListarEmpresas.Items.Clear();
            foreach (var empresas in popularListaEmpresas)
            {
                cmbListarEmpresas.Items.Add(empresas);
            }
            cmbListarEmpresas.ValueMember = "Key";
            cmbListarEmpresas.DisplayMember = "Value";
            cmbListarEmpresas.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string refEmpresa = cmbListarEmpresas.SelectedItem.ToString();
            refEmpresa = refEmpresa.Replace("[", "").Replace("]", "").Replace(",", " ");
            string[] id = refEmpresa.Split(' ');
            IdEmpresa = id[0];

            dgvConsultarFerias.DataSource = null; // Define DataSource como null para limpar as colunas existentes, se houver.

            dgvConsultarFerias.Columns.Clear();
            DataTable tabelaPeriodoAquisitivo = _crud_AgendamentoFerias.ListarFuncionariosParaAgendarFerias(IdEmpresa);
            dgvConsultarFerias.DataSource = tabelaPeriodoAquisitivo;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvConsultarFerias.Columns[0].Width = 70;
            dgvConsultarFerias.Columns[1].Width = 210;
            dgvConsultarFerias.Columns[2].Width = 168;
            dgvConsultarFerias.Columns[3].Width = 100;
            dgvConsultarFerias.Columns[4].Width = 120;
        }

        private void dgvConsultarFerias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView tabelaEmpresas = (DataGridView)sender;
                DataGridViewRow linhaSelecionada = tabelaEmpresas.Rows[e.RowIndex];

                string id = linhaSelecionada.Cells["Código"].Value.ToString();
                Id = id;
            }
        }

        
    }
}
