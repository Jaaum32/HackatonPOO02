using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class PromocaoUI
{
    public List<Promocao> promocoes = new List<Promocao>();

    public void createPromocao(ProdutoUI produtoUi, int idCount)
    {
        Console.WriteLine("produtos:" + produtoUi.catalogo.Count);

        bool exec = true;
        CategoriaProduto categoria = new CategoriaProduto();
        Console.WriteLine("Qual será o nome da promoção?");
        string nome = Console.ReadLine();

        Console.WriteLine("Promoção será valor fixo ou porcentagem? [ 1 - Fixo | 2 - Porcentagem ]");
        string tipo;
        if (readInt() == 1)
            tipo = "Fixo";
        else
            tipo = "Porcentagem";

        Console.WriteLine("Qual será o valor/quantidade de desconto?");
        double valor = readDouble();

        Console.WriteLine("Promoção será de produto ou categoria?\n1 - Categoria | 2 - Produto");
        if (readInt() == 1)
        {
            List<CategoriaProduto> promoCategorias = new List<CategoriaProduto>();
            while (exec)
            {
                Console.WriteLine("O produto será de qual categoria?");
                Console.WriteLine("1 - Camiseta | 2 - Calca | 3 - Bolsa | 4 - Sapato");
                while (true)
                {
                    switch (readInt())
                    {
                        case 1:
                            categoria = CategoriaProduto.Camiseta;
                            break;
                        case 2:
                            categoria = CategoriaProduto.Calca;
                            break;
                        case 3:
                            categoria = CategoriaProduto.Bolsa;
                            break;
                        case 4:
                            categoria = CategoriaProduto.Sapato;
                            break;
                        default:
                            Console.WriteLine("Digite um valor válido");
                            break;
                    }

                    if (categoria != null)
                        break;
                }

                if (categoriaHavePromo(categoria) == null)
                {
                    promoCategorias.Add(categoria);

                    Console.WriteLine("Deseja adicionar outra categoria? [s/n]");
                    if (!Equals(Console.ReadLine(), "s"))
                        exec = false;
                }
                else
                    Console.WriteLine("A categoria " + categoria + " ja está em promoção, escolha outra categoria!");
            }

            Promocao promo = new Promocao(idCount, nome, tipo, valor, null, promoCategorias);
            promocoes.Add(promo);
        }
        else
        {
            List<Produto> promoProdutos = new List<Produto>();
            produtoUi.getAll();
            while (exec)
            {
                Console.WriteLine("Digite o id do produto que deseja adicionar na promoção");
                int id = readInt();
                Produto produto = new Produto();
                while (true)
                {
                    produto = produtoUi.getById(id);
                    if (produto == null)
                        Console.WriteLine("Nenhum produto com este ID! digite outro");
                    else
                        break;
                }

                if (produtoHavePromo(produto) == null)
                {
                    promoProdutos.Add(produtoUi.catalogo[id - 1]);

                    Console.WriteLine("Deseja adicionar outro produto? [s/n]");
                    if (!Equals(Console.ReadLine(), "s"))
                        exec = false;
                }
                else
                    Console.WriteLine("O produto " + produto.Nome + " ja está em promoção, escolha outro produto!");
            }

            Promocao promo = new Promocao(idCount, nome, tipo, valor, promoProdutos, null);
            promocoes.Add(promo);
        }
    }

    public void deletePromocao()
    {
        if (promocoes.Count == 0)
            Console.WriteLine("Nenhuma promoção registrada!");
        else
        {
            Promocao promocao = new Promocao();
            while (true)
            {
                
                try
                {
                    promocao = getById(readInt());

                    if (promocao == null)
                        Console.WriteLine("Nenhuma promoção com este ID! digite outro");
                    else
                    {
                        promocoes.Remove(promocao);
                        Console.WriteLine("Promocao removida com sucesso!");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }
            }
        }
    }

    public Promocao produtoHavePromo(Produto prod)
    {
        foreach (var promocao in promocoes)
        {
            if (promocao.Produtos != null)
                if (promocao.Produtos.Contains(prod))
                    return promocao;
        }

        return null;
    }

    public Promocao categoriaHavePromo(CategoriaProduto cat)
    {
        foreach (var promocao in promocoes)
        {
            if (promocao.Categorias != null)
                if (promocao.Categorias.Contains(cat))
                    return promocao;
        }

        return null;
    }

    public void getAll()
    {
        if (promocoes.Count == 0)
        {
            Console.WriteLine("Nenhuma promoção registrada!");
        }
        else
        {
            Console.WriteLine("\nPromções:");
            for (int i = 0; i < promocoes.Count; i++)
            {
                Console.WriteLine("[" + promocoes[i].Id + "]____________________________\n" + promocoes[i] + "\n");
            }
        }
    }

    public Promocao getById(int id)
    {
        foreach (var promocao in promocoes)
        {
            if (promocao.Id == id)
            {
                return promocao;
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

    public double readDouble()
    {
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Digite um valor válido!");
        }

        return x;
    }
}