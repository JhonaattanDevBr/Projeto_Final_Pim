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

        List<string> dadosRecebidos = new List<string>();
        List<string> dadosParaEnviar = new List<string>();
        
        Thread _t1, _t2;

        public Form_Fgts(List<string> dadosEnviados)
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

            valoresNecesarios.Add(dadosRecebidos[2]); // Adicional
            valoresNecesarios.Add(dadosRecebidos[4]); // Adc. Not
            valoresNecesarios.Add(dadosRecebidos[5]); // Periculosidade/Insalubridade
            valoresNecesarios.Add(dadosRecebidos[6]); // Horas extras
            valoresNecesarios.Add(dadosRecebidos[7]); // Vale transporte
            valoresNecesarios.Add(dadosRecebidos[8]); // Vale alimentação/refeição
            valoresNecesarios.Add(dadosRecebidos[10]); // nome convenio medico
            valoresNecesarios.Add(dadosRecebidos[11]); // valor convenio medico
            valoresNecesarios.Add(dadosRecebidos[14]); // valor convenio odonto
            valoresNecesarios.Add(dadosRecebidos[15]); // valor dependentes
            valoresNecesarios.Add(dadosRecebidos[16]); // Jornada
            valoresNecesarios.Add(dadosRecebidos[18]); // valor de atraso
            valoresNecesarios.Add(dadosRecebidos[19]); // valor do INSS
            valoresNecesarios.Add(dadosRecebidos[20]); // valor da pensao
            valoresNecesarios.Add(dadosRecebidos[21]); // valor da IRRF
            valoresNecesarios.Add(dadosRecebidos[22]); // decimo terceiro
            valoresNecesarios.Add(dadosRecebidos[23]); // Ferias
            valoresNecesarios.Add(txtRetorno.Text.ToString() + " FGTS");

            //for(int i = 0; i <= 22; i++) { }

            valoresDaFolha.Add(dadosRecebidos[1]);

            foreach (string valores in valoresNecesarios)
            {
                string[] vtValores = valores.Split(' ');
                string valor = vtValores[0];
                valoresDaFolha.Add(valor);
                //i++;

            }
            MessageBox.Show("Folha de pagamento computada.", "Operação concluida com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ferias()
        {
            Application.Run(new Form_CalculosFerias(dadosRecebidos));
        }
    }
}
