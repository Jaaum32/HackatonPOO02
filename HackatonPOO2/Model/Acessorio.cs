namespace HackatonPOO2.Model;

public abstract class Acessorio : Produto
{
   private string tamanho;
   private string cor;
   private string marca;
   private string material;

   public Acessorio(int id,string? nome, string descricao, double preco, CategoriaProduto categoria, string tamanho, string cor, string marca, string material) : base(id,nome, descricao, preco, categoria)
   {
      this.tamanho = tamanho;
      this.cor = cor;
      this.marca = marca;
      this.material = material;
   }

   public Acessorio()
   {
   }

   public string Tamanho
   {
      get { return tamanho; }
      set { this.tamanho = value; }
   }
   
   public string Cor
   {
      get { return cor; }
      set { this.cor = value; }
   }

   public string Marca
   {
      get { return marca; }
      set { this.marca = value; }
   }

   public string Material
   {
      get { return material; }
      set { this.material = value; }
   }
   
   
}