using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LootItem
    {
        /// <summary>
        /// Details of the loot item
        /// </summary>
        public Item Details { get; set; }

        /// <summary>
        /// Pecentage the item will drop
        /// </summary>
        public int DropPercentage { get; set; }

        /// <summary>
        /// is it a default item
        /// </summary>
        public bool IsDefaultItem { get; set; }

        /// <summary>
        /// Sets a loot item
        /// </summary>
        /// <param name="details">details of the loot item</param>
        /// <param name="dropPercentage">Percentage drop of the loot Item</param>
        /// <param name="isDefaultItem">is the item a default item</param>
        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}
