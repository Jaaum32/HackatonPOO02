using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class ProdutoUI
{
    public List<Produto> catalogo = new List<Produto>();

    public void createProduto()
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
                Camiseta newCamiseta = new Camiseta(nome,desc,preco,categoria,tamanho,cor,marca,material,largura,comprimento,gola);
                catalogo.Add(newCamiseta);
                break;
            
            case CategoriaProduto.Calca:
                Console.WriteLine("Largura:");
                largura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Comprimento:");
                comprimento = Convert.ToDouble(Console.ReadLine());
                Calca newCalca = new Calca(nome,desc,preco,categoria,tamanho,cor,marca,material,largura,comprimento);
                catalogo.Add(newCalca);
                break;
            
            case CategoriaProduto.Bolsa:
                Console.WriteLine("Volume:");
                double volume = Convert.ToDouble(Console.ReadLine());
                Bolsa newBolsa = new Bolsa(nome,desc,preco,categoria,tamanho,cor,marca,material,volume);
                catalogo.Add(newBolsa);
                break;
            
            case CategoriaProduto.Sapato:
                Console.WriteLine("Numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Modelo:");
                string modelo = Console.ReadLine();
                Sapato newSapato = new Sapato(nome,desc,preco,categoria,tamanho,cor,marca,material,numero,modelo);
                catalogo.Add(newSapato);
                break;
        }
    }
    public void updateProduto()
    {
        getAll();
        Console.WriteLine("Digite o id do produto que eseja alterar:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(catalogo[id].GetType());
        
    }
    public void deleteProduto()
    {
        getAll();
        Console.WriteLine("Digite o id do produto a ser apagado");
        int id = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < catalogo.Count; i++)
        {
            if (catalogo[i].id == id)
            {
                catalogo.RemoveAt(i);
            }
        }
    }
    public void getAll()
    {
        for (int i = 0; i < catalogo.Count; i++)
        {
            Console.WriteLine("["+ i + "]\n" +catalogo[i]+ "\n");
        }
    }
    public bool containsId(int id)
    {
        for (int i = 0; i < catalogo.Count; i++)
        {
            if (catalogo[i].id == id)
            {
                return true;
            }
        }

        return false;
    }
}