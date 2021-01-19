using System;
using System.Collections.Generic;

namespace Objeto_como_argumento.Classes
{
    public class Carrinho
    {
        
        public float ValorTotal { get; set; }

        List<Produto> listaDeProdutos = new List<Produto>();
        
        public void AdicionarProduto(Produto produto){
            listaDeProdutos.Add(produto);
        }

        public void RemoverProduto(int codigo){
            var prod = listaDeProdutos.Find(x => x.Codigo == codigo);
            listaDeProdutos.Remove(prod);
        }
        
        public void MostrarProduto(){
            if (listaDeProdutos != null)
            {
                foreach (var item in listaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Código do produto: {item.Codigo}R$ {item.Preco.ToString("n2")}\nNome - {item.Nome}\n----------------------");
                    Console.ResetColor();
                    
                }
            }
            else if (listaDeProdutos == null)
            {
                Console.WriteLine($"Você ainda não adicionou nenhum produto");
            }
        } 

        public void AlterarItem(int _codigo, Produto _produtoNovo){
            listaDeProdutos.Find(x => x.Codigo == _codigo).Codigo = _produtoNovo.Codigo;
            listaDeProdutos.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;
            listaDeProdutos.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;
        }
    }
}