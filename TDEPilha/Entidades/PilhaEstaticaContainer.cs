using System;
using System.Collections.Generic;
using System.Text;
using TDEPilha.Interface;

namespace TDEPilha.Entidades
{
    public class PilhaEstaticaContainer : IPilha<Container>
    {
        private int[] VetorElementos;
        private int TamanhoMaximo = 12;
        private int Indice;
        private int Topo;

        public PilhaEstaticaContainer()
        {
            VetorElementos = new int[TamanhoMaximo];
            Indice == 0;
        }

    {
        public object VetorElementos { get; private set; }
        public int Indice { get; private set; }

        public bool Compara(PilhaEstaticaContainer pilha)
        {
            throw new NotImplementedException();
        }

        public int Desempilha()
        {
            if (Topo == 0)
            {
             throw new Exception("Espaço está Vazio! Não é possivel remover o container!");
            }
            else
            {
             int valorRetorno = VetorElementos[Topo - 1];

             Topo--;

             return valorRetorno;
            }
        }

        public void Empilha(int valor)
        {
            if (Topo < TamanhoMaximo)
        {
            VetorElementos[Topo] = valor;
            Topo++;
        }
            else
            {
                throw new Exception("Espaço totalmente preenchido! Container não inserido!");
            }
        }

        public bool EstaVazia()
        {
            return Indice == 0;
        }

        public IEnumerable<Container> RetornaTodosElementos()
        {
            throw new NotImplementedException();
        }

        public int Tamanho()
        {
            for (int i = Indice - 1; i >= 0; i--)
            {
                yield return VetorElementos[i];
            }
        }
        public int Topo()
        {
            if (EstaVazia())
            throw new InvalidOperationException("Exceção: Container Vazio");
            return VetorElementos[Indice - 1];
        }


        int IPilha<Container>.Topo()
        {
            throw new NotImplementedException();
        }
    }
}
