using ConexaoBaseDados;
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
    }
}
