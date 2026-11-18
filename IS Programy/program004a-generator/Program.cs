string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "A" nebo "a"
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    Console.Clear();
    // Hlavička programu
    Console.WriteLine("********************************");
    Console.WriteLine("********************************");
    Console.WriteLine("Generátor pseoudonáhodných čísel");
    Console.WriteLine("********************************");
    Console.WriteLine("*********Matyáš Dubský**********");
    Console.WriteLine("********************************");
    Console.WriteLine("********************************");

    // Počet generovaných čísel větších než 0
    Console.Write("Zadejte počet generovaných čísel větších než 0: ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0) {
        Console.Write("Nezadali jste přirozené číslo. Zadejte počet generovaných čísel znovu: ");
    }

    // Načení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }
    
    // Načení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno než dolní mez): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound) {
        Console.Write("Nezadali jste celé číslo větší nebo rovno než dolní meze. Zadejte horní mez znovu: ");
    }

    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"Počet generovaných čísel: {n}");
    Console.WriteLine($"Dolní mez: {lowerBound}");
    Console.WriteLine($"Horní mez: {upperBound}");  
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine();

    //Zde budeme pokračovat s konkrétním algoritmem
    

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter: ");
    Console.WriteLine("Zadáte-li cokoliv jiného, program se ukončí.");
    again = Console.ReadLine() ?? "";
    }