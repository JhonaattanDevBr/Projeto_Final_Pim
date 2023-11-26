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
using BaseDeDados;
using BeneficioDasFerias;
using FolhaDePagamento;
using Microsoft.Win32;

namespace InterfacesDoSistemaDesktop
{
    public partial class Form_CalculosFerias : Form
    {
        Ferias Obj_ferias = new Ferias();
        Folha _folha = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<string> dadosFerias = new List<string>();
        List<string> decimo = new List<string>();
        List<string> ferias = new List<string>();
        List<string> retornoFerias = new List<string>();

        Thread _t1, _t2;


        public Form_CalculosFerias(List<string> dadosEnviados, List<string> dadosDoDecimo)
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
            dadosParaEnviar.Add(dadosRecebidos[22]); // decimo terceiro
            txtSalarioBase.Text = dadosRecebidos[1];

            decimo.Add(dadosDoDecimo[0]);
            decimo.Add(dadosDoDecimo[1]);
            decimo.Add(dadosDoDecimo[2]);
            decimo.Add(dadosDoDecimo[3]);

            dadosFerias = _crud_FolhaDePagamento.ColetarFerias(dadosRecebidos[0]);

            if (dadosFerias[0] == "O período aquisitivo não foi cumprido, O funcionário ainda não possui o benefício das férias.")
            {
                btnCalcular.Enabled = false; // vou deixar o bota~de calcular bloqueado caso o funcionario nao tenha o beneficio das férias forçando o ususario avançar sem calcular as férias.
            }
            else
            {
                txtMesPrimeiroPeriodo.Text = dadosFerias[0];
                txtDiasPrimeiroPeriodo.Text = dadosFerias[1];
                txtDiasVendidos.Text = dadosFerias[2];

                if (txtDiasVendidos.Text != "0")
                {
                    btnCalcularAbono.Enabled = true;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(btnCalcularAbono.Enabled == true)
            {
                bool verdadeiro = true;
                retornoFerias = Obj_ferias.FormulaCalculoDeFerias(Convert.ToDouble(txtSalarioBase.Text), verdadeiro, Convert.ToInt32(txtDiasVendidos.Text), Convert.ToInt32(txtDiasPrimeiroPeriodo.Text), dadosRecebidos[19], dadosRecebidos[21], dadosRecebidos[20], dadosRecebidos[15]);
                double valor = Convert.ToDouble(retornoFerias[4]);
                txtRetorno.Text = $"{valor:f2}";

                string dataRetorno = "01/12/2023";
                string dataSaida = "10/11/2023";
                ferias.Add(dadosFerias[1]); // dias tirados
                ferias.Add(dataSaida); // ddia q sai de ferias
                ferias.Add(dataRetorno); // retrono das ferias
                ferias.Add(dadosFerias[2]); // dias vendidos
                ferias.Add(retornoFerias[0]); // abono
                ferias.Add(retornoFerias[1]); // um terco abono
                ferias.Add(retornoFerias[2]); // INSS
                ferias.Add(retornoFerias[3]); // IRRF
                ferias.Add(txtRetorno.Text.ToString()); // bruto
                ferias.Add(retornoFerias[5]); // liquido
                ferias.Add(dadosRecebidos[0]); // funcionario
                ferias.Add(dadosFerias[3]); // if agendamento
                btnAvancar.Enabled = true;
            }
            else
            {
                bool falso = false;
                retornoFerias = Obj_ferias.FormulaCalculoDeFerias(Convert.ToDouble(txtSalarioBase.Text), falso, Convert.ToInt32(txtDiasVendidos.Text), Convert.ToInt32(txtDiasPrimeiroPeriodo.Text), dadosRecebidos[19], dadosRecebidos[21], dadosRecebidos[20], dadosRecebidos[15]);
                txtRetorno.Text = retornoFerias[4];

                string dataRetorno = "01/12/2023";
                ferias.Add(dadosFerias[1]); // dias tirados
                ferias.Add(dadosFerias[0]); // ddia q sai de ferias
                ferias.Add(dataRetorno); // retrono das ferias
                ferias.Add(dadosFerias[2]); // dias vendidos
                ferias.Add(retornoFerias[0]); // abono
                ferias.Add(retornoFerias[1]); // um terco abono
                ferias.Add(retornoFerias[2]); // INSS
                ferias.Add(retornoFerias[3]); // IRRF
                ferias.Add(retornoFerias[4]); // bruto
                ferias.Add(retornoFerias[5]); // liquido
                ferias.Add(dadosRecebidos[0]); // funcionario
                ferias.Add(dadosFerias[3]); // if agendamento
                btnAvancar.Enabled = true;
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Clear();
            txtRetorno.Focus();
            btnAvancar.Enabled = false;
        }

        private void btnCalcularAbono_Click(object sender, EventArgs e)
        {
            double valorFerias = Obj_ferias.FormulaVendaDasFerias(Convert.ToDouble(txtSalarioBase.Text), Convert.ToInt32(txtDiasVendidos.Text));
            txtAbonoPecuniario.Text = $"R$ {valorFerias:f2}".ToString();
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
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " Férias");
                this.Close();
                _t1 = new Thread(Fgts);
                _t1.SetApartmentState(ApartmentState.STA);
                _t1.Start();
            }
        }

        private void Fgts()
        {
            Application.Run(new Form_Fgts(dadosParaEnviar, decimo, ferias));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DateTime DiaHoraAtual = PegarDiaHoraAtual();
            string mesDecimo = DiaHoraAtual.ToString();
            mesDecimo = mesDecimo.Replace("/", " ");
            string[] mes = mesDecimo.Split(' ');
            string diaAtual = mes[0].ToString();
            string mesAtual = mes[1].ToString();

            if (mesAtual != "11")
            {
                MessageBox.Show("O décimo terceiro não será disponibilizado como benefício de calculo." +
                                "\n\nNOTA: O décimo terceiro é pago apenas nos mêses 11/NOVEMBRO e 12/DEZEMBRO, " +
                                "exceto esses dois períodos, ele só é pago na existência de férias, " +
                                "onde é possivel calcular a primeira parcela.", "ATENÇÃO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _t1 = new Thread(Irrf);
                _t1.SetApartmentState(ApartmentState.STA);
                _t1.Start();
            }
            else
            {
                this.Close();
                _t1 = new Thread(Decimo);
                _t1.SetApartmentState(ApartmentState.STA);
                _t1.Start();
            }
        }

        private void Irrf()
        {
            Application.Run(new Form_Irrf(dadosRecebidos));
        }


        private void Decimo()
        {
            Application.Run(new Form_DecimoTerceiro(dadosRecebidos));
        }

        private DateTime PegarDiaHoraAtual()
        {
            DateTime dataHoraAtual = DateTime.Now;
            return dataHoraAtual;
        }
    }
}
