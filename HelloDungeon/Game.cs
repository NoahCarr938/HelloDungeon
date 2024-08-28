using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Game
    {
        public void Run()
        {
            string playername = "Bobilus";
            float playerHealth = 10.0f;
            float playerMana = 5.0f;
            string playerWeapon = "";
            string playerArmor = "";
            int playerGold = 3;
            float playerStamina = 20.0f;
            float playerReputation = 0.0f;
            int partyMembers = 0;
            int manaPotion = 1;
            int staminaPotion = 1;
            int healthPotion = 1;
            int playerScore = 0;
            string playerRole = "Warrior";
            string playerRole2 = "Wizard";
            bool isDead = false;
            


            Console.WriteLine("Hello, " + playername);
            Console.WriteLine();
            Console.WriteLine("Welcome to my dungeon!");
            Console.WriteLine();
            Console.WriteLine("Score: " + playerScore);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Mana: " + playerMana);
            Console.WriteLine("Stamina: " + playerStamina);
            Console.WriteLine("Current Weapon: " + playerWeapon);
            Console.WriteLine("Mana Potion: " + manaPotion);
            Console.WriteLine("Stamina Potion: " + staminaPotion);
            Console.WriteLine("Health Potion: " + healthPotion);
            Console.WriteLine("Gold: " + playerGold);
            Console.WriteLine("Reputation: " + playerReputation);
            Console.WriteLine("Party Members: " + partyMembers);
            Console.WriteLine();
            Console.WriteLine("Are you a warrior or a wizard.");

            string input = "";
            

            while (input != "1" && input != "2") 
            {
                Console.Write("(1 | 2) > ");    
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                playerRole = "Warrior";
                playerWeapon = "Sword";
                playerArmor = "Heavy";
            }
            else if (input == "2")
            {
                playerRole = "Wizard";
                playerWeapon = "Staff";
                playerArmor = "Light";
            }
            Console.WriteLine("Player role: " + playerRole);
            Console.WriteLine("Player Weapon: " + playerWeapon);

        }
       

    }
}
