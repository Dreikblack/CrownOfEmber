using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrownOfEmber
{
    public partial class FormInventory : Form
    {
        public FormInventory(int nPlayer, int turn, List<string> listItmes)
        {
            InitializeComponent();
            labelInventoryStatus.Text = "Предметы игрока №"+ (nPlayer+1) + " на "+turn + " ход";
        }

        private void ButtonInventoryClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxInventoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxInventoryItems.GetItemText(listBoxInventoryItems.SelectedItem))
            {
                case "Контрабанда в зачарованную деревню":
                    pictureBoxInventory.Image = Properties.Resources.ItemContraband1;
                    break;
                case "Контрабанда в храм Бааля":
                    pictureBoxInventory.Image = Properties.Resources.ItemContraband2;
                    break;
                case "Контрабанда в постоялый двор":
                    pictureBoxInventory.Image = Properties.Resources.ItemContraband3;
                    break;
                case "Контрабанда в салун":
                    pictureBoxInventory.Image = Properties.Resources.ItemContraband4;
                    break;
                case "Контрабанда в перевал":
                    pictureBoxInventory.Image = Properties.Resources.ItemContraband5;
                    break;
            }
        }
    }
}
