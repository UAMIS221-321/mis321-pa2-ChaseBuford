using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.IO;
using System.Collections.Generic;


namespace mis321_pa2_ChaseBuford
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to The Seven Seas Brawlers!");
            Console.WriteLine("\t\tPress any button");
            Console.ReadKey();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Character myChar = new Character();
            Fighting myFight = new Fighting();
            int userInput;
            Console.WriteLine("\t\tMain Menu:");
            Console.WriteLine("  1) Character Selection\n  2) Exit");
            userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                CharacterSelection(myChar, myFight);
            }
            if (userInput == 2)
            {
                Console.WriteLine("Have A Great Day!");
                Environment.Exit(0);
            }
            if (userInput != 1 || userInput != 2 || userInput == 3)
            {
                Console.WriteLine("Invalid Input, Press Any Key To Continue");
                Console.ReadKey();
                Menu();
            }
        }
        static void CharacterSelection(Character myChar, Fighting myFight)
        {
            Console.Clear();
            int userInput;
            Console.WriteLine("What character would you like to fight as?");
            Console.WriteLine(" 1) Jack Sparrow: Captain of the Black Pearl\n 2) Will Turner: Master Swords Man\n 3) Davy Jones: The Devil of the Seven Seas");
            userInput = int.Parse(Console.ReadLine());
            if(userInput == 1)
            {
                JackSparrow(myChar, myFight);
            }
            if (userInput == 2)
            {
                WillTurner(myChar, myFight);
            }
            if (userInput == 3)
            {
                DavyJones(myChar, myFight);
            }

            if (userInput != 1 || userInput != 2 || userInput != 3)
            {
                Console.WriteLine("Invalid Input, Press Any Key To Continue");
                Console.ReadKey();
                Menu();Console.WriteLine("Invalid Input, Press Any Key To Continue");
                Console.ReadKey();
                CharacterSelection(myChar, myFight);
            }
        }
        static void JackSparrow(Character myChar, Fighting myFight)
        {
            Console.Clear();
            string charName = "Jack Sparrow";
            string oppName;
            int userInput;
            int firstStrike;
            Console.WriteLine("Who's your opponent?");
            Console.WriteLine(" 1) Jack Sparrow: Captain of the Black Pearl\n 2) Will Turner: Master Swords Man\n 3) Davy Jones: The Devil of the Seven Seas");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your Max Power is {myChar.GetPower()}\nYour Attack Strength is {myChar.GetAttack()}\nYour Defense is {myChar.GetDefense()}");
            Console.ReadKey();
            Console.Clear();
            Random rand2 = new Random();
            firstStrike = rand2.Next(2)+1;
            if (userInput == 1)
            {
                oppName = "Jack Sparrow";
            }
            if (userInput == 2)
            {
                oppName = "Will Turner";
                myFight.GetBoost(oppName, charName);
            }
            if (userInput == 3)
            {
                oppName = "Davy Jones";
            }
            while (firstStrike == 1)
            {
                myFight.player1Attack();
                myFight.player2Attack();
                if (myFight.GetHealth() <= 0)
                {
                    Console.WriteLine("Player 2 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
                if (myFight.GetHealth2() <= 0)
                {
                    Console.WriteLine("Player 1 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
            }
            while (firstStrike == 2)
            {
                Console.WriteLine("Player 2 strikes");
                myFight.player2Attack();
                myFight.player1Attack();
                if (myFight.GetHealth() <= 0)
                {
                    Console.WriteLine("Player 2 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
                if (myFight.GetHealth2() <= 0)
                {
                    Console.WriteLine("Player 1 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
            }
        }
        static void WillTurner(Character myChar, Fighting myFight)
        {
            Console.Clear();
            string charName = "Will Turner";
            string oppName;
            int userInput;
            int firstStrike;
            Console.WriteLine("Who's your opponent?");
            Console.WriteLine(" 1) Jack Sparrow: Captain of the Black Pearl\n 2) Will Turner: Master Swords Man\n 3) Davy Jones: The Devil of the Seven Seas");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your Max Power is {myChar.GetPower()}\nYour Attack Strength is {myChar.GetAttack()}\nYour Defense is {myChar.GetDefense()}");
            Console.ReadKey();
            Console.Clear();
            Random rand2 = new Random();
            firstStrike = rand2.Next(2)+1;
            if (userInput == 1)
            {
                oppName = "Jack Sparrow";
            }
            if (userInput == 2)
            {
                oppName = "Will Turner";
                myFight.GetBoost(oppName, charName);
            }
            if (userInput == 3)
            {
                oppName = "Davy Jones";
            }
            while (firstStrike == 1)
            {
                Console.WriteLine("Player 1 uses distraction");
                myFight.player1Attack();
                myFight.player2Attack();
                if (myFight.GetHealth() <= 0)
                {
                    Console.WriteLine("Player 1 health " + myFight.GetHealth());
                    Console.WriteLine("Player 2 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
                if (myFight.GetHealth2() <= 0)
                {
                    Console.WriteLine("Player 2 health " + myFight.GetHealth2());
                    Console.WriteLine("Player 1 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
            }
            while (firstStrike == 2)
            {
                Console.WriteLine("Player 2 strikes");
                myFight.player2Attack();
                myFight.player1Attack();
                if (myFight.GetHealth() <= 0)
                {
                    Console.WriteLine("Player 1 health " + myFight.GetHealth());
                    Console.WriteLine("Player 2 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
                if (myFight.GetHealth2() <= 0)
                {
                    Console.WriteLine("Player 2 health " + myFight.GetHealth2());
                    Console.WriteLine("Player 1 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
        }
        }
        static void DavyJones(Character myChar, Fighting myFight)
        {
            Console.Clear();
            string charName = "Davy Jones";
            int userInput;
            string oppName;
            int firstStrike;
            Console.WriteLine("Who's your opponent?");
            Console.WriteLine(" 1) Jack Sparrow: Captain of the Black Pearl\n 2) Will Turner: Master Swords Man\n 3) Davy Jones: The Devil of the Seven Seas");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your Max Power is {myChar.GetPower()}\nYour Attack Strength is {myChar.GetAttack()}\nYour Defense is {myChar.GetDefense()}");
            Console.ReadKey();
            Console.Clear();
            Random rand2 = new Random();
            firstStrike = rand2.Next(2)+1;
            if (userInput == 1)
            {
                oppName = "Jack Sparrow";
                myFight.GetBoost(oppName, charName);
            }
            if (userInput == 2)
            {
                oppName = "Will Turner";
                myFight.GetBoost(oppName, charName);
            }
            if (userInput == 3)
            {
                oppName = "Davy Jones";
                myFight.GetBoost(oppName, charName);
            }
            while (firstStrike == 1)
            {
                Console.WriteLine("Player 1 uses distraction");
                myFight.player1Attack();
                myFight.player2Attack();
                if (myFight.GetHealth() <= 0)
                {
                    Console.WriteLine("Player 1 health " + myFight.GetHealth());
                    Console.WriteLine("Player 2 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
                if (myFight.GetHealth2() <= 0)
                {
                    Console.WriteLine("Player 2 health " + myFight.GetHealth2());
                    Console.WriteLine("Player 1 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
            }
            while (firstStrike == 2)
            {
                Console.WriteLine("Player 2 strikes");
                myFight.player2Attack();
                myFight.player1Attack();
                if (myFight.GetHealth() <= 0)
                {
                    Console.WriteLine("Player 1 health " + myFight.GetHealth());
                    Console.WriteLine("Player 2 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
                if (myFight.GetHealth2() <= 0)
                {
                    Console.WriteLine("Player 2 health " + myFight.GetHealth2());
                    Console.WriteLine("Player 1 is the winner");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Menu();
                }
            }
        }
    }
}