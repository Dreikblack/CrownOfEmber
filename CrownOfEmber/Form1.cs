using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrownOfEmber
{
    public partial class FormField1 : Form
    {
       // public int widthForm1 = 0;
     //   public int heightForm1 = 0;

        public FormField1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           // panel1.Location.Y = 54 + heightForm1 - Form1.ActiveForm.Size.Height;
          //panel1.Top = 50;
            //pictureBox1.Top = 0;
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
