using FolhaDePagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionariosEmpresas;
using BaseDeDados;
using System.Threading;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_AdiantamentoQuinzenal : Form
    {
        Funcionarios _funcionarios = new Funcionarios();
        crud_Funcionarios _crudFuncionarios = new crud_Funcionarios();
        Folha _folha = new Folha();

        Thread _t1;

        public string IdFuncionario { get; set; }
        List<string> dados = new List<string>();

        public Form_AdiantamentoQuinzenal(string idFuncionario)
        {
            InitializeComponent();
            IdFuncionario = idFuncionario;
            dados.Add(idFuncionario);
        }

        private void Form_AdiantamentoQuinzenal_Load(object sender, EventArgs e)
        {
            _funcionarios.Id = IdFuncionario;
            double retornoSalario = _crudFuncionarios.ColetarSalario(_funcionarios);
            dados.Add(retornoSalario.ToString());
            txtSalarioBase.Text = retornoSalario.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                double retorno = _folha.CalcularAdiantamentoQuinzenal(Convert.ToDouble(txtSalarioBase.Text));
                txtRetorno.Text = retorno.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalarioBase.Clear();
            txtRetorno.Clear();
            txtSalarioBase.Focus();
            if (string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                _funcionarios.Id = IdFuncionario;
                double retornoSalario = _crudFuncionarios.ColetarSalario(_funcionarios);
                txtSalarioBase.Text = retornoSalario.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Deseja cancelar o processo de gerar para folha de pagamento?", 
                                                    "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRetorno.Text))
            {
                dados.Add("Não possui adiantamento");
            }
            else
            {
                dados.Add(txtRetorno.Text.ToString() + " Adiantamento Quinzenal");
            }
            this.Close();
            _t1 = new Thread(AdicionalNoturno);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void AdicionalNoturno(object obj)
        {
            Application.Run(new Form_AdicionalNotruno(dados));
        }

        
    }
}
