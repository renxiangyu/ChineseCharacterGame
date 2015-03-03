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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            textBox1.Text = "This game contains two games.One is 'Can you Click'.";
            textBox1.Text += "This game is help you to understand Chinese character and Chinese Pinyin.";
            textBox1.Text += "In this game you shoule use the Pinyin which system give you to spell Chinese characters.";
            textBox1.Text += "Another game is 'Can you Collect. In this game you should solve Chinese character riddles system give you.'";
            textBox1.Text += "For these two games are all test how many Chinese characters are you equipping.\n";
            textBox1.Text += "Nowadays plenty of Chinese people ignore traditional Chinese culture,especially ";
            textBox1.Text += "Chinese characters.So we appeal that please focus on our traditional things,because YOU ARE A CHINESE!";

        }
    }
}
