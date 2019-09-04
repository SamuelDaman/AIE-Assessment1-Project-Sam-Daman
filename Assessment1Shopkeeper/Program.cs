using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Shopkeeper
{
    class Program
    {
        static void Main()
        {
            Stock stock = new Stock();
            Console.WriteLine($"You have {Stock.money} gold and you need wares to sell in your new shop, what will you buy?");
            while (true)
            {
                bool doneShopping = false;
                while (doneShopping == false)
                {
                    Console.WriteLine($"What would you like to purchase?");
                    Console.WriteLine($"{Stock.itemNames[0]}: {Weapon.value}g, {Stock.itemNames[1]}: {Armor.value}g, {Stock.itemNames[2]}: {Tool.value}g, {Stock.itemNames[3]}: {Material.value}g, or {Stock.itemNames[4]}: {Food.value}g?");
                    Console.WriteLine($"Or if you're don't want to shop, Enter 'Done' instead.");
                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "Weapon":
                            Console.WriteLine("This will eventually allow you to buy a Weapon.");
                            break;
                        case "Armor":
                            Console.WriteLine("This will eventually allow you to buy Armor.");
                            break;
                        case "Tool":
                            Console.WriteLine("This will eventually allow you to buy a Tool.");
                            break;
                        case "Material":
                            Console.WriteLine("This will eventually allow you to buy some Material.");
                            break;
                        case "Food":
                            Console.WriteLine("This will eventually allow you to buy Food.");
                            break;
                        case "Done":
                            doneShopping = true;
                            break;
                        default:
                            Console.WriteLine("This will eventually allow you to buy nothing, because you're a loser who can't even spell words.");
                            break;
                    }
                }
                Console.WriteLine("I don't Actually have anything done yet, so you will have to wait.");
                Console.ReadLine();
            }
        }
    }
}
