using FolhaDePagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeneficioDasFerias
{
    public class Ferias
    {
        Folha folhaPG = new Folha();

        private int DiasGozados { get; set; }
        private int DiasVendidos { get; set; }
        private int Saida { get; set; }
        private int Retorno { get; set; }
        private double BrutoDeFerias { get; set; }
        private double LiquidoDeFerias { get; set; }
        private double AbonoPecuniario { get; set; }
        private double UmTercoDoAbonoPecuniario { get; set; }
        private double InssFerias { get; set; }
        private double IrrfFerias { get; set; }


        public void ConsultarBeneficioDasFerias()
        {
            // Aqui eu vou fazer algumas consultas ao banco de dados e retornar algumas informações para o usuario.
        }

        public void AgendarFerias()
        {
            
        }

        public double FormulaCalculoDeFerias(double salario, bool venda, int dias)
        {
            // Ainda preciso terminar esse código
            // Vou precisar passar os valores do INSS e IRRF por parametros.
            double abonoPecuniarioUmTerco, umTercoSalarioBase, salarioBrutoFerias, irrf, pensao = 300, dependente = 400, salarioLiquidoFerias = 0;
            string inss;

            List<string> dadosInss = new List<string>();

            try
            {
                if (venda == true)
                {
                    // Vou precisar validar na tela de agendar férias que o usuario não consiga inserir valor iguais a zero ou maiores que 10.
                    AbonoPecuniario = FormulaVendaDasFerias(salario, dias);
                    abonoPecuniarioUmTerco = UmTercoDoAbonoPecuniario;
                    umTercoSalarioBase = salario / 3;
                    salarioBrutoFerias = salario + umTercoSalarioBase + AbonoPecuniario + abonoPecuniarioUmTerco;
                    BrutoDeFerias = salarioBrutoFerias;

                    dadosInss = folhaPG.FormulaDoInss(salarioBrutoFerias);
                    inss = dadosInss[0];
                    InssFerias = Convert.ToDouble(inss);
                    irrf = folhaPG.FormulaDoIrrf(salarioBrutoFerias, Convert.ToDouble(inss), pensao, dependente);
                    IrrfFerias = irrf;
                    salarioLiquidoFerias = salarioBrutoFerias - Convert.ToDouble(inss) - irrf;
                }
                else if (venda == false)
                {
                    umTercoSalarioBase = salario / 3;
                    salarioBrutoFerias = salario + umTercoSalarioBase;
                    BrutoDeFerias = salarioBrutoFerias;

                    dadosInss = folhaPG.FormulaDoInss(salarioBrutoFerias);
                    inss = dadosInss[0];
                    InssFerias = Convert.ToDouble(inss);
                    irrf = folhaPG.FormulaDoIrrf(salarioBrutoFerias, Convert.ToDouble(inss), pensao, dependente);
                    IrrfFerias = irrf;
                    salarioLiquidoFerias = salarioBrutoFerias - Convert.ToDouble(inss) - irrf;
                }
                return salarioLiquidoFerias;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public double FormulaVendaDasFerias(double salario, int dias)
        {
            double diaria, abonoPecuniario;
            try
            {
                diaria = salario / 30;
                abonoPecuniario = dias * diaria;
                UmTercoDoAbonoPecuniario = abonoPecuniario / 3;
                return abonoPecuniario;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void GerarReciboDeFerias()
        {
            // Aqui vai ser um método a parte apenas para gerar a folha do recibo de férias com as informações que o funcionario ira assinar.
        }
    }
}

