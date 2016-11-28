namespace CrownOfEmber
{
    partial class FormShop
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
            this.listBoxShopItems = new System.Windows.Forms.ListBox();
            this.pictureBoxShopCurItem = new System.Windows.Forms.PictureBox();
            this.buttonBuyItem = new System.Windows.Forms.Button();
            this.labelShop = new System.Windows.Forms.Label();
            this.buttonShopExit = new System.Windows.Forms.Button();
            this.labelShopTalers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopCurItem)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxShopItems
            // 
            this.listBoxShopItems.FormattingEnabled = true;
            this.listBoxShopItems.Location = new System.Drawing.Point(13, 27);
            this.listBoxShopItems.Name = "listBoxShopItems";
            this.listBoxShopItems.Size = new System.Drawing.Size(282, 316);
            this.listBoxShopItems.TabIndex = 0;
            this.listBoxShopItems.SelectedIndexChanged += new System.EventHandler(this.listBoxShopItems_SelectedIndexChanged);
            // 
            // pictureBoxShopCurItem
            // 
            this.pictureBoxShopCurItem.Location = new System.Drawing.Point(301, 27);
            this.pictureBoxShopCurItem.Name = "pictureBoxShopCurItem";
            this.pictureBoxShopCurItem.Size = new System.Drawing.Size(290, 400);
            this.pictureBoxShopCurItem.TabIndex = 1;
            this.pictureBoxShopCurItem.TabStop = false;
            // 
            // buttonBuyItem
            // 
            this.buttonBuyItem.Location = new System.Drawing.Point(13, 362);
            this.buttonBuyItem.Name = "buttonBuyItem";
            this.buttonBuyItem.Size = new System.Drawing.Size(282, 29);
            this.buttonBuyItem.TabIndex = 2;
            this.buttonBuyItem.Text = "Купить предмет";
            this.buttonBuyItem.UseVisualStyleBackColor = true;
            this.buttonBuyItem.Click += new System.EventHandler(this.buttonBuyItem_Click);
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(12, 9);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(51, 13);
            this.labelShop.TabIndex = 3;
            this.labelShop.Text = "Магазин";
            // 
            // buttonShopExit
            // 
            this.buttonShopExit.Location = new System.Drawing.Point(13, 397);
            this.buttonShopExit.Name = "buttonShopExit";
            this.buttonShopExit.Size = new System.Drawing.Size(282, 29);
            this.buttonShopExit.TabIndex = 4;
            this.buttonShopExit.Text = "Выйти отсюда";
            this.buttonShopExit.UseVisualStyleBackColor = true;
            this.buttonShopExit.Click += new System.EventHandler(this.buttonShopExit_Click);
            // 
            // labelShopTalers
            // 
            this.labelShopTalers.AutoSize = true;
            this.labelShopTalers.Location = new System.Drawing.Point(12, 346);
            this.labelShopTalers.Name = "labelShopTalers";
            this.labelShopTalers.Size = new System.Drawing.Size(80, 13);
            this.labelShopTalers.TabIndex = 5;
            this.labelShopTalers.Text = "Ваши талеры: ";
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 430);
            this.Controls.Add(this.labelShopTalers);
            this.Controls.Add(this.buttonShopExit);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.buttonBuyItem);
            this.Controls.Add(this.pictureBoxShopCurItem);
            this.Controls.Add(this.listBoxShopItems);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShop_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopCurItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShopItems;
        private System.Windows.Forms.PictureBox pictureBoxShopCurItem;
        private System.Windows.Forms.Button buttonBuyItem;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Button buttonShopExit;
        private System.Windows.Forms.Label labelShopTalers;
    }
}