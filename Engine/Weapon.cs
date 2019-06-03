using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {

        /// <summary>
        /// Minimum DMG the Weapon can deal
        /// </summary>
        public int MinimumDamage { get; set; }

        /// <summary>
        /// Maximum DMG the Weapon can deal
        /// </summary>
        public int MaximumDamage { get; set; }

        /// <summary>
        /// Sets a weapon
        /// </summary>
        /// <param name="id">ID of the weapon</param>
        /// <param name="name">Name of the weapon</param>
        /// <param name="namePlural">PLural name of the weapon</param>
        /// <param name="minimumDamage">Min DMG the weapon does</param>
        /// <param name="maximumDamage">Max DMG the weapon does</param>
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int price) : base(id, name, namePlural, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
