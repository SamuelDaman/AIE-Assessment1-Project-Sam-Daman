using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Shopkeeper
{
    class Stock
    {
        public static int money = 500;
        public static int weapons = 0;
        public static int armor = 0;
        public static int tools = 0;
        public static int materials = 0;
        public static int food = 0;
        public static string[] itemNames = new string[5] { "Weapon", "Armor", "Tool", "Material", "Food" };
    }
    class Weapon
    {
        public static int value = 10;
    }
    class Armor
    {
        public static int value = 20;
    }
    class Tool
    {
        public static int value = 10;
    }
    class Material
    {
        public static int value = 1;
    }
    class Food
    {
        public static int value = 5;
    }

}

