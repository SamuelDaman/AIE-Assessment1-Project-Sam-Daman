using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    //This class stores information on the customer that the player is currently interacting in the Shopkeep function
    class Customer
    {
        //The name of the customer
        public string name = "";
        //This checks how much money the customer is will to spend
        public int budget;
        //This decides how large of a price markup the customer is will accept
        public float priceLeniency;
        //This decides how low of a price they are willing to sell their items for when bartering
        public float barterTolerance;
        //This shows the number of items they're willing to buy
        public int buyLimit;
        //This shows the number of items they're willing sell when bartering
        public int barterLimit;
        //This checks what products they're willing to buy
        public bool[] productInterest;
    }
    //These classes store the information of each individual customer type
    class Commoner : Customer
    {
        public Commoner()
        {
            name = "Commoner";
            budget = 50;
            priceLeniency = 1.5f;
            barterTolerance = 2f;
            buyLimit = 3;
            barterLimit = 3;
            productInterest = new bool[5] { true, false, true, false, true };
        }
    }
    class Merchant : Customer
    {
        public Merchant()
        {
            name = "Merchant";
            budget = 1000;
            priceLeniency = 1.7f;
            barterTolerance = 1.25f;
            buyLimit = 7;
            barterLimit = 5;
            productInterest = new bool[5] { true, true, true, true, true };
        }
    }
    class Warrior : Customer
    {
        public Warrior()
        {
            name = "Warrior";
            budget = 200;
            priceLeniency = 1.6f;
            barterTolerance = 5f;
            buyLimit = 5;
            barterLimit = 6;
            productInterest = new bool[5] { true, true, false, false, true };
        }
    }
    class Knight : Customer
    {
        public Knight()
        {
            name = "Knight";
            budget = 1000;
            priceLeniency = 1.5f;
            barterTolerance = 2f;
            buyLimit = 7;
            barterLimit = 4;
            productInterest = new bool[5] { true, true, false, false, false };
        }
    }
    class Worker : Customer
    {
        public Worker()
        {
            name = "Worker";
            budget = 100;
            priceLeniency = 1.25f;
            barterTolerance = 4f;
            buyLimit = 5;
            barterLimit = 3;
            productInterest = new bool[5] { false, false, true, true, true };
        }
    }
    class Craftsman : Customer
    {
        public Craftsman()
        {
            name = "Craftsman";
            budget = 500;
            priceLeniency = 1.5f;
            barterTolerance = 2f;
            buyLimit = 6;
            barterLimit = 5;
            productInterest = new bool[5] { false, false, true, true, true };
        }
    }
}
