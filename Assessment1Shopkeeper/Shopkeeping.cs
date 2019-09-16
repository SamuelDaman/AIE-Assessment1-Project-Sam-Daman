using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This class is used for selling to customers and bartering for the customer's goods.
    /// </summary>
    class Shopkeeping
    {
        public static void Shopkeep()
        {
            Random randomNumber = new Random();
            Customer currentCustomer = new Customer();
            //This uses a random number to decide which customer the player will deal with.
            int chosenCustomer = randomNumber.Next(0, 6);
            switch (chosenCustomer)
            {
                case 0:
                    currentCustomer = new Commoner();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You welcome a {currentCustomer.name} into your shop.\r\nThey have {currentCustomer.budget}g.\r\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    currentCustomer = new Merchant();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You welcome a {currentCustomer.name} into your shop.\r\nThey have {currentCustomer.budget}g.\r\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    currentCustomer = new Warrior();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You welcome a {currentCustomer.name} into your shop.\r\nThey have {currentCustomer.budget}g.\r\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    currentCustomer = new Knight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You welcome a {currentCustomer.name} into your shop.\r\nThey have {currentCustomer.budget}g.\r\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    currentCustomer = new Worker();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You welcome a {currentCustomer.name} into your shop.\r\nThey have {currentCustomer.budget}g.\r\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 5:
                    currentCustomer = new Craftsman();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You welcome a {currentCustomer.name} into your shop.\r\nThey have {currentCustomer.budget}g.\r\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Something has gone wrong; the game did a stupid.\r\n");
                    break;
            }
            //This checks if the player actually has any items to sell before allowing them to open up shop.
            if (Stock.weapons > 0 || Stock.armor > 0 || Stock.tools > 0 || Stock.materials > 0 || Stock.food > 0)
            {
                //This is the loop where the player will sell to the customer.
                for (int i = 0; i < currentCustomer.buyLimit; i++)
                {
                    int productNumber = randomNumber.Next(5);
                    switch (productNumber)
                    {
                        case 0:
                            if (Stock.weapons > 0)
                            {
                                if (currentCustomer.productInterest[productNumber] == true)
                                {
                                    Console.WriteLine($"The {currentCustomer.name} asks you what you want for this...");
                                    Console.WriteLine($"{Stock.itemNames[productNumber]}\r\nName your price.");
                                    Int32.TryParse(Console.ReadLine(), out int price);
                                    if (price <= Weapon.value * currentCustomer.priceLeniency && price <= currentCustomer.budget)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"The {currentCustomer.name} buys the {Stock.itemNames[productNumber]} for {price}g.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        currentCustomer.budget -= price;
                                        Stock.money += price;
                                        Stock.weapons -= 1;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {currentCustomer.name} refuses to buy it for that price");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        i++;
                                    }
                                }
                                else
                                {
                                    i--;
                                }
                            }
                            break;
                        case 1:
                            if (Stock.armor > 0)
                            {
                                if (currentCustomer.productInterest[productNumber] == true)
                                {
                                    Console.WriteLine($"The {currentCustomer.name} asks you what you want for this...");
                                    Console.WriteLine($"{Stock.itemNames[productNumber]}\r\nName your price.");
                                    Int32.TryParse(Console.ReadLine(), out int price);
                                    if (price <= Armor.value * currentCustomer.priceLeniency && price <= currentCustomer.budget)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"The {currentCustomer.name} buys the {Stock.itemNames[productNumber]} for {price}g.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        currentCustomer.budget -= price;
                                        Stock.money += price;
                                        Stock.armor -= 1;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {currentCustomer.name} refuses to buy it for that price");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        i++;
                                    }
                                }
                                else
                                {
                                    i--;
                                }
                            }
                            break;
                        case 2:
                            if (Stock.tools > 0)
                            {
                                if (currentCustomer.productInterest[productNumber] == true)
                                {
                                    Console.WriteLine($"The {currentCustomer.name} asks you what you want for this...");
                                    Console.WriteLine($"{Stock.itemNames[productNumber]}\r\nName your price.");
                                    Int32.TryParse(Console.ReadLine(), out int price);
                                    if (price <= Tool.value * currentCustomer.priceLeniency && price <= currentCustomer.budget)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"The {currentCustomer.name} buys the {Stock.itemNames[productNumber]} for {price}g.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        currentCustomer.budget -= price;
                                        Stock.money += price;
                                        Stock.tools -= 1;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {currentCustomer.name} refuses to buy it for that price");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        i++;
                                    }
                                }
                                else
                                {
                                    i--;
                                }
                            }
                            break;
                        case 3:
                            if (Stock.materials > 0)
                            {
                                if (currentCustomer.productInterest[productNumber] == true)
                                {
                                    Console.WriteLine($"The {currentCustomer.name} asks you what you want for this...");
                                    Console.WriteLine($"{Stock.itemNames[productNumber]}\r\nName your price.");
                                    Int32.TryParse(Console.ReadLine(), out int price);
                                    if (price <= Material.value * currentCustomer.priceLeniency && price <= currentCustomer.budget)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"The {currentCustomer.name} buys the {Stock.itemNames[productNumber]} for {price}g.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        currentCustomer.budget -= price;
                                        Stock.money += price;
                                        Stock.materials -= 1;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {currentCustomer.name} refuses to buy it for that price");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        i++;
                                    }
                                }
                                else
                                {
                                    i--;
                                }
                            }
                            break;
                        case 4:
                            if (Stock.food > 0)
                            {
                                if (currentCustomer.productInterest[productNumber] == true)
                                {
                                    Console.WriteLine($"The {currentCustomer.name} asks you what you want for this...");
                                    Console.WriteLine($"{Stock.itemNames[productNumber]}\r\nName your price.");
                                    Int32.TryParse(Console.ReadLine(), out int price);
                                    if (price <= Food.value * currentCustomer.priceLeniency && price <= currentCustomer.budget)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"The {currentCustomer.name} buys the {Stock.itemNames[productNumber]} for {price}g.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        currentCustomer.budget -= price;
                                        Stock.money += price;
                                        Stock.food -= 1;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {currentCustomer.name} refuses to buy it for that price");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        i++;
                                    }
                                }
                                else
                                {
                                    i--;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("No one comes in.");
                            break;
                    }
                }
                Console.WriteLine($"The {currentCustomer.name} is done buying from you.\r\nNow do you want to 'Barter' with them or 'Close' up shop?");
                //This reads the player's answer and either starts bartering or closes shop.
                string choice = Console.ReadLine().ToLower();
                for (int i = 0; i < currentCustomer.barterLimit; i++)
                {
                    switch (choice)
                    {
                        case "barter":
                            if (Stock.money > 0)
                            {
                                int itemChosen = randomNumber.Next(5);
                                switch (itemChosen)
                                {
                                    case 0:
                                        Console.WriteLine($"The {currentCustomer.name} is willing to sell their...\r\n{Stock.itemNames[itemChosen]}");
                                        Console.WriteLine("How much will you pay for it?");
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Int32.TryParse(Console.ReadLine(), out int payment);
                                            if (payment <= Stock.money)
                                            {
                                                if (payment >= Weapon.value / currentCustomer.barterTolerance)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine($"You purchase the {Stock.itemNames[itemChosen]} for {payment}g.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Stock.money -= payment;
                                                    Stock.weapons += 1;
                                                    break;
                                                }
                                                else if (j < 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} demands a higher price for the {Stock.itemNames[itemChosen]}.");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} gets frustrated and moves on.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        break;
                                    case 1:
                                        Console.WriteLine($"The {currentCustomer.name} is willing to sell their...\r\n{Stock.itemNames[itemChosen]}");
                                        Console.WriteLine("How much will you pay for it?");
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Int32.TryParse(Console.ReadLine(), out int payment);
                                            if (payment <= Stock.money)
                                            {
                                                if (payment >= Armor.value / currentCustomer.barterTolerance)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine($"You purchase the {Stock.itemNames[itemChosen]} for {payment}g.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Stock.money -= payment;
                                                    Stock.armor += 1;
                                                    break;
                                                }
                                                else if (j < 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} demands a higher price for the {Stock.itemNames[itemChosen]}.");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} gets frustrated and moves on.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine($"The {currentCustomer.name} is willing to sell their...\r\n{Stock.itemNames[itemChosen]}");
                                        Console.WriteLine("How much will you pay for it?");
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Int32.TryParse(Console.ReadLine(), out int payment);
                                            if (payment <= Stock.money)
                                            {
                                                if (payment >= Tool.value / currentCustomer.barterTolerance)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine($"You purchase the {Stock.itemNames[itemChosen]} for {payment}g.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Stock.money -= payment;
                                                    Stock.tools += 1;
                                                    break;
                                                }
                                                else if (j < 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} demands a higher price for the {Stock.itemNames[itemChosen]}.");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} gets frustrated and moves on.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine($"The {currentCustomer.name} is willing to sell their...\r\n{Stock.itemNames[itemChosen]}");
                                        Console.WriteLine("How much will you pay for it?");
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Int32.TryParse(Console.ReadLine(), out int payment);
                                            if (payment <= Stock.money)
                                            {
                                                if (payment >= Material.value / currentCustomer.barterTolerance)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine($"You purchase the {Stock.itemNames[itemChosen]} for {payment}g.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Stock.money -= payment;
                                                    Stock.materials += 1;
                                                    break;
                                                }
                                                else if (j < 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} demands a higher price for the {Stock.itemNames[itemChosen]}.");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} gets frustrated and moves on.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        break;
                                    case 4:
                                        Console.WriteLine($"The {currentCustomer.name} is willing to sell their...\r\n{Stock.itemNames[itemChosen]}");
                                        Console.WriteLine("How much will you pay for it?");
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Int32.TryParse(Console.ReadLine(), out int payment);
                                            if (payment <= Stock.money)
                                            {
                                                if (payment >= Food.value / currentCustomer.barterTolerance)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine($"You purchase the {Stock.itemNames[itemChosen]} for {payment}g.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Stock.money -= payment;
                                                    Stock.food += 1;
                                                    break;
                                                }
                                                else if (j < 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} demands a higher price for the {Stock.itemNames[itemChosen]}.");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {currentCustomer.name} gets frustrated and moves on.\r\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        default:
                            return;
                    }
                }
            }
            else
            {
                Console.WriteLine($"You have no items to sell and the {currentCustomer.name} leaves.");
            }
        }
    }
}
