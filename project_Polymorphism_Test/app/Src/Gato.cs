using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threadding.Tasks;


namespace app.Src  

{

    public class Gato : Animal
    {
        public Gato (string nome, int idade, string classe, string cor) : base(nome, idade, classe,cor)
        {
        }


        //public override void Dormir()
        //{
        //    Console.WriteLine($"Eu {Nome}, estou dormindo nyaaahh");
        //}

        public override void Comer()
        {
            Console.WriteLine($"Eu {Nome}, estou comendo nyam nyam");
        }

        public void Ronronar()
        {
            Console.WriteLine($"Eu {Nome}, estou ronronando nrrr nrrr");
        }


        
    }
}