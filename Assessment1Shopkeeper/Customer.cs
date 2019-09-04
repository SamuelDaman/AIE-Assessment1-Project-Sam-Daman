using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Shopkeeper
{
    class Customer
    {
        public static int budget;
        public static float priceLeniency;
        public static float barterTolerance;
        public static bool[] productInterest;
    }
    class Commoner : Customer
    {
        public static string name = "Commoner";
        public static int budget = 50;
        public static float priceLeniency = 1.5f;
        public static float barterTolerance = 1.5f;
        public static bool[] productInterest = new bool[5] { true, false, true, false, true };
    }
    class Merchant : Customer
    {
        public static string name = "Merchant";
        public static int budget = 1000;
        public static float priceLeniency = 1.1f;
        public static float barterTolerance = 1.25f;
        public static bool[] productInterest = new bool[5] { true, true, true, true, true };
    }
    class Warrior : Customer
    {
        public static string name = "Warrior";
        public static int budget = 100;
        public static float priceLeniency = 1.6f;
        public static float barterTolerance = 1.8f;
        public static bool[] productInterest = new bool[5] { true, true, false, false, true };
    }
    class Knight : Customer
    {
        public static string name = "Knight";
        public static int budget = 750;
        public static float priceLeniency = 1.5f;
        public static float barterTolerance = 1.5f;
        public static bool[] productInterest = new bool[5] { true, true, false, false, false };
    }
    class Worker : Customer
    {
        public static string name = "Worker";
        public static int budget = 75;
        public static float priceLeniency = 1.25f;
        public static float barterTolerance = 1.75f;
        public static bool[] productInterest = new bool[5] { false, false, true, true, true };
    }
    class Craftsman : Customer
    {
        public static string name = "Craftsman";
        public static int budget = 500;
        public static float priceLeniency = 1.5f;
        public static float barterTolerance = 1.5f;
        public static bool[] productInterest = new bool[5] { false, false, true, true, true };
    }
}
