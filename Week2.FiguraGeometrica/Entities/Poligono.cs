using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.FiguraGeometrica
{
    public abstract class Poligono : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altezza { get; set; }


        public Poligono(string name, double _base, double altezza)
             : base(name)
        {

        }

    }
}