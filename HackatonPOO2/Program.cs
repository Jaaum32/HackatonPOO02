using HackatonPOO2.UI;
using HackatonPOO2.Model;

namespace HackatonPOO2;
internal abstract class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        CarrinhoUI carrinho = new CarrinhoUI();
        ProdutoUI produto = new ProdutoUI();
        PromocaoUI promocao = new PromocaoUI();

        bool exec = true;

        while (exec)
        {
            switch (menu())
            {
             case 1: 
                 produto.getAll(produto.catalogo);
                 Console.WriteLine("Digite o Id do produto que deseja adicionar ao carrinho");
                 int pos = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(produto.catalogo[pos]);
                 carrinho.adicionarProdutoAoCarrinho(produto.catalogo[pos]);
                 break;
             case 2: 
                 carrinho.getAll();
                 Console.WriteLine("Digite o Id do produto que deseja remover do carrinho");
                 carrinho.removerProdutoAoCarrinho(Convert.ToInt32(Console.ReadLine()));
                 break;
             case 3: 
                 promocao.getAll(promocao.promocoes);
                 break;
             case 4: 
                 promocao.createPromocao();
                 break;
             case 5: 
                 promocao.deletePromocao();
                 break;
             case 6: 
                 produto.getAll(produto.catalogo);
                 break;
             case 7: 
                 produto.createProduto();
                 break;
             case 8: 
                 produto.updateProduto();
                 break;
             case 9: 
                 produto.deleteProduto();
                 break;
             case 10: // *Fechar compra
                 break;
             case 0:
                 exec = false;
                 break;
            }
        }

    }

    public static int menu()
    {
        Console.WriteLine("Digite a opcao desejada:");
        Console.WriteLine("1- Adicionar produtos no carrinho");
        Console.WriteLine("2- Remover produtos do carrinho");
        
        Console.WriteLine("3- Ver descontos");
        Console.WriteLine("4- Aplicar promocao");
        Console.WriteLine("5- Remover promocao");
        
        Console.WriteLine("6- Ver catalogo");
        Console.WriteLine("7- Adicionar produtos no catalogo");
        Console.WriteLine("8- Editar produtos no catalogo");
        Console.WriteLine("9- Remover produtos do catalogo");
        
        Console.WriteLine("10 - Fechar compra");
        Console.WriteLine("0 - Sair");
        
        return Convert.ToInt32(Console.ReadLine());
    }
}