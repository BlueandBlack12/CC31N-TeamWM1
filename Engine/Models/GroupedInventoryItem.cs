namespace Engine.Models
{
    public class GroupedInventoryItem : BaseNotificationClass
    {
        private GameItems _item;
        private int _quantity;
        public GameItems Item
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }
        public GroupedInventoryItem(GameItems item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}