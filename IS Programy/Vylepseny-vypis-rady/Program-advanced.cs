string again = "a";

// Řídící cyklus programu
while (again.ToLower() == "a")
{
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("***************************");
    Console.WriteLine("******Výpis******Řady******");
    Console.WriteLine("*******Matyáš Dubský*******");
    Console.WriteLine("***************************");
    Console.WriteLine();

    // Vstup počáteční hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    // Vstup koncové hodnoty + kontrola, aby nebyla menší než první číslo
    int last;
    while (true) {
        Console.Write("Zadejte poslední číslo řady (celé číslo): ");
        if (int.TryParse(Console.ReadLine(), out last) && last >= first) {
            break; // Vstup je platný a koncové číslo je větší/rovno prvnímu, vyskočíme z cyklu
        }
        Console.WriteLine($"Chyba: Poslední číslo musí být větší nebo rono prvnímu ({first}). Zkuste to znovu.");
    }

    // Vstup diference s kontrolou kladného nenulového čísla
    Console.Write("Zadejte diferenci řady (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0) {
        Console.Write("Nezadali jste celé kladné číslo. Zadejte diferenci řady znovu: ");
    }

    // --- NOVÉ: Samotný výpis řady ---
    Console.WriteLine();
    Console.WriteLine("Výsledek řady:");
    
    // Cyklus projde od počáteční do koncové hodnoty s daným krokem
    for (int i = first; i <= last; i += step)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine(); // Odřádkování po skončení výpisu řady
    // ---------------------------------

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}