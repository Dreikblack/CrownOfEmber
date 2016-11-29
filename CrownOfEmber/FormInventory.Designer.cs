namespace CrownOfEmber
{
    partial class FormInventory
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
            this.labelInventoryStatus = new System.Windows.Forms.Label();
            this.listBoxInventoryItems = new System.Windows.Forms.ListBox();
            this.pictureBoxInventory = new System.Windows.Forms.PictureBox();
            this.ButtonInventoryClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInventoryStatus
            // 
            this.labelInventoryStatus.AutoSize = true;
            this.labelInventoryStatus.Location = new System.Drawing.Point(7, 3);
            this.labelInventoryStatus.Name = "labelInventoryStatus";
            this.labelInventoryStatus.Size = new System.Drawing.Size(156, 13);
            this.labelInventoryStatus.TabIndex = 0;
            this.labelInventoryStatus.Text = "Предметы игрока №0 на  ход";
            // 
            // listBoxInventoryItems
            // 
            this.listBoxInventoryItems.FormattingEnabled = true;
            this.listBoxInventoryItems.Location = new System.Drawing.Point(10, 29);
            this.listBoxInventoryItems.Name = "listBoxInventoryItems";
            this.listBoxInventoryItems.Size = new System.Drawing.Size(191, 329);
            this.listBoxInventoryItems.TabIndex = 1;
            this.listBoxInventoryItems.SelectedIndexChanged += new System.EventHandler(this.listBoxInventoryItems_SelectedIndexChanged);
            // 
            // pictureBoxInventory
            // 
            this.pictureBoxInventory.Location = new System.Drawing.Point(207, 3);
            this.pictureBoxInventory.Name = "pictureBoxInventory";
            this.pictureBoxInventory.Size = new System.Drawing.Size(290, 400);
            this.pictureBoxInventory.TabIndex = 2;
            this.pictureBoxInventory.TabStop = false;
            // 
            // ButtonInventoryClose
            // 
            this.ButtonInventoryClose.Location = new System.Drawing.Point(10, 365);
            this.ButtonInventoryClose.Name = "ButtonInventoryClose";
            this.ButtonInventoryClose.Size = new System.Drawing.Size(191, 38);
            this.ButtonInventoryClose.TabIndex = 3;
            this.ButtonInventoryClose.Text = "Закрыть инвентарь";
            this.ButtonInventoryClose.UseVisualStyleBackColor = true;
            this.ButtonInventoryClose.Click += new System.EventHandler(this.ButtonInventoryClose_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 406);
            this.Controls.Add(this.ButtonInventoryClose);
            this.Controls.Add(this.pictureBoxInventory);
            this.Controls.Add(this.listBoxInventoryItems);
            this.Controls.Add(this.labelInventoryStatus);
            this.Name = "FormInventory";
            this.Text = "FormInventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInventoryStatus;
        private System.Windows.Forms.ListBox listBoxInventoryItems;
        private System.Windows.Forms.PictureBox pictureBoxInventory;
        private System.Windows.Forms.Button ButtonInventoryClose;
    }
}