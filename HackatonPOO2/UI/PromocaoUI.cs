using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class PromocaoUI
{
    public List<Promocao> promocoes = new List<Promocao>();
    ProdutoUI produto = new ProdutoUI();

    public void createPromocao()
    {
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

                promoCategorias.Add(categoria);

                Console.WriteLine("Deseja adicionar outra categoria? (S/N)");
                if (!Equals(Console.ReadLine(), "S"))
                    exec = false;
            }

            Promocao promo = new Promocao(nome, tipo, valor, null, promoCategorias);
        }
        else
        {
            List<Produto> promoProdutos = new List<Produto>();
            produto.getAll(produto.catalogo);
            while (exec)
            {
                Console.WriteLine("Digite o id do produto que deseja adicionar na promoção");
                int id = Convert.ToInt32(Console.ReadLine());
                promoProdutos.Add(produto.catalogo[id - 1]);
                
                Console.WriteLine("Deseja adicionar outro produto? (S/N)");
                if (!Equals(Console.ReadLine(), "S"))
                    exec = false;
            }
            
            Promocao promo = new Promocao(nome, tipo, valor, promoProdutos, null);
        }
    }

    public void deletePromocao()
    {
        getAll(promocoes);
        Console.WriteLine("Digite o id da promoção para excluir");
        promocoes.RemoveAt(Convert.ToInt32(Console.ReadLine()));
    }

    public void getAll(List<Promocao> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("[" + (i + 1) + "]" +list[i] + "\n");
        }
    }
}