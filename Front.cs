string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[x] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[%] Porcentagem");
Console.WriteLine("[b] Bhaskara");
Console.WriteLine("[*] Esponenciação");
Console.WriteLine("[r] Radiciação");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Codigo.CalcularSoma();
        break;
    case "-":
        Codigo.CalcularSubtracao();
        break;
    case "x":
        Codigo.CalcularMultiplicacao();
        break;
    case "/":
        Codigo.CalcularDivisao();
        break;
     case "%":
        Codigo.CalcularPorcentagem();
        break;
    case "b":
        Codigo.CalcularBhaskara();
        break;
    case "*":
        Codigo.CalcularExponenciação();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
    
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");