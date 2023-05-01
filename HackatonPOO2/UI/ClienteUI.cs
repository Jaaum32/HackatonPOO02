using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class ClienteUI
{
    public List<Cliente> clientes = new List<Cliente>();

    public void createCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    /// <summary>
    /// Busca um usúario pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Cliente getCliente(int id)
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].id == id)
            {
                return clientes[i];
            }
        }

        return null;
    }


    /// <summary>
    /// Busca um cliente pelo seu id.
    /// caso o id não seja encontrado, o método retornará "-1".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int getPosCliente(int id)
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].id == id)
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
    public void updateCliente(int id, Cliente cliente)
    {
        clientes[id] = cliente;
    }

    public void deleteCliente(int id)
    {
        int pos = getPosCliente(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel remover, pois este usuário não foi encontrado");
        }
        else
        {
            clientes.RemoveAt(pos);
        }
    }

    public void getAll()
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            Console.WriteLine(clientes[i].ToString());
        }
    }
    
    public bool containsId(int id)
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].id == id)
            {
                return true;
            }
        }

        return false;
    }
}