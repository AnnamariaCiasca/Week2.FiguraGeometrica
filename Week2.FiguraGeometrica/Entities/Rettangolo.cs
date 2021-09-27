using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.FiguraGeometrica
{
   public class Rettangolo : Poligono
    {
    
        public Rettangolo(string name, double altezza, double _base)
            : base(name, altezza, _base)
        {
            this.Altezza = altezza;
            this.Base = _base;

        }
        public override double CalcolaPerimetro()
        {
            double perimetro = (Base + Altezza) * 2;
            Console.WriteLine($"Il perimetro vale: {perimetro}");
            return perimetro;
           
        }

        public override double CalcolaArea()
        {
            double area = Base * Altezza;
            Console.WriteLine($"L'area vale: {area}\n");
            return area;
        }
    }
}
