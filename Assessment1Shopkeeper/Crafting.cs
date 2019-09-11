using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Shopkeeper
{
    class Crafting
    {
        public static void Craft()
        {
            Console.WriteLine("Crafting takes Materials and time. Each time you craft an item one hour will go by.");
            while (true)
            {
                Console.WriteLine($"You have {Stock.materials}m, What would you like to craft?");
                Console.WriteLine($"{Stock.itemNames[0]} : 3m | {Stock.itemNames[1]} : 6m | {Stock.itemNames[2]} : 3m");
                Console.WriteLine("Or you can enter 'Done' to stop crafting.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "Weapon":
                        if (Stock.materials >= 3)
                        {
                            Console.WriteLine("You use 3 Material items to create a Weapon.");
                            Stock.materials -= 3;
                            Stock.weapons += 1;
                            Program.hoursPassed++;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough Material items to craft this.");
                        }
                        break;
                    case "Armor":
                        if (Stock.materials >= 6)
                        {
                            Console.WriteLine("You use 6 Material items to create Armor.");
                            Stock.materials -= 6;
                            Stock.armor += 1;
                            Program.hoursPassed++;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough Material items to craft this.");
                        }
                        break;
                    case "Tool":
                        if (Stock.materials >= 3)
                        {
                            Console.WriteLine("You use 3 Material items to create a Tool.");
                            Stock.materials -= 3;
                            Stock.tools += 1;
                            Program.hoursPassed++;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough Material items to craft this.");
                        }
                        break;
                    case "Done":
                        return;
                    default:
                        break;
                }
                if (Program.hoursPassed >= 9)
                {
                    return;
                }
            }
        }
    }
}
