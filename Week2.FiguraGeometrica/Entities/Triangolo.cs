using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.FiguraGeometrica
{
    class Triangolo : Poligono
    {


        public double Cateto1 { get; set; }
        public double Cateto2 { get; set; }



        public Triangolo(string name, double altezza, double _baseT, double cateto1, double cateto2)
            : base(name, _baseT, altezza)
        {
            this.Altezza = altezza;
            this.Base = _baseT;
            this.Cateto1 = cateto1;
            this.Cateto2 = cateto2;
        }

        public override double CalcolaPerimetro()
        {
            double perimetro = (Base + Cateto1 + Cateto2);
            Console.WriteLine($"Il perimetro vale: {perimetro}");
            return perimetro;
        }

        public override double CalcolaArea()
        {
            double area = (Base * Altezza) / 2;
            Console.WriteLine($"L'area vale: {area}\n");
            return area;

        }
    }
}