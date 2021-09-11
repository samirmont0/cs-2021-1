using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa13_1
{
    class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Au! Au! Au! Au!";
        }

        public override string ToString()
        {
            return $"Eu sou um cachorro, meu nome é {Nome} e tenho {Idade} anos";
        }

        public string Correr()
        {
            return "Estou correndo!";
        }
    }
}
