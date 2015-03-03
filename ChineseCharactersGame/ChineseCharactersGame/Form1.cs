using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ChineseCharactersGame
{
    public partial class Form1 : Form
    {
        //parameter which use for text rolling in textBox1
        private string Str = "Welcome ";
        private StringBuilder Sb = null;
        private int Len_text = 30;
        private char[] Text_container = null;

        //control background music
        SoundPlayer Player = new SoundPlayer(ChineseCharactersGame.Properties.Resources.huimeng1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //control rolling text which is using timer
            Str = Str.PadLeft(Len_text, ' ');
            Text_container = Str.ToCharArray();

            textBox1.Text = Str;

            timer1.Enabled = true;
            timer1.Start();

            soundToolStripMenuItem.Checked = true;

            //play background music
            Player.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)//control time change
        {
            //using random number which is from 0--255 to change text'color
            Random Rd = new Random();
            int Color_x, Color_y, Color_z;

            Sb = new StringBuilder();

            for (int i = 0; i < Text_container.Length; i++)
            {
                if (i > 0)
                {
                    Sb.Append(Text_container[i]);
                }

            }
            Sb.Append(Text_container[0]);

            textBox1.Text = Sb.ToString();
            Text_container = Sb.ToString().ToCharArray();

            Color_x = Rd.Next() % 256;
            Color_y = Rd.Next() % 256;
            Color_z = Rd.Next() % 256;

            textBox1.ForeColor = Color.FromArgb(Color_x, Color_y, Color_z);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        private void historyOfStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to show history of story one form
            Form2 Form_history1 = new Form2();

            Form_history1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gamehelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show gamehelp form
            Form3 Form_help1 = new Form3();

            Form_help1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show "Can you click" game
            Form4 Game1 = new Form4(this);

            Game1.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show "Can you collect" game
            Form5 Game2 = new Form5(this);

            Game2.Show();
            this.Visible = false;
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show "Can you click" game
            Form4 Game1 = new Form4(this);

            Game1.Show();
            this.Visible = false;
        }

        private void canYouCollectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show "Can you collect" game
            Form5 Game2 = new Form5(this);

            Game2.Show();
            this.Visible = false;
        }

        //two method below is for contorling music on or off
        private void soundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (soundToolStripMenuItem.Checked == true)
                soundToolStripMenuItem.Checked = false;
            else
                soundToolStripMenuItem.Checked = true;
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            if (soundToolStripMenuItem.Checked == true)
                Player.PlayLooping();
            else
                Player.Stop();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
