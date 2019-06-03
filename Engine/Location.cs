using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        /// <summary>
        /// ID of the location
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// name of the location
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the location
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the item required to enter
        /// </summary>
        public Item ItemRequiredToEnter { get; set; }

        /// <summary>
        /// the quests avaiable in this location
        /// </summary>
        public Quest QuestAvailableHere { get; set; }

        /// <summary>
        /// what monsters live here
        /// </summary>
        public Monster MonsterLivingHere { get; set; }

        /// <summary>
        /// whast the location to the north
        /// </summary>
        public Location LocationToNorth { get; set; }

        /// <summary>
        /// whast the location to the east
        /// </summary>
        public Location LocationToEast { get; set; }

        /// <summary>
        /// whats th locaation to the south
        /// </summary>
        public Location LocationToSouth { get; set; }

        /// <summary>
        /// whats the location to the west
        /// </summary>
        public Location LocationToWest { get; set; }


        public Vendor VendorWorkingHere { get; set; }

        /// <summary>
        /// sets a location
        /// </summary>
        /// <param name="id">ID of the location</param>
        /// <param name="name">Name of the location</param>
        /// <param name="description">Description of the location</param>
        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
