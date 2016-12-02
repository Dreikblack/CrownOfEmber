using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrownOfEmber
{
    public partial class FormSelection : Form
    {
        public FormSelection(string text, List<string> listSelects)
        {
            labelSelection.Text = text;
            foreach (string curItem in listSelects)
            {
                listBoxSelection.Items.Add(curItem);
            }
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxSelection.Items.Count > 0)
            {
                if (listBoxSelection.GetItemText(listBoxSelection.SelectedItem) == "")
                {
                    listBoxSelection.SetSelected(0, true);
                }
                switch (listBoxSelection.GetItemText(listBoxSelection.SelectedItem))
                        {
                            case "1 тур - 5 талеров":
                                 FormField1.SelfRef.addedNewAtStart(listBoxSelection.GetItemText(listBoxSelection.SelectedItem), 1);
                                break;
                            case "2 тура - 5 талеров":
                                FormField1.SelfRef.addedNewAtStart(listBoxSelection.GetItemText(listBoxSelection.SelectedItem), 2);
                                break;
                            case "3 тура - 5 талеров":
                                FormField1.SelfRef.addedNewAtStart(listBoxSelection.GetItemText(listBoxSelection.SelectedItem), 3);
                                break;
                        }
                        this.Owner.Show();
                        this.Close();
                    }
        }
    }
}
