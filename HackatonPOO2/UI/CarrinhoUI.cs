using HackatonPOO2.Model;

namespace HackatonPOO2.UI;

public class CarrinhoUI
{
    private CarrinhoDeCompras carrinhoDeCompras = new CarrinhoDeCompras();

    public void adicionarProdutoAoCarrinho(Produto produto)
    {
        carrinhoDeCompras.Produtos.Add(produto);
    }
    public void removerProdutoAoCarrinho(int id)
    {
        carrinhoDeCompras.Produtos.RemoveAt(id);
    }
    
    
    public void getAll()
    {
        for (int i = 0; i < carrinhoDeCompras.Produtos.Count; i++)
        {
            Console.WriteLine(i + " - " +carrinhoDeCompras.Produtos[i].ToString() + "\n");
        }
    }
}