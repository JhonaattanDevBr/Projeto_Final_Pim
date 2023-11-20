using BaseDeDados;
using FolhaDePagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_Periculosidade_Insalubridade : Form
    {
        Folha folhaPG = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();

        Thread _t1, _t2;

        public Form_Periculosidade_Insalubridade(List<string> dadosEnviados)
        {
            InitializeComponent();
            dadosRecebidos = dadosEnviados;
            txtSalarioBase.Text = dadosRecebidos[1]; 
            dadosParaEnviar.Add(dadosRecebidos[0]); // Id
            dadosParaEnviar.Add(dadosRecebidos[1]); // Salario
            dadosParaEnviar.Add(dadosRecebidos[2]); // Adiantamento
            dadosParaEnviar.Add(dadosRecebidos[3]); // Horas Adc. Not
            dadosParaEnviar.Add(dadosRecebidos[4]); // Adc. Not
        }


        private void rdbInsalubridade_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbInsalubridade.Checked)
                {
                    gpbPericulosidade.Visible = false;
                    gpbInsalubridade.Visible = true;
                    txtRetornoPericulosidade.Clear();
                }
                else
                {
                    gpbPericulosidade.Visible = true;
                    gpbInsalubridade.Visible = false;
                    txtRetornoInsalubridade.Clear();
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao realizar a operação");
            }
        }

        private void btnCalcularInsalubridade_Click(object sender, EventArgs e)
        {
            double retorno, salario = 0;
            int grauLeve = 10, grauMedio = 20, grauGrave = 40;
            string beneficio = "insalubridade";
            try
            {
                if (rdbGrauLeve.Checked)
                {
                    retorno = folhaPG.CalcularPericulosidadeInsalubridade(salario, grauLeve, beneficio);
                    txtRetornoInsalubridade.Text = $"{retorno:f2}".ToString();
                }
                else if (rdbGrauMedio.Checked)
                {
                    retorno = folhaPG.CalcularPericulosidadeInsalubridade(salario, grauMedio, beneficio);
                    txtRetornoInsalubridade.Text = $"{retorno:f2}".ToString();
                }
                else
                {
                    retorno = folhaPG.CalcularPericulosidadeInsalubridade(salario, grauGrave, beneficio);
                    txtRetornoInsalubridade.Text = $"{retorno:f2}".ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar a operação");
            }
        }

        private void btnLimparInsalubridade_Click(object sender, EventArgs e)
        {
            try
            {
                rdbGrauLeve.Checked = true;
                txtRetornoInsalubridade.Clear();
                txtRetornoInsalubridade.Focus();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao realizar a operação");
            }
        }

        private void btnCalcularPericulosidade_Click(object sender, EventArgs e)
        {
            string beneficio = "periculosidade";
            double retorno;
            int grau = 0;
            try
            {
                retorno = folhaPG.CalcularPericulosidadeInsalubridade(Convert.ToDouble(txtSalarioBase.Text), grau, beneficio);
                txtRetornoPericulosidade.Text = $"{retorno:f2}".ToString();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao realizar a operação");
            }
        }

        private void btnLimparPericulosidade_Click(object sender, EventArgs e)
        {
            try
            {
                txtRetornoPericulosidade.Clear();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao realizar a operação");
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
            if (string.IsNullOrEmpty(txtRetornoInsalubridade.Text) && string.IsNullOrEmpty(txtRetornoPericulosidade.Text))
            {
                dadosParaEnviar.Add("Não possui insalubridade/periculosidade");
            }
            else if(txtRetornoInsalubridade.Text != "")
            {
                dadosParaEnviar.Add(txtRetornoInsalubridade.Text.ToString() + " Insalubridade");
            }
            else
            {
                dadosParaEnviar.Add(txtRetornoPericulosidade.Text.ToString() + " Periculosidade");
            }
            this.Close();
            _t1 = new Thread(HorasExtras);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void HorasExtras()
        {
            Application.Run(new Form_HorasExtras(dadosParaEnviar));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(AdicionalNoturno);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void AdicionalNoturno()
        {
            Application.Run(new Form_AdicionalNotruno(dadosRecebidos));
        }
    }
}
