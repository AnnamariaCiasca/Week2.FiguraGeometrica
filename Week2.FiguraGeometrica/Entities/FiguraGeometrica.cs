using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.FiguraGeometrica
{
    public abstract class FiguraGeometrica
    {

        public string Name { get; set; }

        public FiguraGeometrica(string name)
        {
            this.Name = name;
        }

        public string PrintNome()
        {
            return $"\n{Name.ToUpper()}\n";
        }


        public virtual double CalcolaPerimetro()
        {
            return 0;
        }
        public virtual double CalcolaArea()
        {
            return 0;
        }
    }
}
