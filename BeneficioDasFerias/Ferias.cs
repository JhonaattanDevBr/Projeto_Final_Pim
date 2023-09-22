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
        //FolhaDePagamento FolhaDePagamento = new FolhaDePagamento();
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
            string primeiroMes, segundoMes, terceiroMes;
            int escolha, periodo, diasVendidos, ferias = 30, primeiroPeriodo = 0, segundoPeriodo = 0, terceiroPeriodo = 0;
            char venda;

            Console.WriteLine("- Informe como o funcionário deseja tirar as férias.");
            Console.WriteLine();
            Console.WriteLine("- Para férias completas dígite [1]");
            Console.WriteLine("- Para férias em dois periodos dígite [2]");
            Console.WriteLine("- Para férias em três periodos dígite [3]");
            Console.Write("- Escolha...: ");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (escolha)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("- O funcionário optou por fazer a venda das férias. [S] ou [N] ?");
                        Console.Write("- Vender...: ");
                        venda = char.Parse(Console.ReadLine().ToUpper());
                        Console.WriteLine();
                        if (venda == 'S')
                        {
                            do
                            {
                                Console.WriteLine("- Informe quantos dias ele deseja vender. MÁXIMO Permitido 10 dias");
                                Console.Write("- Dias vendidos...: ");
                                diasVendidos = int.Parse(Console.ReadLine());
                                ferias = 30;
                                ferias = ferias - diasVendidos;
                                Console.WriteLine();
                            } while (diasVendidos > 10);
                            Console.WriteLine($"- O funcionário téra {ferias} dias de ferias devido a venda de {diasVendidos} dias.");
                            Console.WriteLine();
                            Console.WriteLine("- Informe o mes que o funcionario solicitou as férias: ");
                            Console.Write("- Mês...: ");
                            primeiroMes = Console.ReadLine();
                            Console.WriteLine();
                        }
                        else if (venda == 'N')
                        {
                        }
                        else
                        {
                            Console.WriteLine("- Error, Opção invalida, selecione entre as opções.");
                            Console.WriteLine("- Dígite qualquer coisa para continuar.");
                            Console.ReadKey();
                            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ REFAÇA A OPERAÇÃO ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                            Console.WriteLine();
                        }
                    } while (venda != 'S' && venda != 'N');
                    // Aqui vou precisar enviar as informações das variaveis para o banco de dados.
                    break;

                case 2:
                    Console.WriteLine("- O funcionário optou por fazer a venda das férias. [S] ou [N] ?");
                    Console.Write("- Vender...: ");
                    venda = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();
                    if (venda == 'S')
                    {
                        do
                        {
                            Console.WriteLine("- Informe quantos dias ele deseja vender. MÁXIMO Permitido 10 dias");
                            Console.Write("- Dias vendidos...: ");
                            diasVendidos = int.Parse(Console.ReadLine());
                            ferias = 30;
                            ferias = ferias - diasVendidos;
                            Console.WriteLine();

                        } while (diasVendidos > 10);
                        Console.WriteLine($"- O funcionário téra {ferias} dias de férias devido a venda de {diasVendidos} dias.");
                        do
                        {
                            Console.WriteLine();
                            Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                            primeiroPeriodo = int.Parse(Console.ReadLine());
                            Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                            segundoPeriodo = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (primeiroPeriodo + segundoPeriodo > ferias)
                            {
                                Console.WriteLine("--- ATENÇÃO!");
                                Console.WriteLine($"- Por optar em realizar a venda de {diasVendidos} dias das férias, os dias gozados do funcionário não podem exceder a {ferias}.");
                            }
                        } while (primeiroPeriodo + segundoPeriodo > ferias);
                        Console.WriteLine("- Informe o mes do primeiro periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        primeiroMes = Console.ReadLine();
                        Console.WriteLine("- Informe o mes do segundo periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        segundoMes = Console.ReadLine();
                    }
                    else if (venda == 'N')
                    {
                        do
                        {
                            Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                            primeiroPeriodo = int.Parse(Console.ReadLine());
                            Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                            segundoPeriodo = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (primeiroPeriodo + segundoPeriodo > ferias)
                            {
                                Console.WriteLine("--- ATENÇÃO!");
                                Console.WriteLine($"- Os dias gozados do funcionário não podem exceder a {ferias} dias.");
                                Console.WriteLine();
                            }
                        } while (primeiroPeriodo + segundoPeriodo > ferias);
                        Console.WriteLine("- Informe o mes do primeiro periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        primeiroMes = Console.ReadLine();
                        Console.WriteLine("- Informe o mes do segundo periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        segundoMes = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("- Error, Opção invalida, selecione entre as opções.");
                        Console.WriteLine("- Dígite qualquer coisa para continuar.");
                        Console.ReadKey();
                        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ REFAÇA A OPERAÇÃO ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                        Console.WriteLine();
                    }
                    // Aqui vou precisar enviar as informações das variaveis para o banco de dados.
                    break;

                case 3:
                    Console.WriteLine("- O funcionário optou por fazer a venda das férias. [S] ou [N] ?");
                    Console.Write("- Vender...: ");
                    venda = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();
                    if (venda == 'S')
                    {
                        do
                        {
                            Console.WriteLine("- Informe quantos dias ele deseja vender. MÁXIMO Permitido 10 dias");
                            Console.Write("- Dias vendidos...: ");
                            diasVendidos = int.Parse(Console.ReadLine());
                            ferias = 30;
                            ferias = ferias - diasVendidos;
                            Console.WriteLine();
                        } while (diasVendidos > 10);
                        Console.WriteLine($"- O funcionário téra {ferias} dias de férias devido a venda de {diasVendidos} dias.");
                        Console.WriteLine();


                        Console.WriteLine("- Um dos periodos deve ser de no minimo 14 dias. Escolha um deles.");
                        Console.WriteLine();
                        Console.WriteLine("- Para primeiro periodo dígite [1]");
                        Console.WriteLine("- Para segundo periodo dígite [2]");
                        Console.WriteLine("- Para terceiro periodo dígite [3]");
                        Console.Write("- Periodo...: ");
                        periodo = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        do
                        {
                            if (periodo == 1)
                            {
                                do
                                {
                                    Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                                    primeiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                } while (primeiroPeriodo < 14);
                                do
                                {
                                    Console.WriteLine("- Agora informe os outros dois periodos. Nenhum deles pode ser menor que 5 dias.");
                                    Console.WriteLine();
                                    Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                                    segundoPeriodo = int.Parse(Console.ReadLine());
                                    Console.Write("- Quantos dias o fucionario solicitou para o 3º periodo: ");
                                    terceiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("--- ATENÇÃO!");
                                        Console.WriteLine($"- Por optar em realizar a venda de {diasVendidos} dias das férias, os dias gozados do funcionário não podem exceder ou ser menor que os {ferias} das férias.");
                                    }
                                    Console.WriteLine();
                                } while (!(segundoPeriodo >= 5 && terceiroPeriodo >= 5 && primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias));
                            }
                            else if (periodo == 2)
                            {
                                do
                                {
                                    Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                                    segundoPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                } while (segundoPeriodo < 14);
                                do
                                {
                                    Console.WriteLine("- Agora informe os outros dois periodos. Nenhum deles pode ser menor que 5 dias.");
                                    Console.WriteLine();
                                    Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                                    primeiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.Write("- Quantos dias o fucionario solicitou para o 3º periodo: ");
                                    terceiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("--- ATENÇÃO!");
                                        Console.WriteLine($"- Por optar em realizar a venda de {diasVendidos} dias das férias, os dias gozados do funcionário não podem exceder ou ser menor que os {ferias} das férias.");
                                    }
                                    Console.WriteLine();
                                } while (!(primeiroPeriodo >= 5 && terceiroPeriodo >= 5 && primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias));

                            }
                            else if (periodo == 3)
                            {
                                do
                                {
                                    Console.Write("- Quantos dias o fucionario solicitou para o 3º periodo: ");
                                    terceiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                } while (terceiroPeriodo < 14);
                                do
                                {
                                    Console.WriteLine("- Agora informe os outros dois periodos. Nenhum deles pode ser menor que 5 dias.");
                                    Console.WriteLine();
                                    Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                                    primeiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                                    segundoPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("--- ATENÇÃO!");
                                        Console.WriteLine($"- Por optar em realizar a venda de {diasVendidos} dias das férias, os dias gozados do funcionário não podem exceder ou ser menor que os {ferias} das férias.");
                                    }
                                    Console.WriteLine();
                                } while (!(primeiroPeriodo >= 5 && segundoPeriodo >= 5 && primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias));

                            }
                            else
                            {
                                Console.WriteLine("- Error, Opção invalida, selecione entre as opções.");
                                Console.WriteLine("- Dígite qualquer coisa para continuar.");
                                Console.ReadKey();
                                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ REFAÇA A OPERAÇÃO ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                                Console.WriteLine();
                            }
                        } while (periodo != 1 && periodo != 2 && periodo != 3);
                        Console.WriteLine();

                        Console.WriteLine("- Informe o mes do primeiro periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        primeiroMes = Console.ReadLine();
                        Console.WriteLine("- Informe o mes do segundo periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        segundoMes = Console.ReadLine();
                        Console.WriteLine("- Informe o mes do segundo periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        terceiroMes = Console.ReadLine();
                    }
                    else if (venda == 'N')
                    {
                        Console.WriteLine("- Um dos periodos deve ser de no minimo 14 dias. Escolha um deles.");
                        Console.WriteLine();
                        Console.WriteLine("- Para primeiro periodo dígite [1]");
                        Console.WriteLine("- Para segundo periodo dígite [2]");
                        Console.WriteLine("- Para terceiro periodo dígite [3]");
                        Console.Write("- Periodo...: ");
                        periodo = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        do
                        {
                            if (periodo == 1)
                            {
                                do
                                {
                                    Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                                    primeiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                } while (primeiroPeriodo < 14);
                                do
                                {
                                    Console.WriteLine("- Agora informe os outros dois periodos. Nenhum deles pode ser menor que 5 dias.");
                                    Console.WriteLine();
                                    Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                                    segundoPeriodo = int.Parse(Console.ReadLine());
                                    Console.Write("- Quantos dias o fucionario solicitou para o 3º periodo: ");
                                    terceiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("--- ATENÇÃO!");
                                        Console.WriteLine($"- Os dias gozados do funcionário não podem exceder ou ser menor que os {ferias} das férias.");
                                    }
                                    Console.WriteLine();
                                } while (!(segundoPeriodo >= 5 && terceiroPeriodo >= 5 && primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias));
                            }
                            else if (periodo == 2)
                            {
                                do
                                {
                                    Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                                    segundoPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                } while (segundoPeriodo < 14);
                                do
                                {
                                    Console.WriteLine("- Agora informe os outros dois periodos. Nenhum deles pode ser menor que 5 dias.");
                                    Console.WriteLine();
                                    Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                                    primeiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.Write("- Quantos dias o fucionario solicitou para o 3º periodo: ");
                                    terceiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("--- ATENÇÃO!");
                                        Console.WriteLine($"- Os dias gozados do funcionário não podem exceder ou ser menor que os {ferias} das férias.");
                                    }
                                    Console.WriteLine();
                                } while (!(primeiroPeriodo >= 5 && terceiroPeriodo >= 5 && primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias));

                            }
                            else if (periodo == 3)
                            {
                                do
                                {
                                    Console.Write("- Quantos dias o fucionario solicitou para o 3º periodo: ");
                                    terceiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                } while (terceiroPeriodo < 14);
                                do
                                {
                                    Console.WriteLine("- Agora informe os outros dois periodos. Nenhum deles pode ser menor que 5 dias.");
                                    Console.WriteLine();
                                    Console.Write("- Quantos dias o fucionario solicitou para o 1º periodo: ");
                                    primeiroPeriodo = int.Parse(Console.ReadLine());
                                    Console.Write("- Quantos dias o fucionario solicitou para o 2º periodo: ");
                                    segundoPeriodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("--- ATENÇÃO!");
                                        Console.WriteLine($"- Os dias gozados do funcionário não podem exceder ou ser menor que os {ferias} das férias.");
                                    }
                                    Console.WriteLine();
                                } while (!(primeiroPeriodo >= 5 && segundoPeriodo >= 5 && primeiroPeriodo + segundoPeriodo + terceiroPeriodo == ferias));

                            }
                            else
                            {
                                Console.WriteLine("- Error, Opção invalida, selecione entre as opções.");
                                Console.WriteLine("- Dígite qualquer coisa para continuar.");
                                Console.ReadKey();
                                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ REFAÇA A OPERAÇÃO ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                                Console.WriteLine();
                            }
                        } while (periodo != 1 && periodo != 2 && periodo != 3);
                        Console.WriteLine();

                        Console.WriteLine("- Informe o mes do primeiro periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        primeiroMes = Console.ReadLine();
                        Console.WriteLine("- Informe o mes do segundo periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        segundoMes = Console.ReadLine();
                        Console.WriteLine("- Informe o mes do segundo periodo que o funcionario solicitou as férias: ");
                        Console.Write("- Mês...: ");
                        terceiroMes = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("- Error, Opção invalida, selecione entre as opções.");
                        Console.WriteLine("- Dígite qualquer coisa para continuar.");
                        Console.ReadKey();
                        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ REFAÇA A OPERAÇÃO ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                        Console.WriteLine();
                    }
                    break;
                // Aqui vou precisar enviar as informações das variaveis para o banco de dados.
                default:
                    Console.WriteLine("- Error, Opção invalida, selecione entre as opções.");
                    Console.WriteLine("- Dígite qualquer coisa para continuar.");
                    Console.ReadKey();
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ REFAÇA A OPERAÇÃO ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    Console.WriteLine();
                    break;
            }
        }

        public double FormulaCalculoDeFerias(double salario, bool venda, int dias)
        {
            // Ainda preciso terminar esse código
            // Vou precisar passar os valores do INSS e IRRF por parametros.
            double abonoPecuniarioUmTerco, umTercoSalarioBase, salarioBrutoFerias, inss, irrf, pensao = 300, dependente = 400, salarioLiquidoFerias = 0;

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

                    inss = folhaPG.FormulaDoInss(salarioBrutoFerias);
                    InssFerias = inss;
                    irrf = folhaPG.FormulaDoIrrf(salarioBrutoFerias, inss, pensao, dependente);
                    IrrfFerias = irrf;
                    salarioLiquidoFerias = salarioBrutoFerias - inss - irrf;
                }
                else if (venda == false)
                {
                    umTercoSalarioBase = salario / 3;
                    salarioBrutoFerias = salario + umTercoSalarioBase;
                    BrutoDeFerias = salarioBrutoFerias;

                    inss = folhaPG.FormulaDoInss(salarioBrutoFerias);
                    InssFerias = inss;
                    irrf = folhaPG.FormulaDoIrrf(salarioBrutoFerias, inss, pensao, dependente);
                    IrrfFerias = irrf;
                    salarioLiquidoFerias = salarioBrutoFerias - inss - irrf;
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

