using System;
using Engine;
using System.Windows.Forms;
namespace SuperAdventure
{
    public partial class TradingScreen : Form
    {
        private Player _currentPlayer;
        public TradingScreen(Player p)
        {
            _currentPlayer = p;
            InitializeComponent();
            
            //style to display numeric column values
            DataGridViewCellStyle rightAlignedCellStyle = new DataGridViewCellStyle();
            rightAlignedCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //populate the datagrid for the player's inventory
            uxMyItemsGrid.RowHeadersVisible = false;
            uxMyItemsGrid.AutoGenerateColumns = false;

            //hidden column holds the itemID, so we know which item to sell
            uxMyItemsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemID",
                Visible = false
            });

            uxMyItemsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 100,
                DataPropertyName = "Description"
            });

            uxMyItemsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Qty",
                Width = 30,
                DefaultCellStyle = rightAlignedCellStyle,
                DataPropertyName = "Quantity"
            });

            uxMyItemsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Width = 35,
                DefaultCellStyle = rightAlignedCellStyle,
                DataPropertyName = "Price"
            });

            uxMyItemsGrid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Sell 1",
                UseColumnTextForButtonValue = true,
                Width = 100,
                DataPropertyName = "ItemID"
            });

            //bind the player's inventory to the datagrid
            uxMyItemsGrid.DataSource = _currentPlayer.Inventory;

            //when the user clicks ona row, call this function
            uxMyItemsGrid.CellClick += uxMyItemsGrid_CellClick;

            //populate the datagrid for the vendor's inventory
            uxVendorItemsGrid.RowHeadersVisible = false;
            uxVendorItemsGrid.AutoGenerateColumns = false;

            //hidden column holds the item ID, so we know which item to sell
            uxVendorItemsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemID",
                Visible = false
            });

            uxVendorItemsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 100,
                DataPropertyName = "Description"
            });

            uxVendorItemsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Width = 35,
                DefaultCellStyle = rightAlignedCellStyle,
                DataPropertyName = "Price"
            });

            uxVendorItemsGrid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Buy 1",
                UseColumnTextForButtonValue = true,
                Width = 50,
                DataPropertyName = "ItemID"
            });

            //binds the vendor's inventory to the datagridview
            uxVendorItemsGrid.DataSource = _currentPlayer.CurrentLocation.VendorWorkingHere.Inventory;

            //when the user clicks on a row, call this function
            uxVendorItemsGrid.CellClick += uxVendorItemsGrid_CellClick;

            
        }

        private void uxMyItemsGrid_CellClick(object sneder, DataGridViewCellEventArgs e)
        {
            //The first column of a datagridview has an index = 0
            //this is known as a "zero-based" array/collection.list
            //everythin starts with 0
            //
            // the 5th column (columnIndex = 4) is the column with the button
            //if the player clicked the button column, we will sell an item from that row
            if(e.ColumnIndex == 4)
            {
                //this gets the ID value of the item, from the hidden 1st column
                //ColumnIndex = 0 for the first column
                var itemID = uxMyItemsGrid.Rows[e.RowIndex].Cells[0].Value;

                //get the Item object for the seleced item row
                Item itemBeingSold = World.ItemByID(Convert.ToInt32(itemID));

                //get the item object for the selected item row
                if(itemBeingSold.Price == World.UNSELLABLE_ITEM_PRICE)
                {
                    MessageBox.Show("You can't sell the " + itemBeingSold.Name);
                }
                else
                {
                    //remove item from players inventory
                    _currentPlayer.RemoveItemFromInventory(itemBeingSold);

                    //gives player the amount of godl that item is worth
                    _currentPlayer.Gold += itemBeingSold.Price;
                }
            }
        }

        private void uxVendorItemsGrid_CellClick(object sneder, DataGridViewCellEventArgs e)
        {
            //4th column (ColumnIndex = 3) has the "Buy 1" button
            if(e.ColumnIndex == 3)
            {
                //gets the ID value of the item, from the hidden first row
                var itemID = uxVendorItemsGrid.Rows[e.RowIndex].Cells[0].Value;

                //get the item object for the selected item row
                Item itemBeingBought = World.ItemByID(Convert.ToInt32(itemID));

                //checks if player has enough gold
                if(_currentPlayer.Gold >= itemBeingBought.Price)
                {
                    //adds item into player,s inventory
                    _currentPlayer.AddItemToInventory(itemBeingBought);

                    //removes gold from player
                    _currentPlayer.Gold -= itemBeingBought.Price;
                }
                else
                {
                    MessageBox.Show("You do not have enough gold to buy the " + itemBeingBought.Name);
                }
            }
        }


        private void uxCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
