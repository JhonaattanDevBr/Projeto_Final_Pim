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

        public double FormulaCalculoDeFerias(double salario, bool venda, int diasVendidos, int dias, string inssFunc, string irrfFunc, string pensaoFunc, string dependenteFunc)
        {
            double abonoPecuniarioUmTerco, umTercoSalarioBase, salarioBrutoFerias, salarioLiquidoFerias = 0;

            string[] vtInss = inssFunc.Split(' ');
            double inss = Convert.ToDouble(vtInss[0]);

            string[] vtIrrf = irrfFunc.Split(' ');
            double irrf = Convert.ToDouble(vtIrrf[0]);

            string[] vtPensao = pensaoFunc.Split(' ');
            double pensao = Convert.ToDouble(vtPensao[0]);

            string[] vtDependente = dependenteFunc.Split(' ');
            double dependente = Convert.ToDouble(vtDependente[1]);

            List<string> dadosInss = new List<string>();
            List<string> dadosIrrf = new List<string>();

            try
            {
                if (venda == true)
                {
                    // Vou precisar validar na tela de agendar férias que o usuario não consiga inserir valor iguais a zero ou maiores que 10.
                    AbonoPecuniario = FormulaVendaDasFerias(salario, diasVendidos);
                    abonoPecuniarioUmTerco = UmTercoDoAbonoPecuniario;
                    umTercoSalarioBase = salario / 3;
                    salarioBrutoFerias = salario + umTercoSalarioBase + AbonoPecuniario + abonoPecuniarioUmTerco;
                    BrutoDeFerias = salarioBrutoFerias;

                    dadosInss = folhaPG.FormulaDoInss(salarioBrutoFerias);
                    double diferencaInss = Convert.ToDouble(dadosInss[0]) - inss;
                    inss += diferencaInss;
                    // inss = Convert.ToDouble(dadosInss[0]);
                    InssFerias = Convert.ToDouble(inss);

                    dadosIrrf = folhaPG.FormulaDoIrrf(salarioBrutoFerias, Convert.ToDouble(inss), pensao, dependente);
                    double diferencaIrrf = Convert.ToDouble(dadosIrrf[0]) - irrf;
                    irrf += diferencaIrrf;
                    IrrfFerias = Convert.ToDouble(irrf);

                    salarioLiquidoFerias = salarioBrutoFerias - inss - irrf;
                }
                else if (venda == false)
                {
                    umTercoSalarioBase = salario / 3;
                    salarioBrutoFerias = salario + umTercoSalarioBase;
                    BrutoDeFerias = salarioBrutoFerias;

                    dadosInss = folhaPG.FormulaDoInss(salarioBrutoFerias);
                    inss = Convert.ToDouble(dadosInss[0]);
                    InssFerias = Convert.ToDouble(inss);

                    dadosIrrf = folhaPG.FormulaDoIrrf(salarioBrutoFerias, Convert.ToDouble(inss), pensao, dependente);
                    irrf = Convert.ToDouble(dadosIrrf[0]);
                    IrrfFerias = Convert.ToDouble(irrf); ;

                    salarioLiquidoFerias = salarioBrutoFerias - Convert.ToDouble(inss) - Convert.ToDouble(irrf); ;
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

