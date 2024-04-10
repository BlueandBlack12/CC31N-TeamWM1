﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monsters : BaseNotificationClass
    {
        private int _hitPoints;
        public string Name { get; private set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }
        public int HitPoints
        {
            get { return _hitPoints; }
             set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }
        public ObservableCollection<ItemQuantity> Inventory { get; set; }
        public Monsters(string name, string imageName,
            int maximumHitPoints, int hitPoints,
            int minimumDamage, int maxmumDamage,
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = string.Format("pack://application:,,,/Engine;component/Images/Monsters/{0}", imageName);
            MaximumHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maxmumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}
