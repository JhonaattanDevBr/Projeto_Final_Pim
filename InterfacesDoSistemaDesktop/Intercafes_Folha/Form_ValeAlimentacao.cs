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
    public partial class Form_ValeAlimentacao : Form
    {
        Folha folhaPG = new Folha();
        Crud_FolhaDePagamento _crud_FolhaDePagamento = new Crud_FolhaDePagamento();

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();

        Thread _t1, _t2;

        public Form_ValeAlimentacao(List<string> dadosEnviados)
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
            txtSalarioBase.Text = dadosRecebidos[1];
        }
       
        private void btnCalculcar_Click(object sender, EventArgs e)
        {

            Folha ObjFolha = new Folha();
            double retorno = ObjFolha.CalcularValeAlimentacao(Convert.ToDouble(txtValeAlimentacao.Text), Convert.ToInt16(txtDias.Text), Convert.ToInt16(txtPercentual.Text));
            txtRetorno.Text = retorno.ToString();
        }

        private void txtPercentual_TextChanged(object sender, EventArgs e)
        {
            // Preciso incluir na verificação para quando ele der focus ele altomaticamente retirar os numeros da caixa pois esta quebrando a funcionalidade da caixa.
            string validacao = txtPercentual.Text.Trim(); // O comando trim() remove espaços em branco extras do início e do final da entrada.
            if (string.IsNullOrEmpty(validacao)) // Aqui eu testo se o campo for vazio.
            {
                txtPercentual.Focus();
                return;
            }
            if (!int.TryParse(validacao, out int percentual)) // Aqui eu testo se no campo for inserido uma letra.
            {
                MessageBox.Show("Este campo não aceita letras ou caracteres.", "ATENÇÂO");
                txtPercentual.Focus();
                return;
            }
            if (percentual > 20) // Aqui eu testo se o campo for maior que 20.
            {
                MessageBox.Show("Valores acima de 20% não são aceitos.", "ATENÇÂO");
                txtPercentual.Focus();
                return;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValeAlimentacao.Clear();
            txtDias.Clear();
            txtPercentual.Clear();
            txtRetorno.Clear();
            txtValeAlimentacao.Focus();
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // Preciso incluir na verificação para quando ele der focus ele altomaticamente retirar os numeros da caixa pois esta quebrando a funcionalidade da caixa.
            string validacao = txtDias.Text.Trim();
            if(string.IsNullOrEmpty(validacao))
            {
                txtDias.Focus();
                return;
            }
            if(!int.TryParse(validacao,out int dias)) 
            {
                MessageBox.Show("Este campo não aceita letras ou caracteres.", "ATENÇÃO");
                txtDias.Focus();
                return;
            }
            if(dias > 22)
            {
                MessageBox.Show("Valores acima de 22 não são aceitos.", "ATENÇÃO");
                txtDias.Focus();
                return;

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
    }
}
