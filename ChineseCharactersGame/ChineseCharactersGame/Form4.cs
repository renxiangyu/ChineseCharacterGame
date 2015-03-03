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
    public partial class Form4 : Form
    {
        private string[] Array_words = new string[20];
        private string Select = "";
        private int[] selectPos = new int[20];
        private Character[] Base = new Character[1000] ;
        private int Difficulty = 1 ;
        private int Time;
        private int Score;
        private int TotalChoose = 0;
        private string initialConsonantSource = "bcdfghjklmnpqrstwxnyzn";
        private string syllableRimeSource = "aeiovu";
        private int initialConsonant = 10;
        private int syllableRime = 6;
        private int Cold = 0;
        private int Hot = 0;
        private int coldClick = 0;
        private int hotClick = 0;
        private Button[] buttonChoose = new Button[20];
        private Form1 form = new Form1();
        private SoundPlayer right = new SoundPlayer(ChineseCharactersGame.Properties.Resources.J0214098);
        private SoundPlayer wrong = new SoundPlayer(ChineseCharactersGame.Properties.Resources.Misc_StartLevel);
        private SoundPlayer Player = new SoundPlayer(ChineseCharactersGame.Properties.Resources.huimeng2);

        public Form4( Form1 f)
        {
            InitializeComponent();
            InitResource();
            InitButton();
            form = f;
        }

        public void InitButton()
        {
            buttonChoose[0] = button3;
            buttonChoose[1] = button4;
            buttonChoose[2] = button5;
            buttonChoose[3] = button6;
            buttonChoose[4] = button7;
            buttonChoose[5] = button8;
            buttonChoose[6] = button9;
            buttonChoose[7] = button10;
            buttonChoose[8] = button11;
            buttonChoose[9] = button12;
            buttonChoose[10] = button13;
            buttonChoose[11] = button14;
            buttonChoose[12] = button15;
            buttonChoose[13] = button16;
            buttonChoose[14] = button17;
            buttonChoose[15] = button18;

            int i;

            for (i = 0; i <= 15; i++)
                buttonChoose[i].BackColor = Color.White;
        }

        public void InitResource()
        {
            string temp , temp1 = "" , temp2 = "" , temp3 = "", t = "" ;
            int count = 0, total = 0;

            temp = ChineseCharactersGame.Properties.Resources.read;

            while (total < temp.Length)
            {
                if (temp[total] != '\n')
                    t += temp[total];
                else
                {
                    count++;
                    if (count < 3)
                    {
                        if (count == 1) temp1 = t;
                        else if (count == 2) temp2 = t;
                    }
                    else if (count == 3)
                    {
                        temp3 = t;
                        Base[TotalChoose] = new Character( temp1,temp2,temp3 );
                        count = 0;
                        TotalChoose++;
                    }
                    t = "";
                }
                total++;
            }

        }

        public void InitArray()//create array to click
        {
            int temppos , tempval , countini = 0 , countsyl = 0 , cold = -20 , hot = -20;

            Random Rd = new Random();

            int i ;

            InitButton();

            for( i = 0 ; i < 20 ; i++ )
                Array_words[i] = "" ;
            Select = "";

            while (countini != initialConsonant)
            {
                temppos = Rd.Next() % 16;
                tempval = Rd.Next() % initialConsonantSource.Length;

                if (Array_words[temppos] == "")
                {
                    Array_words[temppos] = initialConsonantSource[tempval].ToString();
                    countini++;
                } 
            }

            while (countsyl != syllableRime)
            {
                temppos = Rd.Next() % 16;
                tempval = Rd.Next() % syllableRimeSource.Length;

                if (Array_words[temppos] == "")
                {
                    Array_words[temppos] = syllableRimeSource[tempval].ToString();
                    countsyl++;
                }
            }

            for (i = 0; i < 16; i++)
                buttonChoose[i].Text = Array_words[i];

            temppos = cold + Rd.Next() % 23;
            if (temppos > 0)
            {
                Cold = temppos;
                for (i = 1; i <= temppos; i++)
                    buttonChoose[Rd.Next() % 16].BackColor = Color.Cyan;
            }

            temppos = hot + Rd.Next() % 23;
            if (temppos > 0)
            {
                Hot = temppos;
                for (i = 1; i <= temppos; i++)
                    buttonChoose[Rd.Next() % 16].BackColor = Color.Gold;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time--;

            int i;

            if (Time == 0)
            {
                Time = 0 ;
                timer1.Enabled = false ;
                if (Score > 100) MessageBox.Show("You are so smart!");
                else if (Score > 80) MessageBox.Show("You did a good job!");
                else if (Score > 50) MessageBox.Show("You can do better!");
                else if (Score <= 50) MessageBox.Show("You should learn more about Chinese culture");

                for (i = 0; i < 16; i++)
                {
                    buttonChoose[i].Text = "";
                    buttonChoose[i].Enabled = false;
                    buttonChoose[i].BackColor = Color.White;
                }

                Select = "";

                for (i = 0; i < 20; i++)
                    selectPos[i] = 0;

                textBox1.Text = "";
                coldClick = 0;
                hotClick = 0;
                textBox2.Text = "";
                label5.Text = "pinyin";
            }

            label2.Text = Time.ToString();

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 1)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button3.Text;
                Select += button3.Text;
                selectPos[Select.Length] = 1;
                if (button3.BackColor == Color.Cyan) coldClick++;
                if (button3.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 2)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button4.Text;
                Select += button4.Text;
                selectPos[Select.Length] = 2;
                if (button4.BackColor == Color.Cyan) coldClick++;
                if (button4.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 3)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button5.Text;
                Select += button5.Text;
                selectPos[Select.Length] = 3;
                if (button5.BackColor == Color.Cyan) coldClick++;
                if (button5.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 4)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button6.Text;
                Select += button6.Text;
                selectPos[Select.Length] = 4;
                if (button6.BackColor == Color.Cyan) coldClick++;
                if (button6.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 5)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button7.Text;
                Select += button7.Text;
                selectPos[Select.Length] = 5;
                if (button7.BackColor == Color.Cyan) coldClick++;
                if (button7.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 6)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button8.Text;
                Select += button8.Text;
                selectPos[Select.Length] = 6;
                if (button8.BackColor == Color.Cyan) coldClick++;
                if (button8.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 7)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button9.Text;
                Select += button9.Text;
                selectPos[Select.Length] = 7;
                if (button9.BackColor == Color.Cyan) coldClick++;
                if (button9.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 8)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button10.Text;
                Select += button10.Text;
                selectPos[Select.Length] = 8;
                if (button10.BackColor == Color.Cyan) coldClick++;
                if (button10.BackColor == Color.Gold) hotClick++;  
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 9)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button11.Text;
                Select += button11.Text;
                selectPos[Select.Length] = 9;
                if (button11.BackColor == Color.Cyan) coldClick++;
                if (button11.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 10)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button12.Text;
                Select += button12.Text;
                selectPos[Select.Length] = 10;
                if (button12.BackColor == Color.Cyan) coldClick++;
                if (button12.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 11)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button13.Text;
                Select += button13.Text;
                selectPos[Select.Length] = 11;
                if (button13.BackColor == Color.Cyan) coldClick++;
                if (button13.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 12)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button14.Text;
                Select += button14.Text;
                selectPos[Select.Length] = 12;
                if (button14.BackColor == Color.Cyan) coldClick++;
                if (button14.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 13)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button15.Text;
                Select += button15.Text;
                selectPos[Select.Length] = 13;
                if (button15.BackColor == Color.Cyan) coldClick++;
                if (button15.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 14)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button16.Text;
                Select += button16.Text;
                selectPos[Select.Length] = 14;
                if (button16.BackColor == Color.Cyan) coldClick++;
                if (button16.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 15)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button17.Text;
                Select += button17.Text;
                selectPos[Select.Length] = 15;
                if (button17.BackColor == Color.Cyan) coldClick++;
                if (button17.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int flag = 0, i;
            for (i = 0; i < selectPos.Length; i++)
            {
                if (selectPos[i] == 16)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                textBox1.Text += button18.Text;
                Select += button18.Text;
                selectPos[Select.Length] = 16;
                if (button18.BackColor == Color.Cyan) coldClick++;
                if (button18.BackColor == Color.Gold) hotClick++; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int i;
            
            Random Rd = new Random() ;

            for (i = 0; i < TotalChoose; i++)
            {
                if (Select.Equals(Base[i].getpin().Trim()))
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                Score += (Select.Length + 1) * Select.Length / 2;
                label5.Text = Base[i].gettone();
                textBox2.Text = Base[i].getword();

                right.Play();

                if (coldClick != 0)
                {
                    Time += 3 * coldClick;
                    label2.Text = Time.ToString();
                    Cold -= coldClick;
                    coldClick = 0;
                }

                if (hotClick != 0)
                {
                    Score += (Select.Length + 1) * Select.Length / 2 * 2 * hotClick;
                    Hot -= hotClick;
                    hotClick = 0;
                }

                if (Select.Length >= 4)
                {
                    for (i = 0; i < 3; i++)
                    {
                        buttonChoose[selectPos[i + 1] - 1].Text = initialConsonantSource[Rd.Next() % initialConsonantSource.Length].ToString();
                        buttonChoose[selectPos[i + 1] - 1].BackColor = Color.White;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Cyan;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Gold;
                    }

                    for (i = 3; i < Select.Length; i++)
                    {
                        buttonChoose[selectPos[i + 1] - 1].Text = syllableRimeSource[Rd.Next() % syllableRimeSource.Length].ToString();
                        buttonChoose[selectPos[i + 1] - 1].BackColor = Color.White;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Cyan;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Gold;
                    }
                }

                else
                {
                    for (i = 0; i < Select.Length - 1; i++)
                    {
                        buttonChoose[selectPos[i + 1] - 1].Text = initialConsonantSource[Rd.Next() % initialConsonantSource.Length].ToString();
                        buttonChoose[selectPos[i + 1] - 1].BackColor = Color.White;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Cyan;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Gold;
                    }

                    for (i = Select.Length - 1; i < Select.Length; i++)
                    {
                        buttonChoose[selectPos[i + 1] - 1].Text = syllableRimeSource[Rd.Next() % syllableRimeSource.Length].ToString();
                        buttonChoose[selectPos[i + 1] - 1].BackColor = Color.White;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Cyan;
                        if (Rd.Next() % 20 <= 1) buttonChoose[selectPos[i + 1] - 1].BackColor = Color.Gold;
                    }
                }

                Select = "";

                for (i = 0; i < 20; i++)
                    selectPos[i] = 0;

                textBox1.Text = "";

                label4.Text = Score.ToString();
            }

            else
                wrong.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i; 

            Select = "";

            for (i = 0; i < 20; i++)
                selectPos[i] = 0;

            textBox1.Text = "";
            coldClick = 0;
            hotClick = 0;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void startAgainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Time = 120;
            Score = 0;
            label2.Text = Time.ToString();
            label4.Text = Score.ToString();

            Player.Stop();

            int i;

            for (i = 0; i < 16; i++)
                buttonChoose[i].Enabled = true;

            InitArray();

            timer1.Enabled = true;
            timer1.Interval = 1000;

            label5.Text = "pinyin";
            textBox2.Text = "";
            pauseToolStripMenuItem1.Enabled = true;
            textBox1.Text = "";
        }

        private void highToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Difficulty = 3;
            syllableRime = 2;
            initialConsonant = 14;
            helpToolStripMenuItem1.Checked = true;
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pauseToolStripMenuItem1.Text == "Pause")
            {
                timer1.Enabled = false;
                pauseToolStripMenuItem1.Text = "Start";
            }
            else
            {
                timer1.Enabled = true;
                pauseToolStripMenuItem1.Text = "Pause";
            }
        }

        private void mediumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Difficulty = 2;
            syllableRime = 4;
            initialConsonant = 12;
            mediumToolStripMenuItem1.Checked = true;
        }

        private void lowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Difficulty = 1;
            syllableRime = 6;
            initialConsonant = 10;
            lowToolStripMenuItem1.Checked = true;
        }

        private void soundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (soundToolStripMenuItem1.Checked == false)
                soundToolStripMenuItem1.Checked = true;
            else
                soundToolStripMenuItem1.Checked = false;
        }

        private void CheckChange(object sender, EventArgs e)
        {
            if (soundToolStripMenuItem1.Checked == true)
                Player.PlayLooping();
            else
                Player.Stop();
        }

        private void gamehelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void historyOfStoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Player.PlayLooping();
        }
    }

    public class Character
    {
        private string Pin;
        private string Words;
        private string Tone;

        public Character( string p , string w , string t )
        {
            Pin = p;
            Words = w;
            Tone = t;
        }

        public string getpin()
        {
            return Pin;
        }

        public string getword()
        {
            return Words;
        }

        public string gettone()
        {
            return Tone;
        }
    }
}
