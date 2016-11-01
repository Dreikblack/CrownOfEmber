using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrownOfEmber
{
    public partial class FormStart : Form
    {
        
        public FormStart()
        {
            InitializeComponent();            
        }

        List<string> listPlayers = new List<string>();
        int numberPlayer = 1;

        private void listBoxChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxChar.GetItemText(listBoxChar.SelectedItem) == "Эльф")
            {
                picBoxCardChar.Image = Properties.Resources.CardElf;
            }
            else if (listBoxChar.GetItemText(listBoxChar.SelectedItem) == "Гоблин")
            {
                picBoxCardChar.Image = Properties.Resources.CardGoblin;
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            FormField1 FrmF1 = new FormField1();
            //FrmF1.Activate();
            FrmF1.Owner = this;
            FrmF1.Show();
            this.Hide();
        }

        private void buttonSelectChar_Click(object sender, EventArgs e)
        {
            if (listBoxChar.Items.Count > 0)
            {
                if (listBoxChar.GetItemText(listBoxChar.SelectedItem) == "")
                {
                    listBoxChar.SetSelected(0, true);
                }
                listPlayers.Add(listBoxChar.GetItemText(listBoxChar.SelectedItem));
                listBoxChar.Items.Remove(listBoxChar.SelectedItem);
                if (listBoxChar.Items.Count > 0)
                {
                    numberPlayer = numberPlayer + 1;
                    labelPlayerN.Text = "Игрок № " + numberPlayer;
                }
            }
        }
    }
}
