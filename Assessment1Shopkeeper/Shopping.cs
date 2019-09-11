using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    class Shopping
    {
        public static void Shop()
        {
            while (true)
            {
                Console.WriteLine($"You have {Stock.money} gold, What would you like to purchase?");
                Console.WriteLine($"{Stock.itemNames[0]}: {Weapon.value}g | {Stock.itemNames[1]}: {Armor.value}g | {Stock.itemNames[2]}: {Tool.value}g | {Stock.itemNames[3]}: {Material.value}g | {Stock.itemNames[4]}: {Food.value}g");
                Console.WriteLine($"Or if you're don't want to shop, Enter 'Done' instead.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "Weapon":
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
                    case "Armor":
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
                    case "Tool":
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
                    case "Material":
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
                    case "Food":
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
                    case "Done":
                        return;
                    default:
                        Console.WriteLine("You have bought nothing, because you're a loser who can't even spell words.");
                        break;
                }
                Console.WriteLine($"You have {Stock.money}g.\r\n");
            }
        }
    }
}
