using System;
using System.Collections.Generic;
using System.Linq;

// Classe Tarefa
class Tarefa
{
  // Atributos
  public string Titulo { get; set; }
  public string Descricao { get; set; }
  public bool Concluida { get; set; }
  public DateTime Prazo { get; set; }

  // Construtor
  public Tarefa(string titulo, string descricao, bool concluida, DateTime prazo)
  {
    Titulo = titulo;
    Descricao = descricao;
    Concluida = concluida;
    Prazo = prazo;
  }
}

namespace MeuProjeto
{
  class Menu
  {
    static List<Tarefa> tarefas = new List<Tarefa>();

    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("----- TAREFAS -----");
        Console.WriteLine("1. Adicionar tarefa");
        Console.WriteLine("2. Marcar tarefa como concluída");
        Console.WriteLine("3. Excluir tarefa");
        Console.WriteLine("4. Listar tarefas");
        Console.WriteLine("5. Buscar tarefas");
        Console.WriteLine("6. Estatísticas");
        Console.WriteLine("7. Editar tarefa");
        Console.WriteLine("0. Sair");
        Console.WriteLine("Escolha uma opção:");

        int escolha;
        if (!int.TryParse(Console.ReadLine(), out escolha))
        {
          Console.WriteLine("Opção inválida. Tente novamente.");
          continue;
        }

        switch (escolha)
        {
          case 1:
            AdicionarTarefa();
            break;
          case 2:
            MarcarComoConcluida();
            break;
          case 3:
            ExcluirTarefa();
            break;
          case 4:
            ListarTarefas();
            break;
          case 5:
            BuscarTarefas();
            break;
          case 6:
            ExibirEstatisticas();
            break;
          case 7:
            EditarTarefa();
            break;
          case 0:
            return;
          default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
        }
      }
    }

    static void AdicionarTarefa()
    {
      Console.WriteLine("Qual o título da tarefa?");
      string titulo = Console.ReadLine();
      Console.WriteLine("Qual a descrição da tarefa?");
      string descricao = Console.ReadLine();
      Console.WriteLine("Qual o prazo da tarefa (yyyy-mm-dd)?");

      if (DateTime.TryParse(Console.ReadLine(), out DateTime prazo))
      {
        tarefas.Add(new Tarefa(titulo, descricao, false, prazo));
        Console.WriteLine("Tarefa adicionada com sucesso!");
      }
      else
      {
        Console.WriteLine("Formato de data inválido. Tarefa não adicionada.");
      }
    }

    static void MarcarComoConcluida()
    {
      ListarTarefas();
      Console.WriteLine("Qual tarefa deseja marcar como concluída?");
      if (int.TryParse(Console.ReadLine(), out int escolha) && escolha > 0 && escolha <= tarefas.Count)
      {
        tarefas[escolha - 1].Concluida = true;
        Console.WriteLine("Tarefa marcada como concluída!");
      }
      else
      {
        Console.WriteLine("Escolha inválida. Tarefa não marcada como concluída.");
      }
    }

    static void ExcluirTarefa()
    {
      ListarTarefas();
      Console.WriteLine("Qual tarefa deseja excluir?");
      if (int.TryParse(Console.ReadLine(), out int escolha) && escolha > 0 && escolha <= tarefas.Count)
      {
        tarefas.RemoveAt(escolha - 1);
        Console.WriteLine("Tarefa excluída com sucesso!");
      }
      else
      {
        Console.WriteLine("Escolha inválida. Tarefa não excluída.");
      }
    }

    static void ListarTarefas()
    {
      Console.WriteLine("----- LISTA DE TAREFAS -----");
      if (tarefas.Count > 0)
      {
        for (int i = 0; i < tarefas.Count; i++)
        {
          Console.WriteLine($"{i + 1}. {tarefas[i].Titulo}");
          Console.WriteLine($"{tarefas[i].Descricao}");
          Console.WriteLine($"Concluída: {tarefas[i].Concluida}");
          Console.WriteLine($"Prazo: {tarefas[i].Prazo:yyyy-MM-dd}");
          Console.WriteLine();
        }
      }
      else
      {
        Console.WriteLine("Nenhuma tarefa encontrada.");
      }
    }

    static void BuscarTarefas()
    {
      Console.WriteLine("Qual a palavra-chave?");
      string busca = Console.ReadLine().ToLower();
      var resultado = tarefas.Where(tarefa => tarefa.Titulo.Contains(busca) || tarefa.Descricao.Contains(busca)).ToList();

      Console.WriteLine("----- RESULTADOS DA PESQUISA -----");
      foreach (var tarefa in resultado)
      {
        Console.WriteLine(tarefa.Titulo);
        Console.WriteLine(tarefa.Descricao);
        Console.WriteLine($"Concluída: {tarefa.Concluida}");
        Console.WriteLine($"Prazo: {tarefa.Prazo:yyyy-MM-dd}");
        Console.WriteLine();
      }
    }

    static void ExibirEstatisticas()
    {
      Console.WriteLine($"Existem {tarefas.Count} tarefas no total.");
      Console.WriteLine($"Existem {tarefas.Count(tarefa => tarefa.Concluida)} tarefas concluídas.");
      Console.WriteLine($"Existem {tarefas.Count(tarefa => !tarefa.Concluida)} tarefas pendentes.");
    }

    static void EditarTarefa()
    {
      ListarTarefas();
      Console.WriteLine("Qual tarefa deseja editar? (Digite 0 para cancelar)");
      if (int.TryParse(Console.ReadLine(), out int escolha) && escolha > 0 && escolha <= tarefas.Count)
      {
        Console.WriteLine("Qual o novo título?");
        tarefas[escolha - 1].Titulo = Console.ReadLine();
        Console.WriteLine("Qual a nova descrição?");
        tarefas[escolha - 1].Descricao = Console.ReadLine();
        Console.WriteLine("Qual o novo prazo (yyyy-MM-dd)?");

        if (DateTime.TryParse(Console.ReadLine(), out DateTime novoPrazo))
        {
          tarefas[escolha - 1].Prazo = novoPrazo;
          Console.WriteLine("Tarefa editada com sucesso!");
        }
        else
        {
          Console.WriteLine("Formato de data inválido. Tarefa não editada.");
        }
      }
      else
      {
        Console.WriteLine("Escolha inválida. Tarefa não editada.");
      }
    }
  }
}
