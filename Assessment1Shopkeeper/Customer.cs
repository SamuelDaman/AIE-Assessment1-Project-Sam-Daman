using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Shopkeeper
{
    class Customer
    {
        public int budget;
        public float priceLeniency;
        public float barterTolerance;
        public int productInterest;
    }
    class Commoner : Customer
    {
        public int budget = 50;
        public float priceLeniency = 1.5f;
        public float barterTolerance = 1.5f;
        public int productInterest = 0;
    }
    class Merchant : Customer
    {
        public int budget = 1000;
        public float priceLeniency = 1.1f;
        public float barterTolerance = 1.25f;
        public int productInterest = 0;
    }
    class Warrior : Customer
    {
        public int budget = 100;
        public float priceLeniency = 1.6f;
        public float barterTolerance = 1.8f;
        public int productInterest = 0;
    }
    class Knight : Customer
    {
        public int budget = 500;
        public float priceLeniency = 1.5f;
        public float barterTolerance = 1.5f;
        public int productInterest = 0;
    }
    class Worker : Customer
    {
        public int budget = 75;
        public float priceLeniency = 1.25f;
        public float barterTolerance = 1.75f;
        public int productInterest = 0;
    }
    class Craftsman : Customer
    {
        public int budget = 500;
        public float priceLeniency = 1.5f;
        public float barterTolerance = 1.5f;
        public int productInterest = 0;
    }
}
