using static System.Console;
using static System.Convert;

int n1 = 7, n2 = 13;

WriteLine("Insira um numero A:");

n1 = ToInt32(ReadLine());

WriteLine("Insira outro número B:");

n2 = ToInt32(ReadLine());

WriteLine($"Número A:{n1} Número B: {n2}");

n1 = n1 + n2;
n2 = n1 - n2;
n1 = n1 - n2;

WriteLine($"Número A:{n1} Número B: {n2}");

double CalcularDesconto(double a)
{
    double desconto = a * 0.1;
    double valorFinal = a - desconto;
    return valorFinal;
}

String Produto = "Desconto";
double preco;
WriteLine("digite o preço do produto.");
preco = ToDouble(ReadLine());
double desconto = preco * 0.1;

double invocarFuncao = CalcularDesconto(preco);
WriteLine($"o preço do produto é {preco}, o desconto é de {Math.Round(desconto, 2)} e o preço com o desconto é {Math.Round(invocarFuncao, 2)}  ");


ReadKey();
