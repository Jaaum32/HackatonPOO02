namespace HackatonPOO2.Model;

public class Calca : Acessorio
{
    private double largura;
    private double comprimento;

    public Calca(string? nome, string desc, double preco, CategoriaProduto categoria, string tamanho, string cor, string marca, string material, double largura, double comprimento) : base(nome, desc, preco, categoria, tamanho, cor, marca, material)
    {
        this.largura = largura;
        this.comprimento = comprimento;
    }

    public Calca()
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
}