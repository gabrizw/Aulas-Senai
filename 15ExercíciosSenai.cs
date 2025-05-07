using static System.Console;
using static System.Convert;

//Não colocar os códigos juntos para não dar problema e usar "using static System" para ".Console" e ".Convert"

//1 - Verificação de Paridade:
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

// 2 - Classificação por Idade:

int filtrarPorIdade(int a)
{
    if(a >= 0 && a <= 12)
    {
        WriteLine($"Você é uma criança porque tem {a} anos.");
    }
    else if(a >= 13 && a <= 17)
    {
        WriteLine($"Você é um adolescente porque tem {a} anos.");
    }
    else if (a >= 18 && a <= 59)
    {
        WriteLine($"Você é um adulto porque tem {a} anos.");
    }
    else if (a >= 60)
    {
        WriteLine($"Você é um idoso porque tem {a} anos.");
    }
    else
    {
        WriteLine("Você digitou uma entrada inválida, tente novamente.");
    }
    return a;
}

int idade;
WriteLine("Digite sua idade para saber sua classificação");
idade = Convert.ToInt32(ReadLine());
filtrarPorIdade(idade);

// 3 - Calculadora Simples

double calculadoraSimples(string c, double a, double b)
{
    string adicao = "+", subtracao = "-", multiplicacao = "*", multiplicacao1 = "x", multiplicacao2 = "X", divisao = "/";
    if (c == adicao)
    {
        WriteLine($"O resultado de {a} {c} {b} é {a + b}.");
    }
    else if (c == subtracao) {
        WriteLine($"O resultado de {a} {c} {b} é {a - b}.");
    }
    else if (c == multiplicacao || c == multiplicacao1 || c == multiplicacao2)
    {
        WriteLine($"O resultado de {a} {c} {b} é {a * b}.");
    }
    else if (c == divisao)
    {           
        if (b == 0)
        {
            WriteLine($"O resultado de {a} {c} {b} é 0.");

        }
        else
        {
            WriteLine($"O resultado de {a} {c} {b} é {a / b}.");
        }
    }
    return a;

}


double num1, num2;
string operador;
WriteLine("Digite um número para efetuar uma operação");
num1 = Convert.ToDouble(ReadLine());
WriteLine("Digite outro número para efetuar uma operação");
num2 = Convert.ToDouble(ReadLine());
WriteLine("Digite uma operação entre (+) (-) (*) (/) para efetutar operações.");
operador = ReadLine();
calculadoraSimples(operador, num1, num2);

// 4 - Dia da Semana:

int diaSemana;
WriteLine("Insira um número entre 1 a 7 para exibir o dia da semana correspondente ao número fornecido.");
diaSemana = Convert.ToInt32(ReadLine());

switch (diaSemana)
{
    case 1:
        WriteLine("Domingo");
        break;
    case 2:
        WriteLine("Segunda-Feira");
        break;
    case 3:
        WriteLine("Terça-Feira");
        break;
    case 4:
        WriteLine("Quarta-Feira");
        break;
    case 5:
        WriteLine("Quinta-Feira");
        break;
    case 6:
        WriteLine("Sexa-Feira");
        break;
    case 7:
        WriteLine("Sábado");
        break;
    default:
        WriteLine("Não possui dia da semana correspondente a sua entrada.");
        break;
}

// 5.Verificação de Vogal/Consoante:
string vogalOuNao;
WriteLine("Digite uma letra do alfabeto e descubra se é vogal ou consoante!");
vogalOuNao = ReadLine().ToLower();
switch (vogalOuNao)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        WriteLine($"{vogalOuNao} é uma vogal.");
        break;
    case "b":
    case "c":
    case "d":
    case "f":
    case "g":
    case "h":
    case "j":
    case "k":
    case "l":
    case "m":
    case "n":
    case "p":
    case "q":
    case "r":
    case "s":
    case "t":
    case "v":
    case "w":
    case "x":
    case "y":
    case "z":
        WriteLine($"{vogalOuNao} é uma consoante.");
        break;
    default:
        WriteLine("A entrada fornecida não está no alfabeto.");
        break;
}

// 6 - Média Aritmética e Aprovação:

double mediaAluno(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    if (media < 6.9)
    {
        WriteLine($"Você está reprovado pois sua média é {media} e a média necessária é 7.0");
    }
    else
    {
        WriteLine($"Você está aprovado pois sua média é {media}.");
    }
    return media;
}

double nota, nota1, nota2;
WriteLine("Digite sua nota:");
nota = Convert.ToDouble(ReadLine());
WriteLine("Digite sua nota:");
nota1 = Convert.ToDouble(ReadLine());
WriteLine("Digite sua nota:");
nota2 = Convert.ToDouble(ReadLine());
mediaAluno(nota, nota1, nota2);

//Exercício 7

using static System.Convert;
using static System.Console;

double produtoDesconto(double a)

{
    double desconto;
    if (a < 50)
    {
        WriteLine($"Sem desconto, preço original de R${a}");
    }
    else if (a > 51 && a < 100)
    {
        desconto = a * 0.05;
        double valorFinal = a - desconto;
        WriteLine($"Seu produto custa {a}, com o desconto de  5%(R${Math.Round(desconto, 2)}).O valor final do produto é { Math.Round(valorFinal, 2)}.");
    }
    else if (a > 101)
    {
        desconto = a * 0.1;
        double valorFinal = a - desconto;
        WriteLine($"O produto custa {a}, com o desconto de 10%(R${Math.Round(desconto, 2)}).O valor final do produto é {Math.Round(valorFinal, 2)}.");
    }
    return a;
}
double produto;
WriteLine("Digite o valor do produto -->");
produto = Convert.ToDouble(ReadLine());
produtoDesconto(produto);

