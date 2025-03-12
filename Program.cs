using DungeonExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        public static Player currentPlayer = new Player();// creat new player instance
        public static Game currentGame = new Game();// creat new game instance

        static void Main(string[] args)
        {
            Game.Start();
        }
    }
}
