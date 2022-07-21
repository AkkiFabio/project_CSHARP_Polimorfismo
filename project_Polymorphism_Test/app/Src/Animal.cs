using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threadding.Tasks;


namespace app.Src  

{

    public class Animal
    {
        public string Nome { get;set; }

        public int Idade { get; set; }

        public string Classe { get; set; }

        public string Cor { get; set; }
                
        public Animal(string nome, int idade, string classe, string cor) 
        {
            Nome = nome;
            Idade = idade;
            Classe = classe;
            Cor = cor;
   
        }                 

        public virtual void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo");
        }

        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }




        
    }
}