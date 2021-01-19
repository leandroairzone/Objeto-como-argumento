using System;
using Objeto_como_argumento.Classes;

namespace Objeto_como_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
           int ops1 = 0, quant = 0;
            Carrinho carrinho = new Carrinho();

            Console.WriteLine($"--------------------\nAdicionando produtos\n--------------------");
            do
            {   
                Console.WriteLine("[1] Adicionar produtos\n[2] Remover produtos\n[3] Ver lista de produtos\n[4] Sair");
                ops1 = int.Parse(Console.ReadLine());

                while (ops1 != 1 && ops1 != 2 && ops1 != 3 && ops1 != 4)
                {
                    Console.WriteLine($"Opção inválida.\n[1] Adicionar produtos\n[2] Remover produtos\n[3] Ver lista de produtos\n[4] Sair");
                    ops1 = int.Parse(Console.ReadLine());
                }

                switch (ops1)
                {
                    case 1:
                        Console.Write($"Digite quantos produtos você deseja adicionar: ");
                        quant = int.Parse(Console.ReadLine());

                        while (quant <= 0)
                        {
                            Console.Write($"Numero inválido.\nDigite novamente: ");
                            quant = int.Parse(Console.ReadLine());
                        }

                        for (var i = 0; i < quant; i++)
                        {
                            Produto produto = new Produto();
                            Console.Write($"Digite o codigo do produto: ");
                            produto.Codigo = int.Parse(Console.ReadLine());
                            Console.Write($"Digite o nome do produto: ");
                            produto.Nome = Console.ReadLine();
                            Console.Write($"Digite o preço do produto: R$ ");
                            produto.Preco = float.Parse(Console.ReadLine());
                            carrinho.AdicionarProduto(produto);
                        }
                    break;

                    case 2:
                        Console.Write($"Digite o código do produto que você deseja remover: ");
                        Produto excluir = new Produto();
                        excluir.Codigo = int.Parse(Console.ReadLine());
                        carrinho.RemoverProduto(excluir.Codigo);
                    break;

                    case 3:
                        carrinho.MostrarProduto();
                    break;
                }
            } while (ops1 != 4);

            //carrinho.RemoverProduto(produto1);

            
            
        }
    }
}
