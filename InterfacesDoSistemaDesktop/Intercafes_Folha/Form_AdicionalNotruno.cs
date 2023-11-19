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
    public partial class Form_AdicionalNotruno : Form
    {
        Folha folhaPG = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<TimeSpan> listaHoras = new List<TimeSpan>();

        Thread _t1, _t2;

        public Form_AdicionalNotruno(List<string> dadosEnviados)
        {
            InitializeComponent();
            dadosRecebidos = dadosEnviados;
            txtSalarioBase.Text = dadosRecebidos[1];
            DateTime DiaHoraAtual = PegarDiaHoraAtual();
            //listaHoras = _crud_FolhaDePagamento.ColetarRegistroHoara(dadosRecebidos[0], DiaHoraAtual.ToString());
            //textBox1.Text = CalcularHoras(listaHoras).ToString();
            listaHoras = _crud_FolhaDePagamento.ColetarRegistroAdcNoturno(dadosRecebidos[0], DiaHoraAtual.ToString());
            txtTotalHoras.Text = CalcularHoras(listaHoras).ToString();
            string horas = txtTotalHoras.Text;
            horas = horas.Replace(":", " ");
            string[] divisorHoras = horas.Split(' ');
            int horasTrabalhadas = int.Parse(divisorHoras[0]);
            int minutosTrabalhados = int.Parse(divisorHoras[1]);
            double retorno;
            retorno = folhaPG.ConversorDeMinutosEmHoras(horasTrabalhadas, minutosTrabalhados);
            txtTotalHorasConvertidas.Text = $"{retorno:f2}".ToString();
            dadosParaEnviar.Add(dadosRecebidos[0]); // Id
            dadosParaEnviar.Add(dadosRecebidos[1]); // Salario
            dadosParaEnviar.Add(dadosRecebidos[2]); // Adiantamento
            
        }


        private void txtSalarioBase_TextChanged(object sender, EventArgs e)
        {
            string validacao = txtSalarioBase.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(validacao))
                {
                    txtSalarioBase.Clear();
                    txtSalarioBase.Focus();
                    return;
                }
                if (!int.TryParse(validacao, out int valor))
                {
                    MessageBox.Show("Este campo não aceita letra ou caracteres.", "ATENÇÃO");
                    txtSalarioBase.Clear();
                    txtSalarioBase.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double retorno;
            try
            {
                    retorno = folhaPG.CalcularAdicionalNoturno(Convert.ToDouble(txtSalarioBase.Text), Convert.ToDouble(txtTotalHorasConvertidas.Text));
                    txtRetorno.Text = $"{retorno:f2}".ToString();
            }
            catch (Exception)
            {
                throw;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(AdiantamentoQuinzenal);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRetorno.Text))
            {
                dadosParaEnviar.Add("Não possui horas de noturno");
                dadosParaEnviar.Add("Não possui adicional noturno");
            }
            else
            {
                dadosParaEnviar.Add(txtTotalHoras.Text.ToString() + " Horas Adc. Noturno");
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " Adc. Noturno");
            }
            this.Close();
            _t1 = new Thread(PericulosidadEnsalubridade);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void AdiantamentoQuinzenal()
        {
            Application.Run(new Form_AdiantamentoQuinzenal(dadosRecebidos[0]));
        }

        private void PericulosidadEnsalubridade()
        {
            Application.Run(new Form_Periculosidade_Insalubridade(dadosParaEnviar));
        }
    }
}
