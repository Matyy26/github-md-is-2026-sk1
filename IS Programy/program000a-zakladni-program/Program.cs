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
    Console.WriteLine("*******Název programu******");
    Console.WriteLine("***************************");
    Console.WriteLine("*******Matyáš Dubský*******");
    Console.WriteLine("***************************");
    Console.WriteLine("***************************");

    // Načtení první hodnoty
    Console.Write("Zadejte číslo (celé číslo): ");
    int xxx;
    while(!int.TryParse(Console.ReadLine(), out xxx)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    // Načení dalšího čísla
    Console.Write("Zadejte další číslo (celé číslo): ");
    int yyy;
    while(!int.TryParse(Console.ReadLine(), out yyy)) {
        Console.Write("Nezadali jste celé číslo. Zadejte další číslo znovu: ");
    }
    
    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"První číslo: {xxx}; Poslední číslo: {yyy};");
    Console.WriteLine("================================");
    //Console.WriteLine($"První číslo řady: {first}");
    //Console.WriteLine($"Poslední číslo řady: {last}");
    //Console.WriteLine($"Diference řady: {step}");
    Console.WriteLine();

    //Zde budeme pokračovat s konkrétním algoritmem

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
    }