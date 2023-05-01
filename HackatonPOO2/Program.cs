using System.Data;
using HackatonPOO2.Model;
using HackatonPOO2.UI;
//cmoit
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        ClienteUI cui = new ClienteUI();
        CategoriaUI caui = new CategoriaUI();
        VendaUI vui = new VendaUI();
        ProdutoUI pui = new ProdutoUI();

        int idCountClient = 1;
        int idCountProduto = 1;
        int idCountCategoria = 1;
        int idCountVenda = 1;

        bool execMenu = true;
        bool execProd = true;
        bool execClient = true;
        bool execCategoria = true;
        bool execVenda = true;

        while (execMenu)
        {
            Console.WriteLine("--- Sistema ---\n1 - Produto\n2 - Cliente\n3 - Categoria\n4 - Venda\n0 - Sair");
            int id;
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    Console.Clear();
                    execMenu = false;
                    break;
                case 1:
                    Console.Clear();
                    while (execProd)
                    {
                        Console.WriteLine(
                            "--- Produto ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                Console.Clear();
                                execProd = false;
                                break;
                            case 1:
                                Console.Clear();

                                if (caui.categoria.Count == 0)
                                {
                                    Console.WriteLine("Cadastre uma cateroria para inserir um produto.");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                }

                                Produto p = new Produto();
                                Console.WriteLine("Nome: ");
                                p.Nome = Console.ReadLine();
                                Console.WriteLine("Descrição: ");
                                p.Desc = Console.ReadLine();
                                Console.WriteLine("Preço: ");
                                p.Preco = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("ID da Categoria: ");

                                for (int i = 0; i < caui.categoria.Count; i++)
                                {
                                    Console.WriteLine(caui.categoria[i].id + " - " + caui.categoria[i].Nome);
                                }

                                int idCategoria = 0;
                                while (true)
                                {
                                    idCategoria = Convert.ToInt32(Console.ReadLine());
                                    if (caui.containsId(idCategoria))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Digite um id presente na lista:");
                                        //Thread.Sleep(3000);
                                        //Console.Clear();
                                    }
                                }


                                p.Categoria = caui.categoria[caui.getPosCategoria(idCategoria)];
                                Console.WriteLine();
                                p.id = idCountProduto;
                                idCountProduto++;

                                pui.createProduto(p);

                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do produto a ser buscado: ");
                                id = pui.getPosProduto(Convert.ToInt32(Console.ReadLine()));
                                if (id == -1)
                                {
                                    Console.WriteLine("Não foi possivel editar, pois este produto não foi encontrado");
                                }
                                else
                                {
                                    Console.WriteLine(pui.produtos[id].ToString());
                                    Produto pn = new Produto();
                                    Console.WriteLine("Nome: ");
                                    pn.Nome = Console.ReadLine();
                                    Console.WriteLine("Descrição: ");
                                    pn.Desc = Console.ReadLine();
                                    Console.WriteLine("Preço: ");
                                    pn.Preco = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("ID da Categoria: ");
                                    for (int i = 0; i < caui.categoria.Count; i++)
                                    {
                                        Console.WriteLine(caui.categoria[i].id + " - " + caui.categoria[i].Nome);
                                    }

                                    pn.Categoria =
                                        caui.categoria[caui.getPosCategoria(Convert.ToInt32(Console.ReadLine()))];
                                    pn.id = pui.produtos[id].id;
                                    Console.WriteLine();

                                    pui.updateProduto(id, pn);
                                }

                                break;
                            case 3:
                                Console.Clear();
                                pui.getAll();
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do produto a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(pui.getProduto(id).ToString());
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do produto para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                pui.deleteProduto(id);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Este número não está no MENU!");
                                break;
                        }
                    }

                    execProd = true;

                    break;
                case 2:
                    Console.Clear();
                    while (execClient)
                    {
                        Console.WriteLine(
                            "--- Cliente ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                Console.Clear();
                                execClient = false;
                                break;
                            case 1:
                                Console.Clear();
                                Cliente c = new Cliente();
                                Console.WriteLine("Nome: ");
                                c.Nome = Console.ReadLine();
                                Console.WriteLine("Sobrenome: ");
                                c.Sobrenome = Console.ReadLine();
                                Console.WriteLine("Endereço: ");
                                c.Endereco = Console.ReadLine();
                                Console.WriteLine("Telefone: ");
                                c.Telefone = Console.ReadLine();
                                Console.WriteLine();
                                c.id = idCountClient;
                                idCountClient++;

                                cui.createCliente(c);

                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do cliente a ser buscado: ");
                                id = cui.getPosCliente(Convert.ToInt32(Console.ReadLine()));
                                if (id == -1)
                                {
                                    Console.WriteLine("Não foi possivel editar, pois este cliente não foi encontrado");
                                }
                                else
                                {
                                    Console.WriteLine(cui.clientes[id].ToString());
                                    Cliente cn = new Cliente();
                                    Console.WriteLine("Nome: ");
                                    cn.Nome = Console.ReadLine();
                                    Console.WriteLine("Sobrenome: ");
                                    cn.Sobrenome = Console.ReadLine();
                                    Console.WriteLine("Endereço: ");
                                    cn.Endereco = Console.ReadLine();
                                    Console.WriteLine("Telefone: ");
                                    cn.Telefone = Console.ReadLine();
                                    cn.id = cui.clientes[id].id;
                                    Console.WriteLine();

                                    cui.updateCliente(id, cn);
                                }

                                break;
                            case 3:
                                Console.Clear();
                                cui.getAll();
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do cliente a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(cui.getCliente(id).ToString());
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do cliente para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                cui.deleteCliente(id);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Este número não está no MENU!");
                                break;
                        }
                    }

                    execClient = true;

                    break;
                case 3:
                    Console.Clear();
                    while (execCategoria)
                    {
                        Console.WriteLine(
                            "--- Categoria ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                Console.Clear();
                                execCategoria = false;
                                break;
                            case 1:
                                Console.Clear();
                                Categoria c = new Categoria();
                                Console.WriteLine("Nome: ");
                                c.Nome = Console.ReadLine();
                                Console.WriteLine("Descricao: ");
                                c.Desc = Console.ReadLine();
                                Console.WriteLine();
                                c.id = idCountCategoria;
                                idCountCategoria++;

                                caui.createCategoria(c);

                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do categoria a ser buscado: ");
                                id = caui.getPosCategoria(Convert.ToInt32(Console.ReadLine()));
                                if (id == -1)
                                {
                                    Console.WriteLine(
                                        "Não foi possivel editar, pois esta categoria não foi encontrada");
                                }
                                else
                                {
                                    Console.WriteLine(caui.categoria[id].ToString());
                                    Categoria cn = new Categoria();
                                    Console.WriteLine("Nome: ");
                                    cn.Nome = Console.ReadLine();
                                    Console.WriteLine("Descricao: ");
                                    cn.Desc = Console.ReadLine();
                                    cn.id = caui.categoria[id].id;
                                    Console.WriteLine();

                                    caui.updateCategory(id, cn);
                                }

                                break;
                            case 3:
                                Console.Clear();
                                caui.getAll();
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do categoria a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(caui.getCategoria(id).ToString());
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Digite o ID do categoria para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                caui.deleteCategoria(id);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Este número não está no MENU!");
                                break;
                        }
                    }

                    execCategoria = true;

                    break;
                case 4:
                    Console.Clear();
                    while (execVenda)
                    {
                        Console.WriteLine(
                            "--- Venda ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");

                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                Console.Clear();
                                execVenda = false;
                                break;
                            case 1:
                                if (cui.clientes.Count == 0)
                                {
                                    Console.WriteLine("Não é possivel realizar uma venda sem um cliente.");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                }

                                if (pui.produtos.Count == 0)
                                {
                                    Console.WriteLine("Não é possivel realizar uma venda sem produtos.");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                }

                                Console.Clear();
                                Venda v = new Venda();
                                Console.WriteLine("ID do Cliente: ");
                                for (int i = 0; i < cui.clientes.Count; i++)
                                {
                                    Console.WriteLine(cui.clientes[i].id + " - " + cui.clientes[i].Nome + " " +
                                                      cui.clientes[i].Sobrenome);
                                }

                                int idCLiente = 0;
                                while (true)
                                {
                                    idCLiente = Convert.ToInt32(Console.ReadLine());
                                    if (cui.containsId(idCLiente))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Digite um id presente na lista:");
                                        //Thread.Sleep(3000);
                                        //Console.Clear();
                                    }
                                }

                                v.Cliente = cui.clientes[cui.getPosCliente(idCLiente)];


                                Console.WriteLine("Data: ");
                                v.Data = Console.ReadLine();


                                List<Produto> p = new List<Produto>();
                                double? val = 0;
                                while (true)
                                {
                                    Console.WriteLine(
                                        "Digite o ID do produto (digite X para parar de adicionar produtos): ");
                                    for (int i = 0; i < pui.produtos.Count; i++)
                                    {
                                        Console.WriteLine(pui.produtos[i].id + " - " + pui.produtos[i].Nome);
                                    }

                                    string? idp = Console.ReadLine();

                                    if (idp.ToUpper() == "X")
                                    {
                                        break;
                                    }

                                    if (pui.containsId(Convert.ToInt32(idp)))
                                    {
                                        p.Add(pui.produtos[pui.getPosProduto(Convert.ToInt32(idp))]);
                                        val += pui.produtos[pui.getPosProduto(Convert.ToInt32(idp))].Preco;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Digite um id presente na lista.");
                                        //Thread.Sleep(3000);
                                        //Console.Clear();
                                    }
                                }

                                v.ProdutosComprados = p;
                                v.ValorTotal = val;
                                Console.WriteLine();
                                v.id = idCountVenda;
                                idCountVenda++;

                                vui.createVenda(v);

                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Digite o ID da venda a ser buscado: ");
                                id = vui.GetPosVenda(Convert.ToInt32(Console.ReadLine()));
                                if (id == -1)
                                {
                                    Console.WriteLine("Não foi possivel editar, pois esta venda não foi encontrada");
                                }
                                else
                                {
                                    Console.WriteLine(vui.vendas[id].ToString());
                                    Venda vn = new Venda();
                                    Console.WriteLine("ID do Cliente: ");
                                    for (int i = 0; i < cui.clientes.Count; i++)
                                    {
                                        Console.WriteLine(cui.clientes[i].id + " - " + cui.clientes[i].Nome + " " +
                                                          cui.clientes[i].Sobrenome);
                                    }

                                    vn.Cliente = cui.clientes[cui.getPosCliente(Convert.ToInt32(Console.ReadLine()))];
                                    Console.WriteLine("Data: ");
                                    vn.Data = Console.ReadLine();
                                    List<Produto> pn = new List<Produto>();
                                    double? valn = 0;
                                    while (true)
                                    {
                                        Console.WriteLine(
                                            "Digite o ID do produto (digite X para parar de adicionar produtos): ");
                                        for (int i = 0; i < pui.produtos.Count; i++)
                                        {
                                            Console.WriteLine(pui.produtos[i].id + " - " + pui.produtos[i].Nome);
                                        }

                                        string? idp = Console.ReadLine();

                                        if (idp == "X")
                                        {
                                            break;
                                        }

                                        pn.Add(pui.produtos[pui.getPosProduto(Convert.ToInt32(idp))]);
                                        valn += pui.produtos[pui.getPosProduto(Convert.ToInt32(idp))].Preco;
                                    }

                                    vn.ProdutosComprados = pn;
                                    vn.ValorTotal = valn;
                                    vn.id = vui.vendas[id].id;
                                    Console.WriteLine();

                                    vui.updateVenda(id, vn);
                                }

                                break;
                            case 3:
                                Console.Clear();
                                vui.getAll();
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Digite o ID da venda a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(vui.getVenda(id).ToString());
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Digite o ID da venda para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                vui.deleteVenda(id);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Este número não está no MENU!");
                                break;
                        }
                    }

                    execVenda = true;

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Essa não é uma opção do MENU!");
                    break;
            }
        }
    }
}