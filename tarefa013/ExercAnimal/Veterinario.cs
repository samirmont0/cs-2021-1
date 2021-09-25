using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa13_1
{
    class Veterinario
    {
        public void Examinar(Animal animal)
        {
            Console.WriteLine(animal.EmitirSom());
        }
    }
}
