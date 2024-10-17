using InterfacesTechClass.Core.Contracts;

namespace InterfacesTechClass.Core.Entidades
{
    internal class Eletronico : ICalculaDescontoEletronico
    {
        public int Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double CalculaDescontoEletronico() => Preco - Preco * 0.10;
        
    }
}
