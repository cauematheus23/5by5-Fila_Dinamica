using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Fila_Dinamica
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string nome)
        {
            this.nome = nome;
            proximo = null;
        }

        public override string? ToString()
        {
            return "Nome: " + nome;
        }

        public void setNext(Pessoa aux)
        {
            this.proximo = aux;
        }
        public Pessoa? getNext()
        {
            return this.proximo;
        }
        public string getNome()
        {
            return this.nome;
        }
    }
}
