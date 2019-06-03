using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class QuestCompletionItem
    {
        /// <summary>
        /// details of the quest completion item
        /// </summary>
        public Item Details { get; set; }

        /// <summary>
        /// the AMT of quest comption items
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// sets a quest completion item
        /// </summary>
        /// <param name="details"></param>
        /// <param name="quantity"></param>
        public QuestCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
