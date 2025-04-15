//Exercício 1

using System.Diagnostics.Contracts;
using static System.Console;
using static System.Convert;

List<string> nomes = new List<string>();
List<int> idades = new List<int>();

for (int i = 1; i <= 10; i++)
{
    WriteLine($"Digite o {i}° nome de um aluno");
    string nome = ReadLine();
    nomes.Add(nome);
    WriteLine($"Digite a idade do {i}° aluno");
    int idade = ToInt32(ReadLine());
    idades.Add(idade);
}

List<(string Nome, int Idade)> estudantes =  new List<(string, int)>();


for (int i = 0; i < nomes.Count; i++)
{
    estudantes.Add((nomes[i], idades[i]));
}

estudantes.Sort((a, b) => a.Idade.CompareTo(b.Idade));
var estudanteMaisNovo = estudantes[0];
var estudanteMaisVelho = estudantes[estudantes.Count - 1];
WriteLine("Estudantes ordenados por idade:");
foreach (var estudante in estudantes)
{
    WriteLine($"{estudante.Nome} - {estudante.Idade} anos");
}

WriteLine($"Estudante mais novo é o(a) {estudanteMaisNovo.Nome} com {estudanteMaisNovo.Idade} anos");
WriteLine($"Estudante mais velho é o(a) {estudanteMaisVelho.Nome} com {estudanteMaisVelho.Idade} anos");
ReadLine();

//Exercício 2

using System.Diagnostics.Contracts;
using static System.Console;
using static System.Convert;

List<(string Nome, double Nota)> turma = new List<(string, double)>();
for (int i = 1; i <= 10; i++)
{
    Write($"Digite o nome do {i}º aluno:\n ");
    string nome = ReadLine();

    Write($"Digite a nota do {i}º aluno:\n ");
    double nota = ToDouble(ReadLine());

    turma.Add((nome, nota));
}
double somaNotas = 0;
foreach (var aluno in turma)
{
    somaNotas += aluno.Nota;
}
double mediaNotas = somaNotas / turma.Count;
WriteLine("\nAlunos e suas notas:");
foreach (var aluno in turma)
{
    WriteLine($"{aluno.Nome} - {aluno.Nota}");
}

WriteLine($"Média da turma é de {mediaNotas:F2} pontos");
ReadLine();

//Exercício 3

using static System.Convert;
using static System.Console;


List<string> nomes = new List<string>();
List<int> idades = new List<int>();
for (int i = 0; i < 3; i++)
{
    WriteLine($"Digite o nome da candidata {i + 1}:");
    string nome = ReadLine();
    nomes.Add(nome);
    WriteLine($"Digite a idade da candidata {i + 1}:");
    int idade = ToInt32(ReadLine());
    idades.Add(idade);
}
List<string> candidatasAptas = new List<string>();
for (int i = nomes.Count - 1; i >= 0; i--)
{
    if (idades[i] < 18 || idades[i] > 20)
    {
        WriteLine($"A candidata {nomes[i]} não está apta para a campanha.");
        nomes.RemoveAt(i);
        idades.RemoveAt(i);
    }
    else
    {
        WriteLine($"A candidata {nomes[i]} aptas para a campanha.");
        foreach (string candidata in candidatasAptas)
        {
            WriteLine(candidata);
        }
    }
}

Exercício 4

using static System.Convert;
using static System.Console;


int[] V1 = new int[20];
int[] V2 = new int[20]; 
int iguais = 0;

WriteLine("Digite os 20 números para a lista V1:");
for (int i = 0; i < 20; i++)
{
    Write($"V1[{i}]: ");
    V1[i] = int.Parse(ReadLine());
}

WriteLine("\nDigite os 20 números para a lista V2:");
for (int i = 0; i < 20; i++)
{
    Write($"V2[{i}]: ");
    V2[i] = int.Parse(ReadLine());
}

for (int i = 0; i < 20; i++)
{
    if (V1[i] == V2[i])
    {
        iguais++;
    }
}

WriteLine($"Quantidade de valores idênticos nas mesmas posições: {iguais}");

Exercício 5

using static System.Console;
using static System.Convert;


double[] notas = new double[15];
int acimaDe7 = 0;
bool acimaDe5 = false;
double soma = 0;

WriteLine("Digite as notas dos 15 alunos:");
for (int i = 0; i < 15; i++)
{
    Write($"Nota do aluno {i + 1}: ");
    notas[i] = double.Parse(ReadLine());
    soma += notas[i];
    if (notas[i] > 7.0)
    {
        acimaDe7++;
    }
    else if (notas[i] > 5.0)
    {
        acimaDe5 = true;
    }
}

double media = soma / 15;

