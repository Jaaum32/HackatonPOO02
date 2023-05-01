namespace HackatonPOO2.Model;

public class Cliente
{
    public int id;
    private string? nome;
    private string? sobrenome;
    private string? endereco;
    private string? telefone;

    public Cliente(string? nome, string? sobrenome, string? endereco, string? telefone)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.endereco = endereco;
        this.telefone = telefone;
    }

    public Cliente()
    { }

    public string? Nome
    {
        get { return nome; }
        set { this.nome = value; }
    }

    public string? Sobrenome
    {
        get { return sobrenome; }
        set { this.sobrenome = value; }
    }

    public string? Endereco
    {
        get { return endereco; }
        set { this.endereco = value; }
    }

    public string? Telefone
    {
        get { return telefone; }
        set { this.telefone = value; }
    }

    public override string ToString()
    {
        return "[" + id + "]\nNome: " + nome + " " + sobrenome + "\nEndereco: " + endereco + "\nTelefone: " + telefone;
    }
}