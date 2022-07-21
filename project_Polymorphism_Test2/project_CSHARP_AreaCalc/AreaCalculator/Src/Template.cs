using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalculator.Src
{
      
        public abstract class Template
        {
            public string Nome { get; set; }
            public double Base { get; set; } 
            public double Altura { get; set; }

            public Template(string aNome, double aBase, double aAltura)
            {
                Nome = aNome;
                Base = aBase;
                Altura = aAltura;
            }
            public abstract double AreaTotal();
        }
    
}
