﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This is the class used to start the game and call on other classes and functions.
    /// </summary>
    class Program
    {
        //The hoursPassed variable is used to keep track of how many hours have gone by.
        //defaultHoursPassed is what hoursPassed is set to if the Parse method in the Load function fails.
        public static int hoursPassed = 0;
        public static int defaultHoursPassed = 0;
        //The itemsAreOrdered bool keeps track of whether the player has ordered items from a smith.
        public static bool itemsAreOrdered = false;
        static void Main()
        {
            Stock stock = new Stock();
            //This boolean is used to check whether the player has lost.
            bool lose = false;
            //This is the intoductory text.
            Console.WriteLine($"You need wares to sell in your new shop.\r\n" +
                $"Be careful with your money, though.\r\n" +
                $"At the end of the day you will need to pay 10g in rent and consume three Food from your stock to stay alive.\r\n");
            Shopping.Shop();
            //This is the loop in which the main game takes place.
            while (true)
            {
                Console.WriteLine("Now, you can 'Check' your stock, 'Shop' for goods, 'Open' your shop, or use Material items to 'Craft' other items.");
                Console.WriteLine("Alternatively, you can 'Save' your game, 'Load' your saved game, or you can 'Quit' to exit the game.");
                //This reads the answer that the player types reacts accordingly.
                string action = Console.ReadLine().ToLower();
                switch (action)
                {
                    case "check":
                        Console.Clear();
                        Console.WriteLine($"money = {Stock.money}\r\nweapons = {Stock.weapons}\r\narmor = {Stock.armor}\r\ntools = {Stock.tools}\r\nmaterials = {Stock.materials}\r\nfood = {Stock.food}\r\nHours Passed = {hoursPassed}");
                        break;
                    case "shop":
                        Console.Clear();
                        Shopping.Shop();
                        hoursPassed++;
                        break;
                    case "open":
                        Console.Clear();
                        Shopkeeping.Shopkeep();
                        hoursPassed++;
                        break;
                    case "craft":
                        Console.Clear();
                        Crafting.Craft();
                        break;
                    case "save":
                        Console.Clear();
                        SaveGame.Save();
                        break;
                    case "load":
                        Console.Clear();
                        LoadGame.Load();
                        break;
                    case "quit":
                        return;
                    default:
                        Console.Clear();
                        break;
                }
                //This if statement checks if the day has ended.
                if (hoursPassed >= 9)
                {
                    //Here, the player receives the items they ordered from the smith.
                    if (itemsAreOrdered == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("In the morning, you receive your order from the blacksmith.");
                        if (Crafting.orderedItems[0] > 0)
                        {
                            Console.WriteLine($"{Crafting.orderedItems[0]} Weapons");
                            Stock.weapons += Crafting.orderedItems[0];
                            Crafting.orderedItems[0] = 0;
                        }
                        if (Crafting.orderedItems[1] > 0)
                        {
                            Console.WriteLine($"{Crafting.orderedItems[1]} suits of Armor");
                            Stock.armor += Crafting.orderedItems[1];
                            Crafting.orderedItems[1] = 0;
                        }
                        if (Crafting.orderedItems[2] > 0)
                        {
                            Console.WriteLine($"{Crafting.orderedItems[2]} Tools");
                            Stock.tools += Crafting.orderedItems[2];
                            Crafting.orderedItems[2] = 0;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        itemsAreOrdered = false;
                    }
                    //This checks if the player has enough food and money to survive.
                    if (Stock.food >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("At the end of the day, you consume three Food items from your stock.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Stock.food -= 3;
                    }
                    else if (Stock.food < 3)
                    {
                        if (Stock.money >= Food.value * 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"You don't have food on hand, so you spend {(Food.value * 3) - (Stock.food * Food.value)}g to get some.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Stock.money -= (Food.value * 3) - (Stock.food * Food.value);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You were unable to acquire food.");
                            Console.ForegroundColor = ConsoleColor.White;
                            lose = true;
                            break;
                        }
                    }
                    if (Stock.money >= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("And you pay 10g of rent.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Stock.money -= 10;
                    }
                    else if (Stock.money < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were unable to pay rent.");
                        Console.ForegroundColor = ConsoleColor.White;
                        lose = true;
                        break;
                    }
                    Console.WriteLine("");
                    hoursPassed = 0;
                } 
            }
            //This checks if the player has lost and notifies the player that they have lost.
            if (lose == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU LOSE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
        }
    }
}
