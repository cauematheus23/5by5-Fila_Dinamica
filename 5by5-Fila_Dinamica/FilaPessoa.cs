using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Fila_Dinamica
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            head = null;
            tail = null;
        }
        bool IsEmpty()
        {
            return head == null && tail == null;
        }
        public void Push(Pessoa aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                this.tail.setNext(aux);
                tail = aux;
            }

        }

        public void print()
        {
            Pessoa aux = head;
            if (IsEmpty())
            {
                Console.WriteLine("Fila vazia, nada a imprimir");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getNext();

                } while(aux != null);

            }
        }
        public void Pop()
        {
            if(!IsEmpty())
            {
                if(tail == head)
                {

                    head = tail = null;
                }
                else
                {
                    Console.WriteLine("Pessoa removida da fila com sucesso");
                    head = head.getNext();
                }
                
            }

        }
        public void BuscarPessoa(string nome_pessoa)
        { Pessoa aux = head;
            
            do
            {
                if (!IsEmpty())
                {


                    if (aux.getNome() == nome_pessoa)
                    {
                        Console.WriteLine("A pessoa existe na fila");
                        aux = aux.getNext();
                    }
                    else
                    {
                        aux = aux.getNext();
                    }

                }
                else
                {
                    Console.WriteLine("Lista vazia, nada pra buscar");
                }
            } while (aux != null);
        }
    }
}
