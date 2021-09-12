using System;
using System.Collections.Generic;
using System.Text;
using TDEPilha.Entidades;

namespace TDEPilha.Interface
{
    public interface IPilha<T>
    {
        object VetorElementos { get; }
        int Indice { get; }

        public void Empilha(Container valor);

        public T Desempilha();

        public int Topo()
        {
         if (EstaVazia())
         throw new InvalidOperationException("Exceção: Container Vazio");
            return VetorElementos[Indice - 1];
        }


    public int Tamanho();

    public IEnumerable<T> RetornaTodosElementos();

    public bool EstaVazia();

    public bool Compara(PilhaEstaticaContainer pilha);
}
}
