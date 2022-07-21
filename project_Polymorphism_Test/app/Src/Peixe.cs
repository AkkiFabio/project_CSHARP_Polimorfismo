using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Src.Interfaces;

namespace app.Src
{
    public class Peixe : Animal, IAcoesPeixe
    {

        public Peixe (string nome, int idade, string classe, string cor) : base(nome, idade, classe,cor)
        {
        }
        public void Nadar()
        {
        Console.WriteLine($"Eu {Nome}, estou nadando glub glub");
        }
        
    }
}