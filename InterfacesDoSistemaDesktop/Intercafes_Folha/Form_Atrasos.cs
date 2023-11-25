using BaseDeDados;
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
    public partial class Form_Atrasos : Form
    {
        Folha _folha = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<string> dadosConvOdonto = new List<string>();
        List<TimeSpan> listaHoras = new List<TimeSpan>();

        Thread _t1, _t2;

        public Form_Atrasos(List<string> dadosEnviados)
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
            txtSalarioBase.Text = dadosRecebidos[1];
            int jornada = _crud_FolhaDePagamento.ColetarJornada(dadosRecebidos[0]);
            txtJornada.Text = jornada.ToString();

            DateTime DiaHoraAtual = PegarDiaHoraAtual();
            
            listaHoras = _crud_FolhaDePagamento.ColetarRegistroAtrasos(dadosRecebidos[0], DiaHoraAtual.ToString());
            txtTotalHorasAtraso.Text = CalcularHoras(listaHoras).ToString();

            string horas = txtTotalHorasAtraso.Text;
            horas = horas.Replace(":", " ");
            string[] divisorHoras = horas.Split(' ');
            int horasTrabalhadas = int.Parse(divisorHoras[0]);
            int minutosTrabalhados = int.Parse(divisorHoras[1]);
            double retorno = _folha.ConversorDeMinutosEmHoras(horasTrabalhadas, minutosTrabalhados);
            txtTotalHorasConvertidas.Text = $"{retorno:f2}".ToString();
            dadosParaEnviar.Add(jornada.ToString() + " Jornada");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double retorno;
            retorno = _folha.CalcularAtraso(Convert.ToDouble(txtSalarioBase.Text), Convert.ToDouble(txtTotalHorasConvertidas.Text), Convert.ToInt32(txtJornada.Text));
            txtRetorno.Text = $"{retorno:f2}".ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Clear();
            txtRetorno.Clear();
        }

        private DateTime PegarDiaHoraAtual()
        {
            DateTime dataHoraAtual = DateTime.Now;
            return dataHoraAtual;
        }

        private TimeSpan CalcularHoras(List<TimeSpan> tm)
        {
            List<TimeSpan> listaTm = new List<TimeSpan>();
            listaTm = tm;
            TimeSpan somaTotal = TimeSpan.Zero;
            foreach (var tempo in listaTm)
            {
                somaTotal += tempo;
            }
            return somaTotal;
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
            if (!string.IsNullOrEmpty(txtRetorno.Text))
            {
                dadosParaEnviar.Add(txtTotalHorasAtraso.Text.ToString() + " Horas Em Atraso");
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " Valor do atraso");
            }
            else
            {
                dadosParaEnviar.Add("0 Não possui Horas Em Atraso");
                dadosParaEnviar.Add("0 Não possui Valor do atraso");
            }
            this.Close();
            _t1 = new Thread(Inss);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void Inss()
        {
            Application.Run(new Form_Inss(dadosParaEnviar));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(Dependentes);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void Dependentes()
        {
            Application.Run(new Form_Dependentes(dadosRecebidos));
        }
    }
}
