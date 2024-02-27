using PROJETOS.Models;







Calculadora calc = new Calculadora();

calc.Somar(1,2);
calc.Dividir(12,3);
calc.Subtrair(7,4);
calc.Multiplicar(5,5);
calc.Potencia(2,3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

string? opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.WriteLine("Digite a sua Opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
        break;

        case "2":
            Console.WriteLine("Busca de Cliente");
        break;

        case "3":
            Console.WriteLine("Apagar de Cliente");
        break;

        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
        break;

        default:
            Console.WriteLine("Opção inválida");
        break;
    }
}


int soma = 0, numero = 0;


do
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

}while(numero != 0);

Console.WriteLine($"Total da soma dos numeros é: {soma}");




