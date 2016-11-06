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

            switch(listBoxChar.GetItemText(listBoxChar.SelectedItem))
            {
                case "Амазонка":
                    picBoxCardChar.Image = Properties.Resources.CardAmazon;
                    break;
                case "Безумный учёный":
                    picBoxCardChar.Image = Properties.Resources.CardScientist;
                    break;
                case "Гладиатор":
                    picBoxCardChar.Image = Properties.Resources.CardGladiator;
                    break;
                case "Гоблин":
                    picBoxCardChar.Image = Properties.Resources.CardGoblin;
                    break;
                case "Гусар":
                    picBoxCardChar.Image = Properties.Resources.CardHussar;
                    break;
                case "Звездочёт":
                    picBoxCardChar.Image = Properties.Resources.CardAstrologer;
                    break;
                case "Знахарка":
                    picBoxCardChar.Image = Properties.Resources.CardPowwow;
                    break;
                case "Инопланетянин":
                    picBoxCardChar.Image = Properties.Resources.CardAlien;
                    break;
                case "Королева ведьм":
                    picBoxCardChar.Image = Properties.Resources.CardWitch;
                    break;
                case "Монах":
                    picBoxCardChar.Image = Properties.Resources.CardMonk;
                    break;
                case "Мутант":
                    picBoxCardChar.Image = Properties.Resources.CardMutant;
                    break;
                case "Оборотень":
                    picBoxCardChar.Image = Properties.Resources.CardWerwolf;
                    break;
                case "Наёмник":
                    picBoxCardChar.Image = Properties.Resources.CardMercenary;
                    break;
                case "Ниндзя":
                    picBoxCardChar.Image = Properties.Resources.CardNinja;
                    break;
                case "Разрушитель":
                    picBoxCardChar.Image = Properties.Resources.CardDestroyer;
                    break;
                case "Фея":
                    picBoxCardChar.Image = Properties.Resources.CardFairy;
                    break;
                case "Цыган":
                    picBoxCardChar.Image = Properties.Resources.CardGipsy;
                    break;
                case "Эльф":
                    picBoxCardChar.Image = Properties.Resources.CardElf;
                    break;
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (listPlayers.Count==0)
            {
                SelectChar();
            }
            FormField1 FrmF1 = new FormField1(listPlayers);
            //FrmF1.Activate();
            FrmF1.Owner = this;
            FrmF1.Show();
            this.Hide();
        }

        private void buttonSelectChar_Click(object sender, EventArgs e)
        {
            SelectChar();
        }
        private void SelectChar()
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
            if (listBoxChar.Items.Count > 0 && listBoxChar.GetItemText(listBoxChar.SelectedItem) == "")
            {
                    listBoxChar.SetSelected(0, true);
            }
         }
    }
}
