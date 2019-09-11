using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    class SaveGame
    {
        public static void Save()
        {
            int[] lines = new int[7] { Stock.money, Stock.weapons, Stock.armor, Stock.tools, Stock.materials, Stock.food, Program.hoursPassed };
            StreamWriter writer = new StreamWriter("GameWrite.txt");
            foreach (int line in lines)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }
    }
}
