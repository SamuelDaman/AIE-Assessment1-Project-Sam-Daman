using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    //This is the class used to start the game and call on other classes and functions
    class Program
    {
        //The hoursPassed variable is used to keep track of how many hours have gone by
        //defaultHoursPassed is what hoursPassed is set to if the Parse method in the Load function fails
        public static int hoursPassed = 0;
        public static int defaultHoursPassed = 0;
        static void Main()
        {
            Stock stock = new Stock();
            //Booleans used to check whether the player has won or lost
            bool win = false;
            bool lose = false;
            //Intoductory text
            Console.WriteLine($"You need wares to sell in your new shop.\r\n" +
                $"Be careful with your money, though.\r\n" +
                $"At the end of the day you will need to pay 10g in rent and consume three Food from your stock to stay alive.\r\n");
            Shopping.Shop();
            //The loop in which the main game takes place
            while (true)
            {
                Console.WriteLine("Now, you can 'Check' your stock, 'Shop' for goods, 'Open' your shop, or use Material items to 'Craft' other items.");
                Console.WriteLine("Or, you can 'Save' your game or 'Load' your saved game.");
                //This reads the answer that the player types reacts accordingly
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
                        Console.Clear();
                        Crafting.Craft();
                        break;
                    case "Save":
                        Console.Clear();
                        SaveGame.Save();
                        break;
                    case "Load":
                        Console.Clear();
                        LoadGame.Load();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                //If statements checking if you have enough food and money by the end of the day
                if (hoursPassed >= 9)
                {
                    if (Stock.food >= 3)
                    {
                        Console.WriteLine("At the end of the day, you consume three Food items from your stock.");
                        Stock.food -= 3;
                    }
                    else if (Stock.food < 3)
                    {
                        if (Stock.money >= Food.value * 3)
                        {
                            Console.WriteLine($"You don't have food on hand, so you spend {(Food.value * 3) - (Stock.food * Food.value)}g to get some.");
                            Stock.money -= (Food.value * 3) - (Stock.food * Food.value);
                        }
                        else
                        {
                            Console.WriteLine("You were unable to acquire food.");
                            lose = true;
                            break;
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
                        break;
                    }
                    hoursPassed = 0;
                } 
            }
            //This checks if the player has lost and notifies the player that they have lost
            if (lose == true)
            {
                Console.WriteLine("YOU LOSE");
            }
            Console.ReadLine();
        }
    }
}
