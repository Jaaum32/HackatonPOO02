using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class CarrinhoUI
{
    public List<Produto> carrinho = new List<Produto>();
    

    public void adicionarProdutoAoCarrinho(ProdutoUI produtoUi)
    {
        bool exec = true;
        produtoUi.getAll();
        Console.WriteLine("Digite o Id do produto que deseja adicionar ao carrinho");
        while (exec)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            Produto produto = produtoUi.getById(id);

            if (produto == null)
                Console.WriteLine("Nennhum produto com este ID! digite outro");
            else
                carrinho.Add(produto);

            Console.WriteLine("Produto adicionado com sucesso!");
            exec = false;
        }
    }

    public void removerProdutoAoCarrinho()
    {
        bool exec = true;
        getAll();
        Console.WriteLine("Digite o Id do produto que deseja adicionar ao carrinho");
        while (exec)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            Produto produto = getById(id);

            if (produto == null)
                Console.WriteLine("Nennhum produto com este ID no carrinho! digite outro");
            else
                carrinho.Remove(produto);

            Console.WriteLine("Produto removido com sucesso!");
            exec = false;
        }
    }

    public void getAll()
    {
        Console.WriteLine("\nProdutos no carrinho:");
        for (int i = 0; i < carrinho.Count; i++)
        {
            Console.WriteLine("[" + carrinho[i].Id + "]" + carrinho[i] + "\n");
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
}