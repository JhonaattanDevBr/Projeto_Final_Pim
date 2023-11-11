using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficioDasFerias
{
    public class AgendamentoFerias
    {
		public string IdAgendamento { get; set; }
		public string PrimeiroMes { get; set; }
		public string PrimeiroPeriodo { get; set; }
		public string SegundoMes { get; set; }
		public string SegundoPeriodo { get; set; }
		public string TerceiroMes { get; set; }
		public string TerceiroPeriodo { get; set; }
		public string DiasRestantes { get; set; }
		public string DiasVendidos { get; set; }
		public string PrimeiraParcelaDecimo { get; set; }
		public string IdFuncionario { get; set; }
        public string MensagemErro { get; set; }

        public bool AuntenticarAgendamentoFerias()
		{
			bool[] auten = new bool[3];
			auten[0] = AutenticarMeses();
			auten[1] = AutenticarDias();
			auten[2] = AutenticarQuantidadeDias();

			if (auten[0])
			{
				if (auten[1])
				{
					if (auten[2])
					{
                        return true;
					}
					else
					{
                        MensagemErro = "Para férias em três periodos um deles deve ser de no mínimo 14 dias e os demais mínimo de 5";
                        return false;
					}
				}
				else
				{
                    MensagemErro = "O benefício das férias não pode ser menor ou exceder a 30 dias,\npodendo ser dividido em até três periodos diferentes.";
                    return false;
				}
			}
			else
			{
                MensagemErro = "Os meses selecionados não podem ser iguais.";
                return false;
			}
		}

		public bool AutenticarMeses()
		{
			if (PrimeiroMes != SegundoMes && SegundoMes != TerceiroMes && TerceiroMes != PrimeiroMes)
			{
                return true;
			}
			else 
			{
                return false;
			}
		}

		public bool AutenticarDias()
		{
			int dias = 30, totalDias;

			int[] peridos = new int[4];
			peridos[0] = Convert.ToInt32(PrimeiroPeriodo);
			peridos[1] = Convert.ToInt32(SegundoPeriodo);
			peridos[2] = Convert.ToInt32(TerceiroPeriodo);
			peridos[3] = Convert.ToInt32(DiasVendidos);

			totalDias = peridos[0] + peridos[1] + peridos[2] + peridos[3]; 
			if(totalDias == dias)
			{
				return true;
			}
			else 
			{
                return false; 
			}
		}

		public bool AutenticarQuantidadeDias()
		{
            int[] peridos = new int[4];
			bool retornoPeriodos = false;

            peridos[0] = Convert.ToInt32(PrimeiroPeriodo);
            peridos[1] = Convert.ToInt32(SegundoPeriodo);
            peridos[2] = Convert.ToInt32(TerceiroPeriodo);
            peridos[3] = Convert.ToInt32(DiasVendidos);

            if (peridos[0] != 0 && peridos[1] == 0 && peridos[2] == 0)
			{
				retornoPeriodos = UmPeriodo();
				return true;
			}
			else if (peridos[0] != 0 && peridos[1] != 0 && peridos[2] == 0)
			{
				retornoPeriodos = DoisPeriodos();
                return true;
            }
			else if (peridos[0] != 0 && peridos[1] != 0 && peridos[2] != 0)
			{
				retornoPeriodos = TresPeriodos();
                return true;
            }
			else 
			{
				return false; 
			}
        }

		private bool UmPeriodo()
		{
            int[] peridos = new int[4];
            int dias = 30;
            peridos[0] = Convert.ToInt32(PrimeiroPeriodo);
            peridos[1] = Convert.ToInt32(SegundoPeriodo);
            peridos[2] = Convert.ToInt32(TerceiroPeriodo);
            peridos[3] = Convert.ToInt32(DiasVendidos);

			int totalDias = peridos[0] + peridos[3];
            if (totalDias == dias)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		private bool DoisPeriodos()
		{
            int[] peridos = new int[4];
			int dias = 30;
            peridos[0] = Convert.ToInt32(PrimeiroPeriodo);
            peridos[1] = Convert.ToInt32(SegundoPeriodo);
            peridos[2] = Convert.ToInt32(TerceiroPeriodo);
            peridos[3] = Convert.ToInt32(DiasVendidos);

			if (peridos[0] >= 5 && peridos[1] >= 5)
			{
                int totalDias = peridos[0] + peridos[1] + peridos[3];
                if (totalDias == dias)
                {
                    return true;
                }
                else { return false; }
            }
			else { return false; }
        }

		private bool TresPeriodos()
		{
            int[] peridos = new int[4];
			int dias = 30;
            peridos[0] = Convert.ToInt32(PrimeiroPeriodo);
            peridos[1] = Convert.ToInt32(SegundoPeriodo);
            peridos[2] = Convert.ToInt32(TerceiroPeriodo);
            peridos[3] = Convert.ToInt32(DiasVendidos);

            if (peridos[0] >= 14 || peridos[1] >= 14 || peridos[2] >= 14)
			{
				if (peridos[0] >= 5 && peridos[1] >= 5 && peridos[2] >= 5)
				{
					int totalDias = peridos[0] + peridos[1] + peridos[2] + peridos[3];
					if (totalDias == dias)
					{
						return true;
					}
					else { return false; }
				}
				else{ return false; }
			}
			else { return false; }
		}
    }
}
