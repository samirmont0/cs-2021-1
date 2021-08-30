using System;
using System.Collections.Generic;

namespace Tarefa13_1
{
    class AnimalTeste
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Boltz";
            cachorro.Idade = 3;

            Cavalo cavalo = new Cavalo();
            cavalo.Nome = "Brabo";
            cavalo.Idade = 1;

            Preguica preguica = new Preguica();
            preguica.Nome = "Lentois";
            preguica.Idade = 1;

            List<Animal> animais = new List<Animal>();
            animais.Add(cachorro);
            animais.Add(cavalo);
            animais.Add(preguica);

            foreach(var animal in animais)
            {
                Console.WriteLine(animal.EmitirSom());
            }

            Veterinario vet = new Veterinario();
            vet.Examinar(cachorro);
            vet.Examinar(cavalo);
            vet.Examinar(preguica);
        }
    }
}
