using ConexaoBaseDados;
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
    public partial class Form_ViewDeleteConvenioMedico : Form
    {
        crud_PlanoSaude _crud_PlanoSaude = new crud_PlanoSaude();
        public Form_ViewDeleteConvenioMedico()
        {
            InitializeComponent();
        }

        private void Form_ViewDeleteConvenioMedico_Load(object sender, EventArgs e)
        {
            DataTable tabelaConvenioMedico = _crud_PlanoSaude.buscarConvenioMedico();
            dgvVisualizaConvMedico.DataSource = tabelaConvenioMedico;
            // ja esta funcionando agora preciso configurar permissoes e caracteristicas da tabela
            // como por exemplo não permitir que o usuario faça a alteração dos dados digitando.
        }
    }
}
