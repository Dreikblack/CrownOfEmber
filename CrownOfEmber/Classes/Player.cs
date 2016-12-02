using System;
using System.Collections.Generic;
using System.Text;

namespace CrownOfEmber.Classes
{
    class Player
    {
        public Player(string charName, int n)
        {
            this.charName = charName;
            Number = n;
            switch (this.charName)
            {
                case "Амазонка":
                case "Гусар":
                case "Звездочёт":
                case "Фея":
                case "Эльф":
                case "Монах":
                    Kindness = "Добрый";
                    break;
                case "Безумный учёный":
                case "Знахарка":
                case "Инопланетянин":
                case "Цыган":
                case "Гладиатор":
                    Kindness = "Нейтральный";
                    break;
                case "Гоблин":
                case "Мутант":
                case "Королева ведьм":
                case "Наёмник":
                case "Ниндзя":
                case "Оборотень":
                case "Разрушитель":
                    Kindness = "Злой";
                    break;
            }
            switch (this.charName)
            {
                case "Амазонка":
                case "Гладиатор":
                case "Гусар":
                case "Звездочёт":
                case "Инопланетянин":
                case "Монах":
                case "Мутант":
                case "Наёмник":
                case "Фея":
                case "Эльф":         
                    Honor = "Честный";
                    break;
                case "Безумный учёный":
                case "Знахарка": 
                case "Цыган":
                case "Гоблин":              
                case "Королева ведьм":               
                case "Ниндзя":
                case "Оборотень":
                case "Разрушитель":
                    Honor = "Нечестный";
                    break;
            }
            switch (this.charName)
            {
               
                case "Гусар":
                case "Звездочёт":
                case "Знахарка":
                case "Монах":
                case "Мутант":
                case "Наёмник":
                case "Ниндзя":
                case "Разрушитель":
                case "Фея":
                case "Эльф":
                    Patience = "Терепеливый";
                    break;
                case "Амазонка":
                case "Безумный учёный":
                case "Цыган":
                case "Гладиатор":
                case "Гоблин":
                case "Инопланетянин":
                case "Королева ведьм":           
                case "Оборотень":
                    Patience = "Нетерпеливый";
                    break;
            }
            switch (this.charName)
            {
                case "Амазонка":
                case "Безумный учёный":
                case "Звездочёт":
                case "Оборотень":
                    Strength = 2;
                    break;
                case "Знахарка":
                case "Инопланетянин":
                case "Королева ведьм":
                case "Монах":
                case "Фея":
                case "Эльф":
                    Strength = 3;
                    break;
                case "Гусар":
                case "Цыган":
                    Strength = 4;
                    break;
                case "Гладиатор":
                case "Гоблин":
                case "Мутант":
                case "Наёмник":
                case "Ниндзя":
                    Strength = 5;
                    break;          
                case "Разрушитель":
                    Strength = 6;
                    break;
                
            }

            switch (this.charName)
            {
                case "Оборотень":             
                    Intellect = 2;
                    break;
                case "Гоблин":
                case "Цыган":
                    Intellect = 3;
                    break;
                case "Амазонка":
                case "Гладиатор":
                case "Гусар":
                case "Знахарка":
                case "Ниндзя":
                    Intellect = 4;
                    break;           
                case "Звездочёт":
                case "Инопланетянин":
                case "Королева ведьм":
                case "Монах":
                case "Наёмник":
                case "Фея":
                case "Эльф":
                    Intellect = 5;
                    break;
                case "Безумный учёный":
                case "Мутант":
                case "Разрушитель":
                    Intellect = 6;
                    break;
            }

            switch (this.charName)
            {
                case "Мутант":
                case "Разрушитель":
                    Magic = 1;
                    break;
                case "Гусар":
                case "Инопланетянин":
                    Magic = 2;
                    break;
                case "Безумный учёный":
                case "Гладиатор":
                case "Наёмник":
                case "Ниндзя":
                    Magic = 3;
                    break;
                case "Амазонка":
                case "Гоблин":
                case "Звездочёт":
                case "Знахарка":
                case "Монах":
                case "Эльф":             
                    Magic = 4;
                    break;
                case "Оборотень":
                case "Фея":
                case "Цыган":
                    Magic = 5;
                    break;
                case "Королева ведьм":
                    Magic = 6;
                    break;
            }
            switch (this.charName)
            {
                case "Инопланетянин":
                case "Королева ведьм":
                case "Наёмник":
                case "Разрушитель":
                    Health = 3;
                    break;
                case "Амазонка":
                case "Гладиатор":
                case "Гоблин":
                case "Звездочёт":
                case "Знахарка":
                case "Монах":
                case "Фея":
                case "Эльф":
                case "Цыган":
                    Health = 4;
                    break;               
                case "Безумный учёный":
                case "Гусар":
                case "Мутант":
                case "Ниндзя":
                case "Оборотень":
                    Health = 5;
                    break;
            }
            switch (this.charName)
            {
                case "Гусар":
                case "Оборотень":
                case "Фея":
                    Talers = 12;
                    break;
                case "Безумный учёный":
                case "Инопланетянин":
                case "Мутант":
                case "Разрушитель":
                case "Цыган":
                    Talers = 15;
                    break;
                case "Гоблин":
                case "Королева ведьм":
                case "Ниндзя":
                case "Эльф":
                    Talers = 18;
                    break;
                case "Амазонка":
                case "Гладиатор":
                case "Знахарка":
                case "Монах":
                case "Наёмник":
                    Talers = 20;
                    break;
                case "Звездочёт":
                    Talers = 22;
                    break;
            }

            switch (this.charName)
            {
                case "Гусар":
                    Place = "label0503";
                    break;
                case "Оборотень":
                    Place = "label0208";
                    break;
                case "Фея":
                    Place = "label0402";
                    break;
                case "Безумный учёный":
                    Place = "label0706";
                    break;
                case "Инопланетянин":
                    Place = "label1104";
                    break;
                case "Мутант":
                    Place = "label0704";
                    break;
                case "Разрушитель":
                    Place = "label0705";
                    break;
                case "Цыган":
                    Place = "label0202";
                    break;
                case "Гоблин":
                    Place = "label0502";
                    break;
                case "Королева ведьм":
                    Place = "label0602";
                    break;
                case "Ниндзя":
                    Place = "label1005";
                    break;
                case "Эльф":
                    Place = "label0708";
                    break;
                case "Амазонка":
                    Place = "label0407";
                    break;
                case "Гладиатор":
                    Place = "label0907";
                    break;
                case "Знахарка":
                    Place = "label0808";
                    break;
                case "Монах":
                    Place = "label0604";
                    break;
                case "Наёмник":
                    Place = "label1006";
                    break;
                case "Звездочёт":
                    Place = "label1105";
                    break;
            }
            if (charName=="Амазонка")
            {
                listItems.Add("Horse");
            }
        }

