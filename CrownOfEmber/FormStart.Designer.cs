namespace CrownOfEmber
{
    partial class FormStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxChar = new System.Windows.Forms.ListBox();
            this.picBoxCardChar = new System.Windows.Forms.PictureBox();
            this.labelSelectChar = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPlayerN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNumberOfPlayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxChar
            // 
            this.listBoxChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxChar.FormattingEnabled = true;
            this.listBoxChar.ItemHeight = 24;
            this.listBoxChar.Items.AddRange(new object[] {
            "Эльф",
            "Гоблин"});
            this.listBoxChar.Location = new System.Drawing.Point(13, 61);
            this.listBoxChar.Name = "listBoxChar";
            this.listBoxChar.Size = new System.Drawing.Size(108, 172);
            this.listBoxChar.TabIndex = 0;
            this.listBoxChar.SelectedIndexChanged += new System.EventHandler(this.listBoxChar_SelectedIndexChanged);
            // 
            // picBoxCardChar
            // 
            this.picBoxCardChar.Image = global::CrownOfEmber.Properties.Resources.CardElf;
            this.picBoxCardChar.Location = new System.Drawing.Point(185, 12);
            this.picBoxCardChar.Name = "picBoxCardChar";
            this.picBoxCardChar.Size = new System.Drawing.Size(600, 268);
            this.picBoxCardChar.TabIndex = 1;
            this.picBoxCardChar.TabStop = false;
            // 
            // labelSelectChar
            // 
            this.labelSelectChar.AutoSize = true;
            this.labelSelectChar.Location = new System.Drawing.Point(12, 36);
            this.labelSelectChar.Name = "labelSelectChar";
            this.labelSelectChar.Size = new System.Drawing.Size(99, 13);
            this.labelSelectChar.TabIndex = 2;
            this.labelSelectChar.Text = "Выбор персонажа";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(13, 288);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(99, 23);
            this.buttonStartGame.TabIndex = 3;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 9);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPlayerN
            // 
            this.labelPlayerN.AutoSize = true;
            this.labelPlayerN.Location = new System.Drawing.Point(10, 9);
            this.labelPlayerN.Name = "labelPlayerN";
            this.labelPlayerN.Size = new System.Drawing.Size(52, 13);
            this.labelPlayerN.TabIndex = 5;
            this.labelPlayerN.Text = "Игрок №";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать этого персонажа";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfPlayers
            // 
            this.labelNumberOfPlayers.AutoSize = true;
            this.labelNumberOfPlayers.Location = new System.Drawing.Point(118, 293);
            this.labelNumberOfPlayers.Name = "labelNumberOfPlayers";
            this.labelNumberOfPlayers.Size = new System.Drawing.Size(68, 13);
            this.labelNumberOfPlayers.TabIndex = 7;
            this.labelNumberOfPlayers.Text = "с 1 игроком";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 319);
            this.Controls.Add(this.labelNumberOfPlayers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPlayerN);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelSelectChar);
            this.Controls.Add(this.picBoxCardChar);
            this.Controls.Add(this.listBoxChar);
            this.Name = "FormStart";
            this.Text = "FormStart";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChar;
        private System.Windows.Forms.PictureBox picBoxCardChar;
        private System.Windows.Forms.Label labelSelectChar;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelPlayerN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNumberOfPlayers;
    }
}