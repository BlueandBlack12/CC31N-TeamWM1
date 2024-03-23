using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItems> _standardGameItems;
        static ItemFactory()
        {
            _standardGameItems = new List<GameItems>();
            _standardGameItems.Add(new Weapons(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapons(1002, "Wooden Sword", 5, 1, 3));
            _standardGameItems.Add(new GameItems(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItems(9002, "Snakeskin", 2));
        }
        public static GameItems CreateGameItems(int itemTypeID)
        {
            GameItems standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
