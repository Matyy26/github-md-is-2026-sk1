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


    //Ošetření záporných čísel (znaménko nemá vliv na číslice)
    if (number < 0)
    {
        number = -number;
    }

    //Zváštní příprad pro 0
    if (number == 0)
    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice (zprava)");

        //Matematický rozklad čísla pomocí cyklu
        //Využíváme operaci modulo - určení zbytku po celočíselném dělení
        while (number > 0)
        {
            digit = number % 10; //Modulo 10 - získáme poslední číslici
            sum = sum + digit; //Přičtení číslice k celkovému součtu

            Console.WriteLine($"Číslice: {digit}");

            number = number / 10; //Celočíselné dělení 10 odstraní poslední číslici
        }
    }

    //Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("================================"); 
    Console.WriteLine($"Ciferný součet čísla je {numberBackup} = {sum}");
    Console.WriteLine("================================");
    Console.WriteLine();

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter: ");
    Console.WriteLine("Zadáte-li cokoliv jiného, program se ukončí.");
    again = Console.ReadLine() ?? "";
    }