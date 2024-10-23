using System;
using InterfacesTechClass.Core.Contracts;

namespace InterfacesTechClass.Core.Entidades
{
    internal class Roupa : ICalculaDesconto
    {
        public int Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double CalculaDesconto() => Preco - Preco * 0.20;
       
    }
}
