
namespace Engine.Models
{
    public class Monsters : LivingEntity
    {

        public string ImageName { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; private set; }
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
