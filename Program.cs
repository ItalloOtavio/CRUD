﻿
namespace CRUD;

class Program
{
    static Pessoa[] pessoas = new Pessoa[10];
    static int quantidadePessoas = 0;

    // Cadastrar pessoas

    static void Cadastrar()
    {
        Console.WriteLine("Digite o id da Pessoa:");
        int id = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a Idade:");
        int idade = int.Parse(Console.ReadLine()!);

        Pessoa p = new Pessoa();
        p.nome = nome;
        p.idade = idade;
        p.id = id;

        pessoas[quantidadePessoas] = p;

        quantidadePessoas++;

        Console.WriteLine("Pessoa cadastrada com sucesso!");

    }

    static void Listar()
    {
        if (quantidadePessoas == 0)
        {
            Console.WriteLine("Nenhuma Pessoa Cadastrada");
            return;
        }
        else
        {
            for (int i = 0; i < quantidadePessoas; i++)
            {
                Pessoa p = pessoas[i];
                Console.WriteLine($"ID:{p.id} Nome:{p.nome} Idade: {p.idade}");
            }
        }
    }

    static void Atualizar()
    {
        Console.WriteLine("Digite o ID da pessoa que deseja atualizar:");
        int id = int.Parse(Console.ReadLine()!);

        int indice = -1;

        for (int i = 0; i < quantidadePessoas; i++)
        {
            if (pessoas[i].id == id)
            {
                indice = i;
                break;
            }
        }
        if (indice == -1)
        {
            Console.WriteLine("Pessoa não encontrada");
            return;
        }

        Console.WriteLine("Digite o novo id");
        pessoas[indice].id = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o novo nome:");
        pessoas[indice].nome = Console.ReadLine()!;
        Console.WriteLine("Digite a nova idade:");
        pessoas[indice].idade = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Pessoa atualizada com sucesso!");
    }

    static void Remover()
    {
        Console.WriteLine("Digite o id da pessoa que deseja remover:");
        int id = int.Parse(Console.ReadLine()!);

        int indice = -1;

        for (int i = 0; i < quantidadePessoas; i++)
        {
            if (pessoas[i].id == id)
            {
                indice = i;
                break;
            }
        }
        if (indice == -1)
        {
            Console.WriteLine("Pessoa não encontrada.");
            return;
        }

        for (int i = indice; i < quantidadePessoas - 1; i++)
        {
            pessoas[i] = pessoas[i + 1];
        }
        pessoas[quantidadePessoas - 1] = null;
        quantidadePessoas--;

        Console.WriteLine("Pessoa removida com sucesso!");
    }
    static void Main(string[] args)
    {
        int op;
        while (true)
        {
            Console.WriteLine("====CRUD====");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Remover");
            Console.WriteLine("0 - Sair");
            op = int.Parse(Console.ReadLine()!);

            if (op == 0)
            {
                break;
            }

            switch (op)
            {
                case 1:
                    Cadastrar();
                    break;
                case 2:
                    Listar();
                    break;
                case 3:
                    Atualizar();
                    break;
                case 4:
                    Remover();
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;

            }
        }
    }
}
