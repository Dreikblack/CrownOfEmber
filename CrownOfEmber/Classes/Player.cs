using System;
using System.Collections.Generic;
using System.Text;

namespace CrownOfEmber.Classes
{
    class Player
    {
        public Player(string charName)
        {
            nameChar = charName;
            switch (nameChar)
            {
                case "Эльф":
                kindness = "Добрый";
                break;
                case "Гоблин":
                kindness = "Злой";
                break;
            }
            switch (nameChar)
            {
                case "Эльф":
                    honor = "Честный";
                    break;
                case "Гоблин":
                    honor = "Бесчестный";
                    break;
            }
            switch (nameChar)
            {
                case "Эльф":
                    patience = "Терепеливый";
                    break;
                case "Гоблин":
                    patience = "Нетерпеливый";
                    break;
            }
        }
        string nameChar;
        string strKindness;
        string strHonor;
        string strPatience;
        public string charName()
        {
            return nameChar;
        }
        public string kindness
        {
           get { return strKindness; }
           set { strKindness = value; }
        }
        public string honor
        {
            get { return strHonor; }
            set { strHonor = value; }
        }
        public string patience
        {
            get { return strPatience; }
            set { strPatience = value; }
        }
    }
}
