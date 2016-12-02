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
        List<Label> listPlaces = new List<Label>();
        List<Button> listButtonPlayers = new List<Button>();
        List<int> listContrabands = new List<int>();
        const int countJourneys = 6;
        List<int> listJourneys = new List<int>();
        
        short curPlayer = 0;
        short curRound = 1;
        short curTurn = 1;
        short curRes = 0;
        int bankMoney = 0;
        //public Player[] msPlayers = new Player[2];
        public static FormField1 SelfRef
        {
            get;
            set;
        }
        public FormField1(List<string> ltPlayers)
        {
            InitializeComponent();
            SelfRef = this;
            for (int i = 0; i < ltPlayers.Count; i++)
            {
                listPlayers.Add(new Player(ltPlayers[i], i));
            }
            Random rnd = new Random();
            while(listJourneys.Count == countJourneys)
            {
               int t = rnd.Next(countJourneys-1) +1;
                if (!listJourneys.Exists(x => x == t))
                {
                    listJourneys.Add(t);
                }
            }
            for (int i=1;i<=5;i++)
            {
                listContrabands.Add(i);
            }

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
            FillListPlaces();
            //widthForm1 = Form1.ActiveForm.Size.Width;
            // heightForm1 = Form1.ActiveForm.Size.Height;
            for (int i = 0; i < listPlayers.Count; i++)
            {
                for (int j = 0; j < listPlaces.Count; j++)
                {
                    if (listPlaces[j].Name == listPlayers[i].Place)
                    {
                        listButtonPlayers.Add(new Button());
                        listButtonPlayers[i].Location = new Point(listPlaces[j].Location.X, listPlaces[j].Location.Y + listPlaces[j].Size.Height-15);
                        listButtonPlayers[i].Name = "ButtonPlayer" + (i);
                        listButtonPlayers[i].Size = new Size(30, 30);
                        listButtonPlayers[i].TabIndex = 0;
                        listButtonPlayers[i].Text = "" + (i + 1);
                        listButtonPlayers[i].BackColor = Color.Orange; 
                        listButtonPlayers[i].Click += new EventHandler(ButtonPlayer_Click); 
                        Controls.Add(listButtonPlayers[i]);
                        listButtonPlayers[i].Parent = picBoxField1;
                        listButtonPlayers[i].BringToFront();
                        break;
                    }
                }
            }
            SetStatus();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            string newPlace = ((Label)sender).Name;
            Title oldTitile = new Title(newPlace);
            if (curRes > 0 && PathFinding(listPlayers[curPlayer].Place, newPlace, curRes))
            {
                listPlayers[curPlayer].Place = newPlace;//Перемещение
                for (int j = 0; j < listPlaces.Count; j++)
                {
                    if (listPlaces[j].Name == newPlace)
                    {
                        listButtonPlayers[curPlayer].Location = new Point(listPlaces[j].Location.X, listPlaces[j].Location.Y+listPlaces[j].Size.Height - 15);
                    }
                }
                curRes = 0;
                //Выполнение условий поля
                ExecuteField(newPlace);
            }
              else
                  MessageBox.Show("Невозможно туда переместиться");

        }

        private void ExecuteField(string place)
        {
            DialogResult dialogResult = new DialogResult();
            Random rnd = new Random();
            switch(place)
            {
                case "label0106":
                    dialogResult = MessageBox.Show("Стражники предлагают сыграть в кости. \nCтавятся 5 талеров и кидаются два кубика:\n9-12 ты выиграл 15 талеров.\nВы согласны сыграть?", "Застава", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (listPlayers[curPlayer].Talers>=5)
                        {
                            int t1 = rnd.Next(6) + 1;
                            int t2 = rnd.Next(6) + 1;
                            if ((t1 + t2) > 9)
                            {
                                MessageBox.Show("Вы выкинули " + t1 + " и " + t2 + ".\nВы выиграли 15 талеров");
                                listPlayers[curPlayer].Talers += 15;
                            }
                            else
                            {
                                MessageBox.Show("Вы выкинули " + t1 + " и " + t2 + ".\nВы проиграли 5 талеров (Они переходят в банк).");
                                listPlayers[curPlayer].Talers -= 5;
                                bankMoney += 5;
                            }
                        }
                        else
                        {
                            MessageBox.Show("У вас нет 5 талеров.");
                        }
                    }
                    /*else if (dialogResult == DialogResult.No)
                    {
                    }*/
                    break;
                case "label0107":
                    FormShop FrmS = new FormShop("Контрабанда", listContrabands, listPlayers[curPlayer].Experience, listPlayers[curPlayer].Talers);
                    FrmS.Activate();
                    FrmS.Owner = this;
                    this.Hide();
                    FrmS.Show();
                    break;
				case "label0108":
                    List<string> listSelects = new List<string>();
                    listSelects.Add("1 тур - 5 талеров");
                    listSelects.Add("2 тура - 10 талеров");
                    listSelects.Add("3 тура - 15 талеров");
                    listSelects.Add("Отказаться);
				FormShop FrmSelection = new FormSelection("Вы можете завербоваться и остаться на поле Иностранный лиегион. \nВыберите срок и оплату. \nПо окончании срока службы бросится кубик:\n1-4 поулчаетете деньги\n5-6Вас объявили дезертиром (теряете 1 ПЖ и половину выслуженный денег)", listSelects);
                    FrmSelection.Activate();
                    FrmSelection.Owner = this;
                    this.Hide();
                    FrmSelection.Show();
				break;
            }
            SetStatus();
        }

        public void setNewVars(int playersTalers, List<string> listItems)
        {
            listPlayers[curPlayer].Talers = playersTalers;
            foreach (string curItem in listItems)
            {
                listPlayers[curPlayer].listItems.Add(curItem);
            }
            SetStatus();
        }

        public void addedNewAtStart(string item, int leftTours)
        {
            listPlayers[curPlayer].leftTurns = leftTours;
            listPlayers[curPlayer].listAtStartTurn.Add(item);
        }

        private bool PathFinding(string from, string where, short N)
        {
            List<List<Title>> listOfLists = new List<List<Title>>();
            for (int i=0;i<=N;i++)
            {
                listOfLists.Add(new List<Title>());
            }

            listOfLists[0].Add(new Title(from));
            for (int i = 1; i <= N; i++)
            {
                for(int j=0;j<listOfLists[i-1].Count;j++)
                {
                    foreach (string strNear in listOfLists[i - 1][j].NearTitles)
                    {
                        if (i > 1 && !listOfLists[i - 2].Exists(x => x.Place == strNear)) 
                        {
                            listOfLists[i].Add(new Title(strNear));
                        }
                        else if (i < 2)
                        {
                            listOfLists[i].Add(new Title(strNear));
                        }
                    }
                }
            }
            for (int j = 0; j < listOfLists[N].Count; j++)
            {
                if (listOfLists[N][j].Place == where)
                {
                    return true;
                }
            }
            return false;
        }

        private void ButtonPlayer_Click(object sender, EventArgs e)
        {
        }

        private void кинутьКубикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxRes.Text == "")
            {
                Random rnd = new Random();
                int res = rnd.Next(6) + 1;
                curRes = (short)res;
                toolStripTextBoxRes.Text = "На кубике " + res;
            }
        }

        private void ToolStripMenuItems_Click(object sender, EventArgs e)
        {
            FormInventory FrmInv = new FormInventory(curPlayer, curTurn, listPlayers[curPlayer].listItems);
            FrmInv.Activate();
            FrmInv.Show();
        }


        private void закончитьХодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beginEndTurn:
            if (curPlayer < (listPlayers.Count - 1))
            {
                curPlayer++;
            }
            else
            {
                curPlayer = 0;
                curRound++;
            }
            curTurn++;
            SetStatus();
            curRes = 0;
            toolStripTextBoxRes.Text = "";
            if (listPlayers[curPlayer].leftTurns>0)
            {
                MessageBox.Show("Игроку №"+(curPlayer+1)+" осталось "+listPlayers[curPlayer].leftTurns+" туров (включая текущий) до своего хода");
                listPlayers[curPlayer].leftTurns--;
                goto beginEndTurn;
            }
            Random rnd = new Random();
            int t = 0;
            foreach (string curAtStart in listPlayers[curPlayer].listAtStartTurn)
            {
                
                switch (curAtStart)
                {
                    case "1 тур - 5 талеров":
                        t = rnd.Next(6)+1; 
                        if (t<5)
                        {
                            listPlayers[curPlayer].Talers+=5;
                            MessageBox.Show("Игрок №"+(curPlayer+1)+" отслужил в Иностранном легионе и получил 5 талеров");
                        }
                        else
                        {
                            listPlayers[curPlayer].Talers+=3;
                            listPlayers[curPlayer].Health--;
                            MessageBox.Show("Игрок №"+(curPlayer+1)+" отслужил в Иностранном легионе и был объявлен дезертиром. Получено 3 талеров и потерян один ПЖ");
                        }
                        break;
                    case "2 тура - 5 талеров":
                        if (t<5)
                        {
                            MessageBox.Show("Игрок №"+(curPlayer+1)+" отслужил в Иностранном легионе и получил 10 талеров");
                            listPlayers[curPlayer].Talers+=10;
                        }
                        else
                        {
                            listPlayers[curPlayer].Talers+=5;
                            listPlayers[curPlayer].Health--;
                            MessageBox.Show("Игрок №"+(curPlayer+1)+" отслужил в Иностранном легионе и был объявлен дезертиром. Получено 5 талеров и потерян один ПЖ");
                        }
                        break;
                    case "3 тура - 15 талеров":
                        if (t<5)
                        {
                            listPlayers[curPlayer].Talers+=15;
                            MessageBox.Show("Игрок №"+(curPlayer+1)+" отслужил в Иностранном легионе и получил 15 талеров");
                        }
                        else
                        {
                            listPlayers[curPlayer].Talers+=8;
                            listPlayers[curPlayer].Health--;
                            MessageBox.Show("Игрок №"+(curPlayer+1)+" отслужил в Иностранном легионе и был объявлен дезертиром. Получено 8 талеров и потерян один ПЖ");
                        }
                        break;
                }
            }
        }

        private void SetStatus()
        {
            toolStripTextBoxCurPlayer.Text = "Ход игрока №" + (curPlayer + 1);
            toolStripTextBoxCharName.Text = listPlayers[curPlayer].Name();
            toolStripTextBoxKindness.Text = listPlayers[curPlayer].Kindness;
            toolStripTextBoxHonor.Text = listPlayers[curPlayer].Honor;
            toolStripTextBoxPatience.Text = listPlayers[curPlayer].Patience;
            toolStripTextBoxRound.Text = "Тур: " + curRound;
            toolStripTextBoxTurn.Text = "Ход: " + curTurn;
            labeltTalers.Text = ""+listPlayers[curPlayer].Talers;
            labelHealth.Text = "Пункты жизни: "+listPlayers[curPlayer].Health;
            labelInt.Text = "Пункты ума: " + listPlayers[curPlayer].Intellect;
            labelMagic.Text = "Пункты магии: " + listPlayers[curPlayer].Magic;
            labelStrength.Text = "Пункты силы: " + listPlayers[curPlayer].Strength;
            labelExp.Text = "Пункты\nопыта:\n   " + listPlayers[curPlayer].Experience;
        }

        private void FormField1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void FillListPlaces()
        {
            listPlaces.Add(label0106);
            listPlaces.Add(label0107);
            listPlaces.Add(label0108);
            listPlaces.Add(label0109);
            listPlaces.Add(label0201);
            listPlaces.Add(label0202);
            listPlaces.Add(label0203);
            listPlaces.Add(label0204);
            listPlaces.Add(label0205);
            listPlaces.Add(label0206);
            listPlaces.Add(label0207);
            listPlaces.Add(label0208);
            listPlaces.Add(label0209);
            listPlaces.Add(label0302);
            listPlaces.Add(label0303);
            listPlaces.Add(label0304);
            listPlaces.Add(label0305);
            listPlaces.Add(label0306);
            listPlaces.Add(label0307);
            listPlaces.Add(label0308);
            listPlaces.Add(label0309);
            listPlaces.Add(label0402);
            listPlaces.Add(label0403);
            listPlaces.Add(label0404);
            listPlaces.Add(label0405);
            listPlaces.Add(label0407);
            listPlaces.Add(label0408);
            listPlaces.Add(label0409);
            listPlaces.Add(label0502);
            listPlaces.Add(label0503);
            listPlaces.Add(label0504);
            listPlaces.Add(label0505);
            listPlaces.Add(label0507);
            listPlaces.Add(label0508);
            listPlaces.Add(label0509);
            listPlaces.Add(label0602);
            listPlaces.Add(label0603);
            listPlaces.Add(label0604);
            listPlaces.Add(label0605);
            listPlaces.Add(label0606);
            listPlaces.Add(label0607);
            listPlaces.Add(label0608);
            listPlaces.Add(label0609);
            listPlaces.Add(label0702);
            listPlaces.Add(label0704);
            listPlaces.Add(label0705);
            listPlaces.Add(label0706);
            listPlaces.Add(label0708);
            listPlaces.Add(label0709);
            listPlaces.Add(label0802);
            listPlaces.Add(label0803);
            listPlaces.Add(label0804);
            listPlaces.Add(label0805);
            listPlaces.Add(label0807);
            listPlaces.Add(label0808);
            listPlaces.Add(label0809);
            listPlaces.Add(label0902);
            listPlaces.Add(label0903);
            listPlaces.Add(label0904);
            listPlaces.Add(label0905);
            listPlaces.Add(label0907);
            listPlaces.Add(label0908);
            listPlaces.Add(label0909);
            listPlaces.Add(label1002);
            listPlaces.Add(label1003);
            listPlaces.Add(label1004);
            listPlaces.Add(label1005);
            listPlaces.Add(label1006);
            listPlaces.Add(label1007);
            listPlaces.Add(label1008);
            listPlaces.Add(label1009);
            listPlaces.Add(label1101);
            listPlaces.Add(label1102);
            listPlaces.Add(label1103);
            listPlaces.Add(label1104);
            listPlaces.Add(label1105);
            listPlaces.Add(label1106);
            listPlaces.Add(label1107);
            listPlaces.Add(label1108);
            listPlaces.Add(label1109);
            listPlaces.Add(label1206);
            listPlaces.Add(label1207);
            listPlaces.Add(label1208);
            listPlaces.Add(label1209);
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
