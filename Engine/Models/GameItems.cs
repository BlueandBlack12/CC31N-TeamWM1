
namespace Engine.Models
{
    public class GameItems
    {
        public int ItemTypeID { get; }
        public string Name { get; }
        public int Price { get; }
        public bool IsUnique { get; }
        public GameItems(int itemTypeID, string name, int price, bool isUnique = false)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            IsUnique = isUnique;
        }
        public GameItems Clone()
        {
            return new GameItems(ItemTypeID, Name, Price, IsUnique);
        }
    }
}
