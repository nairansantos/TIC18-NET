using System;
using System.Collections.Generic;
using System.Linq;

public class Estoque
{
  private List<Produto> produtos = new List<Produto>();

  public void CadastrarProduto(int codigo, string nome, int quantidade, decimal preco)
  {
    Produto novoProduto = new Produto(codigo, nome, quantidade, preco);
    produtos.Add(novoProduto);
    Console.WriteLine("Produto cadastrado com sucesso!");
  }

  public void ConsultarProdutoPorCodigo(int codigo)
  {
    Produto produto = produtos.FirstOrDefault(p => p.Codigo == codigo);

    if (produto != null)
    {
      Console.WriteLine($"Nome: {produto.Nome}");
      Console.WriteLine($"Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
      Console.WriteLine($"Preço Unitário: {produto.PrecoUnitario:C}");
    }
    else
    {
      Console.WriteLine("Produto não encontrado!");
    }
  }

  public void AtualizarEstoque(int codigo, int quantidade)
  {
    Produto produto = produtos.FirstOrDefault(p => p.Codigo == codigo);

    if (produto != null)
    {
      if (produto.QuantidadeEmEstoque + quantidade < 0)
      {
        Console.WriteLine("Erro: Não é possível remover mais unidades do que as disponíveis em estoque.");
      }
      else
      {
        produto = produto with { QuantidadeEmEstoque = produto.QuantidadeEmEstoque + quantidade };
        Console.WriteLine($"Estoque atualizado para {produto.QuantidadeEmEstoque} unidades.");
      }
    }
    else
    {
      Console.WriteLine("Produto não encontrado!");
    }
  }

  public IEnumerable<Produto> ListarProdutosComQuantidadeAbaixoDoLimite(int limiteEstoque)
  {
    return produtos.Where(p => p.QuantidadeEmEstoque < limiteEstoque);
  }

  public IEnumerable<Produto> FiltrarProdutosPorValor(decimal valorMinimo, decimal valorMaximo)
  {
    return produtos.Where(p => p.PrecoUnitario >= valorMinimo && p.PrecoUnitario <= valorMaximo);
  }

  public decimal CalcularValorTotalEstoque()
  {
    return produtos.Sum(p => p.QuantidadeEmEstoque * p.PrecoUnitario);
  }

  public IEnumerable<(string Nome, decimal ValorTotal)> CalcularValorTotalPorProduto()
  {
    return produtos.Select(p => (p.Nome, ValorTotal: p.QuantidadeEmEstoque * p.PrecoUnitario));
  }
}
