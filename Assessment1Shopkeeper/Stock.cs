using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This class hold information on how many of each item type you have and the names of each item type.
    /// The default varibles are used as a failsafe in the Load function.
    /// </summary>
    class Stock
    {
        public static int money = 500;
        public static int defaultMoney = 500;
        public static int weapons = 0;
        public static int defaultWeapons = 0;
        public static int armor = 0;
        public static int defaultArmor = 0;
        public static int tools = 0;
        public static int defaultTools = 0;
        public static int materials = 0;
        public static int defaultMaterials = 0;
        public static int food = 10;
        public static int defaultFood = 10;
        public static string[] itemNames = new string[5] { "Weapon", "Armor", "Tool", "Material", "Food" };
    }
    //These classes store the values of each item type which are used to set price ranges when buying, selling, and bartering.
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
        public static int value = 2;
    }
    class Food
    {
        public static int value = 5;
    }

}

