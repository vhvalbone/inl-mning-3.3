using System;
namespace inlämning_3._3;

class program
{
    static void Main()
    {
        int MaxkostnadPerDag = 950;
        int Timpris = 80;

        Console.Write("Hur många timmar vill du hyra en bil? ");
        int antalTimmar = int.Parse(Console.ReadLine());

        if (antalTimmar <= MaxkostnadPerDag / Timpris)
        {
            int kostnad = antalTimmar * Timpris;
            Console.WriteLine("Kostnaden för " + antalTimmar + " timmar är " + kostnad + " kr.");
        }
        else
        {
            Console.WriteLine("Kostnaden för " + antalTimmar + " timmar överstiger den maximala kostnaden per dag " + 950 + " kr. ");
        }
    }
}
