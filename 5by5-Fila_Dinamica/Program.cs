using _5by5_Fila_Dinamica;
int opc;
FilaPessoa filaPessoa = new FilaPessoa();
void Menu()
{
    Console.WriteLine("[1] - Inserir pessoa na fila");
    Console.WriteLine("[2] - Remover pessoa na fila");
    Console.WriteLine("[3] - Imprimir fila");
    Console.WriteLine("[4] - Buscar pessoa na fila");
    Console.WriteLine("[0] - Sair");
}

do
{
    Console.Clear();
    Console.WriteLine("Escolha qual opção deseja");
    Console.WriteLine("========== MENU FILA ==========");
    Menu();
    
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            Console.WriteLine("Digite o nome da pessoa: ");
            filaPessoa.Push(new(Console.ReadLine()));
            break;
        case 2: filaPessoa.Pop();
            break;
        case 3:filaPessoa.print();
            break;
        case 4:
            Console.WriteLine("Digite o nome da pessoa para buscar na fila");
            string nome_pessoa = Console.ReadLine();
            filaPessoa.BuscarPessoa(nome_pessoa);
            break;
        default:
            break;
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadLine();

} while (opc != 0);