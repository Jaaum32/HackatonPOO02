using HackatonPOO2.Model;

namespace HackatonPOO.UI;

public class VendaUI
{
    public List<Venda> vendas = new List<Venda>();
    
    public void createVenda(Venda venda)
    {
        vendas.Add(venda);
    }
    
    /// <summary>
    /// Busca uma categoria pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Venda getVenda(int id)
    {
        for (int i = 0; i < vendas.Count; i++)
        {
            if (vendas[i].id == id)
            {
                return vendas[i];
            }
        }

        return null;
    }
    
    /// <summary>
    /// Busca uma venda pelo seu id.
    /// caso o id não seja encontrado, o método retornará "-1".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int GetPosVenda(int id)
    {
        for (int i = 0; i < vendas.Count; i++)
        {
            if (vendas[i].id == id)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cliente"></param>
    public void updateVenda(int id, Venda venda)
    {
        vendas[id] = venda;
        
    }
    
    public void deleteVenda(int id)
    {
        int pos = GetPosVenda(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel remover, pois esta venda não foi encontrado");
        }
        else
        {
            vendas.RemoveAt(pos);
        }
    }

    public void getAll()
    {
        for (int i = 0; i < vendas.Count; i++)
        {
            Console.WriteLine(vendas[i].ToString());
        }
    }
}