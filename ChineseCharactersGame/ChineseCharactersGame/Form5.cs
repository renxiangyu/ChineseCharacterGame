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
    public partial class Form5 : Form
    {
        private Riddle[] riddle = new Riddle[20];
        private int[] appear = new int[20];
        private int Time;
        private int Score;
        private int now = -1;
        private Form1 form = new Form1();
        private SoundPlayer Player = new SoundPlayer(ChineseCharactersGame.Properties.Resources.huimeng2);

        public Form5(Form1 f)
        {
            InitializeComponent();

            form = f;

            riddle[0] = new Riddle(ChineseCharactersGame.Properties.Resources.zi1, ChineseCharactersGame.Properties.Resources.z1ck, ChineseCharactersGame.Properties.Resources.z1ek);
            riddle[1] = new Riddle(ChineseCharactersGame.Properties.Resources.zi2, ChineseCharactersGame.Properties.Resources.zi2ck, ChineseCharactersGame.Properties.Resources.zi2ek);
            riddle[2] = new Riddle(ChineseCharactersGame.Properties.Resources.zi3, ChineseCharactersGame.Properties.Resources.zi3ck, ChineseCharactersGame.Properties.Resources.zi3ek);
            riddle[3] = new Riddle(ChineseCharactersGame.Properties.Resources.zi4, ChineseCharactersGame.Properties.Resources.zi4ck, ChineseCharactersGame.Properties.Resources.zi4ek);
            riddle[4] = new Riddle(ChineseCharactersGame.Properties.Resources.zi5, ChineseCharactersGame.Properties.Resources.zi5ck, ChineseCharactersGame.Properties.Resources.zi5ek);
            riddle[5] = new Riddle(ChineseCharactersGame.Properties.Resources.zi6, ChineseCharactersGame.Properties.Resources.zi6ck, ChineseCharactersGame.Properties.Resources.zi6ek);
            riddle[6] = new Riddle(ChineseCharactersGame.Properties.Resources.zi7, ChineseCharactersGame.Properties.Resources.zi7ck, ChineseCharactersGame.Properties.Resources.zi7ek);
            riddle[7] = new Riddle(ChineseCharactersGame.Properties.Resources.zi8, ChineseCharactersGame.Properties.Resources.zi8ck, ChineseCharactersGame.Properties.Resources.zi8ek);
            riddle[8] = new Riddle(ChineseCharactersGame.Properties.Resources.zi9, ChineseCharactersGame.Properties.Resources.zi9ck, ChineseCharactersGame.Properties.Resources.zi9ek);
            riddle[9] = new Riddle(ChineseCharactersGame.Properties.Resources.zi10, ChineseCharactersGame.Properties.Resources.zi10ck, ChineseCharactersGame.Properties.Resources.zi10ek);
        }

        private void startAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;

            Random Rd = new Random();

            button1.Enabled = true;
            button2.Enabled = true;

            timer1.Interval = 1000;
            timer1.Enabled = true;
            Time = 60;
            label2.Text = Time.ToString();

            Score = 0;
            label4.Text = Score.ToString();

            for (i = 0; i < 10; i++)
                appear[i] = 0;

            now = Rd.Next() % 10;
            appear[now] = 1;
            textBox1.Text = riddle[now].getriddle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time--;
            label2.Text = Time.ToString();

            int i;

            if (Time == 0)
            {
                timer1.Enabled = false;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                for (i = 0; i < 10; i++)
                    appear[i] = 0;

                if (Score > 80) MessageBox.Show("You did a good job!");
                else if (Score > 60) MessageBox.Show("You are a smart guy!");
                else if (Score > 30) MessageBox.Show("You can do better and know much about Chinese character!");
                else if (Score <= 20) MessageBox.Show("You should learn much more about Chinese character!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;

            Random Rd = new Random();

            if (textBox2.Text.Trim() == riddle[now].getenglishkey().Trim() || textBox3.Text.Trim() == riddle[now].getchinesekey().Trim())
            {
                Score += 10;
                label4.Text = Score.ToString();

                if (Score == 100)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("You are so remarkable to finish all riddles of Chinese characters.Congratulations!");

                    Time = 0;
                    label2.Text = Time.ToString();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }

                else
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    while (true)
                    {
                        x = Rd.Next() % 10;
                        if (appear[x] == 0)
                        {
                            now = x;
                            appear[now] = 1;
                            textBox1.Text = riddle[now].getriddle();
                            break;
                        }
                    }
                }
            }

            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();

            this.Close();
        }

        private void soundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (soundToolStripMenuItem.Checked == false)
                soundToolStripMenuItem.Checked = true;
            else
                soundToolStripMenuItem.Checked = false;
        }

        private void gameHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
        }

        private void histroyOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void CheckChange(object sender, EventArgs e)
        {
            if (soundToolStripMenuItem.Checked == true)
                Player.PlayLooping();
            else
                Player.Stop();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Player.PlayLooping();
        }
    }

    public class Riddle
    {
        private string riddleOfCharacter;
        private string chineseKey;
        private string englishKey;

        public Riddle(string r, string rc, string re)
        {
            riddleOfCharacter = r;
            chineseKey = rc;
            englishKey = re;
        }

        public string getriddle()
        {
            return riddleOfCharacter;
        }

        public string getchinesekey()
        {
            return chineseKey;
        }

        public string getenglishkey()
        {
            return englishKey;
        }
    }
}
