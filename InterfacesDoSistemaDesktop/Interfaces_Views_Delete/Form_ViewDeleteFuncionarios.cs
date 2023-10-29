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

        public Form_ViewDeleteFuncionarios()
        {
            InitializeComponent();
        }

        private void Form_ViewDeleteFuncionarios_Load(object sender, EventArgs e)
        {
            dgvVisualizarFuncionarios.Columns.Clear();
            DataTable tabelaFUncionarios = _crud_Funcionarios.BuscarEmpresas();
            dgvVisualizarFuncionarios.DataSource = tabelaFUncionarios;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvVisualizarFuncionarios.Columns[0].Width = 70;
            dgvVisualizarFuncionarios.Columns[1].Width = 210;
            dgvVisualizarFuncionarios.Columns[2].Width = 168;
            dgvVisualizarFuncionarios.Columns[3].Width = 120;
            dgvVisualizarFuncionarios.Columns[4].Width = 160;
            dgvVisualizarFuncionarios.Columns[5].Width = 140;
        }
    }
}
