using System;
using System.Diagnostics;
using System.Media;

namespace DungeonExplorer
{
    internal class DungeonExplorerTests
    {
        public void TestPuckUpPotions()
        {
        
            var player = new Player();
            var initialPotionCount = player.potions;

            Player.pickUpItem("Potion");

            bool result = (initialPotionCount == initialPotionCount + 1);
            Debug.Assert(result, "Potion count increases by too much.");
        }
    }
}
