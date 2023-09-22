using FolhaDePagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DecimoTerceiroSalario
{
    public class DecimoTerceiro
    {

        private double SalarioBaseDecimoTerceiro { get; set; }
        private double PrimeiraParcelaDecimoTerceiro { get; set; }
        private double SegundaParcelaDecimoTerceiro { get; set; }


        private double ContabilizarDecimoTerceiroBruto(double salario, int mesesTrabalhados)
        {
            double salarioBaseDecimoTerceiro;
            try
            {
                salarioBaseDecimoTerceiro = (salario / 12) * (double)mesesTrabalhados;
                SalarioBaseDecimoTerceiro = salarioBaseDecimoTerceiro;
                return salarioBaseDecimoTerceiro;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double CalcularPrimeiraParcelaDoDecimoTerceiro(double salario, int mesesTrabalhados)
        {
            double primeiraParcelaDecimoTerceiro;
            try
            {
                double salarioBaseDecimoTerceiro = ContabilizarDecimoTerceiroBruto(salario, mesesTrabalhados);
                primeiraParcelaDecimoTerceiro = salarioBaseDecimoTerceiro / 2;
                PrimeiraParcelaDecimoTerceiro = primeiraParcelaDecimoTerceiro;
                return primeiraParcelaDecimoTerceiro;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public double CalcularSegundaParcelaDoDecimoTerceiro(double salario, int mesesTrabalhados, double inss, double irrf)
        {
            double salarioBaseDecimoTerceiro, segundaParcelaDoDecimo;
            try
            {
                salarioBaseDecimoTerceiro = ContabilizarDecimoTerceiroBruto(salario, mesesTrabalhados);
                segundaParcelaDoDecimo = (salarioBaseDecimoTerceiro / 2) - inss - irrf;
                SegundaParcelaDecimoTerceiro = segundaParcelaDoDecimo;
                return segundaParcelaDoDecimo;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
