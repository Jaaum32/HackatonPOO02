namespace HackatonPOO2.Model;

public class Bolsa : Acessorio
{
    private double volume;

    public Bolsa(string? nome, string desc, double preco, CategoriaProduto categoria, string tamanho, string cor, string marca, string material, double volume) : base(nome, desc, preco, categoria, tamanho, cor, marca, material)
    {
        this.volume = volume;
    }

    public Bolsa()
    {
    }

    public double Volume
    {
        get { return volume; }
        set { this.volume = value; }
    }
    public override string ToString()
    {
        return "\nNome: " + Nome + "\nCategoria: [" + Categoria + "]\nPreco: R$" + Preco + "\nDesc: " + Desc + " \nVolume: " + volume;
    }
}