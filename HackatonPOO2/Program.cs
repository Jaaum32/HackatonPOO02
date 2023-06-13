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
                    carrinhoUI.adicionarProdutoAoCarrinho(produtoUI);
                    break;
                case 2:
                    carrinhoUI.getAll();
                    break;
                case 3:
                    carrinhoUI.removerProdutoAoCarrinho();
                    break;
                case 4:
                    promocaoUI.getAll();
                    break;
                case 5:
                    promocaoUI.createPromocao(produtoUI, idCountPromocao);
                    break;
                case 6:
                    promocaoUI.deletePromocao();
                    break;
                case 7:
                    produtoUI.getAll();
                    break;
                case 8:
                    produtoUI.createProduto(idCountProduto);
                    break;
                case 9:
                    produtoUI.updateProduto(idCountProduto);
                    break;
                case 10:
                    produtoUI.deleteProduto();
                    break;
                case 11:
                    double valorFinal = carrinhoUI.calcularValorTotal(produtoUI, promocaoUI);
                    Console.WriteLine("Valor final: R$" + valorFinal);
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

        return Convert.ToInt32(Console.ReadLine());
    }
}