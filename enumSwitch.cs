using System.Threading.Tasks.Dataflow;

Console.WriteLine("Selecione uma das opções a baixo:");
Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
int selecionar = int.Parse(Console.ReadLine());

Opcao opcoeSelecionada = (Opcao)selecionar;

Console.WriteLine(opcoeSelecionada);

Console.ReadLine();

switch (opcoeSelecionada)
{
    case Opcao.Criar:
    Console.WriteLine("Criado com sucesso");
    break;
    case Opcao.Deletar:
     Console.WriteLine("Deletado com sucesso");
    break;
    case Opcao.Editar:
     Console.WriteLine("Editado com sucesso");
    break;
    default:
     Console.WriteLine("Nao tem essa opcao");
    break;
}


Console.ReadLine();

enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualiza}