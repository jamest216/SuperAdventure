using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HealingPotion : Item
    {
        /// <summary>
        /// amount the potion heals
        /// </summary>
        public int AmountToHeal { get; set; }

        /// <summary>
        /// sets a potion
        /// </summary>
        /// <param name="id">ID of Potion</param>
        /// <param name="name">Name of Potion</param>
        /// <param name="namePlural">Plural name of Potion</param>
        /// <param name="amountToHeal">AMT the Potion heals</param>
        public HealingPotion(int id, string name, string namePlural, int amountToHeal, int price) : base(id, name, namePlural, price)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
