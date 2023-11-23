using BaseDeDados;
using BeneficioDasFerias;
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
    public partial class Form_Irrf : Form
    {
        Folha _folha = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<string> dadosConvOdonto = new List<string>();
        

        Thread _t1, _t2;

        public Form_Irrf(List<string> dadosEnviados)
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
            txtSalarioBase.Text = dadosRecebidos[1];
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Clear();
            txtRetorno.Focus();
            gpbMensagem.Visible = false;
            lblMensagamFaixa.Visible = false;
            lblMensagemPorcentagem.Visible = false;
            lblMensagemFormaDeCalculo.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> irrf = new List<string>();
            try // ta dando algum erro aqui q eu não sei oq é
            {
                irrf = _folha.CalcularIrrf(dadosRecebidos[1], dadosRecebidos[19], dadosRecebidos[20], dadosRecebidos[15]);

                    txtRetorno.Text = irrf[0].ToString();
                    gpbMensagem.Visible = true;
                    lblMensagamFaixa.Visible = true;
                    lblMensagemPorcentagem.Visible = true;
                    lblMensagemFormaDeCalculo.Visible = true;
                    lblMensagamFaixa.Text = irrf[1];
                    lblMensagemPorcentagem.Text = irrf[2];
                    lblMensagemFormaDeCalculo.Text = irrf[3];
               
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao realizar a operação." + ex); ;
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
            if (!string.IsNullOrEmpty(txtRetorno.Text))
            {
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " Valor do IRRF");
                DateTime DiaHoraAtual = PegarDiaHoraAtual();
                string mesDecimo = DiaHoraAtual.ToString();
                mesDecimo = mesDecimo.Replace("/", " ");
                string[] mes = mesDecimo.Split(' ');
                string diaAtual = mes[0].ToString();
                string mesAtual = mes[1].ToString();

                if (mesAtual != "11")
                {
                    dadosParaEnviar.Add("Não possui décimo terceiro");
                    MessageBox.Show("O décimo terceiro não será disponibilizado como benefício de calculo." +
                                    "\n\nNOTA: O décimo terceiro é pago apenas nos mêses 11/NOVEMBRO e 12/DEZEMBRO, " +
                                    "exceto esses dois períodos, ele só é pago na existência de férias, " +
                                    "onde é possivel calcular a primeira parcela.", "ATENÇÃO", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _t1 = new Thread(Ferias);
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
            else
            {
                MessageBox.Show("O calculo do IRRF deve computado, clicque em calcular.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Decimo()
        {
            Application.Run(new Form_DecimoTerceiro(dadosParaEnviar));
        }

        private void Ferias()
        {
            Application.Run(new Form_CalculosFerias(dadosParaEnviar));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(Pensao);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void Pensao()
        {
            Application.Run(new Form_Pensao(dadosRecebidos));
        }

        private DateTime PegarDiaHoraAtual()
        {
            DateTime dataHoraAtual = DateTime.Now;
            return dataHoraAtual;
        }
    }
}