WriteLine($"Média das notas: {media:F2}");
WriteLine($"Quantidade de alunos com nota acima de 7.0: {acimaDe7}");

if (!acimaDe5)
{
    WriteLine("Não há nenhum aluno com nota acima de 5.");
}

Exercício 6

using static System.Console;
using static System.Convert;

double[] tempos = new double[12];
for (int i = 0; i < 12; i++)
{
    Write($"Tempo da volta {i + 1}: ");
    tempos[i] = double.Parse(ReadLine());
}

double melhorTempo = tempos[0];
int voltaMelhor = 1;
double soma = tempos[0];

for (int i = 1; i < 12; i++)
{
    soma += tempos[i];
    if (tempos[i] < melhorTempo)
    {
        melhorTempo = tempos[i];
        voltaMelhor = i + 1;
    }
}

double media = soma / 12;

WriteLine($"Melhor tempo: {melhorTempo:F2}");
WriteLine($"Volta do melhor tempo: {voltaMelhor}");
WriteLine($"Tempo médio das 12 voltas: {media:F2}");

Exercício 7

using static System.Console;
using static System.Convert;

Write("Quantos números deseja informar? ");
int quantidade = int.Parse(ReadLine());

List<int> numeros = new List<int>();

for (int i = 0; i < quantidade; i++)
{
    Write($"Digite o {i + 1}º número positivo: ");
    int num = int.Parse(ReadLine());
    if (num > 0) numeros.Add(num);
}

int soma = 0, maior = numeros[0];
foreach (int n in numeros)
{
    soma += n;
    if (n > maior) maior = n;
}

double media = (double)soma / numeros.Count;

WriteLine($"Média: {media:F2}");
WriteLine($"Maior número: {maior}");

Exercício 8

using static System.Console;
using static System.Convert;


Write("Quantos alunos deseja saber a media? ");
int n = int.Parse(ReadLine());

double[] G1 = new double[n];
double[] G2 = new double[n];
double[] medias = new double[n];

for (int i = 0; i < n; i++)
{
    Write($"Nota G1 do aluno {i + 1}: ");
    G1[i] = double.Parse(ReadLine());

    Write($"Nota G2 do aluno {i + 1}: ");
    G2[i] = double.Parse(ReadLine());

    medias[i] = (G1[i] + G2[i]) / 2;
}

WriteLine("\nNotas dos alunos:");
for (int i = 0; i < n; i++)
{
    WriteLine($"Aluno {i + 1} - G1: {G1[i]:F1}, G2: {G2[i]:F1}, Média: {medias[i]:F1}");
}

Exercício 9

using static System.Console;
using static System.Convert;


List<int> todos = new List<int>();
List<int> pares = new List<int>();
List<int> impares = new List<int>();

for (int i = 0; i < 10; i++)
{
    Write($"Digite o {i + 1}º número (maior que zero): ");
    int num = int.Parse(ReadLine());
    if (num > 0)
    {
        todos.Add(num);
        if (num % 2 == 0) pares.Add(num);
        else impares.Add(num);
    }
}

todos.Sort();
pares.Sort();
impares.Sort();

WriteLine("Todos os números: " + string.Join(", ", todos));
WriteLine("Números pares: " + string.Join(", ", pares));
WriteLine("Números ímpares: " + string.Join(", ", impares));

Exercício 10

using static System.Console;
using static System.Convert;

int[] gabarito = new int[13];

WriteLine("Digite o gabarito da loteria (13 números entre 1 e 3):");
for (int i = 0; i < 13; i++)
{
    Write($"Gabarito[{i + 1}]: ");
    gabarito[i] = int.Parse(ReadLine());
}

Write("\nQuantos apostadores deseja verificar? ");
int totalApostadores = int.Parse(ReadLine());

for (int a = 0; a < totalApostadores; a++)
{
    WriteLine($"\nApostador {a + 1}:");

    Write("Nome do apostador: ");
    string nome = ReadLine();

    Write("Número do cartão: ");
    string numeroCartao = ReadLine();

    int[] respostas = new int[13];
    WriteLine("Digite as 13 respostas do apostador (valores entre 1 e 3):");
    for (int i = 0; i < 13; i++)
    {
        Write($"Resposta[{i + 1}]: ");
        respostas[i] = int.Parse(ReadLine());
    }

    int acertos = 0;
    for (int i = 0; i < 13; i++)
    {
        if (respostas[i] == gabarito[i])
        {
            acertos++;
        }
    }

    WriteLine($"Apostador: {nome}");
    WriteLine($"Número do cartão: {numeroCartao}");
    WriteLine($"Número de acertos: {acertos}");

    if (acertos == 13)
    {
        WriteLine("Ganhador");
    }
}
