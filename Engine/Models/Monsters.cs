﻿namespace Engine.Models
{
    public class Monsters : LivingEntity
    {
        public string ImageName { get; }
        public int MinimumDamage { get; }
        public int MaximumDamage { get; }
        public int RewardExperiencePoints { get; }
        public Monsters(string name, string imageName,
                       int maximumHitPoints, int currentHitPoints,
                       int minimumDamage, int maxmumDamage,
                       int rewardExperiencePoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            ImageName = $"/Engine;component/Images/Monsters/{imageName}";
            MinimumDamage = minimumDamage;
            MaximumDamage = maxmumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
        }
    }
}