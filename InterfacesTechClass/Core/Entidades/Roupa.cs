using System;

namespace InterfacesTechClass.Core.Entidades
{
    internal class Roupa : ICalculaDescontoRoupas
    {
        public int Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double CalculaDescontosRoupas() => Preco - Preco * 0.20;
       
    }
}
