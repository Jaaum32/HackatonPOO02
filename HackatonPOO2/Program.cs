using HackatonPOO2.UI;

namespace HackatonPOO2;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        CarrinhoUI carrinhoUI = new CarrinhoUI();
        ProdutoUI produtoUI = new ProdutoUI();
        PromocaoUI promocaoUI = new PromocaoUI();
        int idCountProduto = 1;
        int idCountPromocao = 1;

        bool exec = true;

        while (exec)
        {
            switch (menu())
            {
                case 1:
                    Console.Clear();
                    carrinhoUI.adicionarProdutoNoCarrinho(produtoUI);
                    break;
                case 2:
                    Console.Clear();
                    carrinhoUI.getAll();
                    break;
                case 3:
                    Console.Clear();
                    carrinhoUI.removerProdutoNoCarrinho();
                    break;
                case 4:
                    Console.Clear();
                    promocaoUI.getAll();
                    break;
                case 5:
                    Console.Clear();
                    promocaoUI.createPromocao(produtoUI, idCountPromocao);
                    idCountPromocao++;
                    break;
                case 6:
                    Console.Clear();
                    promocaoUI.deletePromocao();
                    break;

                case 7:
                    Console.Clear();
                    produtoUI.getAll();
                    break;
                case 8:
                    Console.Clear();
                    produtoUI.createProduto(idCountProduto);
                    idCountProduto++;
                    break;
                case 9:
                    Console.Clear();
                    produtoUI.updateProduto();
                    break;
                case 10:
                    produtoUI.deleteProduto();
                    break;
                case 11:
                    Console.Clear();
                    double valorFinal = carrinhoUI.calcularValorTotal(produtoUI, promocaoUI);
                    Console.WriteLine("Valor final: R$" + valorFinal + "\n");
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Adeus");
                    exec = false;
                    break;
            }
        }
    }

    public static int menu()
    {
        Console.WriteLine("\nDigite a opcao desejada:");
        Console.WriteLine("1- Adicionar produtos no carrinho");
        Console.WriteLine("2- Ver Produtos no carrinho");
        Console.WriteLine("3- Remover produtos do carrinho");

        Console.WriteLine("4- Ver descontos");
        Console.WriteLine("5- Criar  promocao");
        Console.WriteLine("6- Remover promocao");

        Console.WriteLine("7- Ver catalogo");
        Console.WriteLine("8- Adicionar produtos no catalogo");
        Console.WriteLine("9- Editar produtos no catalogo");
        Console.WriteLine("10- Remover produtos do catalogo");

        Console.WriteLine("11 - Fechar compra");
        Console.WriteLine("0 - Sair");
        int op;
        while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out op) || op > 11)
        {
            Console.WriteLine("\nNão é uma opção! Digite novamente:");
        }

        return op;
    }
}