namespace ChineseCharactersGame
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canYouCollectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamehelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyOfStoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.choiceToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yToolStripMenuItem,
            this.canYouCollectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yToolStripMenuItem.Text = "Can you click";
            this.yToolStripMenuItem.Click += new System.EventHandler(this.yToolStripMenuItem_Click);
            // 
            // canYouCollectToolStripMenuItem
            // 
            this.canYouCollectToolStripMenuItem.Name = "canYouCollectToolStripMenuItem";
            this.canYouCollectToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.canYouCollectToolStripMenuItem.Text = "Can you collect";
            this.canYouCollectToolStripMenuItem.Click += new System.EventHandler(this.canYouCollectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // choiceToolStripMenuItem
            // 
            this.choiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem});
            this.choiceToolStripMenuItem.Name = "choiceToolStripMenuItem";
            this.choiceToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.choiceToolStripMenuItem.Text = "Choice";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.soundToolStripMenuItem.Text = "Sound";
            this.soundToolStripMenuItem.CheckedChanged += new System.EventHandler(this.CheckChanged);
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.soundToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamehelpToolStripMenuItem,
            this.historyOfStoryToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gamehelpToolStripMenuItem
            // 
            this.gamehelpToolStripMenuItem.Name = "gamehelpToolStripMenuItem";
            this.gamehelpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gamehelpToolStripMenuItem.Text = "Gamehelp";
            this.gamehelpToolStripMenuItem.Click += new System.EventHandler(this.gamehelpToolStripMenuItem_Click);
            // 
            // historyOfStoryToolStripMenuItem
            // 
            this.historyOfStoryToolStripMenuItem.Name = "historyOfStoryToolStripMenuItem";
            this.historyOfStoryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.historyOfStoryToolStripMenuItem.Text = "History of storyⅠ";
            this.historyOfStoryToolStripMenuItem.Click += new System.EventHandler(this.historyOfStoryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(35, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Can you click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Can you collect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChineseCharacters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canYouCollectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamehelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyOfStoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

