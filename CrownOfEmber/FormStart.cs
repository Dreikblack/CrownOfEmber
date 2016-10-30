using System;
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
    }
}
