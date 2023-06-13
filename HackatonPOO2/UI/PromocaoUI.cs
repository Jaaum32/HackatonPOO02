using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class PromocaoUI
{
    public List<Promocao> promocoes = new List<Promocao>();

    public void createPromocao(ProdutoUI produtoUi)
    {
        Console.WriteLine("produtos:" + produtoUi.catalogo.Count);

        bool exec = true;
        CategoriaProduto categoria = new CategoriaProduto();
        Console.WriteLine("Qual será o nome da promoção?");
        string nome = Console.ReadLine();

        Console.WriteLine("Promoção será valor fixo ou porcentagem?\n1 - Fixo | 2 - Porcentagem");
        string tipo;
        if (Convert.ToInt32(Console.ReadLine()) == 1)
            tipo = "Fixo";
        else
            tipo = "Porcentagem";

        Console.WriteLine("Qual será o valor/quantidade de desconto?");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Promoção será de produto ou categoria?\n1 - Categoria | 2 - Produto");
        if (Equals("1", Console.ReadLine()))
        {
            List<CategoriaProduto> promoCategorias = new List<CategoriaProduto>();
            while (exec)
            {
                Console.WriteLine("O produto será de qual categoria?");
                Console.WriteLine("1 - Camiseta | 2 - Calca | 3 - Bolsa | 4 - Sapato");
                switch (Convert.ToInt32(Console.ReadLine()))
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
                }

                if (categoriaHavePromo(categoria) == null)
                {
                    promoCategorias.Add(categoria);

                    Console.WriteLine("Deseja adicionar outra categoria? (S/N)");
                    if (!Equals(Console.ReadLine(), "S"))
                        exec = false;
                }
                else
                {
                    Console.WriteLine("A categoria " + categoria + " ja está em promoção, escolha outra categoria!");
                }
            }

            Promocao promo = new Promocao(nome, tipo, valor, null, promoCategorias);
            promocoes.Add(promo);
        }
        else
        {
            List<Produto> promoProdutos = new List<Produto>();
            produtoUi.getAll();
            while (exec)
            {
                Console.WriteLine("Digite o id do produto que deseja adicionar na promoção");
                int id = Convert.ToInt32(Console.ReadLine());

                Produto produto = produtoUi.catalogo[id - 1];

                if (produtoHavePromo(produto) == null)
                {
                    promoProdutos.Add(produtoUi.catalogo[id - 1]);

                    Console.WriteLine("Deseja adicionar outro produto? (S/N)");
                    if (!Equals(Console.ReadLine(), "S"))
                        exec = false;
                }
                else
                {
                    Console.WriteLine("O produto " + produto.Nome + " ja está em promoção, escolha outro produto!");
                }
            }

            Promocao promo = new Promocao(nome, tipo, valor, promoProdutos, null);
            promocoes.Add(promo);
        }
    }

    public void deletePromocao()
    {
        getAll();
        Console.WriteLine("Digite o id da promoção para excluir");
        promocoes.RemoveAt(Convert.ToInt32(Console.ReadLine()));
    }

    public Promocao produtoHavePromo(Produto prod)
    {
        foreach (var promocao in promocoes)
        {
            if(promocao.Produtos != null)
                if (promocao.Produtos.Contains(prod))
                    return promocao;
        }

        return null;
    }

    public Promocao categoriaHavePromo(CategoriaProduto cat)
    {
        foreach (var promocao in promocoes)
        {
            if(promocao.Categorias != null)
                if (promocao.Categorias.Contains(cat))
                    return promocao;
        }

        return null;
    }

    public void getAll()
    {
        for (int i = 0; i < promocoes.Count; i++)
        {
            Console.WriteLine("[" + (i + 1) + "]" + promocoes[i] + "\n");
        }
    }
}