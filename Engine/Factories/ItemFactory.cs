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
            private static readonly List<GameItems> _standardGameItems = new List<GameItems>(); 
        static ItemFactory()
        {
            _standardGameItems = new List<GameItems>();
            _standardGameItems.Add(new Weapons(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapons(1002, "Wooden Sword", 5, 1, 3));
            _standardGameItems.Add(new GameItems(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItems(9002, "Snakeskin", 2));
            _standardGameItems.Add(new GameItems(9003, "Rat tail", 1));
            _standardGameItems.Add(new GameItems(9004, "Rat fur", 2));
            _standardGameItems.Add(new GameItems(9005, "Spider fang", 1));
            _standardGameItems.Add(new GameItems(9006, "Spider silk", 2));
            _standardGameItems.Add(new GameItems(9007, "Gold", 1));
            _standardGameItems.Add(new GameItems(9008, "Cloth", 2));
        }
        
            
        
        
        public static GameItems CreateGameItems(int itemTypeID)
        {
            GameItems standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                if (standardItem is Weapons)
                {
                    return (standardItem as Weapons).Clone();
                }
                return standardItem.Clone();
            }
            return null;
        }
    }
}
