using HackatonPOO2.UI;

namespace HackatonPOO2.Model;

public class Promocao
{
    private string? nome;
    private string tipo;
    private double valor;
    private List<Produto>? produtos;
    private List<CategoriaProduto>? categorias;

    public Promocao(string? nome, string tipo, double valor, List<Produto>? produtos,
        List<CategoriaProduto>? categorias)
    {
        this.nome = nome;
        this.tipo = tipo;
        this.valor = valor;
        this.produtos = produtos;
        this.categorias = categorias;
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

    public List<Produto>? Produtos
    {
        get { return produtos; }
        set { this.produtos = value; }
    }

    public List<CategoriaProduto>? Categorias
    {
        get { return categorias; }
        set { this.categorias = value; }
    }

    public override string ToString()
    {
        return "__________________________________" +
               "\nNome: " + nome +
               "\nTipo: " + tipo +
               "\nValor: " + (tipo == "Fixo"
                   ? ("R$ " + valor)
                   : (valor + "%")) +
               "\n" + (produtos != null
                   ? "Produtos na promoção:\n" + listar(produtos)
                   : "Categorias na promoção:\n" + listar(categorias));
    }

    public string listar<T>(List<T> a)
    {
        string lista = "";
        for (int i = 0; i < a.Count; i++)
        {
            lista += "  " + a[i] + "\n";
        }
        

        return lista;
    }
}