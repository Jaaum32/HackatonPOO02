using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class CarrinhoUI
{
    public List<Produto> carrinho = new List<Produto>();

    public void adicionarProdutoNoCarrinho(ProdutoUI produtoUi)
    {
        if (produtoUi.catalogo.Count == 0)
            Console.WriteLine("Nenhum produto no catálogo!");
        else
        {
            produtoUi.getAll();
            Console.WriteLine("Digite o ID do produto que deseja adicionar ao carrinho");
            Produto produto = new Produto();
            while (true)
            {
                produto = produtoUi.getById(readInt());

                if (produto == null)
                    Console.WriteLine("Nenhum produto com este ID! digite outro");
                else
                {
                    carrinho.Add(produto);
                    Console.WriteLine("Produto adicionado com sucesso!");
                    break;
                }
            }
        }
    }

    public void removerProdutoNoCarrinho()
    {
        if (carrinho.Count == 0)
            Console.WriteLine("Nenhum produto no carrinho!");
        else
        {
            getAll();
            Console.WriteLine("Digite o ID do produto que deseja remover do carrinho");
            Produto produto = new Produto();
            while (true)
            {
                produto = getById(readInt());

                if (produto == null)
                    Console.WriteLine("Nenhum produto com este ID! digite outro");
                else
                {
                    carrinho.Add(produto);
                    Console.WriteLine("Produto removido com sucesso!");
                    break;
                }
            }
        }
    }

    public void getAll()
    {
        if (carrinho.Count == 0)
        {
            Console.WriteLine("Nenhum produto no carrinho!");
        }
        else
        {
            Console.WriteLine("\nProdutos no carrinho:");
            for (int i = 0; i < carrinho.Count; i++)
            {
                Console.WriteLine("[" + carrinho[i].Id + "]" + carrinho[i] + "\n");
            }
        }
    }

    public double calcularValorTotal(ProdutoUI produtoUi, PromocaoUI promocaoUi)
    {
        if (carrinho.Count == 0)
        {
            Console.WriteLine("Nenhuma produto no carrinho para fechar a compra!");
            return 0;
        }
        else
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

            carrinho.Clear();
            return valorTotal;
        }
    }

    public Produto getById(int id)
    {
        foreach (var produto in carrinho)
        {
            if (produto.Id == id)
            {
                return produto;
            }
        }

        return null;
    }

    public int readInt()
    {
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Digite um valor válido!");
        }

        return x;
    }
}