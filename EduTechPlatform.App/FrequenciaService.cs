using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduTechPlatform.App
{
    public class FrequenciaService
    {
            public int CalcularPorcentagemPresenca(int aulasTotais, int faltas)
        {
            int percentualPresenca = ((aulasTotais - faltas) /(double)aulasTotais) * 100;
            return percentualPresenca;
        }
        
    }
}



 