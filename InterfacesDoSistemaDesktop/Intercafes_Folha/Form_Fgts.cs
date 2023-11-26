using BaseDeDados;
using FolhaDePagamento;
using InterfacesDoSistemaDesktop.Intercafes_Folha;
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
    public partial class Form_Fgts : Form
    {
        Folha _folha = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<string> decimo = new List<string>();
        List<string> ferias = new List<string>();


        Thread _t1, _t2;

        public Form_Fgts(List<string> dadosEnviados, List<string> dadosDoDecimo, List<string> dadosDasFerias)
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
            dadosParaEnviar.Add(dadosRecebidos[18]); // valor de atraso
            dadosParaEnviar.Add(dadosRecebidos[19]); // valor do INSS
            dadosParaEnviar.Add(dadosRecebidos[20]); // valor da pensao
            dadosParaEnviar.Add(dadosRecebidos[21]); // valor da IRRF
            dadosParaEnviar.Add(dadosRecebidos[22]); // decimo terceiro
            dadosParaEnviar.Add(dadosRecebidos[23]); // Ferias
            txtSalarioBase.Text = dadosRecebidos[1];

            decimo.Add(dadosDoDecimo[0]);
            decimo.Add(dadosDoDecimo[1]);
            decimo.Add(dadosDoDecimo[2]);
            decimo.Add(dadosDoDecimo[3]);

            ferias.Add(dadosDasFerias[0]);
            ferias.Add(dadosDasFerias[1]);
            ferias.Add(dadosDasFerias[2]);
            ferias.Add(dadosDasFerias[3]);
            ferias.Add(dadosDasFerias[4]);
            ferias.Add(dadosDasFerias[5]);
            ferias.Add(dadosDasFerias[6]);
            ferias.Add(dadosDasFerias[7]);
            ferias.Add(dadosDasFerias[8]);
            ferias.Add(dadosDasFerias[9]);
            ferias.Add(dadosDasFerias[10]);
            ferias.Add(dadosDasFerias[11]);


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Folha folhaPG = new Folha();
            double retorno = folhaPG.CalcularFgts(Convert.ToDouble(txtSalarioBase.Text));
            txtRetorno.Text = retorno.ToString();
        }

        private void SelecionarFuncionaParaGerarFolha()
        {
            Application.Run(new Form_SelFuncionarioGerarFolha());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t1 = new Thread(Ferias);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            List<string> valoresNecesarios = new List<string>();
            List<string> valoresDaFolha = new List<string>();
            //List<string> idNecessarios = new List<string>();
            List<string> listaDeId = new List<string>();
            List<string> listaDecimoFerias = new List<string>();
            List<string> valoresDecimmoFerias = new List<string>();
            //List<string> ferias = new List<string>();

            List<string> valoresEntrada = new List<string>();
            List<string> valoresSaida = new List<string>();
            string faltas = "0";

            valoresEntrada.Add(dadosRecebidos[2]);
            valoresEntrada.Add(dadosRecebidos[4]);
            valoresEntrada.Add(dadosRecebidos[5]);
            valoresEntrada.Add(dadosRecebidos[6]);
            valoresEntrada.Add(dadosRecebidos[22]);
            valoresEntrada.Add(dadosRecebidos[23]);

            valoresSaida.Add(dadosRecebidos[7]);
            valoresSaida.Add(dadosRecebidos[8]);
            valoresSaida.Add(dadosRecebidos[11]);
            valoresSaida.Add(dadosRecebidos[14]);
            valoresSaida.Add(dadosRecebidos[15]);
            valoresSaida.Add(dadosRecebidos[18]);
            valoresSaida.Add(dadosRecebidos[19]);
            valoresSaida.Add(dadosRecebidos[20]);
            valoresSaida.Add(dadosRecebidos[21]);

            listaDeId.Add(dadosRecebidos[0]); // id funcionario
            string idConvMedico = dadosRecebidos[9];
            string[] medico = idConvMedico.Split(' ');

            string idConvOdonto = dadosRecebidos[12];
            string[] odonto = idConvOdonto.Split(' ');

            listaDeId.Add(medico[0]); // id convenio medico
            listaDeId.Add(odonto[0]); // id convenio odontologico

            string retornoEntradas = CalcularEntradas(valoresEntrada);
            string retornoSaidas = CalcularSaidas(valoresSaida);

            string entradas = retornoEntradas, saidas = retornoSaidas;
            double salarioLiquido = Convert.ToDouble(entradas) - Convert.ToDouble(saidas);

            valoresNecesarios.Add(dadosRecebidos[1]); // Salario
            valoresNecesarios.Add(dadosRecebidos[7]); // Vale transporte
            valoresNecesarios.Add(dadosRecebidos[8]); // Vale alimentação/refeição
            valoresNecesarios.Add(dadosRecebidos[2]); // Adicional
            // aqui eu preciso colocar as horas trabalhas total
            valoresNecesarios.Add(dadosRecebidos[6]); // Horas extras
            valoresNecesarios.Add(dadosRecebidos[4]); // Adc. Not
            valoresNecesarios.Add(dadosRecebidos[5]); // Periculosidade/Insalubridade
            valoresNecesarios.Add(dadosRecebidos[15]); // valor dependentes
            valoresNecesarios.Add(dadosRecebidos[20]); // valor da pensao
            valoresNecesarios.Add(dadosRecebidos[18]); // valor de atraso
            valoresNecesarios.Add(faltas);
            valoresNecesarios.Add(dadosRecebidos[19]); // valor do INSS
            valoresNecesarios.Add(dadosRecebidos[21]); // valor da IRRF
            valoresNecesarios.Add(txtRetorno.Text.ToString() + " FGTS");
            valoresNecesarios.Add(retornoEntradas); // vencimentos
            valoresNecesarios.Add(retornoSaidas); // descontos
            valoresNecesarios.Add(salarioLiquido.ToString()); // liquido

            foreach (string valores in valoresNecesarios)
            {
                string[] vtValores = valores.Split(' ');
                string valor = vtValores[0];
                valoresDaFolha.Add(valor);
            }

            string horas = "220";
            valoresDaFolha.Add(horas);

            string idEmpresa = _crud_FolhaDePagamento.ColetarIdEmpresaFUnc(dadosRecebidos[0]);
            listaDeId.Add(idEmpresa);

            bool[] retornoEtapasFolha = new bool[3];

            retornoEtapasFolha[0] = _crud_FolhaDePagamento.InserirDecimoTerceiro(decimo);
            retornoEtapasFolha[1] = _crud_FolhaDePagamento.ArmazenarFolhaDePagamento(valoresDaFolha, listaDeId);
            retornoEtapasFolha[2] = _crud_FolhaDePagamento.ArmazenarFerias(ferias, listaDeId);

            if (retornoEtapasFolha[0])
            {
                if (retornoEtapasFolha[1])
                {
                    if (retornoEtapasFolha[2])
                    {
                        MessageBox.Show("Folha de pagamento computada.", "Operação concluida com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        _t1 = new Thread(SelecionarFuncionarioParaGerarFolha);
                        _t1.SetApartmentState(ApartmentState.STA);
                        _t1.Start();
                    }
                    else
                    {
                        MessageBox.Show("Folha de pagamento não computada. Falha ao computar féria", "Falha na operação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Folha de pagamento não computada. Falha ao computar folha de pagamento", "Falha na operação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Folha de pagamento não computada. Falha ao computar décimo Terceiro", "Falha na operação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Ferias()
        {
            Application.Run(new Form_CalculosFerias(dadosRecebidos, decimo));
        }

        private string CalcularEntradas(List<string> valoresEntrada)
        {
            double entradas = 0;
            foreach (string valores in valoresEntrada)
            {
                string[] vtValores = valores.Split(' ');
                string valor = vtValores[0];
                double valorFormatado = Convert.ToDouble(valor);
                entradas += valorFormatado;
            }
            return entradas.ToString();
        }

        private string CalcularSaidas(List<string> valoresSaida)
        {
            double saidas = 0;
            foreach (string valores in valoresSaida)
            {
                string[] vtValores = valores.Split(' ');
                string valor = vtValores[0];
                double valorFormatado = Convert.ToDouble(valor);
                saidas += valorFormatado;
            }
            return saidas.ToString();
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

        private DateTime PegarDiaHoraAtual()
        {
            DateTime dataHoraAtual = DateTime.Now;
            return dataHoraAtual;
        }

        private void SelecionarFuncionarioParaGerarFolha()
        {
            Application.Run(new Form_SelFuncionarioGerarFolha());
        }
    }
}
