using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This is the class used for buying items for a fixed price
    /// </summary>
    class Shopping
    {
        public static void Shop()
        {
            //The loop where the player can buy as many items as they can afford
            while (true)
            {
                Console.WriteLine($"You have {Stock.money} gold, enter the name of the item you want to purchase.");
                Console.WriteLine($"{Stock.itemNames[0]}: {Weapon.value}g | {Stock.itemNames[1]}: {Armor.value}g | {Stock.itemNames[2]}: {Tool.value}g | {Stock.itemNames[3]}: {Material.value}g | {Stock.itemNames[4]}: {Food.value}g");
                Console.WriteLine($"Or if you're don't want to shop, enter 'Done' instead.");
                //This reads the player's answer then allows them say how many of the chosen item they want to buy
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "weapon":
                        if (Stock.money >= Weapon.value)
                        {
                            Console.WriteLine("How many would you like to buy?");
                            Int32.TryParse(Console.ReadLine(), out int amount);
                            if (Stock.money < Weapon.value * amount)
                            {
                                Console.WriteLine("You can't afford that many.");
                                break;
                            }
                            else if (amount <= 0)
                            {
                                Console.WriteLine("You bought nothing.");
                                break;
                            }
                            Console.WriteLine("You have bought Weapons.");
                            Stock.money -= Weapon.value * amount;
                            Stock.weapons += amount;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to buy this.");
                        }
                        break;
                    case "armor":
                        if (Stock.money >= Armor.value)
                        {
                            Console.WriteLine("How many would you like to buy?");
                            Int32.TryParse(Console.ReadLine(), out int amount);
                            if (Stock.money < Armor.value * amount)
                            {
                                Console.WriteLine("You can't afford that many.");
                                break;
                            }
                            else if (amount <= 0)
                            {
                                Console.WriteLine("You bought nothing.");
                                break;
                            }
                            Console.WriteLine("You have bought Armor.");
                            Stock.money -= Armor.value * amount;
                            Stock.armor += amount;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to buy this.");
                        }
                        break;
                    case "tool":
                        if (Stock.money >= Tool.value)
                        {
                            Console.WriteLine("How many would you like to buy?");
                            Int32.TryParse(Console.ReadLine(), out int amount);
                            if (Stock.money < Tool.value * amount)
                            {
                                Console.WriteLine("You can't afford that many.");
                                break;
                            }
                            else if (amount <= 0)
                            {
                                Console.WriteLine("You bought nothing.");
                                break;
                            }
                            Console.WriteLine("You have bought Tools.");
                            Stock.money -= Tool.value * amount;
                            Stock.tools += amount;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to buy this.");
                        }
                        break;
                    case "material":
                        if (Stock.money >= Material.value)
                        {
                            Console.WriteLine("How many would you like to buy?");
                            Int32.TryParse(Console.ReadLine(), out int amount);
                            if (Stock.money < Material.value * amount)
                            {
                                Console.WriteLine("You can't afford that many.");
                                break;
                            }
                            else if (amount <= 0)
                            {
                                Console.WriteLine("You bought nothing.");
                                break;
                            }
                            Console.WriteLine("You have bought Materials.");
                            Stock.money -= Material.value * amount;
                            Stock.materials += amount;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to buy this.");
                        }
                        break;
                    case "food":
                        if (Stock.money >= Food.value)
                        {
                            Console.WriteLine("How many would you like to buy?");
                            Int32.TryParse(Console.ReadLine(), out int amount);
                            if (Stock.money < Food.value * amount)
                            {
                                Console.WriteLine("You can't afford that many.");
                                break;
                            }
                            else if (amount <= 0)
                            {
                                Console.WriteLine("You bought nothing.");
                                break;
                            }
                            Console.WriteLine("You have bought some Food.");
                            Stock.money -= Food.value * amount;
                            Stock.food += amount;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to buy this.");
                        }
                        break;
                    case "done":
                        return;
                    default:
                        Console.WriteLine("You have bought nothing, because you're a loser who can't even spell words.");
                        break;
                }
                //This is used to create a line break without putting "\r\n" at the end of every closing line in the case-switch
                Console.WriteLine("");
            }
        }
    }
}
