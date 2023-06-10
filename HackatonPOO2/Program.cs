using HackatonPOO2.UI;
using HackatonPOO2.Model;

namespace HackatonPOO2;
internal abstract class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        CarrinhoUI carrinhoUI = new CarrinhoUI();
        ProdutoUI produtoUI = new ProdutoUI();
        PromocaoUI promocaoUI = new PromocaoUI();

        bool exec = true;

        while (exec)
        {
            switch (menu())
            {
             case 1: 
                 produtoUI.getAll();
                 Console.WriteLine("Digite o Id do produto que deseja adicionar ao carrinho");
                 int pos = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(produtoUI.catalogo[pos]);
                 carrinhoUI.adicionarProdutoAoCarrinho(produtoUI.catalogo[pos]);
                 break;
             case 2: 
                 carrinhoUI.getAll();
                 Console.WriteLine("Digite o Id do produto que deseja remover do carrinho");
                 carrinhoUI.removerProdutoAoCarrinho(Convert.ToInt32(Console.ReadLine()));
                 break;
             case 3: 
                 promocaoUI.getAll();
                 break;
             case 4: 
                 promocaoUI.createPromocao();
                 break;
             case 5: 
                 promocaoUI.deletePromocao();
                 break;
             case 6: 
                 produtoUI.getAll();
                 break;
             case 7: 
                 produtoUI.createProduto();
                 break;
             case 8: 
                 produtoUI.updateProduto();
                 break;
             case 9: 
                 produtoUI.deleteProduto();
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
        Console.WriteLine("4- Criar  promocao");
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