public class Aritmetica
{
    public static double Soma(double parcela1, double parcela2)
    {
        double total = parcela1 + parcela2;
        return total;
    }
        public static double Subtracao(double minuendo, double subtraendo)
    {
        double diferenca = minuendo - subtraendo;
        return diferenca;
    }

    public static double Multiplicacao(double fator1, double fator2)
    {
        double produto = fator1 * fator2;
        return produto;
    }
     public static double Divisao(double dividendo, double divisor )

     { if (divisor == 0)
    {
        throw new Exception("Não é possível dividir por zero.");
    }
    double quociente  = dividendo / divisor;
    return quociente;
     }

    public static decimal Porcentagem(decimal  porcentagem,  decimal numero )
    {
        decimal resultado = porcentagem /100 * numero;
        return porcentagem;
    }

    public static double Bhaskara(double a , double b, double c, double delta, double x1, double x2)
    {
        delta = Math.Pow(b,2) -4 * a *c;
         x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
         return delta;
    }

    public static double Exponenciação(double numero, double potencia)
    {
        potencia = Math.Pow(numero,2);
        return numero;
    }


}
