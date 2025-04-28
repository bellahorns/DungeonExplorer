using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        public static void Start()
        {
            bool victory = false; //the player has not yet won
            //call main game loop
            victory = mainGameLoop(victory);

            //Win or lose message
            if (victory == true)
                Game.Winner(); //win message

            else
                Game.Death(); //lose meaage
        }

        private static bool mainGameLoop(bool victory)
        {
            while (Program.currentPlayer.health > 0 && victory == false) //while the player is alive and they have no won, loop the game
            {
            storyStart(); // game intro
            Story(); //story filler after first fight
            while (Program.currentPlayer.roomCount <= 5 && Program.currentPlayer.health > 0) //wile loop for wile the player has not compled each room and the player is alive
            {
                    Rooms.roomActions(); //generate a new room
                    Program.currentPlayer.roomCount += 1; //add a room to the room count
            }
            if (Program.currentPlayer.roomCount == 6 && Program.currentPlayer.health > 0) //is statment to say the player has won if they are alive and have cmpleted all rooms
                victory = true;
            }
            return victory;
        }

        private static void storyStart()
        {
            Console.WriteLine("Welcome to the Dungeon!"); //welcome message

            //asking the user for their name
            Console.WriteLine("Name:");
            Program.currentPlayer.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You have woken up in the first room of the dungeon.");
            //if the user has not submitted a name they are toild their charecter cannot remember their name
            if (Program.currentPlayer.name == "")
                Console.WriteLine("You can't even remeber your name");
            //if the player did submit a name, it is shown back to them
            else
                Console.WriteLine("You can only remember that your name is " + Program.currentPlayer.name);
            Console.ReadKey();
            //Story elements ouputted
            Console.WriteLine("You feel around in the darkness and find a door. You quietly open it and go through.");
            Console.WriteLine("You see your captor in the next room, facing away from you.");
            Encounters.FirstEncounter();
        }

        private static void Story()
        {
            Console.Clear();
            //story text, guiding the user and explaining the objective of the next part of the game
            Console.WriteLine("With your captor dead on the floor you deside to go through his pockets.");
            Console.WriteLine("There isn't much, but you find a crumpled up peice of paper in his pocket.");
            Console.WriteLine("It looks like... a map! There are 5 rooms till the exit. It's time to start your escape...");
            Console.WriteLine("You go through the next door.");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Winner()
        {
            Console.Clear();
            //Text telling the user they won
            Console.WriteLine("Opening the last door you step out into the warm outside air.");
            Console.WriteLine("You did it! You escaped the dungoen! Congratulations!");
            Console.WriteLine("Thank you for playing Dungeon Explorer.");
            Console.WriteLine("Click any key to close the window.");
            Console.ReadKey();
        }

        private static void Death()
        {
            Console.Clear();
            //Text telling the user they died
            Console.WriteLine("You didn't make it out the dungeon, you died.");
            Console.WriteLine("commiserations.");
            Console.WriteLine("Thank you for playing Dungeon Explorer.");
            Console.WriteLine("Click any key to close the window.");
            Console.ReadKey();
        }
    }
}