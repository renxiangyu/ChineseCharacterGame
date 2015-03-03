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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            textBox1.Text = "This game is developed by Rambers.";
            textBox2.Text += "Our advisor:Associate Professor FengJunm,NWU.        \n" ;
            textBox2.Text += "Our members:RenXiangyu,WuXiao,LiuWei,ZhangQinning,LiChen,YinSiyuan.         \n";
            textBox2.Text += "Thanks for playing and please pay attention to traditional CHNINESE culture!";

            textBox2.ScrollBars = ScrollBars.Both;

            textBox2.ReadOnly = true;
        }
    }
}
