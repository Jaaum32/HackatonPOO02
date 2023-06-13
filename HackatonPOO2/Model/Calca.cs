namespace HackatonPOO2.Model;

public class Calca : Acessorio
{
    private double largura;
    private double comprimento;

    public Calca(int id,string? nome, string desc, double preco, CategoriaProduto categoria, string tamanho, string cor, string marca, string material, double largura, double comprimento) : base(id,nome, desc, preco, categoria, tamanho, cor, marca, material)
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
    
    public override string ToString()
    {
        return "\nNome: " + Nome + "\nCategoria: [" + Categoria + "]\nPreco: R$" + Preco + "\nDesc: " + Desc + " \nLargura: " + largura + "\nComprimento: " + comprimento;
    }
}