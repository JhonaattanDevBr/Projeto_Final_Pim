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
    public partial class Form_Pensao : Form
    {
        Folha _folha = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        List<string> dadosConvOdonto = new List<string>();
        List<TimeSpan> listaHoras = new List<TimeSpan>();

        Thread _t1, _t2;

        public Form_Pensao(List<string> dadosEnviados)
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
            txtSalarioBase.Text = dadosRecebidos[1];
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Folha _folha = new Folha();
            double retorno = _folha.CalcularPensao();
            txtRetorno.Text = retorno.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Clear();
            txtRetorno.Focus();
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
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " Valor da pensão");
                
            }
            else
            {
                dadosParaEnviar.Add(" 0 Não possui pensão");
            }
            this.Close();
            _t1 = new Thread(Irrf);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void Irrf()
        {
            Application.Run(new Form_Irrf(dadosParaEnviar));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(Inss);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void Inss()
        {
            Application.Run(new Form_Inss(dadosRecebidos));
        }
    }
}
