using ConsolePOOProduto.Entidade;
using System.Globalization;

Console.Write("Entre com  os dados do produto: ");
Console.Write("Nome:");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto produto = new Produto(nome, preco, quantidade);

/// Esse é o  exemplo fazendo o override no método virtual ToString();
Console.WriteLine("Dados do produto: " + produto);
Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
Console.Write("Digite  o Numero de produtos a ser removido do estoque ");
produto.RemoverProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados do produto: " + produto);
