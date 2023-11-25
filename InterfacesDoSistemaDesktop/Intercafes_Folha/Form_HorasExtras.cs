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
    public partial class Form_HorasExtras : Form
    {
        Folha folhaPG = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<TimeSpan> listaHoras = new List<TimeSpan>();

        Thread _t1, _t2;

        public Form_HorasExtras(List<string> dadosEnviados) // Aqui eu chego sempre com 6 itens na lista.
        {
            InitializeComponent();
            dadosRecebidos = dadosEnviados;
            dadosParaEnviar.Add(dadosRecebidos[0]); // Id
            dadosParaEnviar.Add(dadosRecebidos[1]); // Salario
            dadosParaEnviar.Add(dadosRecebidos[2]); // Adicional
            dadosParaEnviar.Add(dadosRecebidos[3]); // Horas Adc. Not
            dadosParaEnviar.Add(dadosRecebidos[4]); // Adc. Not
            dadosParaEnviar.Add(dadosRecebidos[5]); // Periculosidade/Insalubridade
            txtSalarioBase.Text = dadosRecebidos[1];

            DateTime DiaHoraAtual = PegarDiaHoraAtual();
            //listaHoras = _crud_FolhaDePagamento.ColetarRegistroHoara(dadosRecebidos[0], DiaHoraAtual.ToString());
            //textBox1.Text = CalcularHoras(listaHoras).ToString();
            listaHoras = _crud_FolhaDePagamento.ColetarRegistroHorasExtras(dadosRecebidos[0], DiaHoraAtual.ToString());
            txtTotalHoras.Text = CalcularHoras(listaHoras).ToString();
            string horas = txtTotalHoras.Text;
            horas = horas.Replace(":", " ");
            string[] divisorHoras = horas.Split(' ');
            int horasTrabalhadas = int.Parse(divisorHoras[0]);
            int minutosTrabalhados = int.Parse(divisorHoras[1]);
            double retorno;
            retorno = folhaPG.ConversorDeMinutosEmHoras(horasTrabalhadas, minutosTrabalhados);
            txtTotalHorasConvertidas.Text = $"{retorno:f2}".ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                txtRetorno.Clear();
                rdbCinquenta.Checked = true;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao realizar a operação!");
            }
        }

        private void rdbCinquenta_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbCinquenta.Checked)
                {
                    double cinquenta = 0.5;
                    double horasConvertidas = Convert.ToDouble(txtTotalHorasConvertidas.Text);
                    double retorno = folhaPG.CalcularHoraExtra(Convert.ToDouble(txtSalarioBase.Text), cinquenta, horasConvertidas);
                    txtRetorno.Text = $"{retorno:f2}".ToString();
                }
                else if (rdbCem.Checked)
                {
                    double Cem = 1.0;
                    double horasConvertidas = Convert.ToDouble(txtTotalHorasConvertidas.Text);
                    double retorno = folhaPG.CalcularHoraExtra(Convert.ToDouble(txtSalarioBase.Text), Cem, horasConvertidas);
                    txtRetorno.Text = $"{retorno:f2}".ToString();
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao realizar a operação!");
            }
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

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRetorno.Text))
            {
                dadosParaEnviar.Add("0 Não possui horas extras");
            }
            else
            {
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " Horas extras");
            }
            this.Close();
            _t1 = new Thread(ValeTransporte);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void ValeTransporte()
        {
            Application.Run(new Form_ValeTransporte(dadosParaEnviar));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(PericulosidadEnsalubridade);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void PericulosidadEnsalubridade()
        {
            Application.Run(new Form_Periculosidade_Insalubridade(dadosParaEnviar));
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
    }
}
