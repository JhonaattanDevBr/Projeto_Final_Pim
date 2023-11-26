using BaseDeDados;
using DecimoTerceiroSalario;
using FolhaDePagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_DecimoTerceiro : Form
    {
        DecimoTerceiro _decimoTerceiro = new DecimoTerceiro();
        Folha _folha = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<string> dadosConvOdonto = new List<string>();
        List<string> dadosDecimo = new List<string>();


        Thread _t1, _t2;


        public Form_DecimoTerceiro(List<string> dadosEnviados)
        {
            InitializeComponent();
            dadosRecebidos = dadosEnviados;
            dadosParaEnviar.Add(dadosRecebidos[0]); // Id
            dadosParaEnviar.Add(dadosRecebidos[1]); // Salario
            dadosParaEnviar.Add(dadosRecebidos[2]); // Adicional
            dadosParaEnviar.Add(dadosRecebidos[3]); // Horas Adc. Not
            dadosParaEnviar.Add(dadosRecebidos[4]); // Adc. Not
            dadosParaEnviar.Add(dadosRecebidos[5]); // Periculosidade/Insalubridade
            dadosParaEnviar.Add(dadosRecebidos[6]); // Horas extras
            dadosParaEnviar.Add(dadosRecebidos[7]); // Vale transporte
            dadosParaEnviar.Add(dadosRecebidos[8]); // Vale alimentação/refeição
            dadosParaEnviar.Add(dadosRecebidos[9]); // id Convenio medico
            dadosParaEnviar.Add(dadosRecebidos[10]); // nome convenio medico
            dadosParaEnviar.Add(dadosRecebidos[11]); // valor convenio medico
            dadosParaEnviar.Add(dadosRecebidos[12]); // Id convenio odonto
            dadosParaEnviar.Add(dadosRecebidos[13]); // nome convenio odonto
            dadosParaEnviar.Add(dadosRecebidos[14]); // valor convenio odonto
            dadosParaEnviar.Add(dadosRecebidos[15]); // valor dependentes
            dadosParaEnviar.Add(dadosRecebidos[16]); // Jornada
            dadosParaEnviar.Add(dadosRecebidos[17]); // Horas em Atraso
            dadosParaEnviar.Add(dadosRecebidos[18]); // valor de atraso
            dadosParaEnviar.Add(dadosRecebidos[19]); // valor do INSS
            dadosParaEnviar.Add(dadosRecebidos[20]); // valor da pensao
            dadosParaEnviar.Add(dadosRecebidos[21]); // valor da IRRF
            txtSalarioBase.Text = dadosRecebidos[1];

            string inss = dadosRecebidos[19];
            string[] vetorInss = inss.Split(' ');
            txtInss.Text = vetorInss[0];

            string irrf = dadosRecebidos[21];
            string[] vetorIrrf = irrf.Split(' ');
            txtIrrf.Text = vetorIrrf[0];
        }

        private void rdbSemBeneficio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSemBeneficio.Checked)
            {
                rdbPrimeiraParcela.Checked = false;
                rdbSegundaParcela.Checked = false;
                gpbCalcular.Visible = false;
                gpbInssIrrf.Visible = false;
                txtRetorno.Clear();
            }
        }

        private void rdbPrimeiraParcela_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrimeiraParcela.Checked)
            {
                rdbSemBeneficio.Checked = false;
                rdbSegundaParcela.Checked = false;
                gpbCalcular.Visible = true;
                gpbInssIrrf.Visible = false;
                txtRetorno.Clear();
            }
        }

        private void rdbSegundaParcela_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSegundaParcela.Checked)
            {
                rdbSemBeneficio.Checked = false;
                rdbPrimeiraParcela.Checked = false;
                gpbCalcular.Visible = true;
                gpbInssIrrf.Visible = true;
                txtRetorno.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Clear();
            txtRetorno.Focus();
            btnAvancar.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double retorno;
            if (rdbPrimeiraParcela.Checked)
            {
                retorno = _decimoTerceiro.CalcularPrimeiraParcelaDoDecimoTerceiro(Convert.ToDouble(txtSalarioBase.Text), Convert.ToInt32(txtMesesTrabalhados.Text));
                txtRetorno.Text = $"{retorno:f2}".ToString();
                string segundaParcela = "0";
                dadosDecimo.Add(dadosRecebidos[0]);
                dadosDecimo.Add(dadosRecebidos[1]);
                dadosDecimo.Add(txtRetorno.Text.ToString());
                dadosDecimo.Add(segundaParcela);
                btnAvancar.Enabled = true;
            }
            else if (rdbSegundaParcela.Checked)
            {
                retorno = _decimoTerceiro.CalcularSegundaParcelaDoDecimoTerceiro(Convert.ToDouble(txtSalarioBase.Text), Convert.ToInt32(txtMesesTrabalhados.Text), Convert.ToDouble(txtInss.Text), Convert.ToDouble(txtIrrf.Text));
                txtRetorno.Text = $"{retorno:f2}".ToString();
                string primeiraParcela = "0";
                dadosDecimo.Add(dadosRecebidos[0]);
                dadosDecimo.Add(dadosRecebidos[1]);
                dadosDecimo.Add(primeiraParcela);
                dadosDecimo.Add(txtRetorno.Text.ToString());
                btnAvancar.Enabled = true;
            }
        }

        private DateTime PegarDiaHoraAtual()
        {
            DateTime dataHoraAtual = DateTime.Now;
            return dataHoraAtual;
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
            if (btnAvancar.Enabled)
            {
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " décimo terceiro");
                this.Close();
                _t1 = new Thread(Ferias);
                _t1.SetApartmentState(ApartmentState.STA);
                _t1.Start();
            }
        }

        private void Ferias()
        {
            Application.Run(new Form_CalculosFerias(dadosParaEnviar, dadosDecimo));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(Irrf);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void Irrf()
        {
            Application.Run(new Form_Irrf(dadosRecebidos));
        }
    }
}
