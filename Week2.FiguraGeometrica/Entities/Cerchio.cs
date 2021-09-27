using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.FiguraGeometrica
{
    public class Cerchio : FiguraGeometrica
    {

        public Centro Coordinate { get; set; }
        public double Raggio { get; set; }

        public Cerchio(string name, double raggio, Centro coordinate)
            : base(name)
        {
            this.Coordinate = coordinate;
            this.Raggio = raggio;

        }

        public override double CalcolaPerimetro()
        {
            double perimetro = Math.PI * Raggio * 2;
            Console.WriteLine($"Il perimetro vale: {perimetro}");
            return perimetro;
        }
        public override double CalcolaArea()
        {
            double area = Math.PI * Raggio * Raggio;
            Console.WriteLine($"L'area vale: {area}\n");
            return area;
        }

    }

    public struct Centro
    {
        public int X;
        public int Y;

        public Centro(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
