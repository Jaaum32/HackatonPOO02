namespace HackatonPOO2.Model;

public class Venda
{
    public int id;
    private Cliente? cliente;
    private String? data;
    private double? valorTotal;
    private List<Produto>? produtosComprados;

    public Venda(Cliente cliente, String data, double valorTotal, List<Produto> produtosComprados)
    {
        this.cliente = cliente;
        this.data = data;
        this.valorTotal = valorTotal;
        this.produtosComprados = produtosComprados;
    }
    public Venda()
    {
    }

    public Cliente? Cliente
    {
        get { return cliente; }
        set { this.cliente = value; }
    }

    public string? Data
    {
        get { return data; }
        set { this.data = value; }
    }

    public double? ValorTotal
    {
        get { return valorTotal; }
        set { this.valorTotal = value; }
    }

    public List<Produto>? ProdutosComprados
    {
        get { return produtosComprados; }
        set { this.produtosComprados = value; }
    }

    public override string ToString()
    {
        return "[" + id + "]\nCliente: [" + cliente + "]\nData: " + data + "\nValor Total: R$" + valorTotal + "\nProdutos Comprados: [" + listar() + "]";
    }
    public string listar()
    {
        string produtos = "";
        if (produtosComprados == null)
        {
            return "nenhum produto comprado!";
        }
        else
        {
            for (int i = 0; i < produtosComprados.Count; i++)
            {
                produtos += produtosComprados[i] + "\n";
            }
            return produtos;
        }


    }

}