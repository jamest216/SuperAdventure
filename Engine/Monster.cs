using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster : LivingCreature
    {
        /// <summary>
        /// ID of the Monster
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the Monster
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Max Damage the Monster can deal
        /// </summary>
        public int MaximumDamage { get; set; }

        /// <summary>
        /// Amount of EXP the monster gives
        /// </summary>
        public int RewardExperiencePoints { get; set; }

        /// <summary>
        /// Amount of gold the monster gives
        /// </summary>
        public int RewardGold { get; set; }

        /// <summary>
        /// a list of loot
        /// </summary>
        public List<LootItem> LootTable { get; set; }

        /// <summary>
        /// Sets a Monster
        /// </summary>
        /// <param name="id">ID of the Monster</param>
        /// <param name="name">Name of the monster</param>
        /// <param name="maximumDamage">Max DMG the Monster can deal</param>
        /// <param name="rewardExperiencePoints">Reward EXP the monster gives</param>
        /// <param name="rewardGold">Reward gold the monster gives</param>
        /// <param name="currentHitPoints">Current HP the monster has</param>
        /// <param name="maximumHitPoints">Max HP the monster has</param>
        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
