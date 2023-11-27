
using System;

Estoque estoque = new Estoque();

while (true)
{
  Console.WriteLine("1. Cadastrar Produto");
  Console.WriteLine("2. Consultar Produto por Código");
  Console.WriteLine("3. Atualizar Estoque");
  Console.WriteLine("4. Relatórios");
  Console.WriteLine("5. Sair");

  Console.Write("Escolha uma opção: ");
  string escolha = Console.ReadLine();

  switch (escolha)
  {
    case "1":
      CadastrarProduto(estoque);
      break;
    case "2":
      ConsultarProdutoPorCodigo(estoque);
      break;
    case "3":
      AtualizarEstoque(estoque);
      break;
    case "4":
      GerarRelatorios(estoque);
      break;
    case "5":
      Environment.Exit(0);
      break;
    default:
      Console.WriteLine("Opção inválida. Tente novamente.");
      break;
  }
}

void CadastrarProduto(Estoque estoque)
{
  try
  {
    Console.Write("Código do Produto: ");
    int codigo = int.Parse(Console.ReadLine());

    Console.Write("Nome do Produto: ");
    string nome = Console.ReadLine();

    Console.Write("Quantidade em Estoque: ");
    int quantidade = int.Parse(Console.ReadLine());

    Console.Write("Preço Unitário: ");
    decimal preco = decimal.Parse(Console.ReadLine());

    estoque.CadastrarProduto(codigo, nome, quantidade, preco);
  }
  catch (FormatException)
  {
    Console.WriteLine("Erro: Informações inválidas. Certifique-se de inserir valores numéricos corretos.");
  }
}

void ConsultarProdutoPorCodigo(Estoque estoque)
{
  Console.Write("Digite o código do produto: ");
  int codigo = int.Parse(Console.ReadLine());
  estoque.ConsultarProdutoPorCodigo(codigo);
}

void AtualizarEstoque(Estoque estoque)
{
  Console.Write("Digite o código do produto: ");
  int codigo = int.Parse(Console.ReadLine());

  Console.Write("Digite a quantidade para adicionar (ou negativa para remover): ");
  int quantidade = int.Parse(Console.ReadLine());

  estoque.AtualizarEstoque(codigo, quantidade);
}

void GerarRelatorios(Estoque estoque)
{
  Console.Write("Informe o limite inferior de quantidade em estoque: ");
  int limiteEstoque = int.Parse(Console.ReadLine());

  var relatorio1 = estoque.ListarProdutosComQuantidadeAbaixoDoLimite(limiteEstoque);
  Console.WriteLine("\nProdutos com quantidade em estoque abaixo do limite:");
  foreach (var produto in relatorio1)
  {
    Console.WriteLine($"{produto.Nome} - Quantidade: {produto.QuantidadeEmEstoque}");
  }

  Console.Write("\nInforme o valor mínimo para filtrar os produtos: ");
  decimal valorMinimo = decimal.Parse(Console.ReadLine());

  Console.Write("Informe o valor máximo para filtrar os produtos: ");
  decimal valorMaximo = decimal.Parse(Console.ReadLine());

  var relatorio2 = estoque.FiltrarProdutosPorValor(valorMinimo, valorMaximo);
  Console.WriteLine("\nProdutos com valor entre o mínimo e o máximo:");
  foreach (var produto in relatorio2)
  {
    Console.WriteLine($"{produto.Nome} - Preço: {produto.PrecoUnitario:C}");
  }

  decimal valorTotalEstoque = estoque.CalcularValorTotalEstoque();
  Console.WriteLine($"\nValor total do estoque: {valorTotalEstoque:C}");

  Console.WriteLine("\nValor total de cada produto de acordo com seu estoque:");
  var relatorio3 = estoque.CalcularValorTotalPorProduto();
  foreach (var (nome, valorTotal) in relatorio3)
  {
    Console.WriteLine($"{nome} - Valor Total: {valorTotal:C}");
  }
}
