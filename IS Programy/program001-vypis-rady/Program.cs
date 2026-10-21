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

    // Vstup počáteční hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    // Vstup koncové hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last)) {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }

    // Vstup diference s kontrolou kladného  nenulového čísla
    Console.Write("Zadejte diferenci řady (kladné celé číslo): ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0) {
        Console.Write("Nezadali jste celé kladné číslo. Zadejte diferenci řady znovu: ");
    }
    
    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference: {step}");
    Console.WriteLine("================================");
    //Console.WriteLine($"První číslo řady: {first}");
    //Console.WriteLine($"Poslední číslo řady: {last}");
    //Console.WriteLine($"Diference řady: {step}");
    Console.WriteLine();

    // Výpis řady
    Console.WriteLine("Výpis čísel řady:");
    if(first <= last)
    {
        int current = first;
        while(current <= last)
        {
            Console.WriteLine(current);
            current = current + step;
            //stručněji zápis předchozího řádku
            //current += step;
        }


    }   
    else
    {
        Console.WriteLine("První číslo je větší než poslední");
        Console.WriteLine("Tento program umí vypsat vzestupnou řadu (od menšího k většímu číslu)");
    }
    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
    }