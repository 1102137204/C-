namespace 工具列
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clickMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.轉大寫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.轉小寫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripSeparator();
            this.字串剪裁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trinEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.允許輸入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPurpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPurpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickMeToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clickMeToolStripMenuItem
            // 
            this.clickMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.轉大寫ToolStripMenuItem,
            this.轉小寫ToolStripMenuItem,
            this.toolStripComboBox1,
            this.字串剪裁ToolStripMenuItem,
            this.允許輸入ToolStripMenuItem});
            this.clickMeToolStripMenuItem.Name = "clickMeToolStripMenuItem";
            this.clickMeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.clickMeToolStripMenuItem.Text = "clickMe &X";
            // 
            // 轉大寫ToolStripMenuItem
            // 
            this.轉大寫ToolStripMenuItem.Name = "轉大寫ToolStripMenuItem";
            this.轉大寫ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.轉大寫ToolStripMenuItem.Text = "轉大寫 &U";
            this.轉大寫ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_UCase_Click);
            // 
            // 轉小寫ToolStripMenuItem
            // 
            this.轉小寫ToolStripMenuItem.Name = "轉小寫ToolStripMenuItem";
            this.轉小寫ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.轉小寫ToolStripMenuItem.Text = "轉小寫 &L";
            this.轉小寫ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_LCase_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(149, 6);
            // 
            // 字串剪裁ToolStripMenuItem
            // 
            this.字串剪裁ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trimToolStripMenuItem,
            this.trinEndToolStripMenuItem});
            this.字串剪裁ToolStripMenuItem.Name = "字串剪裁ToolStripMenuItem";
            this.字串剪裁ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.字串剪裁ToolStripMenuItem.Text = "字串剪裁 &T";
            // 
            // trimToolStripMenuItem
            // 
            this.trimToolStripMenuItem.Name = "trimToolStripMenuItem";
            this.trimToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.trimToolStripMenuItem.Text = "Trim()";
            this.trimToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Trim_Click);
            // 
            // trinEndToolStripMenuItem
            // 
            this.trinEndToolStripMenuItem.Name = "trinEndToolStripMenuItem";
            this.trinEndToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.trinEndToolStripMenuItem.Text = "TrinEnd()";
            this.trinEndToolStripMenuItem.Click += new System.EventHandler(this.menuItem_TrimEnd_Click);
            // 
            // 允許輸入ToolStripMenuItem
            // 
            this.允許輸入ToolStripMenuItem.Checked = true;
            this.允許輸入ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.允許輸入ToolStripMenuItem.Name = "允許輸入ToolStripMenuItem";
            this.允許輸入ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.允許輸入ToolStripMenuItem.Text = "允許輸入 &I";
            this.允許輸入ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Input_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.purpleToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.backgroundColorToolStripMenuItem.Text = "backgroundColor &C";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem.Text = "Green &G";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Green_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blueToolStripMenuItem.Text = "Blue &B";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Blue_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.purpleToolStripMenuItem.Text = "Purple &P";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Purple_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbBlueToolStripMenuItem,
            this.tbGreenToolStripMenuItem,
            this.tbPurpleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // tbBlueToolStripMenuItem
            // 
            this.tbBlueToolStripMenuItem.Name = "tbBlueToolStripMenuItem";
            this.tbBlueToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tbBlueToolStripMenuItem.Text = "TbBlue";
            // 
            // tbGreenToolStripMenuItem
            // 
            this.tbGreenToolStripMenuItem.Name = "tbGreenToolStripMenuItem";
            this.tbGreenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tbGreenToolStripMenuItem.Text = "TbGreen";
            // 
            // tbPurpleToolStripMenuItem
            // 
            this.tbPurpleToolStripMenuItem.Name = "tbPurpleToolStripMenuItem";
            this.tbPurpleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tbPurpleToolStripMenuItem.Text = "TbPurple";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(52, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.ContextMenuStripChanged += new System.EventHandler(this.menuItem_Green_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.textBox2.ForeColor = System.Drawing.Color.Gold;
            this.textBox2.Location = new System.Drawing.Point(15, 69);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(257, 52);
            this.textBox2.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxBlueToolStripMenuItem,
            this.textBoxGreenToolStripMenuItem,
            this.textBoxPurpleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 70);
            // 
            // textBoxBlueToolStripMenuItem
            // 
            this.textBoxBlueToolStripMenuItem.Name = "textBoxBlueToolStripMenuItem";
            this.textBoxBlueToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.textBoxBlueToolStripMenuItem.Text = "TextBoxBlue";
            this.textBoxBlueToolStripMenuItem.Click += new System.EventHandler(this.textBoxBlueToolStripMenuItem_Click);
            // 
            // textBoxGreenToolStripMenuItem
            // 
            this.textBoxGreenToolStripMenuItem.Name = "textBoxGreenToolStripMenuItem";
            this.textBoxGreenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.textBoxGreenToolStripMenuItem.Text = "TextBoxGreen";
            this.textBoxGreenToolStripMenuItem.Click += new System.EventHandler(this.textBoxGreenToolStripMenuItem_Click);
            // 
            // textBoxPurpleToolStripMenuItem
            // 
            this.textBoxPurpleToolStripMenuItem.Name = "textBoxPurpleToolStripMenuItem";
            this.textBoxPurpleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.textBoxPurpleToolStripMenuItem.Text = "TextBoxPurple";
            this.textBoxPurpleToolStripMenuItem.Click += new System.EventHandler(this.textBoxPurpleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem clickMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 轉大寫ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 轉小寫ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem 字串剪裁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trinEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 允許輸入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textBoxBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tbBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tbGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tbPurpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxPurpleToolStripMenuItem;
    }
}

