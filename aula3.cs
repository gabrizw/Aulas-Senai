using static System.Console;
using static System.Convert;

string[] carrosF1 = { "Ferrari", "RedBull", "Mercedes", "Alpine", "Sauber", "Mclaren", "Alphatari ", "Haas", "Willians", "Astonmartin" };

WriteLine("Equipes dentro da Fórmula 1 em 2025:");
Array.Sort(carrosF1);
foreach (var item in carrosF1)
{
    WriteLine(item);
}


string novocarro = "Audi";
List<string> adnome = new List<string>(carrosF1.ToList());
adnome.Add(novocarro);
carrosF1 = adnome.ToArray();
WriteLine("Equipes dentro da Fórmula 1 em 2026:");
foreach (var item in carrosF1)
{
    WriteLine(item);
}

ReadLine(); 
