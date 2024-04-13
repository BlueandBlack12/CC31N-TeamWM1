
namespace Engine.Models
{
    public class GameItems
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsUnique { get; set; }

        public GameItems(int itemTypeID, string name, int price, bool isUnique = false)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            IsUnique = isUnique;
            IsUnique = isUnique;
        }
        public GameItems Clone()
        {
            return new GameItems(ItemTypeID, Name, Price);
        }
    }
}
