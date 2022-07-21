using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalculator.Src
{
    public class Quadrado : Template
    {
        public Quadrado(string aNome, double aBase, double aAltura) : base(aNome, aBase, aAltura)
        {
        }
        
        public override double AreaTotal()
        {
        double area = Base * Altura;
        return area;
        }


    }
}
