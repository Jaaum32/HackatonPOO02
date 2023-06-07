namespace HackatonPOO2.Model;

public class Camiseta : Acessorio
{
    private double largura;
    private double comprimento;
    private string gola;

    public Camiseta(string? nome, string desc, double preco, CategoriaProduto categoria, string tamanho, string cor, string marca, string material, double largura, double comprimento, string gola) : base(nome, desc, preco, categoria, tamanho, cor, marca, material)
    {
        this.largura = largura;
        this.comprimento = comprimento;
        this.gola = gola;
    }

    public Camiseta()
    {
    }

    public double Largura
    {
        get { return largura; }
        set { this.largura = value; }
    }

    public double Comprimento
    {
        get { return comprimento; }
        set { this.comprimento = value; }
    }

    public string Gola
    {
        get { return gola; }
        set { this.gola = value; }
    }
    
    public override string ToString()
    {
        return "\nLargura: " + largura + "\nComprimento: " + comprimento + "\nGola: R$" + gola;
    }
}