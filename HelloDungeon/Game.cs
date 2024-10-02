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
        bool gameOver = false;
        string playername = "Bobilus";
        float playerHealth = 10.0f;
        string playerWeapon = "";
        string playerArmor = "";
        int playerGold = 3;
        int playerScore = 0;
        string playerRole = "Warrior";
        string playerRole2 = "Wizard";
        bool playerIsAlive = true;
        int currentArea = 1;
        struct Player
        {
            // declaring variables in a Player
            public string name;
            public float health;
            public string weapon;
            public string armor;
            public int gold;
            public int score;

            //Player Constructor
            public Player(
                string name,
                float health,
                string weapon,
                string armor,
                int gold,
                int score)
            {
                this.name = name;
                this.health = health;
                this.weapon = weapon;
                this.armor = armor;
                this.gold = gold;
                this.score = score;
            }



        }
        /// <summary>
        /// Prints out the stats of the character who the player is using.
        /// </summary>
        static void PrintPlayerStats(Player player)
        {
            Console.WriteLine(player.name + " Health: " + player.health);
            Console.WriteLine(player.name + " Weapon: " + player.weapon);
            Console.WriteLine(player.name + " Armor: " + player.armor);
            Console.WriteLine(player.name + " Gold: " + player.gold);
            Console.WriteLine(player.name + " Score: " + player.score);
        }
        public void Run()
        {
            // Declaring the values of all of the player1 varaibles.
            Player player1 = new Player(name: "Player 1", health: 10.0f, weapon: "", armor: "", gold: 3, score: 0);

            PrintPlayerStats(player1);
            Console.WriteLine("----------------");


            // Start of the dialogue and the story.
            void Room1()
            {
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
                    Console.WriteLine("You look around and trip into a pit with a large beast in it.");
                    Console.WriteLine("The beast aproaches you and decides to eat you.");
                    Console.WriteLine();
                    Console.WriteLine("You Have Died");
                    playerIsAlive = false;
                }
                else if (input == 2)
                {
                    Console.WriteLine("You decide to wait for a while until suddenly the door to your cell is opened.");
                    Console.WriteLine("A man approaches you wearing bloodied knight armor.");
                    Console.WriteLine("Look, we do not have much time to talk, you must follow me. Orcs are attacking the castle and we need your help");

                }
            }
            void Room2()
            {
                Console.WriteLine("You follow the knight out into the dungeon hall when suddenly you hear orcs from down the hallway.");
                Console.WriteLine("Quick we must hide from them before they see us.");
                int input = GetInput("Do you want to hide or walk towards the orcs?", "Hide", "Walk towards the orcs");
                if (input == 1)
                {
                    Console.WriteLine("You and the soldier decide to hide from the orcs.");
                    Console.WriteLine("You hide behind some crates and hold your breath.");
                    Console.WriteLine("The orcs pass by you not suspceting you at all.");
                }
                else if (input == 2)
                {
                    Console.WriteLine("You decide to walk up to the orcs.");
                    Console.WriteLine("What are you doing they will kill you.");
                    Console.WriteLine("Well well, look who we have here.");
                    Console.WriteLine("The orcs catch both you and the knight and ready their weapons to execute you.");
                    Console.WriteLine("On second thought, we will let you two go if you can answer a simple question.");
                    Console.WriteLine("If a pirate dies and becomes a ghost would they be a pirate ghost or ghost pirate?");
                    input = GetInput("What is the answer?", "Pirate Ghost", "Ghost Pirate");
                    if (input == 1)
                    {
                        Console.WriteLine("Thank you, finally someone agrees. I told my friend Jonathon the same thing and we just kept on arguing.");
                        Console.WriteLine("Anyways you are free to go.");
                        Console.ReadKey();
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Nope, I am sorry but you are wrong.");
                        Console.WriteLine("A ghost pirate is a ghost that became a pirate, a pirate ghost is a pirate that dies and becomes a ghost.");
                        Console.WriteLine("You Have Died.");
                        playerIsAlive = false;
                    }
                }
            }
            void Room3()
            {
                Console.Clear();
                Console.WriteLine("You continue on with the soldier until you reach a pile of ruble blocking the way.");
                if (playerRole == "Wizard")
                {
                    Console.WriteLine("You are able to clear the rubble by using magic.");
                }
                else if (playerRole == "Warrior")
                {
                    Console.WriteLine("You were able to clear the rubble although it took close to an hour");
                }
                Console.WriteLine("You continue on when suddenly the soldier you are with stops you.");
                Console.WriteLine("Listen, you have not seen the battlefield but I have.");
                if (playerRole == "Wizard")
                {
                    Console.WriteLine("I say that you take the stairs further up, your magic would be very effective if you had a clear view of the enemy.");
                }
                else if (playerRole == "Warrior")
                {
                    Console.WriteLine("I say that you follow me to the front lines where you would be most effective.");
                }
                int input = GetInput("So, what will it be?", "Follow the soldier down", "Take the stairs up");
                if (input == 1)
                {
                    Console.WriteLine("You decide to follow the soldier downstairs to the battle.");
                    Console.WriteLine("As soon as you reach the battlefield you see a giant dragon fly over you");
                    input = GetInput("Do you want to head the other way or stay on the battlefield?", "Head the other way", "Stay on the battlefield");
                    if (input == 1)
                    {
                        Console.WriteLine("You decide that it is best to head back the other way.");
                        Console.WriteLine("I will stay here, good luck to you " + playername);
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("You decide to stay on the battlefield");
                        Console.WriteLine("Suddenly the dragon comes back out of nowhere a dragon shows up and burns you and the soldier you are with to death");
                        Console.WriteLine("You Have Died");
                        playerIsAlive = false;
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("You decide to take the stairs up to get a better view of the battle");
                }
            }
            // In this room the player gets a riddle to solve.
            void Room4()
            {
                int numberOfAttempts = 5;
                string input = "";

                // Loop until the player solves the riddle or dies.
                for (int i = 0; i < numberOfAttempts; i++)
                {
                    Console.Clear();
                    Console.WriteLine("When you reach the top of the stairs, a giant dragon flys over you.");
                    Console.WriteLine("It swoops in burning nearly a dozen knights on the battlefield");
                    Console.WriteLine();
                    Console.WriteLine("Before you notice it the dragon lands on the roof of the castle right in front of you");
                    Console.WriteLine("To your amazement the dragon talks, in a very deep voice");
                    Console.WriteLine("I am a bit bored, you humans are awfully easy to annihilate");
                    Console.WriteLine("If you can solve my riddle I will serve you until the end of your life");
                    Console.WriteLine("What begins with the letter t, is filled with t and ends with t?");
                    // Number of attempts the player has remaining.
                    int attemptsRemaining = numberOfAttempts - i;
                    // Displays the amount of remaining attempts.
                    Console.WriteLine("Attempts remaining: " + attemptsRemaining);
                    // Input for the player's guess.
                    Console.Write("> ");
                    input = Console.ReadLine();
                    // If the player answers correctly.
                    if (input == "teapot")
                    {
                        // The player gets feedback that they passed and the loop breaks.
                        Console.WriteLine("Good job, I will serve you for the rest of your life.");
                        Console.ReadKey();
                        break;
                    }
                    
                    {
                        // If the player does not answer correctly.
                        Console.WriteLine("Incorrect, the dragon breaths a light amount of fire on you dealing 4 damage.");
                        Console.ReadKey();
                        playerHealth -= 4.0f;
                    }
                    // If the player dies from guessing.
                    if (playerHealth <= 0)
                    {
                        playerIsAlive = false;
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            // The end of the game.
            void Room5()
            {
                Console.WriteLine("I will go and kill the orcs for you humans.");
                Console.WriteLine("The Dragon scorches the orc army leaving only the humans left standing");
                Console.WriteLine("Out of the corner a king approaches you.");
                Console.WriteLine("Congrats soldier, you have saved our kingdom. I will make you a Lord here and you will have whatever you desire.");
                playerScore += 100;
                Console.WriteLine("Score: " + playerScore);
            }
            void Room6()
            {
                Console.WriteLine("Congrats! you have completed the game!");
            }
            // Loop while the game is on.
            while (!gameOver)
            {
                if (currentArea == 1)
                {
                    Room1();
                }
                if (currentArea == 2)
                {
                    Room2();
                }
                if (currentArea == 3)
                {
                    Room3();
                }
                if (currentArea == 4)
                {
                    Room4();
                }
                if (currentArea == 5)
                {
                    Room5();
                }
                if (currentArea == 6)
                {
                    Room6();
                }

                if (playerIsAlive == false || currentArea == 6)
                {
                    DisplayMainMenu();
                }
                else
                {
                    currentArea++;
                }
            }
            // The menu for restarting or exiting the game.
            void DisplayMainMenu()
            {
                int input = GetInput("Do you want to play again?", "Yes", "No");

                if (input == 1)
                {
                    currentArea = 1;
                    gameOver = false;
                    playerIsAlive = true;
                    string playername = "Bobilus";
                    float playerHealth = 10.0f;
                    string playerWeapon = "";
                    string playerArmor = "";
                    int playerGold = 3;
                    int playerScore = 0;
                }
                else if (input == 2)
                {
                    gameOver = true;
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
