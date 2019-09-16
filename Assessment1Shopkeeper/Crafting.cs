using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This is where the player is able to spend time to turn their material Items into weapons, armor, or tools.
    /// Or they can spend money and less materials for a smith to craft the items for them.
    /// </summary>
    class Crafting
    {
        public static CraftingMethod selfMethod = new CraftingMethod(3);
        public static CraftingMethod smithMethod = new CraftingMethod(1, 6);
        public static int[] orderedItems = new int[3];
        public static void Craft()
        {
            bool choosing = true;
            bool smithHired = false;
            while (choosing == true)
            {
                Console.WriteLine("Would you like to craft the items 'Yourself', or hire a 'Smith'?\r\n");
                Console.WriteLine("Crafting items yourself takes Materials and time. Each time you craft an item one hour will go by.\r\n");
                Console.WriteLine("Having a smith craft them for you will cost less materials but it will cost money.\r\nThe items the smith crafts will be delivered to you at the end of the day.\r\n");
                //This reads the player's choice.
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "yourself":
                        Console.WriteLine("You choose to craft the items yourself.");
                        smithHired = false;
                        choosing = false;
                        break;
                    case "smith":
                        Console.WriteLine("You hire a smith to make the items for you");
                        smithHired = true;
                        choosing = false;
                        break;
                    default:
                        break;
                }
            }
            //This is where the player spends time and materials to make items on their own.
            if (smithHired == false)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You have {Stock.materials}m, enter the name of the item you would like to craft.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{Stock.itemNames[0]} : {selfMethod.materialCost}m |" +
                        $" {Stock.itemNames[1]} : {selfMethod.materialCost * 2}m |" +
                        $" {Stock.itemNames[2]} : {selfMethod.materialCost}m");
                    Console.WriteLine("Or you can enter 'Done' to stop crafting.");
                    string answer = Console.ReadLine().ToLower();
                    switch (answer)
                    {
                        case "weapon":
                            if (Stock.materials >= selfMethod.materialCost)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"You use {selfMethod.materialCost} Material items to create a Weapon.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Stock.materials -= selfMethod.materialCost;
                                Stock.weapons += 1;
                                Program.hoursPassed++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have enough Material items to craft this.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "armor":
                            if (Stock.materials >= selfMethod.materialCost * 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"You use {selfMethod.materialCost * 2} Material items to create Armor.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Stock.materials -= selfMethod.materialCost * 2;
                                Stock.armor += 1;
                                Program.hoursPassed++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have enough Material items to craft this.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "tool":
                            if (Stock.materials >= selfMethod.materialCost)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"You use {selfMethod.materialCost} Material items to create a Tool.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Stock.materials -= selfMethod.materialCost;
                                Stock.tools += 1;
                                Program.hoursPassed++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have enough Material items to craft this.");
                                Console.ForegroundColor = ConsoleColor.White;
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
            //This is where the player spends money and materials to order items from a black smith.
            else if (smithHired == true)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You have {Stock.materials}m and {Stock.money}g, enter the name of the item you like would to craft.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{Stock.itemNames[0]} : {smithMethod.materialCost}m : {smithMethod.moneyCost}g |" +
                        $" {Stock.itemNames[1]} : {smithMethod.materialCost * 2}m : {smithMethod.moneyCost * 2}g |" +
                        $" {Stock.itemNames[2]} : {smithMethod.materialCost}m : {smithMethod.moneyCost}g");
                    Console.WriteLine("Or you can enter 'Done' if your order is complete");
                    string answer = Console.ReadLine().ToLower();
                    switch (answer)
                    {
                        case "weapon":
                            if (Stock.materials >= smithMethod.materialCost && Stock.money >= smithMethod.moneyCost)
                            {
                                Stock.materials -= smithMethod.materialCost;
                                Stock.money -= smithMethod.moneyCost;
                                orderedItems[0] += 1;
                                Program.itemsAreOrdered = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have enough for that.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "armor":
                            if (Stock.materials >= smithMethod.materialCost * 2 && Stock.money >= smithMethod.moneyCost * 2)
                            {
                                Stock.materials -= smithMethod.materialCost * 2;
                                Stock.money -= smithMethod.moneyCost * 2;
                                orderedItems[1] += 1;
                                Program.itemsAreOrdered = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have enough for that.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "tool":
                            if (Stock.materials >= smithMethod.materialCost && Stock.money >= smithMethod.moneyCost)
                            {
                                Stock.materials -= smithMethod.materialCost;
                                Stock.money -= smithMethod.moneyCost;
                                orderedItems[2] += 1;
                                Program.itemsAreOrdered = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have enough for that.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "done":
                            return;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
