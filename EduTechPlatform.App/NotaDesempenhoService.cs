using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduTechPlatform.App
{
    public class NotaDesempenhoService
    {
        public decimal CalcularMediaPonderada(decimal nota1, decimal nota2, decimal notaProjeto)
        {
            decimal result = ((nota1 * 3) + (nota2 * 3) + (notaProjeto * 4)) / 10;
            return result;
        }
      public string ObterSituacaoAcademica(decimal mediaFinal)
        {
            if(mediaFinal >= 7.0)
            {
                return "APROVADO";
            }
            if (mediaFinal >= 5.0 || mediaFinal <= 6.9)
            {
                return "RECUPERAÇÃO";
            }
            if (mediaFinal < 5)
            {
                return "REPOVADO";
            }
        }
        
    }
}