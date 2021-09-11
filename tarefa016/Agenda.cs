using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa016
{
    class Agenda
    {
        List<Contato> contatos = new List<Contato>();

        public void AdicioneContato(Contato contato)
        {
            contatos.Add(contato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }
        public void RemoveContato(Contato contato)
        {
            contatos.Remove(contato);
            Console.WriteLine("Contato removido com sucesso!");
        }
        public Contato ProcureContatoPeloNome(string nome)
        {
            var contatoEncontradoPeloNome = from nomeContato in contatos
                                            where (nomeContato.Nome == nome)
                                            select nomeContato;

            if (!contatoEncontradoPeloNome.Any())
            {
                throw new ContatoNaoEncontratoException("Contato não encontrado");
            }
            else
            {
                return contatoEncontradoPeloNome.FirstOrDefault();
            }
        }
    }
}
