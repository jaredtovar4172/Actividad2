using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo
{
    class Calcular
    {
      public double Circunferencia(double radio)
        {
            double circunferencia = 2 * 3.1416 * radio;
            return (circunferencia);
        }
            public double Area(double radio)
        {
            double area = 3.1316 * Math.Pow(radio, 2);
            return (area);
        }
    }
}
