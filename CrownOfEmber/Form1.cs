using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrownOfEmber.Classes;

namespace CrownOfEmber
{
    public partial class FormField1 : Form
    {
        // public int widthForm1 = 0;
        //   public int heightForm1 = 0;
        List<Player> listPlayers = new List<Player>();
        int curPlayer = 0;
        //public Player[] msPlayers = new Player[2];
        public FormField1(List<string> ltPlayers)
        {
            InitializeComponent();
            for (int i=0;i< ltPlayers.Count;i=i+1)
            {
                listPlayers.Add(new Player(ltPlayers[i]));
            }
            
            //Player player1 = new Player(ltPlayers[0]);
            toolStripTextBoxCharName.Text = "Персонаж:  " + listPlayers[curPlayer].charName()+ "; ";
            toolStripTextBoxKindness.Text = "Статус: " + listPlayers[curPlayer].GetKindness() + ";";
            toolStripTextBoxHonor.Text = listPlayers[curPlayer].GetHonor() + "; ";
            toolStripTextBoxPatience.Text = listPlayers[curPlayer].GetPatience();
        }
        
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           // panel1.Location.Y = 54 + heightForm1 - Form1.ActiveForm.Size.Height;
          //panel1.Top = 50;
            //pictureBox1.Top = 0;
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            SetTransparence();
            //widthForm1 = Form1.ActiveForm.Size.Width;
            // heightForm1 = Form1.ActiveForm.Size.Height;
            
        }

        private void label0201_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обменный пункт");
         
        }

        private void FormField1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void SetTransparence()
        {
            label0106.Parent = picBoxField1;
            label0107.Parent = picBoxField1;
            label0108.Parent = picBoxField1;
            label0109.Parent = picBoxField1;
            label0201.Parent = picBoxField1;
            label0202.Parent = picBoxField1;
            label0203.Parent = picBoxField1;
            label0204.Parent = picBoxField1;
            label0205.Parent = picBoxField1;
            label0206.Parent = picBoxField1;
            label0207.Parent = picBoxField1;
            label0208.Parent = picBoxField1;
            label0209.Parent = picBoxField1;
            label0302.Parent = picBoxField1;
            label0303.Parent = picBoxField1;
            label0304.Parent = picBoxField1;
            label0305.Parent = picBoxField1;
            label0306.Parent = picBoxField1;
            label0307.Parent = picBoxField1;
            label0308.Parent = picBoxField1;
            label0309.Parent = picBoxField1;
            label0402.Parent = picBoxField1;
            label0403.Parent = picBoxField1;
            label0404.Parent = picBoxField1;
            label0405.Parent = picBoxField1;
            label0407.Parent = picBoxField1;
            label0408.Parent = picBoxField1;
            label0409.Parent = picBoxField1;
            label0502.Parent = picBoxField1;
            label0503.Parent = picBoxField1;
            label0504.Parent = picBoxField1;
            label0505.Parent = picBoxField1;
            label0507.Parent = picBoxField1;
            label0508.Parent = picBoxField1;
            label0509.Parent = picBoxField1;
            label0602.Parent = picBoxField1;
            label0603.Parent = picBoxField1;
            label0604.Parent = picBoxField1;
            label0605.Parent = picBoxField1;
            label0606.Parent = picBoxField1;
            label0607.Parent = picBoxField1;
            label0608.Parent = picBoxField1;
            label0609.Parent = picBoxField1;
            label0702.Parent = picBoxField1;
            label0704.Parent = picBoxField1;
            label0705.Parent = picBoxField1;
            label0706.Parent = picBoxField1;
            label0708.Parent = picBoxField1;
            label0709.Parent = picBoxField1;
            label0802.Parent = picBoxField1;
            label0803.Parent = picBoxField1;
            label0804.Parent = picBoxField1;
            label0805.Parent = picBoxField1;
            label0807.Parent = picBoxField1;
            label0808.Parent = picBoxField1;
            label0809.Parent = picBoxField1;
            label0902.Parent = picBoxField1;
            label0903.Parent = picBoxField1;
            label0904.Parent = picBoxField1;
            label0905.Parent = picBoxField1;
            label0907.Parent = picBoxField1;
            label0908.Parent = picBoxField1;
            label0909.Parent = picBoxField1;
            label1002.Parent = picBoxField1;
            label1002.Parent = picBoxField1;
            label1003.Parent = picBoxField1;
            label1004.Parent = picBoxField1;
            label1005.Parent = picBoxField1;
            label1006.Parent = picBoxField1;
            label1007.Parent = picBoxField1;
            label1008.Parent = picBoxField1;
            label1009.Parent = picBoxField1;
            label1101.Parent = picBoxField1;
            label1102.Parent = picBoxField1;
            label1103.Parent = picBoxField1;
            label1104.Parent = picBoxField1;
            label1105.Parent = picBoxField1;
            label1106.Parent = picBoxField1;
            label1107.Parent = picBoxField1;
            label1108.Parent = picBoxField1;
            label1109.Parent = picBoxField1;
            label1206.Parent = picBoxField1;
            label1207.Parent = picBoxField1;
            label1208.Parent = picBoxField1;
            label1209.Parent = picBoxField1;
        }
    }
}
