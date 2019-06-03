using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Engine
{
    public class InventoryItem : INotifyPropertyChanged
    {
        /// <summary>
        /// the Items ID
        /// </summary>
        public int ItemID
        {
            get { return Details.ID; }
        }

        /// <summary>
        /// Price of the item
        /// </summary>
        public int Price
        {
            get { return Details.Price; }
        }

        /// <summary>
        /// details property of an inventory item
        /// </summary>
        private Item _details;

        /// <summary>
        /// quantity of an inventory item
        /// </summary>
        private int _quantity;

        /// <summary>
        /// details of that inventory item
        /// </summary>
        public Item Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }

        /// <summary>
        /// gets / sets the quantity of the item
        /// </summary>
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// changes name from singular to plural if quantity ias more than 1
        /// </summary>
        public string Description
        {
            get
            {
                return Quantity > 1 ? Details.NamePlural : Details.Name;
            }
        }

        /// <summary>
        /// Sets the inventory
        /// </summary>
        /// <param name="details">detials of the inventory</param>
        /// <param name="quantity">AMT of inventory items</param>
        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }

        /// <summary>
        /// interface to detect wjem a prpoerty has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// sneses if property has been changed
        /// </summary>
        /// <param name="name">property being changed</param>
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }



    }
}
