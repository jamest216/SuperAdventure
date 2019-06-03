using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";
        public SuperAdventure()
        {
            InitializeComponent();

            //_player = PlayerDataMapper.CreateFromDatabase();

            if (_player == null)
            {
                if (File.Exists(PLAYER_DATA_FILE_NAME))
                {
                    _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
                }
                else
                {
                    _player = Player.CreateDefaultPlayer();
                }
            }

            //player
            uxHitPoints.DataBindings.Add("Text", _player, "CurrentHitPoints");
            uxGold.DataBindings.Add("Text", _player, "Gold");
            uxExperience.DataBindings.Add("Text", _player, "ExperiencePoints");
            uxLevel.DataBindings.Add("text", _player, "Level");

            uxInventory.RowHeadersVisible = false;
            uxInventory.AutoGenerateColumns = false;

            uxInventory.DataSource = _player.Inventory;

            uxInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 197,
                DataPropertyName = "Description"
            });

            uxInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });

            uxQuests.RowHeadersVisible = false;
            uxQuests.AutoGenerateColumns = false;

            //quests
            uxQuests.DataSource = _player.Quests;

            uxQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 197,
                DataPropertyName = "Name"
            });

            uxQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Done?",
                DataPropertyName = "IsCompleted"
            });

            //weapons
            uxWeaponsBox.DataSource = _player.Weapons;
            uxWeaponsBox.DisplayMember = "Name";
            uxWeaponsBox.ValueMember = "Id";

            if (_player.CurrentWeapon != null)
            {
                uxWeaponsBox.SelectedItem = _player.CurrentWeapon;
            }

            uxWeaponsBox.SelectedIndexChanged += uxWeaponsBox_SelectedIndexChanged;

            //potions
            uxPotionsBox.DataSource = _player.Potions;
            uxPotionsBox.DisplayMember = "Name";
            uxPotionsBox.ValueMember = "Id";

            _player.PropertyChanged += PlayerOnPropertyChanged;
            _player.OnMessage += DisplayMessage;



        }

        /// <summary>
        /// north click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNorth_Click(object sender, EventArgs e)
        {
            _player.MoveNorth();
        }

        /// <summary>
        /// south clck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSouth_Click(object sender, EventArgs e)
        {
            _player.MoveSouth();
        }

        /// <summary>
        /// east click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEast_Click(object sender, EventArgs e)
        {
            _player.MoveEast();
        }

        /// <summary>
        /// west click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxWest_Click(object sender, EventArgs e)
        {
            _player.MoveWest();
        }

        /// <summary>
        /// use weapon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxUseWeapon_Click(object sender, EventArgs e)
        {
            //get the currently selected weapon from the uxWeaponBox
            Weapon currentWeapon = (Weapon)uxWeaponsBox.SelectedItem;
            _player.UseWeapon(currentWeapon);
        }

        /// <summary>
        /// use potion click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxUsePotion_Click(object sender, EventArgs e)
        {
            //get the currently selected potion from the uxPotionBox
            HealingPotion potion = (HealingPotion)uxPotionsBox.SelectedItem;
            _player.UsePotion(potion);
        }

        /// <summary>
        /// scrolls the rich text box
        /// </summary>
        private void ScrollToBottomOfMessages()
        {
            uxMessagesBox.SelectionStart = uxMessagesBox.Text.Length;
            uxMessagesBox.ScrollToCaret();
        }

        /// <summary>
        /// updates player stats
        /// </summary>
        private void UpdatePlayerStats()
        {
            // Refresh player information and inventory controls
            uxHitPoints.Text = _player.CurrentHitPoints.ToString();
            uxGold.Text = _player.Gold.ToString();
            uxExperience.Text = _player.ExperiencePoints.ToString();
            uxLevel.Text = _player.Level.ToString();
        }

        /// <summary>
        /// saves to an xml file when the form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperAdventure_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());

            PlayerDataMapper.SaveToDatabase(_player);
        }

        /// <summary>
        /// event for a selct change in index with the weapon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxWeaponsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentWeapon = (Weapon)uxWeaponsBox.SelectedItem;
        }

        /// <summary>
        /// detects changes in both comboboxes
        /// </summary>  
        /// <param name="sender"></param>
        /// <param name="propertyChangedEventArgs"></param>
        private void PlayerOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Weapons")
            {
                uxWeaponsBox.DataSource = _player.Weapons;
                if (!_player.Weapons.Any())
                {
                    uxWeaponsBox.Visible = false;
                    uxUseWeapon.Visible = false;
                }
            }
            if (propertyChangedEventArgs.PropertyName == "Potions")
            {
                uxPotionsBox.DataSource = _player.Potions;
                if (!_player.Potions.Any())
                {
                    uxPotionsBox.Visible = false;
                    uxUsePotion.Visible = false;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "CurrentLocation")
            {
                // Show/hide available movement buttons
                uxNorth.Visible = (_player.CurrentLocation.LocationToNorth != null);
                uxEast.Visible = (_player.CurrentLocation.LocationToEast != null);
                uxSouth.Visible = (_player.CurrentLocation.LocationToSouth != null);
                uxWest.Visible = (_player.CurrentLocation.LocationToWest != null);
                uxTrade.Visible = (_player.CurrentLocation.VendorWorkingHere != null);

                // Display current location name and description
                uxLocationBox.Text = _player.CurrentLocation.Name + Environment.NewLine;
                uxLocationBox.Text += _player.CurrentLocation.Description + Environment.NewLine;

                if (_player.CurrentLocation.MonsterLivingHere == null)
                {
                    uxWeaponsBox.Visible = false;
                    uxPotionsBox.Visible = false;
                    uxUseWeapon.Visible = false;
                    uxUsePotion.Visible = false;
                }
                else
                {
                    uxWeaponsBox.Visible = _player.Weapons.Any();
                    uxPotionsBox.Visible = _player.Potions.Any();
                    uxUseWeapon.Visible = _player.Weapons.Any();
                    uxUsePotion.Visible = _player.Potions.Any();
                }
            }
        }

        /// <summary>
        /// displays message on the message box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="m"></param>
        private void DisplayMessage(object sender, MessageEventArgs m)
        {
            uxMessagesBox.Text += m.Message + Environment.NewLine;

            if (m.AddExtraNewLine)
            {
                uxMessagesBox.Text += Environment.NewLine;
            }

            uxMessagesBox.SelectionStart = uxMessagesBox.Text.Length;
            uxMessagesBox.ScrollToCaret();
        }


        private void uxTrade_Click(object sender, EventArgs e)
        {
            TradingScreen ts = new TradingScreen(_player);
            ts.StartPosition = FormStartPosition.CenterParent;
            ts.ShowDialog(this);
        }
    }
}
