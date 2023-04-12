using System;
using System.Collections.Generic;
using System.Text;


namespace FightingVideoGame
{

   static class VideoGame 
    {
       public class GameCharacter 
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Defense { get; set; }
 
            // IsAlive property
            public bool IsAlive
            {
                get { return Health > 0; }
            }
        }
        public static void Intructions()
        {
        //rules
        //This is a fighting game between Andrew Tate and Jake Paul
        //You will play as Andrew Tate and your goal is to defeat Jake Paul
        //every turn Andrew tate (you) will choose punch (p) or defend (d)
        //every turn Jake Paul will attack the player or defend himself
        //in order to win the game andrew tate must deal 100 damgae to Jake Paul
        //If Jake Paul does 100 damage to Andrew Tate (you) then he wins!
       
        //instructions
        Console.WriteLine("This is a fighting base game text game, so you can choose to punch (p) OR defend (d)");
        Console.WriteLine("You start off with 100 Health and need to defeat your opponent by attacking and getting there health to 0");
        Console.WriteLine("If you have no health left you lose the fight!");
        Console.WriteLine("If your opponent has 0 health remaining then you win the fight!");
        Console.WriteLine("");
        }
        public static void Dialogue()
        {
         //Game dialogue
        Console.WriteLine("Andrew Tates theme song starts playing");
        Console.WriteLine("Andrew Tate drives in with his bugatti");
        Console.WriteLine("The crowd starts chanting TOP G");
        Console.WriteLine("Jake Paul enteres the arena");
        Console.WriteLine("Everyone starts booing");
        Console.WriteLine("Both fighters enter the arena");
        Console.WriteLine("Andrew Tate says - ill give you a bugatti if you win");
        Console.WriteLine("Jake Paul then say if you win then ill never box again");
        Console.WriteLine("Referee says - FIGHT CLEAN, PROTECT YOURSELF AT ALL TIMES, TOUCH GLOVES WHEN READY, AND RESPECT EACHOTHER");
        Console.WriteLine("");
        } 
        public static void StartGame()
        {
          int EndMessages = 3;
            // Create the player character
            GameCharacter player = new GameCharacter();
            player.Name = "Andrew Tate";
            player.Health = 100;
 
            // Create the enemy character
            GameCharacter enemy = new GameCharacter();
            enemy.Name = "Jake";
            enemy.Health = 100;
 
            // Game loop
            int turn = 0;
            while (player.IsAlive && enemy.IsAlive)
            {
                // Print the current health of both characters
                Console.WriteLine(player.Name + ": " + player.Health + " health");
                Console.WriteLine(enemy.Name + ": " + enemy.Health + " health");
 
                // Check whose turn it is to attack
                if (turn % 2 == 0)
                {
                    // Player's turn to attack
 
                    // Prompt the player to attack or defend
                    Console.WriteLine("Enter 'p' to punch or 'd' to defend: ");
                    string input = Console.ReadLine();
 
                    // Attack or defend based on the player's input
                    if (input == "p")
                    {
                        // Generate a random attack damage value
                        Random rnd = new Random();
                        int attackDamage = rnd.Next(10, 21);
 
                        // Calculate the final damage value based on the enemy's defense
                        int finalDamage = attackDamage - enemy.Defense;
                       
                        if (finalDamage < 0)
                        {
                            finalDamage = 0;
                        }
 
                        // Apply the damage to the enemy's health
                        enemy.Health -= finalDamage;
 
                        // Print the attack message
                        Console.WriteLine(player.Name + " attacks " + enemy.Name + " for " + finalDamage + " damage!");
                    }
                    else if (input == "d")
                    {
                        // Increase the player's defense value
                        player.Defense += 5;
 
                        // Print the defend message
                        Console.WriteLine(player.Name + " defends against " + enemy.Name + "'s attack!");
                    }
                }
           
                else
                {
                    // Enemy's turn to attack
 
                    // Generate a random attack damage value
                    Random rnd = new Random();
                    int attackDamage = rnd.Next(10, 21);
 
                    // Calculate the final damage value based on the player's defense
                    int finalDamage = attackDamage - player.Defense;
                   
                    if (finalDamage < 0)
                    {
                        finalDamage = 0;
                    }
 
                    // Apply the damage to the player's health
                    player.Health -= finalDamage;
 
                    // Print the attack message
                    Console.WriteLine(enemy.Name + " punches " + player.Name + " for " + finalDamage + " damage!");
                }
 
                // Increment the turn counter
                turn++;
 
                //Use Of Switch
                switch (EndMessages)
                {
                case 1:
                    Console.WriteLine("The Crowd goes wild! ");
                    break;
                case 2:
                    Console.WriteLine("Everyone is shocked");
                    break;
                case 3:
                    Console.WriteLine("Nobody can believe what just happen");
                    break;
                case 4:
                    Console.WriteLine("Everyone is amazed");
                    break;
                case 5:
                    Console.WriteLine("Get pooped on");
                    break;
                case 6:
                    Console.WriteLine("get clapped nerd");
                    break;
                case 7:
                    Console.WriteLine("you got end gamed");
                    break;
                }
            }
           
           int counter = 0;  // The loop counter
 
                // Use a do-while loop to keep looping until the counter reaches 10
                do {
                    Console.WriteLine("Referee Counting - "  + counter );
 
                    // Increment the counter by 1 on each of the loop
                    counter++;
                } while (counter < 10);

                Console.WriteLine("Referee - HES OUT COLD!");

            // Print the game over message
            if (player.IsAlive)
            {
                Console.WriteLine("Congratulations, you defeated Jake Paul!");
            }
            else
            {
                Console.WriteLine("Game Over! You were defeated by Jake Paul.");
            }
        } 
        
        public static void EndGame()
        {
           for (int i = 0; i < 10; i++)
            {
                 Console.WriteLine(i);
            }
                Console.WriteLine("Years Later");
                Console.WriteLine("Andrew Tate walks into a coffe shop");
                Console.WriteLine("He notices Jake Paul sitting alone at a table by the window");
                Console.WriteLine("Andrew sits down next to Jake Paul");
                Console.WriteLine("And starts naming off everyone he has fought");

            //single dimensional array 
            string[] names = new string[3];

            // Assign values to the array
            names[0] = "Bruce Lee";
            names[1] = "Mike Tyson";
            names[2] = "Floyd Mayweather";

            // Access the values in the array using their index
            string firstName = names[0];
            string secondName = names[1];
            string thirdName = names[2];

            // Output the values in the array
            Console.WriteLine("I Fought " + firstName);
            Console.WriteLine("I Fought " + secondName);
            Console.WriteLine("I Fought " + thirdName);


            Console.WriteLine("Then Andrew says - But you my friend, you were the toughest of them all,");
            Console.WriteLine("They both stare at eachother and smile! Now they both respect eachother");
            Console.WriteLine("");
            Console.WriteLine("The End");
            Console.WriteLine("");
        } 
        } 
        
     }  
 
    
