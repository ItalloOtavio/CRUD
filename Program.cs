
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
        p.id = idade;

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
                Console.WriteLine($"ID:{p.id}Nome:{p.nome} Idade: {p.idade}");
            }
        }  
    }
    static void Main(string[] args)
    {
        int op;
        Console.WriteLine("====CRUD====");
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Listar");
        Console.WriteLine("3 - Atualizar");
        Console.WriteLine("4 - Remover");
        Console.WriteLine("0 - Sair");
        op = int.Parse(Console.ReadLine()!);

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
            case 0:
                break;

        }
    }
}
