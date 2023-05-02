namespace HackatonPOO2.Model;

public class Sapato : Acessorio
{
    private int numero;
    private string modelo;

    public Sapato(string? nome, string desc, double preco, CategoriaProduto categoria, string tamanho, string cor, string marca, string material, int numero, string modelo) : base(nome, desc, preco, categoria, tamanho, cor, marca, material)
    {
        this.numero = numero;
        this.modelo = modelo;
    }

    public Sapato()
    {
    }

    public int Numero
    {
        get { return numero; }
        set { this.numero = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { this.modelo = value; }
    }
    
}