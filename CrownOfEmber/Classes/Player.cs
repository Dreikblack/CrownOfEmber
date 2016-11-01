using System;
using System.Collections.Generic;
using System.Text;

namespace CrownOfEmber.Classes
{
    class Player
    {
        public Player(string charName, int n)
        {
            nameChar = charName;
            Number = n;
            switch (nameChar)
            {
                case "Эльф":
                Kindness = "Добрый";
                break;
                case "Гоблин":
                Kindness = "Злой";
                break;
            }
            switch (nameChar)
            {
                case "Эльф":
                    Honor = "Честный";
                    break;
                case "Гоблин":
                    Honor = "Бесчестный";
                    break;
            }
            switch (nameChar)
            {
                case "Эльф":
                    Patience = "Терепеливый";
                    break;
                case "Гоблин":
                    Patience = "Нетерпеливый";
                    break;
            }
        }

        int numberPl;

        string nameChar;
        string strKindness;
        string strHonor;
        string strPatience;

        int pointsStrength = 0;  
        int pointsMagic = 0;
        int pointsIntellect = 0;
        int pointsHealth = 0;
        int pointsExp = 0;

        int talers = 0;


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

        public string CharName()
        {
            return nameChar;
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
    }
}
