using System;
using System.Collections.Generic;
using System.Text;

namespace CrownOfEmber.Classes
{
    class Title
    {
        /*
        public struct dbTitle
        {
            public string Place;
            public string Name;
            public int locX;
            public int locY;
            public List<string> NearTitles;           
        }

        List<dbTitle> listTitles = new List<dbTitle>();
        //dbTitle
        */
        public Title(string Place)
        {
            this.Place = Place;
            string strTitles = Properties.Resources.TextFileTitles;
            string[] strTitle = strTitles.Split(new char[] { '\n' });
            foreach (string curTitle in strTitle)
            {
                // if (curTitle.Contains(Place))
                if (curTitle.Substring(0,9)==Place)
                {
                    string[] fieldTitle = curTitle.Split(new char[] {';'});
                    Name = fieldTitle[1];
                    World = fieldTitle[2];
                    if (fieldTitle[fieldTitle.Length - 1].Length>9)
                    {
                       fieldTitle[fieldTitle.Length - 1]=fieldTitle[fieldTitle.Length - 1].Substring(0, 9);
                    }
                    for (int i=3;i< fieldTitle.Length;i++)
                    {
                        NearTitles.Add(fieldTitle[i]);
                    }
                    break;
                }
            }
        }

        int locationX = 0;
        int locationY = 0;
        string strName;
        string strPlace;
        string strWorld;
        public List<string> NearTitles = new List<string>();
        public int X
        {
            get { return locationX; }
            set { locationX = value; }
        }
        public int Y
        {
            get { return locationY; }
            set { locationY = value; }
        }
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
        public string Place
        {
            get { return strPlace; }
            set { strPlace = value; }
        }
        public string World
        {
            get { return strWorld; }
            set { strWorld = value; }
        }
    }
}
