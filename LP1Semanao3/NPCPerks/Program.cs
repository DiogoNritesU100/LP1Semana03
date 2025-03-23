using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using HeroPerk;

internal class Program
{
    private static Perks[] npcPerks;
    private static int n;
    private static string? input;
    private static Perks perks;

    private static void Main(string[] args)
    {
        // Variables
        int numNPCs;

        // Ask for the number of NPCs
        Console.Write("How many NPC?");
        numNPCs = int.Parse(Console.ReadLine());

        // Create the array of NPC perks
        npcPerks = new Perks[numNPCs];

        //For each NPC, ask fot its perks
        for (int n = 0; n < numNPCs; n++);
        {
           // WarpShift?
           Console.WriteLine($"Does NPC {n} has WarpShift (y/n)? ");
           input = Console.ReadLine();
           if (input == "y")
           {
             npcPerks[n] |= Perks.WarpShift;
           }

           //Stealth?
           Console.WriteLine($"Does NPC {n} has Stealth (y/n)? ");
           input = Console.ReadLine();
           if (input == "y")
           {
             npcPerks[n] |= Perks.Stealth;
           }

           //AutoHeal?
           Console.WriteLine($"Does NPC {n} has AutoHeal (y/n)? ");
           input = Console.ReadLine();
           if (input == "y")
           {
             npcPerks[n] |= Perks.AutoHeal;
           }

           //DoubleJump?
           Console.WriteLine($"Does NPC {n} has DoubleJump (y/n)? ");
           input = Console.ReadLine();
           if (input == "y")
           {
             npcPerks[n] |= Perks.DoubleJump;
           }
        }

        // Show on screen the perks of all NPCs
        // If NPC has stealth & autoheal print special message
        foreach (Perks perks in npcPerks);
        {
            Perks special = Perks.Stealth | Perks.AutoHeal;
            Console.WriteLine($"NPC has {perks}");
            if ((perks & special) == special)
            {
                Console.WriteLine("\tHeal silently");
            } 
        }

    }
}