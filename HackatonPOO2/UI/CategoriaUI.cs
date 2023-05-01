using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class CategoriaUI
{
    public List<Categoria> categoria = new List<Categoria>();
    
    public void createCategoria(Categoria categ)
    {
        categoria.Add(categ);
    }
    
    /// <summary>
    /// Busca uma categoria pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Categoria getCategoria(int id)
    {
        for (int i = 0; i < categoria.Count; i++)
        {
            if (categoria[i].id == id)
            {
                return categoria[i];
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
    public int getPosCategoria(int id)
    {
        for (int i = 0; i < categoria.Count; i++)
        {
            if (categoria[i].id == id)
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
    public void updateCategory(int id, Categoria categ)
    {
        categoria[id] = categ;
    }
    
    public void deleteCategoria(int id)
    {
        int pos = getPosCategoria(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel remover, pois este usuário não foi encontrado");
        }
        else
        {
            categoria.RemoveAt(pos);
        }
    }
    public void getAll()
    {
        for (int i = 0; i < categoria.Count; i++)
        {
            Console.WriteLine(categoria[i].ToString());
        }
    }

    public bool containsId(int id)
    {
        for (int i = 0; i < categoria.Count; i++)
        {
            if (categoria[i].id == id)
            {
                return true;
            }
        }

        return false;
    }
}