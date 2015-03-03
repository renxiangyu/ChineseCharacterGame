using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChineseCharactersGame
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            textBox1.ReadOnly = true;
            textBox1.Text = "This game is about Chinese character riddles.";
            textBox1.Text += "During the game you should solve ten of them in 60sec.";
            textBox1.Text += "In these 60sec,you solve a riddle for each time you can get 10pts.";
            textBox1.Text += "For each time you have finished the game you can get a name.";
            textBox1.Text += "So try to solve riddles as much as possible.Let's enjoy Chinese culture's glamour!";
        }
    }
}
