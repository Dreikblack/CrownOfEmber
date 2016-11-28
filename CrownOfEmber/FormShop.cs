using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrownOfEmber
{
    public partial class FormShop : Form
    {
        int freeSlots = 0;
        public int playerTalers = 0;
        public string shopName = "";
        public List<string> listBoughtItems = new List<string>();

        public FormShop(string shopName, List<int> shopItems, int playerTalers, int freeSlots)
        {
            InitializeComponent();
            this.shopName = shopName;
            this.freeSlots = freeSlots;
            this.playerTalers = playerTalers;
            labelShopTalers.Text += playerTalers;
            if (shopName=="Контрабанда")
            {
                labelShop.Text = "Контрабанда. Вы можете доставить контрабандный груз, заплатив предварительно залог";
                foreach(int curItem in shopItems)
                {
                   switch(curItem)
                    {
                        case 1:
                            listBoxShopItems.Items.Add("Контрабанда в зачарованную деревню");
                            break;
                        case 2:
                            listBoxShopItems.Items.Add("Контрабанда в храм Бааля");
                            break;
                        case 3:
                            listBoxShopItems.Items.Add("Контрабанда в постоялый двор");
                            break;
                        case 4:
                            listBoxShopItems.Items.Add("Контрабанда в салун");
                            break;
                        case 5:
                            listBoxShopItems.Items.Add("Контрабанда в перевал");
                            break;
                    }
                }
            }
        }

        
        private void buttonBuyItem_Click(object sender, EventArgs e)
        {
            if (listBoxShopItems.Items.Count > 0)
            {
                if (listBoxShopItems.GetItemText(listBoxShopItems.SelectedItem) == "")
                {
                    listBoxShopItems.SetSelected(0, true);
                }
                if (freeSlots > 0)
                {
                    if (shopName == "Контрабанда")
                    {
                        switch (listBoxShopItems.GetItemText(listBoxShopItems.SelectedItem))
                        {
                            case "Контрабанда в зачарованную деревню":
                            case "Контрабанда в салун":
                                playerTalers -= 5;
                                break;
                            case "Контрабанда в храм Бааля":
                            case "Контрабанда в перевал":
                                playerTalers -= 3;
                                break;
                            case "Контрабанда в постоялый двор":
                                playerTalers -= 4;
                                break;
                        }
                        freeSlots--;
                        listBoughtItems.Add(listBoxShopItems.GetItemText(listBoxShopItems.SelectedItem));
                        listBoxShopItems.Items.Remove(listBoxShopItems.SelectedItem);
                        FormField1.SelfRef.setNewVars(playerTalers, listBoughtItems);
                        this.Owner.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Нельзя приобрести этот предмет, так как у вас максимальное количество предметов.");
                }
            }
            if (listBoxShopItems.Items.Count > 0 && listBoxShopItems.GetItemText(listBoxShopItems.SelectedItem) == "")
            {
                listBoxShopItems.SetSelected(0, true);
            }
        }

        private void listBoxShopItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxShopItems.GetItemText(listBoxShopItems.SelectedItem))
            {
                case "Контрабанда в зачарованную деревню":
                    pictureBoxShopCurItem.Image = Properties.Resources.ItemContraband1;
                    break;
                case "Контрабанда в храм Бааля":
                    pictureBoxShopCurItem.Image = Properties.Resources.ItemContraband2;
                    break;
                case "Контрабанда в постоялый двор":
                    pictureBoxShopCurItem.Image = Properties.Resources.ItemContraband3;
                    break;
                case "Контрабанда в салун":
                    pictureBoxShopCurItem.Image = Properties.Resources.ItemContraband4;
                    break;
                case "Контрабанда в перевал":
                    pictureBoxShopCurItem.Image = Properties.Resources.ItemContraband5;
                    break;
            }
        }

        private void buttonShopExit_Click(object sender, EventArgs e)
        {     
            FormField1.SelfRef.setNewVars(playerTalers, listBoughtItems);
            this.Owner.Show();
            this.Close();
 
        }

        private void FormShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormField1.SelfRef.setNewVars(playerTalers, listBoughtItems);
            this.Owner.Show();
        }
    }
}
