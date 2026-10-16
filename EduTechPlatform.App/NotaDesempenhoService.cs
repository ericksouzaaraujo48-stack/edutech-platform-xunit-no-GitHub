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
      
        
    }
}