using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Engine.Models;


namespace Engine.Factories
{
    public static class MonstersFactory
    {
        public static Monsters GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monsters snake =
                        new Monsters("Snake", "Snake.png", 4, 4, 2, 3,  5, 1);
                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);
                    return snake;
                case 2:
                    Monsters rat =
                        new Monsters("Rat", "Rat.png", 5, 5, 2, 3, 5, 1);
                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);
                    return rat;
                case 3:
                    Monsters giantSpider =
                        new Monsters("Giant Spider", "Spider.png", 10, 10, 4, 5, 10, 3);
                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 75);
                    return giantSpider;
                case 4:
                    Monsters goblin = 
                    new Monsters("Goblin", "Goblin.png", 9, 9, 5, 6, 9, 3);
                    AddLootItem(goblin, 9007, 25);
                    AddLootItem(goblin, 9008, 75);
                    return goblin;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monsters monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItems(itemID));
            }
        }
    }
}
