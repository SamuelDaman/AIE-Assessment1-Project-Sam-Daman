using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    class Program
    {
        public static int hoursPassed = 0;
        static void Main()
        {
            Stock stock = new Stock();
            bool win = false;
            bool lose = false;
            Console.WriteLine($"You need wares to sell in your new shop.\r\n" +
                $"Be careful with your money, though.\r\n" +
                $"At the end of the day you will need to pay 10g in rent and consume three Food from your stock to stay alive.");
            Shopping.Shop();
            while (win != true && lose != true)
            {
                Console.WriteLine("Now, you can 'Check' your stock, 'Shop' for goods, 'Open' your shop, or use Material items to 'Craft' other items.");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "Check":
                        Console.Clear();
                        Console.WriteLine($"money = {Stock.money}\r\nweapons = {Stock.weapons}\r\narmor = {Stock.armor}\r\ntools = {Stock.tools}\r\nmaterials = {Stock.materials}\r\nfood = {Stock.food}\r\nHours Passed = {hoursPassed}");
                        break;
                    case "Shop":
                        Console.Clear();
                        Shopping.Shop();
                        hoursPassed++;
                        break;
                    case "Open":
                        Console.Clear();
                        Shopkeeping.Shopkeep();
                        hoursPassed++;
                        break;
                    case "Craft":
                        Crafting.Craft();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                if (hoursPassed >= 9)
                {
                    if (Stock.food >= 3)
                    {
                        Console.WriteLine("At the end of the day, you consume three Food items from your stock.");
                        Stock.food -= 3;
                    }
                    else if (Stock.food < 3)
                    {
                        if (Stock.money >= 15)
                        {
                            Console.WriteLine($"You don't have food on hand, so you spend {15 - (Stock.food * 5)}g to get some.");
                            Stock.money -= 15 - (Stock.food * 5);
                        }
                        else
                        {
                            Console.WriteLine("You were unable to acquire food.");
                            lose = true;
                        }
                    }
                    if (Stock.money >= 10)
                    {
                        Console.WriteLine("And you pay 10g of rent.");
                        Stock.money -= 10;
                    }
                    else if (Stock.money < 10)
                    {
                        Console.WriteLine("You were unable to pay rent.");
                        lose = true;
                    }
                    hoursPassed = 0;
                } 
            }
            if (lose == true)
            {
                Console.WriteLine("You failed to pay rent and lost your house.");
                Console.WriteLine("YOU LOSE");
            }
            Console.ReadLine();
        }
    }
}
