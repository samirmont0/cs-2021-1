using System;
using System.Runtime.Serialization;

namespace Tarefa016
{
    [Serializable]
    internal class ContatoNaoEncontratoException : Exception
    {
        public ContatoNaoEncontratoException()
        {
        }

        public ContatoNaoEncontratoException(string message) : base(message)
        {
        }
    }
}