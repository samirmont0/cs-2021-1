using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa13_1
{
    class Zoologico
    {
            List<Animal> jaulasZoo = new List<Animal>();
        public Zoologico()
        {

            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Café";
            cachorro1.Idade = 5;
            jaulasZoo.Add(cachorro1);

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Bolinha";
            cachorro2.Idade = 2;
            jaulasZoo.Add(cachorro2);

            Cavalo cavalo1 = new Cavalo();
            cavalo1.Nome = "Potranca";
            cavalo1.Idade = 10;
            jaulasZoo.Add(cavalo1);

            Cavalo cavalo2 = new Cavalo();
            cavalo2.Nome = "Thanos";
            cavalo2.Idade = 6;
            jaulasZoo.Add(cavalo2);

            Cavalo cavalo3 = new Cavalo();
            cavalo3.Nome = "Lis";
            cavalo3.Idade = 3;
            jaulasZoo.Add(cavalo3);

            Cavalo cavalo4 = new Cavalo();
            cavalo4.Nome = "Tadeu";
            cavalo4.Idade = 15;
            jaulasZoo.Add(cavalo4);

            Preguica preguica1 = new Preguica();
            preguica1.Nome = "Sonera";
            preguica1.Idade = 30;
            jaulasZoo.Add(preguica1);

            Preguica preguica2 = new Preguica();
            preguica2.Nome = "Pesadelo";
            preguica2.Idade = 12;
            jaulasZoo.Add(preguica2);

            Preguica preguica3 = new Preguica();
            preguica3.Nome = "Sonho";
            preguica3.Idade = 22;
            jaulasZoo.Add(preguica3);

            Preguica preguica4 = new Preguica();
            preguica4.Nome = "Lesador";
            preguica4.Idade = 6;
            jaulasZoo.Add(preguica4);
        }

        public void percorrerJaulas()
        {
            foreach(Animal animal in jaulasZoo)
            {
                animal.EmitirSom();
                if(animal.ToString().Contains("cavalo"))
                {
                    Cavalo cavalo = new Cavalo();
                    Console.WriteLine(cavalo.Correr());
                }
                else if (animal.ToString().Contains("cachorro"))
                {
                    Cachorro cachorro = new Cachorro();
                    Console.WriteLine(cachorro.Correr());
                }
            }
        }
    }
}
