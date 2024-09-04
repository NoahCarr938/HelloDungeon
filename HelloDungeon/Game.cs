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
        /// <summary>
        /// Contains all of the player variables
        /// </summary>
        struct Player
        {
            // declaring variables in a Player
            public string name;
            public float health;
            public float mana;
            public string weapon;
            public string armor;
            public int gold;
            public float stamina;
            public float reputation;
            public int members;
            public int manapotion;
            public int staminapotion;
            public int healthpotion;
            public int score;

            //Player Constructor
            public Player(
                string name,
                float health,
                float mana,
                string weapon,
                string armor,
                int gold,
                float stamina,
                float reputation,
                int members,
                int manapotion,
                int staminapotion,
                int healthpotion,
                int score)
            {
                this.name = name;
                this.health = health;
                this.mana = mana;
                this.weapon = weapon;
                this.armor = armor;
                this.gold = gold;
                this.stamina = stamina;
                this.reputation = reputation;
                this.members = members;
                this.manapotion = manapotion;
                this.staminapotion = staminapotion;
                this.healthpotion = healthpotion;
                this.score = score;
            }

       

        }
        /// <summary>
        /// Prints out the stats of the character who the player is using.
        /// </summary>
        static void PrintPlayerStats(Player player)
        {
            Console.WriteLine(player.name + " Health: " + player.health);
            Console.WriteLine(player.name + " Mana: " + player.mana);
            Console.WriteLine(player.name + " Weapon: " + player.weapon);
            Console.WriteLine(player.name + " Armor: " + player.armor);
            Console.WriteLine(player.name + " Gold: " + player.gold);
            Console.WriteLine(player.name + " Stamina: " + player.stamina);
            Console.WriteLine(player.name + " Reputation: " + player.reputation);
            Console.WriteLine(player.name + " Members: " + player.members);
            Console.WriteLine(player.name + " ManaPotion: " + player.manapotion);
            Console.WriteLine(player.name + " StaminaPotion: " + player.staminapotion);
            Console.WriteLine(player.name + " HealthPotion: " + player.healthpotion);
            Console.WriteLine(player.name + " Score: " + player.score);
        }
        public void Run()
        {
            // Declaring the values of all of the player1 varaibles.
            Player player1 = new Player(name: "Player 1", health: 10.0f, mana: 5.0f, weapon: "", armor: "", gold: 3, stamina: 20.0f, reputation: 0.0f, members: 0, manapotion: 1, staminapotion: 1, healthpotion: 1, score: 0);

            PrintPlayerStats(player1);
            Console.WriteLine("----------------");

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

            // Start of the dialogue and the story.

            Console.WriteLine("Hello, " + playername);
            Console.WriteLine();
            Console.WriteLine("Welcome to my dungeon!");
            Console.WriteLine();
            int input = GetInput("Are you a warrior or a wizard?", "Warrior", "Wizard");
            // Player gets to choose their class.
            if (input == 1)
            {
                playerRole = "Warrior";
                playerWeapon = "Sword";
                playerArmor = "Heavy";
            }
            else if (input == 2)
            {
                playerRole = "Wizard";
                playerWeapon = "Staff";
                playerArmor = "Light";
            }
            Console.WriteLine("Player role: " + playerRole);
            Console.WriteLine("Player Weapon: " + playerWeapon);
            Console.WriteLine("Player armor: " + playerArmor);
            Console.WriteLine();
            Console.WriteLine("Ahh a " + playerRole);
            Console.WriteLine("Maybe you have a chance to survive after all.");
            Console.WriteLine("Well anyway, good luck I wish you the best. I would love to meet you in person but I don't think that you will get the chance to do so.");



            Console.WriteLine("You find yourself in a dark room, with the only light coming from rusted metal bars on the top of the wall.");
             input = GetInput("Will you choose to look around or wait for some time?", "Look around", "Wait for some time");
            if (input == 1)
            {
                Console.WriteLine("You wander around the room until you bump into someone.");
                Console.WriteLine("Watch where you are going you moron the man yelled");
                Console.WriteLine("The man shoves you away, you trip on a loose stone and roll your ankle.");
                playerHealth -= 0.5f;
                Console.WriteLine("Player Health: " + playerHealth);
                 input = GetInput("Do you want to keep looking for a way out or fight back against the other prsioner?", "Keep looking around", "Fight back");
                if (input == 1)
                {
                    Console.WriteLine("You get back up on your feet and start limping around the room trying to find some way to escape");
                    Console.WriteLine("You find a door with a handle, you notice it is barely hanging onto the hinges.");
                    Console.WriteLine("You break open the door to find a long hallway, you can hear screaming from both sides.");
                    Console.WriteLine("Do you want to go left or right?");
                    input = GetInput("Do you want to go left or right?", "Go left", "Go right");
                    if (input == 1)
                    {
                        Console.WriteLine("You decide to go left, you eventually reach a set of stairs and decide to go up them.");
                        Console.WriteLine("At the top of the stairs a fight between soldiers and a troll is taking place.");
                        Console.WriteLine("A nurse approaches you, I noticed that you were limping, here let me fix your ankle.");
                        playerHealth += 0.5f;
                        Console.WriteLine("Player Health: " + playerHealth);
                    }
                    if (input == 2)
                    {
                        Console.WriteLine("You decide to go right,");
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("You lunge back at the prisoner, even though it is hard to see you can feel the crack of his jaw when your fist connects with his face.");
                    enemyHealth -= 1.0f;
                    Console.WriteLine("Enemy Health: " + enemyHealth);
                    Console.WriteLine("Sorry sir, I didnt mean any harm, please leave me alone.");
                     input = GetInput("Will you let the prisoner go or keep fighting him?", "Let the prisoner go", "Keep fighting him");
                    if (input == 1)
                    {
                        Console.WriteLine("You decide that it is best to let the prisoner go.");
                        Console.WriteLine("Thank you sir for leaving me alone.");
                        Console.WriteLine("I made a foolish mistake thank you for forgiving me.");
                        // The player's reputation increases by 1.
                        playerReputation += 1.0f;
                        Console.WriteLine("Player Repuation: " + playerReputation);
                    }
                    if (input == 2)
                    {
                        Console.WriteLine("You decide to keep fighting the prisoner.");
                        Console.WriteLine("You leap towards the disoriented prisoner and keep on punching him until you hear no breathing coming from him");
                        enemyHealth -= 4.0f;
                        Console.WriteLine("Enemy has been killed.");
                        playerScore += 1;
                        Console.WriteLine("Player Score: " + playerScore);
                    }
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("You wait for some time, all light has disappeared from the prsion you are in.");
                Console.WriteLine("Suddenly, you hear the clashing of swords and screams coming from a room down the hall.");
                Console.WriteLine("The door opens up to your cell and there is enough light to notice there is another prisoner in the room with you");
                Console.WriteLine("A soldier shows up with another one following him carrying weapons and equipment");
                Console.WriteLine("Listen, we do not have time to talk, right now we have to move quickly.");
                Console.WriteLine("I can personally gurantee your freedom if you fight along side us, although the odds of survival are very low");
                 input = GetInput("Do you want to join the soldier or try to escape the cell on your own?", "Join the soldier", "Try to escape the cell on your own");
                if (input == 1)
                {
                    Console.WriteLine("You and the man in your cell decide to join the soldier in defending the castle");
                    Console.WriteLine("It is good to have you on our side, know that your names will go down as legendary if we are victorious today.");
                    Console.WriteLine("Now follow me, we do not have much time to spare.");
                    playerReputation += 5.0f;
                    Console.WriteLine("Player Reputation: " + playerReputation);
                    Console.WriteLine("You head left going up stairs after traveling in the prison hallways for some time");
                    Console.WriteLine("You arrive in a large ballroom area that has been destroyed by all of the chaos going on");
                    Console.WriteLine("A line of soldiers in silver armor are fighting a large troll in the middle of the room, behind them a woman is tending to a soldier's injuries.");
                    Console.WriteLine("Go for the knees it is their weakpoint yelled a soldier near the front");
                }
                if (input == 2)
                {
                    Console.WriteLine("You are useless to me then, get out of here while you can");
                    Console.WriteLine("You are crazy man im going with them murmured the other prisoner");
                    Console.WriteLine("You step out into the hallway, you hear screams coming from both directions, the soldiers head to the left.");
                    Console.WriteLine("Which way will you choose to go");
                    input = GetInput("Which way will you choose to go?", "Go left", "Go right");
                    if (input == 1)
                    {
                        Console.WriteLine("You chose to go left");
                        Console.WriteLine("You decide to follow behind the soldiers from a distance");
                        Console.WriteLine("You follow them up a set of stairs, you arrive in a large ballroom where a group of soldiers are fighting a giant troll");

                    }
                    if (input == 2)
                    {
                        Console.WriteLine("You chose to go right");
                        Console.WriteLine("Blood and dead soldiers line the hallway and the sound of danger is getting closer and closer");
                        Console.WriteLine("You see a group of orcs down the hallway.");
                        input = GetInput("Do you play dead or walk up to the orcs?", "Play dead", "Walk up to the orcs");
                        if (input == 1)
                        {
                            Console.WriteLine("You decide to play dead");
                            Console.WriteLine("The orcs start stabbing the dead soldiers and the soldiers who are on their last breath");
                            Console.WriteLine("Before you can even react you get stabbed in your chest");
                            Console.WriteLine("It takes all of your strength to not yell");
                            // The player loses 5.0 health.
                            playerHealth -= 5.0f;
                            Console.WriteLine("Player Health: " + playerHealth);
                            Console.WriteLine("Eventually the orcs pass by you, heading to the direction that you came from");
                            input = GetInput("Your health is at half, would you like to use a health potion?", "Yes", "No");
                            if (input == 1)
                            {
                                Console.WriteLine("You chose to use a health potion");
                                // The player regains 2.5 health.
                                playerHealth += 2.5f;
                                healthPotion -= 1;
                                Console.WriteLine("Player Health: " + playerHealth);
                                Console.WriteLine("Health potions: " + healthPotion);
                                Console.WriteLine("The bleeding from your wound has stopped and you gather the strength to stand up.");
                                Console.WriteLine("You continue to follow the hallway to the left, hundreds of slain soldiers are on the ground as you pass.");
                                Console.WriteLine("A broken down door at the end of the hallway leads to a cellar.");
                                Console.WriteLine("The cellar is even darker than the prison cell that you came from.");
                            }
                            if (input == 2)
                            {
                                Console.WriteLine("You chose to not use a health potion");
                                Console.WriteLine("The wound is sadly fatal.");
                                // The player dies.
                                playerHealth -= 5.0f;
                                Console.WriteLine("Player Health: " + playerHealth);
                                Console.WriteLine("You have died.");
                                input = 0; 

                             
                            }
                        }
                        if (input == 2)
                        {
                            Console.WriteLine("You decide to walk up to the orcs.");
                            Console.WriteLine("Look at him, he's a prisoner here. What should we do with him boss.");
                            Console.WriteLine("A bigger orc comes from out the crowd of orcs.");
                            Console.WriteLine("Well it is clear that he did not want to fight with the knights.");
                            Console.WriteLine("What is your name?");
                            Console.WriteLine(playername + " hmm what an interesting name.");
                            Console.WriteLine("It sounds rather familiar.");
                            Console.WriteLine("Follow me " + playername + " We are going to take this castle.");
                        }
                    }
                }
            }
            
        }
       
        int GetInput(string description, string option1, string option2)
        {
            string input = "";
            int inputReceived = 0;

            // Input loop
            while (inputReceived != 1 && inputReceived != 2)
            {
                // Print options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                // Get input from player
                input = Console.ReadLine();

                // If player selected the first option
                if (input == "1" || input == option1)
                {
                    // Set inputReceived to be the first option
                    inputReceived = 1;
                }
                // Otherwise if the player selected the second option
                else if (input == "2" || input == option2)
                {
                    // Set inputReceived to be the second option
                    inputReceived = 2;
                }
                // If neither are true
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }
            Console.Clear(); 
            return inputReceived;
        }
    }
}
