using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class ProdutoUI
{
    public List<Produto> catalogo = new List<Produto>();

    public void createProduto(int idCount)
    {
        double largura;
        double comprimento;
        CategoriaProduto categoria = new CategoriaProduto();

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


        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Desc:");
        string desc = Console.ReadLine();
        Console.WriteLine("Preco:");
        double preco = readDouble();
        Console.WriteLine("Tamanho:");
        string tamanho = Console.ReadLine();
        Console.WriteLine("Cor:");
        string cor = Console.ReadLine();
        Console.WriteLine("Marca:");
        string marca = Console.ReadLine();
        Console.WriteLine("Material:");
        string material = Console.ReadLine();
        switch (categoria)
        {
            case CategoriaProduto.Camiseta:
                Console.WriteLine("Largura:");
                largura = readDouble();
                Console.WriteLine("Comprimento:");
                comprimento = readDouble();
                Console.WriteLine("Gola:");
                string gola = Console.ReadLine();
                Camiseta newCamiseta = new Camiseta(idCount, nome, desc, preco, categoria, tamanho, cor, marca,
                    material, largura, comprimento, gola);
                catalogo.Add(newCamiseta);
                break;

            case CategoriaProduto.Calca:
                Console.WriteLine("Largura:");
                largura = readDouble();
                Console.WriteLine("Comprimento:");
                comprimento = readDouble();
                Calca newCalca = new Calca(idCount, nome, desc, preco, categoria, tamanho, cor, marca, material,
                    largura, comprimento);
                catalogo.Add(newCalca);
                break;

            case CategoriaProduto.Bolsa:
                Console.WriteLine("Volume:");
                double volume = readDouble();
                Bolsa newBolsa = new Bolsa(idCount, nome, desc, preco, categoria, tamanho, cor, marca, material,
                    volume);
                catalogo.Add(newBolsa);
                break;

            case CategoriaProduto.Sapato:
                Console.WriteLine("Numero:");
                int numero = readInt();
                Console.WriteLine("Modelo:");
                string modelo = Console.ReadLine();
                Sapato newSapato = new Sapato(idCount, nome, desc, preco, categoria, tamanho, cor, marca, material,
                    numero, modelo);
                catalogo.Add(newSapato);
                break;
        }
    }

    public void updateProduto()
    {
        getAll();
        Console.WriteLine("Digite o id do produto que deseja alterar:");
        CategoriaProduto categoria;
        int id = readInt();
        while (true)
        {
            Produto produto = getById(id);
            if (produto == null)
                Console.WriteLine("Nenhum produto com este ID! digite outro");
            else
            {
                categoria = produto.Categoria;
                break;
            }
        }


        double largura;
        double comprimento;

        Console.WriteLine("Novo nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Nova desc:");
        string desc = Console.ReadLine();
        Console.WriteLine("Novo preco:");
        double preco = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Novo tamanho:");
        string tamanho = Console.ReadLine();
        Console.WriteLine("Nova cor:");
        string cor = Console.ReadLine();
        Console.WriteLine("Nova marca:");
        string marca = Console.ReadLine();
        Console.WriteLine("Novo material:");
        string material = Console.ReadLine();

        switch (categoria)
        {
            case CategoriaProduto.Camiseta:
                Console.WriteLine("Largura:");
                largura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Comprimento:");
                comprimento = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gola:");
                string gola = Console.ReadLine();

                Camiseta newCamiseta = new Camiseta(id, nome, desc, preco, categoria, tamanho, cor, marca, material,
                    largura, comprimento, gola);
                catalogo.Insert(id - 1, newCamiseta);
                break;

            case CategoriaProduto.Calca:
                Console.WriteLine("Largura:");
                largura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Comprimento:");
                comprimento = Convert.ToDouble(Console.ReadLine());

                Calca newCalca = new Calca(id, nome, desc, preco, categoria, tamanho, cor, marca, material, largura,
                    comprimento);
                catalogo.Insert(id - 1, newCalca);
                break;

            case CategoriaProduto.Bolsa:
                Console.WriteLine("Volume:");
                double volume = Convert.ToDouble(Console.ReadLine());

                Bolsa newBolsa = new Bolsa(id, nome, desc, preco, categoria, tamanho, cor, marca, material, volume);
                catalogo.Insert(id - 1, newBolsa);
                break;

            case CategoriaProduto.Sapato:
                Console.WriteLine("Numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Modelo:");
                string modelo = Console.ReadLine();

                Sapato newSapato = new Sapato(id, nome, desc, preco, categoria, tamanho, cor, marca, material, numero,
                    modelo);
                catalogo.Insert(id - 1, newSapato);
                break;
        }
    }

    public void deleteProduto()
    {
        getAll();
        Console.WriteLine("Digite o ID do produto que deseja remover do catálogo");
        Produto produto = new Produto();
        while (true)
        {
            produto = getById(readInt());

            if (produto == null)
                Console.WriteLine("Nenhum produto com este ID! digite outro");
            else
            {
                catalogo.Add(produto);
                Console.WriteLine("Produto removido com sucesso!");
                break;
            }
        }
    }

    public void getAll()
    {
        Console.WriteLine("Quantidade de itens no catálogo: " + catalogo.Count);
        for (int i = 0; i < catalogo.Count; i++)
        {
            Console.WriteLine("[" + catalogo[i].Id + "]" + catalogo[i] + "\n");
        }
    }

    public Produto getById(int id)
    {
        foreach (var produto in catalogo)
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