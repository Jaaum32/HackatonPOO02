using HackatonPOO2.UI;
using HackatonPOO2.Model;

namespace HackatonPOO2;
internal abstract class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        CarrinhoUI carrinho = new CarrinhoUI();
        ClienteUI cliente = new ClienteUI();
        ProdutoUI produto = new ProdutoUI();
        PromocaoUI promocao = new PromocaoUI();
        VendaUI venda = new VendaUI();
        

        bool exec = true;

        while (exec)
        {
            switch (menu())
            {
             case 1: // Adicionar produtos carrinho
                 break;
             case 2: // Remover produtos do carrinho
                 break;
             case 3: // Ver descontos
                 break;
             case 4: // Aplicar descontos em produto
                 break;
             case 5: // plicar descontos em categoria
                 break;
             case 6: // Remover descontos
                 break;
             case 7: // Ver catalogo
                 break;
             case 8: // Adicionar produtos no catalogo
                 produto.createProduto();
                 break;
             case 9: // Editar produtos no catalogo
                 break;
             case 10: // Remover produtos do catalogo
                 break;
             case 11: // Fechar compra
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
        Console.WriteLine("4- Aplicar descontos em produto");
        Console.WriteLine("5- Aplicar descontos em categoria");
        Console.WriteLine("6- Remover descontos");
        
        Console.WriteLine("7- Ver catalogo");
        Console.WriteLine("8- Adicionar produtos no catalogo");
        Console.WriteLine("9- Editar produtos no catalogo");
        Console.WriteLine("10- Remover produtos do catalogo");
        
        Console.WriteLine("11 - Fechar compra");
        Console.WriteLine("0 - Sair");
        
        return Convert.ToInt32(Console.ReadLine());
    }
}