string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "A" nebo "a"
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    Console.Clear();
    // Hlavička programu
    Console.WriteLine("***************************");
    Console.WriteLine("***************************");
    Console.WriteLine("******Výpis******Řady******");
    Console.WriteLine("***************************");
    Console.WriteLine("*******Matyáš Dubský*******");
    Console.WriteLine("***************************");
    Console.WriteLine("***************************");


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";

}
