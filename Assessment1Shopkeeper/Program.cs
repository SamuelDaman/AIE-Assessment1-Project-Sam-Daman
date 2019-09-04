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
            Console.WriteLine($"You have {Stock.money} gold and you need wares to sell in your new shop, what will you buy?\r\n");
            Shopping.Shop();
            while (true)
            {
                Console.WriteLine("What to do now?");
                Console.WriteLine("You can 'Check' your stock, 'Shop' for goods, or 'Open' your shop");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "Check":
                        Console.WriteLine($"money = {Stock.money}\r\nweapons = {Stock.weapons}\r\narmor = {Stock.armor}\r\ntools = {Stock.tools}\r\nmaterials = {Stock.materials}\r\nfood = {Stock.food}\r\n");
                        break;
                    case "Shop":
                        Shopping.Shop();
                        break;
                    case "Open":
                        Console.WriteLine("The door refuses to open. It knows the game isn't complete yet.");
                        break;
                }
            }
        }
    }
}
