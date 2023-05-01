namespace HackatonPOO2.Model;

public class Produto
{
    public int id;
    private string? nome;
    private string? desc;
    private double? preco;
    private Categoria? categoria;

    public Produto(string? nome, String desc, double preco, Categoria categoria)
    {
        this.nome = nome;
        this.desc = nome;
        this.preco = preco;
        this.categoria = categoria;
    }

    public Produto()
    {
    }

    public string? Nome
    {
        get { return nome; }
        set { this.nome = value; }
    }

    public string? Desc
    {
        get { return desc; }
        set { this.desc = value; }
    }

    public double? Preco
    {
        get { return preco; }
        set { this.preco = value; }
    }

    public Categoria? Categoria
    {
        get { return categoria; }
        set { this.categoria = value; }
    }

    public override string ToString()
    {
        return "[" + id + "]\nNome: " + nome + "\nCategoria: [" + categoria + "]\nPreco: R$" + preco + "\nDesc: " + desc;
    }
}