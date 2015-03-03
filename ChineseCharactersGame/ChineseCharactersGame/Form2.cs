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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            richTextBox1.Text = "        During Chinese history, Chinese characters have different stage of development.";
            richTextBox1.Text += "The traditional Chinese characters font change is staging for standard, namely to dazuan, xiao zhuan, official script, regular script for the standard is divided into four stages.";
            richTextBox1.Text += "This result is putting forward, in the development of the Chinese characters font change is not essential change which";
            richTextBox1.Text += "cannot explain the Chinese characters law of historical development, and the structure of the Chinese characters should be changed in the way that the essence of Chinese characters to change.";
            richTextBox1.Text += "The results in this understanding, and on the basis of further put forward the development of the theory of the three stages of Chinese characters. ";
            richTextBox1.Text += "That is the first stage is the picture text stage.";
            richTextBox1.Text += "The shang dynasty before character should be belongs to the stage.";
            richTextBox1.Text += "The second stage is with the table form words as the basis, the table sound writing for the main table sound writing stage. ";
            richTextBox1.Text += "From oracle to the words of the qin owned by the stage.";
            richTextBox1.Text += "The third stage is with the sound as the main body, but also retained some table form words and the table sound word form sound writing phase,";
            richTextBox1.Text += "from qin and han dynasties to modern Chinese characters all belong to the stage.\n";
            richTextBox1.Text += "       To be continued.\n       Next time we will tell you someting about Pinyin.";

            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
        }
    }
}