//Exercício 8

int anoBissexto(int a)
{
    if ((a % 4 == 0 && a % 100 != 0) || a % 400 == 0)
    {
        WriteLine($"o ano de {a} é bissexto");
    }
    else
    {
        WriteLine($"o ano {a} não é bissexto");
    }
    return a;
}

int ano;
WriteLine("Escreva um ano para descobrir se ele é bissexto:");
ano = ToInt32(ReadLine());
anoBissexto(ano);

// Exercício 9

int num1, num2;

string cal;

WriteLine("Digite um número para efetuar uma operação:");
num1 = ToInt32(ReadLine());
WriteLine("Digite outro número para terminar a operação");
num2 = ToInt32(ReadLine());
WriteLine("Ditite uma operação de sua escolha: (+) (-) (*) (/) ");
cal = ReadLine();
switch (cal)
{
    case "+":
        WriteLine($"o resultado de {num1} + {num2} = {num1 + num2}.");
        break;
    case "-":
        WriteLine($"o resultado de {num1} - {num2} = {num1 - num2}.");
        break;
    case "*":
        WriteLine($"o resultado de {num1} X {num2} = {num1 * num2}.");
        break;
    case "/":
        if (num2 != 0)
        {
            WriteLine($"o resultado de {num1} / {num2} = {num1 / num2}.");
        }
        else
        {
            WriteLine($"divisão por {num2} não é possível.");
        }
        break;
    default:
        WriteLine("sua entrada está errada");
        break;
}

//Exercício 10

int leagl;

WriteLine("Digite um número de 1 a 5 para ver o nível de alerta");
leagl = ToInt32(ReadLine());
switch (leagl)
{
    case 1:
        WriteLine("Nível de alerta baixo");
        break;
    case 2:
        WriteLine("Nível de alerta moderado.");
        break;
    case 3:
        WriteLine("Nível de alerta elevado.");
        break;
    case 4:
        WriteLine("Nível de alerta crítico.");
        break;
    case 5:
        WriteLine("EMERGÊNCIA!");
        break;
    default:
        WriteLine("Entrada inválida");
        break;

}

//Exercício 11

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

//Exercício 12

int num1, num2, num3;

WriteLine("Digite um valor para o primeiro lado");
num1 = ToInt32(ReadLine());
WriteLine("Digite um valor para o segundo lado");
num2 = ToInt32(ReadLine());
WriteLine("Digite um valor para o terceiro lado");
num3 = ToInt32(ReadLine());

if (num1 + num2 > num3 && num1 + num3 > num2 && num3 + num2 > num1)
{
    WriteLine("Os lados formam um triângulo");
}
else
{
    WriteLine("Os lados não conseguem formar um triângulo");
}

//Exercício 13

double n1;

WriteLine("Insira a nota do aluno:");
n1 = ToDouble(ReadLine());

switch (n1) {
    case >= 0.0 and <= 4.9:
        WriteLine("D");
        break;
    case >= 5.0 and <= 6.9:
        WriteLine("C");
        break;
    case >= 7.0 and <= 8.9:
        WriteLine("B");
        break;
    case >= 9.0 and <= 10.0:
        WriteLine("A");
        break;
    default:
        WriteLine("Nota inválida! Digite um número positivo nesse formato: \n 6,0\n 7,0\n etc..");
        break;
}

//Exercício 14


int var1, var2, maior, menor;

WriteLine("Digite um número");
var1 = ToInt32(ReadLine());
WriteLine("Digite outro número");
var2 = ToInt32(ReadLine());

if ((var1 % 2 == 0) && (var2 % 2 == 0))
{
    WriteLine($"soma de {var1} e {var2} resulta em {var1 + var2}");
}
else if ((var1 % 2 == 0) && (var2 % 2 != 0) || (var1 % 2 != 0 && var2 % 2 == 0))
{

    if (var1 > var2)
    {
        maior = var1;
        menor = var2;
        WriteLine($"Um número é par e o outro é impar, então fazemos {maior} - {menor} = {maior - menor}");
    }

    else if (var1 == var2)
    {
        WriteLine($"os números são iguais então devemos apenas subtraídos {var1} - {var2} = {var1 - var2}");
    }
    else
    {
        maior = var2;
        menor = var1;
        WriteLine($"Um número é par e o outro é impar, então fazemos {maior} - {menor} = {maior - menor}");

    }
}
else
{
    WriteLine($"os dois números são ímpares, então fazemos {var2} x {var1} = {var1 * var2}");
}

//Exercício 15

int escolhas;

int num1, num2;

WriteLine("Escolha uma opção \n 1 - Somar \n 2 - Subtrair \n 3 - Sair");

escolhas = ToInt32(ReadLine());

switch (escolhas)
{
    case 1:
        WriteLine("Digite um número a ser somado");
        num1 = ToInt32(ReadLine());
        WriteLine("Digite outro número");
        num2 = ToInt32(ReadLine());
        WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case 2:
        WriteLine("Digite um número a ser subtraído");
        num1 = ToInt32(ReadLine());
        WriteLine("Digite outro número");
        num2 = ToInt32(ReadLine());
        WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case 3:
        break;

}
