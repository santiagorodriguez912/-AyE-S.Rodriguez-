//ejercicio 1
List<string> nombres = new List<string>()
{
    "Marlon",
    "Tramontana",
    "Aura_guler",
    "Paralelepipedo",
    "Umamiamor",
    "adolfo",
    "Calampa",
    "VivanLosGitanos",
    "Kirchnerista",
    "GitHubMiPasion",
    "SoyMoro",
    "CalleParaSiempre",
    "menganito",
    "Oreo",
    "OsoMaduro",

};
string Palabralarga = "";
for (int i = 0; i < nombres.Count; i++)
{
    if (nombres[i].Length > Palabralarga.Length)
    {
        Palabralarga = nombres[i];
    }
}
Console.WriteLine("la palabra mas larga es: " + Palabralarga);
