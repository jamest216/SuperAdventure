using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Quest
    {
        /// <summary>
        /// ID of the Quest
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the quest
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the Quest
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Reward EXP the Quest gives
        /// </summary>
        public int RewardExperiencePoints { get; set; }

        /// <summary>
        /// Rward Gold the Quest gives
        /// </summary>
        public int RewardGold { get; set; }

        /// <summary>
        /// Reward item from the Quest
        /// </summary>
        public Item RewardItem { get; set; }

        /// <summary>
        /// a list of quest competion items
        /// </summary>
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        /// <summary>
        /// Sets the quest
        /// </summary>
        /// <param name="id">ID of the quest</param>
        /// <param name="name">Name of the quest</param>
        /// <param name="description">Description of the quest</param>
        /// <param name="rewardExpereiencePoints">Reward EXP the quest gives</param>
        /// <param name="rewardGold">Reward gold the quest gives</param>
        public Quest(int id, string name, string description, int rewardExpereiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExpereiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
