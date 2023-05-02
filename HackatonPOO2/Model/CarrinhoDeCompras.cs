namespace HackatonPOO2.Model;
using HackatonPOO2.UI;

public class CarrinhoDeCompras
{
    private double? valorTotal;
    private List<Produto>? produtos;

    public CarrinhoDeCompras()
    {
    }

    public CarrinhoDeCompras(double valorTotal, List<Produto> produtos)
    {
        this.valorTotal = valorTotal;
        this.produtos = produtos;
    }

    public double? ValorTotal
    {
        get { return valorTotal; }
        set { this.valorTotal = value; }
    }

    public List<Produto>? Produtos
    {
        get { return produtos; }
        set { this.produtos = value; }
    }

    public double? calcularValorTotal(List<Produto> produtos)
    {
        double? valorTotal = 0;
        for (int i = 0; i < produtos.Count; i++)
        {
            valorTotal += produtos[i].Preco;
        }
        return valorTotal;
    }
}