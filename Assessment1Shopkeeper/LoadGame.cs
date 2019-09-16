using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This reads the GameWrite file copy and sets the stock and hoursPassed variables equal to the values written there.
    /// If the values aren't valid it sets them equal to the default variables instead.
    /// The GameWrite copy is deleted when closing the game, so you can not load a game from a previous play session.
    /// </summary>
    class LoadGame
    {
        public static void Load()
        {
            string[] lines = new string[11];
            StreamReader reader = new StreamReader("GameWrite.txt");
            for (int i = 0; i < 11; i++)
            {
                lines[i] = reader.ReadLine();
                Console.WriteLine(lines[i]);
            }
            try
            {
                Stock.money = Int32.Parse(lines[0]);
                Stock.weapons = Int32.Parse(lines[1]);
                Stock.armor = Int32.Parse(lines[2]);
                Stock.tools = Int32.Parse(lines[3]);
                Stock.materials = Int32.Parse(lines[4]);
                Stock.food = Int32.Parse(lines[5]);
                Program.hoursPassed = Int32.Parse(lines[6]);
                Crafting.orderedItems[0] = Int32.Parse(lines[7]);
                Crafting.orderedItems[1] = Int32.Parse(lines[8]);
                Crafting.orderedItems[2] = Int32.Parse(lines[9]);
                Program.itemsAreOrdered = Boolean.Parse(lines[10]);
            }
            catch (Exception e)
            {
                Stock.money = Stock.defaultMoney;
                Stock.weapons = Stock.defaultWeapons;
                Stock.armor = Stock.defaultArmor;
                Stock.tools = Stock.defaultTools;
                Stock.materials = Stock.defaultMaterials;
                Stock.food = Stock.defaultFood;
                Program.hoursPassed = Program.defaultHoursPassed;
                Crafting.orderedItems[0] = 0;
                Crafting.orderedItems[1] = 0;
                Crafting.orderedItems[2] = 0;
                Program.itemsAreOrdered = false;
            }
            reader.Close();
        }
    }
}
