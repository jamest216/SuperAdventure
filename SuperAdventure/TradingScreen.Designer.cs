namespace SuperAdventure
{
    partial class TradingScreen
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
            this.uxMyInventory = new System.Windows.Forms.Label();
            this.uxVendorInventory = new System.Windows.Forms.Label();
            this.uxMyItemsGrid = new System.Windows.Forms.DataGridView();
            this.uxVendorItemsGrid = new System.Windows.Forms.DataGridView();
            this.uxCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxMyItemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxVendorItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMyInventory
            // 
            this.uxMyInventory.AutoSize = true;
            this.uxMyInventory.Location = new System.Drawing.Point(99, 13);
            this.uxMyInventory.Name = "uxMyInventory";
            this.uxMyInventory.Size = new System.Drawing.Size(68, 13);
            this.uxMyInventory.TabIndex = 0;
            this.uxMyInventory.Text = "My Inventory";
            // 
            // uxVendorInventory
            // 
            this.uxVendorInventory.AutoSize = true;
            this.uxVendorInventory.Location = new System.Drawing.Point(349, 13);
            this.uxVendorInventory.Name = "uxVendorInventory";
            this.uxVendorInventory.Size = new System.Drawing.Size(95, 13);
            this.uxVendorInventory.TabIndex = 1;
            this.uxVendorInventory.Text = "Vendor\'s Inventory";
            // 
            // uxMyItemsGrid
            // 
            this.uxMyItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMyItemsGrid.Location = new System.Drawing.Point(13, 43);
            this.uxMyItemsGrid.Name = "uxMyItemsGrid";
            this.uxMyItemsGrid.Size = new System.Drawing.Size(240, 216);
            this.uxMyItemsGrid.TabIndex = 2;
            // 
            // uxVendorItemsGrid
            // 
            this.uxVendorItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxVendorItemsGrid.Location = new System.Drawing.Point(276, 43);
            this.uxVendorItemsGrid.Name = "uxVendorItemsGrid";
            this.uxVendorItemsGrid.Size = new System.Drawing.Size(240, 216);
            this.uxVendorItemsGrid.TabIndex = 3;
            // 
            // uxCloseButton
            // 
            this.uxCloseButton.Location = new System.Drawing.Point(441, 274);
            this.uxCloseButton.Name = "uxCloseButton";
            this.uxCloseButton.Size = new System.Drawing.Size(75, 23);
            this.uxCloseButton.TabIndex = 4;
            this.uxCloseButton.Text = "Close";
            this.uxCloseButton.UseVisualStyleBackColor = true;
            this.uxCloseButton.Click += new System.EventHandler(this.uxCloseButton_Click);
            // 
            // TradingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 310);
            this.Controls.Add(this.uxCloseButton);
            this.Controls.Add(this.uxVendorItemsGrid);
            this.Controls.Add(this.uxMyItemsGrid);
            this.Controls.Add(this.uxVendorInventory);
            this.Controls.Add(this.uxMyInventory);
            this.Name = "TradingScreen";
            this.Text = "Trade";
            ((System.ComponentModel.ISupportInitialize)(this.uxMyItemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxVendorItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMyInventory;
        private System.Windows.Forms.Label uxVendorInventory;
        private System.Windows.Forms.DataGridView uxMyItemsGrid;
        private System.Windows.Forms.DataGridView uxVendorItemsGrid;
        private System.Windows.Forms.Button uxCloseButton;
    }
}