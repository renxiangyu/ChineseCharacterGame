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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            tabPage1.Text = "idiom";
            tabPage2.Text = "ancient Chinese poem";
            tabPage3.Text = "proverb";

            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Both;
            richTextBox3.ScrollBars = RichTextBoxScrollBars.Both;

            richTextBox1.Text = ChineseCharactersGame.Properties.Resources.ch;
            richTextBox2.Text = ChineseCharactersGame.Properties.Resources.gu;
            richTextBox3.Text = ChineseCharactersGame.Properties.Resources.ya;

            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            richTextBox3.ReadOnly = true;
        }
    }
}
