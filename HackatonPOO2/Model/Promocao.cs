namespace HackatonPOO2.Model;

public class Promocao
{
    private string? nome;
    private string tipo;
    private double valor;
    private List<Produto>? produtos;
    
    public Promocao(string? nome, string tipo, double valor,List<Produto>? produtos)
    {
        this.nome = nome;
        this.tipo = tipo;
        this.valor = valor;
        this.produtos = produtos;
    }
    public Promocao()
    {
    }
    
    public string Nome
    {
        get { return nome; }
        set { this.nome = value; }
    }
    public string Tipo
    {
        get { return tipo; }
        set { this.tipo = value; }
    }
    public double Valor
    {
        get { return valor; }
        set { this.valor = value; }
    }
}