using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
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
            float enemyHealth = 5.0f; 
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
            string playerDamage = "";
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
            Console.WriteLine("Are you a warrior or a wizard?");

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
            Console.WriteLine("Player armor: " + playerArmor);




            Console.WriteLine("You find yourself in a dark room, with the only light coming from rusted metal bars on the top of the wall.");
            Console.WriteLine("Will you choose to look around or wait for some time?");

            input = " ";

            while (input != "1" && input != "2")
            {
                Console.Write("(1 | 2) > ");
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                Console.WriteLine("You wander around the room until you bump into someone.");
                Console.WriteLine("Watch where you are going you moron the man yelled");
                Console.WriteLine("The man shoves you away, you trip on a loose stone and roll your ankle.");
                playerHealth -= 0.5f;
                Console.WriteLine("Health: " + playerHealth);
                Console.WriteLine("Do you want to keep looking for a way out or fight back against the other prisoner");

                input = " ";

                while (input != "1" && input != "2") 
                {
                    Console.Write("(1 | 2) > ");
                    input = Console.ReadLine();
                }
                if (input == "1")
                {
                    Console.WriteLine("You get back up on your feet and start limping around the room trying to find some way to escape");
                    Console.WriteLine("You find a door with a handle, you notice it is barely hanging onto the hinges.");
                    Console.WriteLine("You break open the door to find a long hallway, you can hear screaming from both sides.");
                    Console.WriteLine("Do you want to go left or right?");
                }
                else if (input == "2")
                {
                    Console.WriteLine("You lunge back at the prisoner, even though it is hard to see you can feel the crack of his jaw when your fist connects with his face.");
                    enemyHealth -= 1.0f;
                    Console.WriteLine("Enemy Health: " + enemyHealth);
                    Console.WriteLine("Sorry sir, I didnt mean any harm, please leave me alone.");
                    Console.WriteLine("Will you let the prisoner go or keep fighting him?");

                    input = " ";

                    while (input != "1" && input != "2")
                    {
                        Console.Write("(1 | 2) > ");
                        input = Console.ReadLine();
                    }
                    if (input == "1")
                    {


                    }
                    if (input == "1")
                    {


                    }
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("You wait for some time, all light has disappeared from the prsion you are in.");
                Console.WriteLine("Suddenly, you hear the clashing of swords and screams coming from a room down the hall.");
                Console.WriteLine("The door opens up to your cell and there is enough light to notice there is another prisoner in the room with you");
                Console.WriteLine("A soldier shows up with another one following him carrying weapons and equipment");
                Console.WriteLine("Listen, we do not have time to talk, but we have to move quickly.");
                Console.WriteLine("I can personally gurantee your freedom if you fight along side us, although the odds of survival are very low");
                Console.WriteLine("Do you want to join the soldier or try to escape the cell on your own?");
                input = " ";

                while (input != "1" && input != "2")
                {
                    Console.Write("1 | 2) > ");
                    input = Console.ReadLine();

                }
                if (input == "1")
                {
                    Console.WriteLine("You and the man in your cell decide to join the soldier in defending the castle");
                    Console.WriteLine("It is good to have you on our side, know that your names will go down as legendary if we are victorious today.");
                    Console.WriteLine("Now follow me, we do not have much time to spare.");
                    playerReputation += 5.0f;
                    Console.WriteLine("Reputation: " + playerReputation);
                    Console.WriteLine("You head up stairs after traveling in the prison hallways for some time");
                    Console.WriteLine("You arrive in a large ballroom area that has been destroyed by all of the chaos going on");
                    Console.WriteLine("A line of soldiers in silver armor are fighting a large troll in the middle of the room, behind them a woman is tending to a soldier's injuries.");
                    Console.WriteLine("Go for the knees it is their weakpoint yelled a soldier near the front");
                }
                if (input == "2")
                {
                    Console.WriteLine("You are useless to me then, get out of here while you can");
                    Console.WriteLine("You are crazy man im going with them murmured the other prisoner");
                    Console.WriteLine("You step out into the hallway, you hear screams coming from both directions, the soldiers head to the left.");
                    Console.WriteLine("Which way will you choose to go");
                }
            }
            
        }
       

    }
}
