
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Helpers;
namespace _05_Wines_Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("GU4_Wines_Interactive!");

        var rnd = new csSeedGenerator();
        WineCellar wineCellar = new WineCellar("Martin's cellar");

        /*
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
        */

        bool _continue = true;
        do
        {
            ShowMenu();

            int _intanswer;
            if (!csConsoleInput.TryReadInt32("Enter your selection", 1, 6, out _intanswer))
            {
                _continue = false;
                break;
            }

            switch (_intanswer)
            {
                case 1:
                    string _stringanswer = null;
                    if (_continue &&
                        !csConsoleInput.TryReadString("Enter name of winecellar", out _stringanswer))
                    {
                        _continue = false;
                    }
                    else
                    {
                        wineCellar.Name = _stringanswer;
                    }
                    Console.WriteLine($"\nWinecellars name is {wineCellar.Name}");
                    break;

                case 2:
                    Console.WriteLine($"\nList of wines in {wineCellar.Name}");
                    Console.WriteLine(wineCellar);
                    break;

                case 3:
                    Console.WriteLine($"\nAdded a wine to {wineCellar.Name}");
                    wineCellar.Add(new csWine().Seed(rnd));
                    break;

                case 4:
                    Console.WriteLine($"\nValue of {wineCellar.Name}: {wineCellar.Value:N2} Sek");
                    break;

                case 5:
                    Console.WriteLine($"\nHi Lo wines in {wineCellar.Name}");
                    var hilo = wineCellar.WineHiLoCost();
                    Console.WriteLine($"Most expensive wine:\n{hilo.hicost}");
                    Console.WriteLine($"Least expensive wine:\n{hilo.locost}");
                    break;

                case 6:
                    Console.WriteLine($"\nRemoved all wines from {wineCellar.Name}");
                    wineCellar.Clear();
                    break;
            }

        } while (_continue);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n\nMenu:");
        Console.WriteLine("1 - Give the winecellar a name");
        Console.WriteLine("2 - List with winecellar");
        Console.WriteLine("3 - Add one random wine bottle to the winecellar");
        Console.WriteLine("4 - Show the value of the winecellar");
        Console.WriteLine("5 - Show the hi and lo cost wines");
        Console.WriteLine("6 - Remove all the wines from the winecellar");
        Console.WriteLine("Q - Quit program");
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

