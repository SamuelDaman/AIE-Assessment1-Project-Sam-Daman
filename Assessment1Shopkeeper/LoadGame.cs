using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    class LoadGame
    {
        public static void Load()
        {
            string[] lines = new string[7];
            StreamReader reader = new StreamReader("GameWrite.txt");
            for (int i = 0; i < 7; i++)
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
            }
            catch (FormatException e)
            {
                throw;
            }
            reader.Close();
        }
    }
}
