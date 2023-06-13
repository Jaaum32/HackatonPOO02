using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class CarrinhoUI
{
    public List<Produto> carrinho = new List<Produto>();

    public void adicionarProdutoAoCarrinho(ProdutoUI produtoUi)
    {
        produtoUi.getAll();
        Console.WriteLine("Digite o Id do produto que deseja adicionar ao carrinho");
        int id = Convert.ToInt32(Console.ReadLine());
        carrinho.Add(produtoUi.catalogo[id - 1]);
    }

    public void removerProdutoAoCarrinho()
    {
        getAll();
        Console.WriteLine("Digite o Id do produto que deseja adicionar ao carrinho");
        int id = Convert.ToInt32(Console.ReadLine());
        carrinho.RemoveAt(id);
    }

    public void getAll()
    {
        Console.WriteLine("\nProdutos no carrinho:");
        for (int i = 0; i < carrinho.Count; i++)
        {
            Console.WriteLine("[" + (i + 1) + "]" + carrinho[i] + "\n");
        }
    }

    public double calcularValorTotal(ProdutoUI produtoUi, PromocaoUI promocaoUi)
    {
        double desconto = 0;
        double valorTotal = 0;
        foreach (var produto in carrinho)
        {
            Promocao? promocao = promocaoUi.produtoHavePromo(produto);
            if (promocao == null)
                promocao = promocaoUi.categoriaHavePromo(produto.Categoria);

            if (promocao != null)
            {
                if (promocao.Tipo == "Fixo")
                    valorTotal += produto.Preco - promocao.Valor;
                else
                    valorTotal += produto.Preco - (promocao.Valor / 100 * produto.Preco);
            }
            else
            {
                valorTotal += produto.Preco;
            }
        }

        return valorTotal;

        return 0;
    }
}