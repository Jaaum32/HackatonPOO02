using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class ProdutoUI
{
    public List<Produto> produtos = new List<Produto>();

    public void createProduto(Produto produto)
    {
        produtos.Add(produto);
    }
    public Produto getProduto(int id)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].id == id)
            {
                return produtos[i];
            }

        }
        return 
            
            
            null;
    }
    public int getPosProduto(int id)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].id == id)
            {
                return i;
            }

        }
        return -1;
    }

    public void updateProduto(int id, Produto produto)
    {
        produtos[id] = produto;
        
    }
    public void deleteProduto(int id)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].id == id)
            {
                produtos.RemoveAt(i);
            }
        }
    }
    public void getAll()
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine(produtos[i].ToString());
        }
    }

    public bool containsId(int id)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].id == id)
            {
                return true;
            }
        }

        return false;
    }
}