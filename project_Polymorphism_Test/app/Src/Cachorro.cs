using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threadding.Tasks;



namespace app.Src  

{

    public class Cachorro : Animal
    {
        public Cachorro (string nome, int idade, string classe, string cor) : base(nome, idade, classe,cor)
        {
        }


        public override void Dormir()
        {
            Console.WriteLine($"Eu {Nome}, estou dormindo RhRhR");
        }

        public override void Comer()
        {
            Console.WriteLine($"Eu {Nome}, estou comendo nhamnham");
        }
        
        public void Latir()
        {
            Console.WriteLine($"Eu {Nome}, estou latindo awoooo");
        }



        
    }
}