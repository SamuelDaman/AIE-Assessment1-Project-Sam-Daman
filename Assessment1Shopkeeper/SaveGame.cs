using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This writes the player's stock and hourPassed variables down to a copy of the GameWrite text file.
    /// The GameWrite copy will be deleted after closing the game, and so will the save. 
    /// </summary>
    class SaveGame
    {
        public static void Save()
        {
            int[] lines = new int[10] { Stock.money, Stock.weapons, Stock.armor, Stock.tools, Stock.materials, Stock.food, Program.hoursPassed, Crafting.orderedItems[0], Crafting.orderedItems[1], Crafting.orderedItems[2] };
            StreamWriter writer = new StreamWriter("GameWrite.txt");
            foreach (int line in lines)
            {
                writer.WriteLine(line);
            }
            writer.WriteLine(Program.itemsAreOrdered);
            writer.Close();
            StreamReader reader = new StreamReader("GameWrite.txt");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
        }
    }
}
