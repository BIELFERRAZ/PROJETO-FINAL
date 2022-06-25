public class Codigo
{
public static void CalcularSoma()
{
    double a, b, resultado;

    Console.WriteLine("--- Soma A+B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a + b;

    Console.WriteLine($"{a} somado com {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

 public static void CalcularPorcentagem()
 {
     decimal porcentagem, numero, Resultado;
     Console.WriteLine("--- Porcentagem A%B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    porcentagem = Convert.ToDecimal(Console.ReadLine());
    Console.Write("B = ");
    numero = Convert.ToDecimal(Console.ReadLine());

    Resultado = (porcentagem / 100) * numero;

    Console.WriteLine($"{porcentagem}% de {numero} é:{Resultado}");
 }

public static void CalcularSubtracao()
{
    double a, b, resultado;

    Console.WriteLine("--- Subtração A-B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"{a} subtraindo {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void CalcularMultiplicacao()
{
    double a, b, resultado;

    Console.WriteLine("--- Multiplicação A*B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void  CalcularDivisao()
{
    double a, b, resultado;

    Console.WriteLine("--- Divisão A/B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    if (b == 0)
    {
        Console.WriteLine("\nNão é possível dividir por zero.");
    }
    else
    {
        resultado = a / b;

        Console.WriteLine($"{a} dividido por {b} é {resultado}");
    }

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void CalcularBhaskara()
{
    Console.WriteLine("--- Bhaskara A²+B+C ---\n");
    Console.WriteLine("Digite os valores.");
    
    double a, b ,c, delta, x1, x2;

Console.Write("(a):");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("(b):");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c):");
c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(b,2) -4 * a *c;
if (a == 0)
{
    
    Console.ForegroundColor=  ConsoleColor.Yellow;
    Console.WriteLine("Não é uma equação de segundo grau!");
        Console.ResetColor();
}
else if (delta < 0)
{
    Console.ForegroundColor=  ConsoleColor.DarkRed;
    Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais!");
    Console.ResetColor();
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    
    
    Console.WriteLine($"x1 ={x1:N2} e x2 ={x2:N2}");
}
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
}

public static void CalcularExponenciação()
{
double numero,  potencia;

 Console.WriteLine("--- Exponenciação A²---\n");
    Console.WriteLine("Digite os valores.");

Console.Write("(a):");
numero = Convert.ToDouble(Console.ReadLine());

potencia = Math.Pow(numero,2);

Console.WriteLine($"{numero} ao quadrado é:{potencia}");

Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
}

}



