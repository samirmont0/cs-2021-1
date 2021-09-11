using System;

namespace Tarefa016
{
    class AgendaTeste
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            Contato contato1 = new Contato();
            contato1.Nome = "Samir";
            contato1.Telefone = 6699994155;
            contato1.Email = "smr@gmail.com";

            Contato contato2 = new Contato();
            contato2.Nome = "Maria";
            contato2.Telefone = 6299946251;
            contato2.Email = "mra@gmail.com";

            Contato contato3 = new Contato();
            contato3.Nome = "Zezin";
            contato3.Telefone = 6699888155;
            contato3.Email = "zzr@gmail.com";

            agenda.AdicioneContato(contato1);
            agenda.AdicioneContato(contato2);
            agenda.AdicioneContato(contato3);

            try
            {
                Contato contatoEncontrado = agenda.ProcureContatoPeloNome("Samir");
                Console.WriteLine($"\nO contato foi encontrado, e tem nome de: {contatoEncontrado.Nome} " +
                                        $"\nTelefone: {contatoEncontrado.Telefone}" +
                                                $"\nEmail: {contatoEncontrado.Email}\n");
            }
            catch(ContatoNaoEncontratoException ex)
            {
                Console.WriteLine("\n" + ex.Message);
                Console.WriteLine(ex.StackTrace + "\n");     
            }
            finally
            {
                agenda.RemoveContato(contato1);
                agenda.RemoveContato(contato2);
                agenda.RemoveContato(contato3);
            }
        }
    }
}
