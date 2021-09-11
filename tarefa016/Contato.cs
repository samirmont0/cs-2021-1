using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa016
{
    class Contato
    {
        private string nome;
        private long telefone;
        private string email;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }

        public long Telefone
        {
            get { return telefone; }
            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

    }
}
