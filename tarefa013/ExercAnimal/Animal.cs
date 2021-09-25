using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa13_1
{
    abstract class Animal
    {
        private string nome;
        private int idade;
   
        public string Nome 
        {
            get 
            { 
                return nome; 
            }
            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        public abstract string EmitirSom();

    }
}
