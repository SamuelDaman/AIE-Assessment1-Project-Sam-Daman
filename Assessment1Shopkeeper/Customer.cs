using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Shopkeeper
{
    class Customer
    {
        public string name = "";
        public int budget;
        public float priceLeniency;
        public float barterTolerance;
        public bool[] productInterest;
    }
    class Commoner : Customer
    {
        public Commoner()
        {
            name = "Commoner";
            budget = 50;
            priceLeniency = 1.5f;
            barterTolerance = 2f;
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
            productInterest = new bool[5] { false, false, true, true, true };
        }
    }
}
