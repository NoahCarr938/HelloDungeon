using System;
using System.Collections.Generic;
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
            int playerGold = 3;
            float playerStamina = 20.0f;
            float playerReputation = 0.0f;
            int partyMembers = 0;
            int manaPotion = 1;
            int staminaPotion = 1;
            int healthPotion = 1;
            int playerScore = 0;
            bool isDead = false;


            Console.WriteLine("Hello, " + playername);
            Console.WriteLine();
            Console.WriteLine("Welcome to my dungeon!");
            Console.WriteLine();
            Console.WriteLine("Score: " + playerScore);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Mana: " + playerMana);
            Console.WriteLine("Stamina: " + playerStamina);
            Console.WriteLine("Mana Potion: " + manaPotion);
            Console.WriteLine("Stamina Potion: " + staminaPotion);
            Console.WriteLine("Health Potion: " + healthPotion);
            Console.WriteLine("Gold: " + playerGold);
            Console.WriteLine("Reputation: " + playerReputation);
            Console.WriteLine("Party Members: " + partyMembers);
            Console.WriteLine();
            Console.WriteLine("You find yourself in a generic dungeon with two doors what door do you choose?");
         
        }
       

    }
}
