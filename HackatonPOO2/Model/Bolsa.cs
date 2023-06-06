namespace HackatonPOO2.Model;

public class Bolsa : Acessorio
{
    private double volume;
    private int alças;

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
}