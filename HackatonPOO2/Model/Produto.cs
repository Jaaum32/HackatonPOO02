namespace HackatonPOO2.Model;

public class Produto
{
    private string? nome;
    private string? desc;
    private double? preco;
    private CategoriaProduto? categoria;

    public Produto(string? nome, String desc, double preco, CategoriaProduto categoria)
    {
        this.nome = nome;
        this.desc = desc;
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

    public CategoriaProduto? Categoria
    {
        get { return categoria; }
        set { this.categoria = value; }
    }

    public override string ToString()
    {
        return "\nNome: " + nome + "\nCategoria: [" + categoria + "]\nPreco: R$" + preco + "\nDesc: " + desc;
    }
}