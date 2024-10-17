using InterfacesTechClass.Core.Contracts;

namespace InterfacesTechClass.Core.Entidades
{
    internal class Alimento : IProdutoSemDesconto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public string ProdutoSemDesconto()
        {
            return "A Categoria Alimento não possui desconto.";
        }
    }
}
