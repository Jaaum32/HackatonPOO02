namespace HackatonPOO2.Model;

public class Produto
{
    private int id;
    private string? nome;
    private string? desc;
    private double preco;
    private CategoriaProduto categoria;

    public Produto(int id,string? nome, String desc, double preco, CategoriaProduto categoria)
    {
        this.id = id;
        this.nome = nome;
        this.desc = desc;
        this.preco = preco;
        this.categoria = categoria;
    }

    public Produto()
    {
    }
    
    public int Id
    {
        get { return id; }
        set { this.id = value; }
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

    public double Preco
    {
        get { return preco; }
        set { this.preco = value; }
    }

    public CategoriaProduto Categoria
    {
        get { return categoria; }
        set { this.categoria = value; }
    }

    public override string ToString()
    {
        return "\nNome: " + nome + "\nCategoria: [" + categoria + "]\nPreco: R$" + preco + "\nDesc: " + desc;
    }
}