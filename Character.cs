using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.IO;
namespace mis321_pa2_ChaseBuford
{
    public class Character
    {
        public string name {get; set;}
        public int maxPower {get; set;}
        public double health {get; set;}
        public double attackStrength {get; set;}
        public double defensivePower {get; set;}
        public string name2 {get; set;}
        public int maxPower2 {get; set;}
        public double health2 {get; set;}
        public double attackStrength2 {get; set;}
        public double defensivePower2 {get; set;}
        public Character()
        {
            health = 100;
            Random rand1 = new Random();
            maxPower = rand1.Next(100)+1;
            Random rand2 = new Random();
            attackStrength = rand2.Next(maxPower)+1;
            Random rand3 = new Random();
            defensivePower = rand3.Next(maxPower)+1;
            health2 = 100;
            Random rand4 = new Random();
            maxPower2 = rand4.Next(100)+1;
            Random rand5 = new Random();
            attackStrength2 = rand5.Next(maxPower2)+1;
            Random rand6 = new Random();
            defensivePower2 = rand6.Next(maxPower2)+1;
        }
        public double GetHealth()
        {
            return health;
        }
        public double GetHealth2()
        {
            return health2;
        }
        public double GetPower()
        {
            return maxPower;
        }
        public double GetAttack()
        {
            return attackStrength;
        }
        public double GetDefense()
        {
            return defensivePower;
        }
        public double GetPower2()
        {
            return maxPower;
        }
        public double GetAttack2()
        {
            return attackStrength;
        }
        public double GetDefense2()
        {
            return defensivePower;
        }
        
    }
}