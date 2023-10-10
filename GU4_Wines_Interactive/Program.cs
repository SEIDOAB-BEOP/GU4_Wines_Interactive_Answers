
using Helpers;
namespace _05_Wines_Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("GU4_Wines_Interactive!");

        var rnd = new csSeedGenerator();
        WineCellar wineCellar = new WineCellar("Martin's cellar");

        #region Add wines to the winecellar
        wineCellar.Add(new csWine().Seed(rnd));
        wineCellar.Add(new stWine().Seed(rnd));
        #endregion

        Console.WriteLine($"\nWinecellar: {wineCellar.Name}");
        //wineCellar.Wines = null;
        //wineCellar.Wines[0] = new csWine();
        Console.WriteLine(wineCellar);

        Console.WriteLine($"Nr of bottles: {wineCellar.Count}");
        Console.WriteLine($"Value of winecellar: {wineCellar.Value:N2} Sek");

        var hilo = wineCellar.WineHiLoCost();
        Console.WriteLine($"\nMost expensive wine:\n{hilo.hicost}");
        Console.WriteLine($"Least expensive wine:\n{hilo.locost}");

        Console.WriteLine("\nIndexers");
        for (int i = 0; i < wineCellar.Count; i++)
        {
            Console.WriteLine(wineCellar[i]);
        }
    }
}

/* Exercises
1. Modify code in Main() so the interaction with a user becomes menu driven
    1 - Give the winecellar a name
    2 - List with winecellar
    3 - Add one random wine bottle to the winecellar
    4 - Show the value of the winecellar
    5 - Show the hi and lo cost wines
    6 - Remove all the wines from the winecellar
    Q - Quit program

2. Implement all the menufunctions above, using csConsoleInput Helpers
*/

