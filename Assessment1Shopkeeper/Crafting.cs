﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    //This is where the player is able to spend time to turn their material Items into weapons, armor, or tools
    class Crafting
    {
        public static void Craft()
        {
            Console.WriteLine("Crafting takes Materials and time. Each time you craft an item one hour will go by.");
            while (true)
            {
                Console.WriteLine($"You have {Stock.materials}m, enter the name of the item you like to craft.");
                Console.WriteLine($"{Stock.itemNames[0]} : 3m | {Stock.itemNames[1]} : 6m | {Stock.itemNames[2]} : 3m");
                Console.WriteLine("Or you can enter 'Done' to stop crafting.");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "weapon":
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
                    case "armor":
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
                    case "tool":
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
                    case "done":
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
