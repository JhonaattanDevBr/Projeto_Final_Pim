using BaseDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop.Intercafes_Folha
{
    public partial class Form_SelFuncionarioGerarFolha : Form
    {
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        public string IdEmpresa { get; set; }
        public Form_SelFuncionarioGerarFolha()
        {
            InitializeComponent();
        }

        private void Form_SelFuncionarioGerarFolha_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> popularListaEmpresas = _crud_FolhaDePagamento.PopularCaixaListarEmpresas();
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

            dgvFolhaNaoGerada.DataSource = null; // Define DataSource como null para limpar as colunas existentes, se houver.

            dgvFolhaNaoGerada.Columns.Clear();
            DataTable funcionarioParaGerarFolha = _crud_FolhaDePagamento.ListarFuncionariosParaGerarFolha(IdEmpresa);
            dgvFolhaNaoGerada.DataSource = funcionarioParaGerarFolha;

            // Definindo o valor padrao da largura das colunas sempre que a interface iniciar ↓.
            dgvFolhaNaoGerada.Columns[0].Width = 70; // ferias
            dgvFolhaNaoGerada.Columns[1].Width = 100; // primeiro mes
            dgvFolhaNaoGerada.Columns[2].Width = 150; // primeiro mes dias
            dgvFolhaNaoGerada.Columns[3].Width = 60; // segundo mes
            dgvFolhaNaoGerada.Columns[4].Width = 100; // segundo mes dias
            dgvFolhaNaoGerada.Columns[5].Width = 80; //terceiro mes
            

        }
    }
}
