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

        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Desc:");
        string desc = Console.ReadLine();
        Console.WriteLine("Preco:");
        double preco = Convert.ToDouble(Console.ReadLine());
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
                largura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Comprimento:");
                comprimento = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gola:");
                string gola = Console.ReadLine();
                Camiseta newCamiseta = new Camiseta(idCount, nome, desc, preco, categoria, tamanho, cor, marca,
                    material, largura, comprimento, gola);
                catalogo.Add(newCamiseta);
                break;

            case CategoriaProduto.Calca:
                Console.WriteLine("Largura:");
                largura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Comprimento:");
                comprimento = Convert.ToDouble(Console.ReadLine());
                Calca newCalca = new Calca(idCount, nome, desc, preco, categoria, tamanho, cor, marca, material,
                    largura, comprimento);
                catalogo.Add(newCalca);
                break;

            case CategoriaProduto.Bolsa:
                Console.WriteLine("Volume:");
                double volume = Convert.ToDouble(Console.ReadLine());
                Bolsa newBolsa = new Bolsa(idCount, nome, desc, preco, categoria, tamanho, cor, marca, material,
                    volume);
                catalogo.Add(newBolsa);
                break;

            case CategoriaProduto.Sapato:
                Console.WriteLine("Numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
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
        Console.WriteLine("Digite o id do produto que eseja alterar:");
        int id = Convert.ToInt32(Console.ReadLine());
        CategoriaProduto categoria = getById(id).Categoria;

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
        bool exec = true;
        getAll();
        Console.WriteLine("Digite o id do produto a ser apagado");
        while (exec)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            Produto produto = getById(id);

            if (produto == null)
                Console.WriteLine("Nennhum produto com este ID no catalogo! digite outro");
            else
                catalogo.Remove(produto);

            Console.WriteLine("Produto removido com sucesso!");
            exec = false;
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
}