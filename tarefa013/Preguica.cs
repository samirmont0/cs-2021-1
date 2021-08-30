using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa13_1
{
    class Preguica : Animal
    {
        public override string EmitirSom()
        {
            return "iiirrrrí! iiirrrrí!";
        }

        public override string ToString()
        {
            return $"Eu sou uma preguiça, meu nome é {Nome} e tenho {Idade} anos";
        }

        public string SubirEmArvore()
        {
            return "Estou subindo na árvore";
        }
    }
}
