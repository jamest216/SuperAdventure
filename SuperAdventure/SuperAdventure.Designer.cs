namespace SuperAdventure
{
    partial class SuperAdventure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxHitPoints = new System.Windows.Forms.Label();
            this.uxGold = new System.Windows.Forms.Label();
            this.uxExperience = new System.Windows.Forms.Label();
            this.uxLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxWeaponsBox = new System.Windows.Forms.ComboBox();
            this.uxPotionsBox = new System.Windows.Forms.ComboBox();
            this.uxWest = new System.Windows.Forms.Button();
            this.uxSouth = new System.Windows.Forms.Button();
            this.uxEast = new System.Windows.Forms.Button();
            this.uxNorth = new System.Windows.Forms.Button();
            this.uxUsePotion = new System.Windows.Forms.Button();
            this.uxUseWeapon = new System.Windows.Forms.Button();
            this.uxMessagesBox = new System.Windows.Forms.RichTextBox();
            this.uxLocationBox = new System.Windows.Forms.RichTextBox();
            this.uxInventory = new System.Windows.Forms.DataGridView();
            this.uxQuests = new System.Windows.Forms.DataGridView();
            this.uxTrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // uxHitPoints
            // 
            this.uxHitPoints.AutoSize = true;
            this.uxHitPoints.Location = new System.Drawing.Point(110, 19);
            this.uxHitPoints.Name = "uxHitPoints";
            this.uxHitPoints.Size = new System.Drawing.Size(35, 13);
            this.uxHitPoints.TabIndex = 4;
            this.uxHitPoints.Text = "label5";
            // 
            // uxGold
            // 
            this.uxGold.AutoSize = true;
            this.uxGold.Location = new System.Drawing.Point(110, 45);
            this.uxGold.Name = "uxGold";
            this.uxGold.Size = new System.Drawing.Size(35, 13);
            this.uxGold.TabIndex = 5;
            this.uxGold.Text = "label6";
            // 
            // uxExperience
            // 
            this.uxExperience.AutoSize = true;
            this.uxExperience.Location = new System.Drawing.Point(110, 73);
            this.uxExperience.Name = "uxExperience";
            this.uxExperience.Size = new System.Drawing.Size(35, 13);
            this.uxExperience.TabIndex = 6;
            this.uxExperience.Text = "label7";
            // 
            // uxLevel
            // 
            this.uxLevel.AutoSize = true;
            this.uxLevel.Location = new System.Drawing.Point(110, 99);
            this.uxLevel.Name = "uxLevel";
            this.uxLevel.Size = new System.Drawing.Size(35, 13);
            this.uxLevel.TabIndex = 7;
            this.uxLevel.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Action";
            // 
            // uxWeaponsBox
            // 
            this.uxWeaponsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxWeaponsBox.FormattingEnabled = true;
            this.uxWeaponsBox.Location = new System.Drawing.Point(369, 559);
            this.uxWeaponsBox.Name = "uxWeaponsBox";
            this.uxWeaponsBox.Size = new System.Drawing.Size(121, 21);
            this.uxWeaponsBox.TabIndex = 9;
            // 
            // uxPotionsBox
            // 
            this.uxPotionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxPotionsBox.FormattingEnabled = true;
            this.uxPotionsBox.Location = new System.Drawing.Point(369, 593);
            this.uxPotionsBox.Name = "uxPotionsBox";
            this.uxPotionsBox.Size = new System.Drawing.Size(121, 21);
            this.uxPotionsBox.TabIndex = 10;
            // 
            // uxWest
            // 
            this.uxWest.Location = new System.Drawing.Point(412, 457);
            this.uxWest.Name = "uxWest";
            this.uxWest.Size = new System.Drawing.Size(75, 23);
            this.uxWest.TabIndex = 11;
            this.uxWest.Text = "West";
            this.uxWest.UseVisualStyleBackColor = true;
            this.uxWest.Click += new System.EventHandler(this.uxWest_Click);
            // 
            // uxSouth
            // 
            this.uxSouth.Location = new System.Drawing.Point(493, 487);
            this.uxSouth.Name = "uxSouth";
            this.uxSouth.Size = new System.Drawing.Size(75, 23);
            this.uxSouth.TabIndex = 12;
            this.uxSouth.Text = "South";
            this.uxSouth.UseVisualStyleBackColor = true;
            this.uxSouth.Click += new System.EventHandler(this.uxSouth_Click);
            // 
            // uxEast
            // 
            this.uxEast.Location = new System.Drawing.Point(573, 457);
            this.uxEast.Name = "uxEast";
            this.uxEast.Size = new System.Drawing.Size(75, 23);
            this.uxEast.TabIndex = 13;
            this.uxEast.Text = "East";
            this.uxEast.UseVisualStyleBackColor = true;
            this.uxEast.Click += new System.EventHandler(this.uxEast_Click);
            // 
            // uxNorth
            // 
            this.uxNorth.Location = new System.Drawing.Point(493, 433);
            this.uxNorth.Name = "uxNorth";
            this.uxNorth.Size = new System.Drawing.Size(75, 23);
            this.uxNorth.TabIndex = 14;
            this.uxNorth.Text = "North";
            this.uxNorth.UseVisualStyleBackColor = true;
            this.uxNorth.Click += new System.EventHandler(this.uxNorth_Click);
            // 
            // uxUsePotion
            // 
            this.uxUsePotion.Location = new System.Drawing.Point(620, 593);
            this.uxUsePotion.Name = "uxUsePotion";
            this.uxUsePotion.Size = new System.Drawing.Size(75, 23);
            this.uxUsePotion.TabIndex = 15;
            this.uxUsePotion.Text = "Use";
            this.uxUsePotion.UseVisualStyleBackColor = true;
            this.uxUsePotion.Click += new System.EventHandler(this.uxUsePotion_Click);
            // 
            // uxUseWeapon
            // 
            this.uxUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.uxUseWeapon.Name = "uxUseWeapon";
            this.uxUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.uxUseWeapon.TabIndex = 16;
            this.uxUseWeapon.Text = "Use";
            this.uxUseWeapon.UseVisualStyleBackColor = true;
            this.uxUseWeapon.Click += new System.EventHandler(this.uxUseWeapon_Click);
            // 
            // uxMessagesBox
            // 
            this.uxMessagesBox.Location = new System.Drawing.Point(347, 130);
            this.uxMessagesBox.Name = "uxMessagesBox";
            this.uxMessagesBox.ReadOnly = true;
            this.uxMessagesBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.uxMessagesBox.Size = new System.Drawing.Size(360, 286);
            this.uxMessagesBox.TabIndex = 17;
            this.uxMessagesBox.Text = "";
            // 
            // uxLocationBox
            // 
            this.uxLocationBox.Location = new System.Drawing.Point(347, 19);
            this.uxLocationBox.Name = "uxLocationBox";
            this.uxLocationBox.ReadOnly = true;
            this.uxLocationBox.Size = new System.Drawing.Size(360, 105);
            this.uxLocationBox.TabIndex = 18;
            this.uxLocationBox.Text = "";
            // 
            // uxInventory
            // 
            this.uxInventory.AllowUserToAddRows = false;
            this.uxInventory.AllowUserToDeleteRows = false;
            this.uxInventory.AllowUserToResizeRows = false;
            this.uxInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uxInventory.Enabled = false;
            this.uxInventory.Location = new System.Drawing.Point(16, 130);
            this.uxInventory.MultiSelect = false;
            this.uxInventory.Name = "uxInventory";
            this.uxInventory.ReadOnly = true;
            this.uxInventory.RowHeadersVisible = false;
            this.uxInventory.Size = new System.Drawing.Size(312, 309);
            this.uxInventory.TabIndex = 19;
            // 
            // uxQuests
            // 
            this.uxQuests.AllowUserToAddRows = false;
            this.uxQuests.AllowUserToDeleteRows = false;
            this.uxQuests.AllowUserToResizeRows = false;
            this.uxQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uxQuests.Enabled = false;
            this.uxQuests.Location = new System.Drawing.Point(16, 446);
            this.uxQuests.MultiSelect = false;
            this.uxQuests.Name = "uxQuests";
            this.uxQuests.ReadOnly = true;
            this.uxQuests.RowHeadersVisible = false;
            this.uxQuests.Size = new System.Drawing.Size(312, 189);
            this.uxQuests.TabIndex = 20;
            //
            // uxTrade
            //
            this.uxTrade.Location = new System.Drawing.Point(493, 620);
            this.uxTrade.Name = "btnTrade";
            this.uxTrade.Size = new System.Drawing.Size(75, 23);
            this.uxTrade.TabIndex = 21;
            this.uxTrade.Text = "Trade";
            this.uxTrade.UseVisualStyleBackColor = true;
            this.uxTrade.Click +=
            new System.EventHandler(this.uxTrade_Click);
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.uxTrade);
            this.Controls.Add(this.uxQuests);
            this.Controls.Add(this.uxInventory);
            this.Controls.Add(this.uxLocationBox);
            this.Controls.Add(this.uxMessagesBox);
            this.Controls.Add(this.uxUseWeapon);
            this.Controls.Add(this.uxUsePotion);
            this.Controls.Add(this.uxNorth);
            this.Controls.Add(this.uxEast);
            this.Controls.Add(this.uxSouth);
            this.Controls.Add(this.uxWest);
            this.Controls.Add(this.uxPotionsBox);
            this.Controls.Add(this.uxWeaponsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxLevel);
            this.Controls.Add(this.uxExperience);
            this.Controls.Add(this.uxGold);
            this.Controls.Add(this.uxHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SuperAdventure";
            this.Text = "My Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuperAdventure_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uxInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uxHitPoints;
        private System.Windows.Forms.Label uxGold;
        private System.Windows.Forms.Label uxExperience;
        private System.Windows.Forms.Label uxLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxWeaponsBox;
        private System.Windows.Forms.ComboBox uxPotionsBox;
        private System.Windows.Forms.Button uxWest;
        private System.Windows.Forms.Button uxSouth;
        private System.Windows.Forms.Button uxEast;
        private System.Windows.Forms.Button uxNorth;
        private System.Windows.Forms.Button uxUsePotion;
        private System.Windows.Forms.Button uxUseWeapon;
        private System.Windows.Forms.RichTextBox uxMessagesBox;
        private System.Windows.Forms.RichTextBox uxLocationBox;
        private System.Windows.Forms.DataGridView uxInventory;
        private System.Windows.Forms.DataGridView uxQuests;
        private System.Windows.Forms.Button uxTrade;
    }
}

