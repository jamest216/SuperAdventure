using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Item
    {
        /// <summary>
        /// ID of the item
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// name of the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// plural name of the item
        /// </summary>
        public string NamePlural { get; set; }

        /// <summary>
        /// price of item
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// sets an item
        /// </summary>
        /// <param name="id">ID of the item</param>
        /// <param name="name">Name of the item</param>
        /// <param name="namePlural">Plural name of the item</param>
        public Item(int id, string name, string namePlural, int price)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Price = price;
        }
    }
}
