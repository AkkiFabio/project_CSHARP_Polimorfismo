using System;
using app.Src;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var garfield = new Gato ("Garfield", 3, "Gato", "Laranja");

            var pluto = new Cachorro ("Pluto", 2, "Cachorro", "Marrom");

            var peixe = new Peixe ("Nemo", 1, "Peixe", "Laranja e Branco");

            var passaro = new Passaro ("Donald", 6, "Passaro", "Branco");



            pluto.Dormir();
            garfield.Dormir();
            peixe.Dormir();
            peixe.Nadar();
            passaro.Comer();
        }
    }
}
