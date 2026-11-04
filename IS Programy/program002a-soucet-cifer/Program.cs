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
    Console.WriteLine("******Ciferný součet*******");
    Console.WriteLine("***************************");
    Console.WriteLine("*******Matyáš Dubský*******");
    Console.WriteLine("***************************");
    Console.WriteLine("***************************");

    // Načtení první hodnoty
    Console.Write("Zadejte číslo (celé číslo): ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }
    
    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"První číslo: {number};");
    Console.WriteLine("================================");
    //Console.WriteLine($"První číslo řady: {first}");
    //Console.WriteLine($"Poslední číslo řady: {last}");
    //Console.WriteLine($"Diference řady: {step}");
    Console.WriteLine();

    // Příprava pomocných proměnných
    int numberBackup = number;
    int sum = 0; //Neutrální hodnota pro sčítání
    int digit;   //Proměnná pro uložení jednotlivých číslic

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter: ");
    Console.WriteLine("Zadáte-li cokoliv jiného, program se ukončí.");
    again = Console.ReadLine() ?? "";
    }