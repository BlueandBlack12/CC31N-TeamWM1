using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public abstract class LivingEntity : BaseNotificationClass
    {
        private string _name;
        private int _currentHitPoints;
        private int _maximumHitPoints;
        private int _gold;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged(nameof(CurrentHitPoints));
            }
        }
        public int MaximumHitPoints
        {
            get { return _maximumHitPoints; }
            set
            {
                _maximumHitPoints = value;
                OnPropertyChanged(nameof(MaximumHitPoints));
            }
        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }
        public ObservableCollection<GameItems> Inventory { get; set; }
        public List<GameItems> Weapons =>
            Inventory.Where(i => i is Weapons).ToList();
        protected LivingEntity()
        {
            Inventory = new ObservableCollection<GameItems>();
        }
        public void AddItemToInventory(GameItems item)
        {
            Inventory.Add(item);
            OnPropertyChanged(nameof(Weapons));
        }
        public void RemoveItemFromInventory(GameItems item)
        {
            Inventory.Remove(item);
            OnPropertyChanged(nameof(Weapons));
        }
    }
}