        int numberPl;

        private string charName;
        private string strKindness;
        private string strHonor;
        private string strPatience;

        private string place;

        private int pointsStrength = 0;
        private int pointsMagic = 0;
        private int pointsIntellect = 0;
        private int pointsHealth = 0;
        private int pointsExp = 0;
        private int talers = 0;
        private int turnsToEndSkipping = 0;

        public List<string> listItems = new List<string>();
        public List<string> listAtStartTurn = new List<string>();
        public int leftTurns
        {
            get { return turnsToEndSkipping; }
            set { turnsToEndSkipping = value; }
        }

        public int Number
        {
            get { return numberPl; }
            set { numberPl = value; }
        }

        public int Strength
        {
            get { return pointsStrength; }
            set
            {
                pointsStrength = value;
                if (pointsStrength>14)
                {
                    pointsStrength = 14;
                }
                else if (pointsStrength < 0)
                {
                    if ((pointsStrength * -1) <= Magic)
                    {
                        Magic += pointsStrength;
                    }
                    else if ((pointsStrength * -1) <= Intellect)
                    {
                        Intellect += pointsStrength;
                    }
                    else
                    {
                        pointsMagic += pointsStrength;
                        pointsStrength = pointsMagic;
                        Intellect += pointsStrength;
                        pointsMagic = 0;
                    }
                    pointsStrength = 0;
                }
            }
        }
        public int Magic
        {
            get { return pointsMagic; }
            set
            {
                pointsMagic = value;
                if (pointsMagic > 14)
                {
                    pointsMagic = 14;
                }
                else if (pointsMagic < 0)
                {
                    if ((pointsMagic * -1) <= Strength)
                    {
                        Strength += pointsMagic;
                    }
                    else if ((pointsMagic * -1) <= Intellect)
                    {
                        Intellect += pointsMagic;
                    }
                    else
                    {
                        pointsStrength += pointsMagic;
                        pointsMagic = pointsStrength;
                        Intellect += pointsMagic;
                        pointsStrength = 0;
                    }
                    pointsMagic = 0;
                }
            }
        }
        public int Intellect
        {
            get { return pointsIntellect; }
            set
            {
                pointsIntellect = value;
                if (pointsIntellect > 14)
                {
                    pointsIntellect = 14;
                }
                else if (pointsIntellect < 0)
                {
                    Health += pointsIntellect;
                    pointsIntellect = 0;
                }
            }
        }

        public int Talers
        {
            get { return talers; }
            set
            {
                talers = value;
                if (talers < 0)
                {
                    Intellect += (int)Math.Ceiling((double)(talers/5));
                    talers = 0;
                }
            }
        }

        public int Health
        {
            get { return pointsHealth; }
            set
            {
                pointsHealth = value;
                //  if (pointsHealth > 14)
                //   pointsHealth = 14;
                // else
                if (pointsHealth < 0)
                {
                    pointsHealth = 0;
                }
            }
        }
        public int Experience
        {
            get { return pointsExp; }
            set
            {
                pointsExp = value;
                if (pointsExp > 14)
                {
                    pointsExp = 14;
                }
            }
        }

        public string Name()
        {
            return charName;
        }
        public string Kindness
        {
           get { return strKindness; }
           set { strKindness = value; }
        }
        public string Honor
        {
            get { return strHonor; }
            set { strHonor = value; }
        }
        public string Patience
        {
            get { return strPatience; }
            set { strPatience = value; }
        }
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public bool HasAHorse()
        {
            if (listItems.Exists(x => x == "Horse"))
            {
                return true;
            }
            else
                return false;
        }
        public int FreeSlot()
        {
            if (!HasAHorse())
            {
                return 10 - listItems.Count;
            }
            else
            {
                return 10 - listItems.Count;
            }
         }
    }
}
