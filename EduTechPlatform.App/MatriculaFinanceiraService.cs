using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduTechPlatform.App
{
    public class MatriculaFinanceiraService
    {
        public decimal CalcularValorMensalidade(decimal valorBase, int diaPagamento, bool eBolsista)
        {
            if(eBolsista == true)
            {
                return valorBase *0.50;
            }
            if (!eBolsista && diaPagamento <=5)
            {
                return valorBase *0.90;
            }
            else
            {
                return valorBase;
            }
        }

        public bool PodeRealizarRematricula(bool possuiPendenciaFinanceira, string situacaoAcademica)
        {
            if(possuiPendenciaFinanceira == false && situacaoAcademica == "APROVADO")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}