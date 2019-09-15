using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Shopkeeper
{
    /// <summary>
    /// This class contains information needed for crafting
    /// </summary>
    class CraftingMethod
    {
        public int materialCost;
        public int moneyCost;
        public CraftingMethod(int _materialCost)
        {
            materialCost = _materialCost;
        }
        public CraftingMethod(int _materialCost, int _moneyCost)
        {
            materialCost = _materialCost;
            moneyCost = _moneyCost;
        }
    }
}
