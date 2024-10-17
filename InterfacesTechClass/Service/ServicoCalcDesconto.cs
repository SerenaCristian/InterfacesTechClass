using InterfacesTechClass.Core.Entidades;
using System;
using System.Collections.Generic;

namespace InterfacesTechClass.Service
{
    internal class ServicoCalcDesconto
    {
        public string ServiceCalcDesconto(List<Alimento> alimentos,
                                          List<Eletronico> eletronicos,
                                          List<Roupa> roupas)
        {
            double descontoEletronicos = 0;
            double descontoRoupas = 0;

            
            foreach (Alimento alimento in alimentos)
            {
                Console.WriteLine("A Categoria Alimento não tem desconto!");
            }

            
            foreach (Eletronico eletronico in eletronicos)
            {
                descontoEletronicos += eletronico.Preco * 0.10;  
            }

            
            foreach (Roupa roupa in roupas)
            {
                descontoRoupas += roupa.Preco * 0.20; 
            }

           
            return $"O desconto para produtos Eletrônicos é de {descontoEletronicos} (10%)\n" +
                   $"O desconto para produtos Roupas é de {descontoRoupas} (20%)";
        }
    }
}
