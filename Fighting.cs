using System;

namespace mis321_pa2_ChaseBuford
{
    public class Fighting   :   Character
    {
        public void player1Attack()
        {
            if (defensivePower > attackStrength2)
            {
                Console.WriteLine("Player 2 is uneffected");
                Console.ReadKey();
                Console.Clear();
            }
            if (attackStrength2 >= defensivePower)
            {
                Console.WriteLine("Player 2 Blocked " + defensivePower + " Damage!");
                health2 = defensivePower2 + health2 - attackStrength;
                if (health2 > 100)
                {
                    Console.WriteLine("Player 2's Defense Is Too Strong, Player 1 Surrenders. Press Any Key To End The Game");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Player 1 Delt " + attackStrength + " Damage!");
                Console.WriteLine(health2);
                Console.ReadKey();
                Console.Clear();
            }
            if (health > 100 && health2 > 100)
            {
                Console.WriteLine("This Match Is A Draw");
                Console.ReadKey();
                Environment.Exit(0);
                Console.Clear();
            }
        }
        public void player2Attack()
        {
            if (defensivePower2 > attackStrength)
            {
                Console.WriteLine("Player 1 Is Uneffected");
                Console.ReadKey();
                Console.Clear();
            }
            if (attackStrength >= defensivePower2)
            {
                Console.WriteLine("Player 1 Blocked " + defensivePower + " Damage!");
                health = defensivePower + health - attackStrength2;
                if (health > 100)
                {
                    Console.WriteLine("Player 1's Defense Is Too Strong, Player 2 Surrenders. Press Any Key To End The Game");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Player 2 Delt " + attackStrength2 + " Damage!");
                Console.WriteLine(health);
                Console.ReadKey();
                Console.Clear();
            }
            if (health > 100 && health2 > 100)
            {
                Console.WriteLine("This Match Is A Draw, Press Any Key To End The Game");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void GetBoost(string oppName, string charName)
        {
            if(oppName == "Will Turner")
            {
                attackStrength = attackStrength * 0.20 + attackStrength;
            }
            if (oppName == "Davy Jones")
            {
                attackStrength = attackStrength * 0.20 + attackStrength;
            }
            if (oppName == "Jack Sparrow")
            {
                attackStrength = attackStrength * 0.20 + attackStrength;
            }
            if(charName == "Will Turner")
            {
                attackStrength = attackStrength * 0.20 + attackStrength;
            }
            if (charName == "Davy Jones")
            {
                attackStrength = attackStrength * 0.20 + attackStrength;
            }
            if (charName == "Jack Sparrow")
            {
                attackStrength = attackStrength * 0.20 + attackStrength;
            }

        }
    }
}