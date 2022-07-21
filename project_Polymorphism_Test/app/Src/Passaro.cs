using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threadding.Tasks;


namespace app.Src  

{

    public class Passaro : Animal
    {
        public Passaro (string nome, int idade, string classe, string cor) : base(nome, idade, classe,cor)
        {
        }


                public override void Comer()
        {
            Console.WriteLine($"Eu {Nome}, estou comendo bic bic");
        }

        public void Cantar()
        {
            Console.WriteLine($"Eu {Nome}, estou cantando wiiii wiiii");
        }


        
    }
}