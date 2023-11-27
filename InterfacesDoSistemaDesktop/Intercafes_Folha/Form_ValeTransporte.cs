
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
    public partial class Form_ValeTransporte : Form
    {
        Folha folhaPG = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();

        Thread _t1, _t2;

        public Form_ValeTransporte(List<string> dadosEnviados)
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
            txtSalarioBase.Text = dadosRecebidos[1];
            DateTime DiaHoraAtual = PegarDiaHoraAtual();
            int diasUteis = _crud_FolhaDePagamento.ColetarDiasUteis(dadosRecebidos[0], DiaHoraAtual.ToString());
            txtDias.Text = diasUteis.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Folha ObjFolha = new Folha();
            double retorno = ObjFolha.ContabilizarValeTransporte(Convert.ToDouble(txtSalarioBase.Text), Convert.ToInt16(txtDias.Text));
            txtRetorno.Text = retorno.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Clear();
        }


        private DateTime PegarDiaHoraAtual()
        {
            DateTime dataHoraAtual = DateTime.Now;
            return dataHoraAtual;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRetorno.Text))
            {
                dadosParaEnviar.Add("0 Não Possui vale transporte");
            }
            else
            {
                dadosParaEnviar.Add(txtRetorno.Text.ToString() + " Vale transporte");
            }
            this.Close();
            _t1 = new Thread(ValeRefeicaoAlimentacao);
            _t1.SetApartmentState(ApartmentState.STA);
            _t1.Start();
        }

        private void ValeRefeicaoAlimentacao()
        {
            Application.Run(new Form_ValeAlimentacao(dadosParaEnviar));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _t2 = new Thread(HorasExtras);
            _t2.SetApartmentState(ApartmentState.STA);
            _t2.Start();
        }

        private void HorasExtras()
        {
            Application.Run(new Form_HorasExtras(dadosRecebidos));
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
