//Exercício 1

using static System.Console;
using static System.Convert;

int num1, num2;

WriteLine("Digite um valor para o primeiro número");
num1 = ToInt32(ReadLine());
WriteLine("Digite um valor para o segundo número");
num2 = ToInt32(ReadLine());


if (num1 > num2)
{
    WriteLine($"o maior número é o {num1}");
}
else if (num2 > num1)
{
    WriteLine($"o maior número é o {num2}");
}
else
{
    WriteLine("os números são iguais.");
}


ReadLine();

//Exercício 2

using static System.Console;
using static System.Convert;

int num1, num2, num3;

WriteLine("Digite um valor para o primeiro número");
num1 = ToInt32(ReadLine());
WriteLine("Digite um valor para o segundo número");
num2 = ToInt32(ReadLine());
WriteLine("Digite um valor para o terceiro número");
num3 = ToInt32(ReadLine());

if (num1 > num2 && num1 > num3)
{
    WriteLine($"o maior número é o {num1}");
}
else if (num2 > num1 && num2 > num3)
{
    WriteLine($"o maior número é o {num2}");
}
else if (num3 > num1 && num3 > num2)
{
    WriteLine($"o maior número é o {num3}");
}
else
{
    WriteLine("todos os números são iguais.");
}
ReadLine();

//Exercício 3

using static System.Console;
using static System.Convert;

double mediaAluno(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    if (media < 7.0)
    {
        WriteLine($"Você está reprovado pois sua média é {media:F2} e a média necessária é 7.0.");
    }
    else if (media > 7.0 && media < 9.9)
    {
        WriteLine($"Você está aprovado pois sua média é {media:F2}.");
    }
    else
    {
        WriteLine($"Parabéns!! Você foi aprovado com Distinção. Sua média é {media:F2}.");
    }
    return media;
}

double nota, nota1, nota2;
WriteLine("Digite sua nota:");
nota = ToDouble(ReadLine());
WriteLine("Digite sua nota:");
nota1 = ToDouble(ReadLine());
WriteLine("Digite sua nota:");
nota2 = ToDouble(ReadLine());
mediaAluno(nota, nota1, nota2);

//Exercício 4

using static System.Console;
using static System.Convert;

double num1, num2, num3;

WriteLine("Digite um valor de um dos produto para saber qual você deve comprar (pelo preço)");
num1 = ToDouble(ReadLine());
WriteLine("Digite um valor para o segundo produto");
num2 = ToDouble(ReadLine());
WriteLine("Digite um valor para o terceiro produto");
num3 = ToDouble(ReadLine());

if (num1 < num2 && num1 < num3)
{
    WriteLine($"Compre o primeiro produto pois ele custa {num1}");
}
else if (num2 < num1 && num2 < num3)
{
    WriteLine($"Compre o segundo produto pois ele custa {num2}");
}
else if (num3 < num1 && num3 < num2)
{
    WriteLine($"Compre o terceiro produto pois ele custa {num3}");
}
else
{
    WriteLine("todos os números são iguais.");
}

ReadLine();

//Exercício 5

int ePar(int a)
{
    if (a % 2 == 0)
    {
        WriteLine($"O número {a} é Par.");
    }
    else
    {
        WriteLine($"O número {a} é Ímpar.");
    }
    return a;
}
int numPar;
WriteLine("Digite um número para descobrir se ele é par ou ímpar.");
numPar = Convert.ToInt32(ReadLine());
ePar(numPar);

//Exercício 6

using static System.Console;
using static System.Convert;

int filtrarPorIdade(int a)
{
    if (a >= 0 & a <= 15)
    {
        WriteLine($"Você é menor de 18 anos, espere você ter 16 anos para poder doar sangue");
    }
    else if (a >= 18 && a <= 67)
    {
        WriteLine($"Você é um adulto e pode doar sangue.");
    }
    else if (a >= 68 )
    {
        WriteLine($"Você é um idoso não pode mais doar sangue.");
    }
    else
    {
        WriteLine("Você digitou uma entrada inválida, tente novamente.");
    }
    return a;
}

int idade;
WriteLine("Digite sua idade para saber se você pode doar sangue");
idade = ToInt32(ReadLine());
filtrarPorIdade(idade);

//Exercício 7

int n1 = 10, n2 = 20;

WriteLine($"Número A:{n1} Número B: {n2}");

n1 = n1 + n2;
n2 = n1 - n2;
n1 = n1 - n2;

WriteLine($"Número A:{n1} Número B: {n2}");

//Exercício 8

using static System.Console;
using static System.Convert;


double salario, comissaoPorCarroVendido, salarioFinal;

int carrosVendido;
WriteLine("Digite o salário fixo do vendedor");
salario = ToDouble(ReadLine());
WriteLine("Digite quantos carro o vendedor vendeu");
carrosVendido = ToInt32(ReadLine());
WriteLine("Digite um comissão");
comissaoPorCarroVendido = ToDouble(ReadLine());
salarioFinal = salario + (comissaoPorCarroVendido * carrosVendido) + (comissaoPorCarroVendido * 0.05);

WriteLine($"O salário final será de R${salarioFinal:F2}");

ReadLine();

//Exercício 9

using static System.Console;
using static System.Convert;


double temperaturaC, temperaturaF, subC;
WriteLine("escreva a temperatura em Fahrenheit para converter em Celsius");
temperaturaF = ToDouble(ReadLine());
subC = (temperaturaF - 32);
temperaturaC = subC * 5 / 9;
WriteLine($"Temperatura em Fahrenheit {temperaturaF}\nTemperatura em Celsius {Math.Round(temperaturaC,0)}");
ReadLine();

//exercício 10

using static System.Console;
using static System.Convert;


double vMs, vKmh;
WriteLine("digite uma velocidade por M/s para transformar em Km/h");
vMs = ToDouble(ReadLine());
vKmh = vMs * 3.6;
WriteLine($"o total de {vMs} M/s convertido para Km/h é de {Math.Round(vKmh,2)}");
ReadLine();
