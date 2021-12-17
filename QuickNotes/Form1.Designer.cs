namespace QuickNotes
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
            System.Windows.Forms.NotifyIcon notifyIcon1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nameBox1 = new DarkUI.Controls.DarkTextBox();
            this.button1 = new DarkUI.Controls.DarkButton();
            this.label5 = new DarkUI.Controls.DarkLabel();
            this.label2 = new DarkUI.Controls.DarkLabel();
            this.wrapBtn = new DarkUI.Controls.DarkButton();
            this.endBtn = new DarkUI.Controls.DarkButton();
            this.button7 = new DarkUI.Controls.DarkButton();
            this.greetBtn = new DarkUI.Controls.DarkButton();
            this.button3 = new DarkUI.Controls.DarkButton();
            this.mspLbl = new DarkUI.Controls.DarkLabel();
            this.label4 = new DarkUI.Controls.DarkLabel();
            this.nameLbl = new DarkUI.Controls.DarkLabel();
            this.label1 = new DarkUI.Controls.DarkLabel();
            this.button2 = new DarkUI.Controls.DarkButton();
            this.mspTextBox = new DarkUI.Controls.DarkTextBox();
            this.chatlnkBox = new DarkUI.Controls.DarkTextBox();
            this.replyOutputBox = new System.Windows.Forms.RichTextBox();
            this.ticketTextBox = new DarkUI.Controls.DarkTextBox();
            this.button4 = new DarkUI.Controls.DarkButton();
            this.clickpasteLbl2 = new System.Windows.Forms.LinkLabel();
            this.clickpasteLbl1 = new DarkUI.Controls.DarkLabel();
            this.editor = new System.Windows.Forms.RichTextBox();
            this.button5 = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkTitle2 = new DarkUI.Controls.DarkTitle();
            this.darkSectionPanel3 = new DarkUI.Controls.DarkSectionPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.darkTitle3 = new DarkUI.Controls.DarkTitle();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelBottom = new DarkUI.Controls.DarkSectionPanel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.darkSectionPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            notifyIcon1.Tag = "Quick Notes";
            notifyIcon1.Text = "Quick Notes";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.ShowHideToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1105, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // nameBox1
            // 
            this.nameBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nameBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.nameBox1.Location = new System.Drawing.Point(811, 94);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(154, 20);
            this.nameBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 91);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(889, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(806, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Generate Chat Replies";
            // 
            // wrapBtn
            // 
            this.wrapBtn.Location = new System.Drawing.Point(809, 277);
            this.wrapBtn.Name = "wrapBtn";
            this.wrapBtn.Padding = new System.Windows.Forms.Padding(5);
            this.wrapBtn.Size = new System.Drawing.Size(75, 23);
            this.wrapBtn.TabIndex = 10;
            this.wrapBtn.Text = "Wrap";
            this.wrapBtn.Click += new System.EventHandler(this.wrapBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(809, 248);
            this.endBtn.Name = "endBtn";
            this.endBtn.Padding = new System.Windows.Forms.Padding(5);
            this.endBtn.Size = new System.Drawing.Size(75, 23);
            this.endBtn.TabIndex = 10;
            this.endBtn.Text = "Ending";
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(809, 306);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(5);
            this.button7.Size = new System.Drawing.Size(75, 43);
            this.button7.TabIndex = 10;
            this.button7.Text = "Inactivity Ending";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // greetBtn
            // 
            this.greetBtn.Location = new System.Drawing.Point(809, 217);
            this.greetBtn.Name = "greetBtn";
            this.greetBtn.Padding = new System.Windows.Forms.Padding(5);
            this.greetBtn.Size = new System.Drawing.Size(75, 23);
            this.greetBtn.TabIndex = 10;
            this.greetBtn.Text = "Greeting";
            this.greetBtn.Click += new System.EventHandler(this.greetBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(802, 424);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(253, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Copy";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mspLbl
            // 
            this.mspLbl.AutoSize = true;
            this.mspLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mspLbl.Location = new System.Drawing.Point(812, 157);
            this.mspLbl.Name = "mspLbl";
            this.mspLbl.Size = new System.Drawing.Size(30, 13);
            this.mspLbl.TabIndex = 8;
            this.mspLbl.Text = "MSP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(812, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ticket ID";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.nameLbl.Location = new System.Drawing.Point(812, 78);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 8;
            this.nameLbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(801, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paste the chat link here";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 500);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(254, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generate Chat File";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mspTextBox
            // 
            this.mspTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.mspTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mspTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mspTextBox.Location = new System.Drawing.Point(812, 173);
            this.mspTextBox.Name = "mspTextBox";
            this.mspTextBox.Size = new System.Drawing.Size(154, 20);
            this.mspTextBox.TabIndex = 1;
            // 
            // chatlnkBox
            // 
            this.chatlnkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.chatlnkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatlnkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.chatlnkBox.Location = new System.Drawing.Point(802, 475);
            this.chatlnkBox.Name = "chatlnkBox";
            this.chatlnkBox.Size = new System.Drawing.Size(253, 20);
            this.chatlnkBox.TabIndex = 4;
            // 
            // replyOutputBox
            // 
            this.replyOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.replyOutputBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.replyOutputBox.Location = new System.Drawing.Point(802, 355);
            this.replyOutputBox.Name = "replyOutputBox";
            this.replyOutputBox.Size = new System.Drawing.Size(253, 63);
            this.replyOutputBox.TabIndex = 3;
            this.replyOutputBox.Text = "";
            // 
            // ticketTextBox
            // 
            this.ticketTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ticketTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ticketTextBox.Location = new System.Drawing.Point(811, 133);
            this.ticketTextBox.Name = "ticketTextBox";
            this.ticketTextBox.Size = new System.Drawing.Size(154, 20);
            this.ticketTextBox.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 21);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5);
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Launch ClickPaste";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // clickpasteLbl2
            // 
            this.clickpasteLbl2.AutoSize = true;
            this.clickpasteLbl2.LinkColor = System.Drawing.Color.DarkGray;
            this.clickpasteLbl2.Location = new System.Drawing.Point(521, 588);
            this.clickpasteLbl2.Name = "clickpasteLbl2";
            this.clickpasteLbl2.Size = new System.Drawing.Size(92, 13);
            this.clickpasteLbl2.TabIndex = 8;
            this.clickpasteLbl2.TabStop = true;
            this.clickpasteLbl2.Text = "ClickPaste source";
            this.clickpasteLbl2.Visible = false;
            this.clickpasteLbl2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // clickpasteLbl1
            // 
            this.clickpasteLbl1.AutoSize = true;
            this.clickpasteLbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.clickpasteLbl1.Location = new System.Drawing.Point(521, 557);
            this.clickpasteLbl1.Name = "clickpasteLbl1";
            this.clickpasteLbl1.Size = new System.Drawing.Size(480, 26);
            this.clickpasteLbl1.TabIndex = 9;
            this.clickpasteLbl1.Text = "ClickPaste can paste clipboard contents as keystrokes to whatever location you cl" +
    "ick.\r\nThis software is useful when trying to enter passwords in such remote prog" +
    "rams as LogMeInRescue. \r\n";
            this.clickpasteLbl1.Visible = false;
            this.clickpasteLbl1.Click += new System.EventHandler(this.label3_Click);
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.editor.ForeColor = System.Drawing.Color.White;
            this.editor.Location = new System.Drawing.Point(9, 28);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(412, 400);
            this.editor.TabIndex = 14;
            this.editor.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 434);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(157, 34);
            this.button5.TabIndex = 16;
            this.button5.Text = "Save Notes";
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.darkTitle1);
            this.darkSectionPanel1.Location = new System.Drawing.Point(802, 50);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(263, 402);
            this.darkSectionPanel1.TabIndex = 17;
            // 
            // darkTitle1
            // 
            this.darkTitle1.AutoSize = true;
            this.darkTitle1.Location = new System.Drawing.Point(6, 2);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(85, 13);
            this.darkTitle1.TabIndex = 0;
            this.darkTitle1.Text = "Chat Responses";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.darkTitle2);
            this.darkSectionPanel2.Controls.Add(this.button5);
            this.darkSectionPanel2.Controls.Add(this.editor);
            this.darkSectionPanel2.Location = new System.Drawing.Point(367, 49);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(428, 476);
            this.darkSectionPanel2.TabIndex = 18;
            // 
            // darkTitle2
            // 
            this.darkTitle2.AutoSize = true;
            this.darkTitle2.Location = new System.Drawing.Point(6, 3);
            this.darkTitle2.Name = "darkTitle2";
            this.darkTitle2.Size = new System.Drawing.Size(35, 13);
            this.darkTitle2.TabIndex = 17;
            this.darkTitle2.Text = "Notes";
            // 
            // darkSectionPanel3
            // 
            this.darkSectionPanel3.Controls.Add(this.linkLabel2);
            this.darkSectionPanel3.Controls.Add(this.darkTitle3);
            this.darkSectionPanel3.Controls.Add(this.button4);
            this.darkSectionPanel3.Location = new System.Drawing.Point(373, 531);
            this.darkSectionPanel3.Name = "darkSectionPanel3";
            this.darkSectionPanel3.SectionHeader = null;
            this.darkSectionPanel3.Size = new System.Drawing.Size(142, 73);
            this.darkSectionPanel3.TabIndex = 19;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel2.Location = new System.Drawing.Point(17, 55);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(102, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "What is ClickPaste?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // darkTitle3
            // 
            this.darkTitle3.AutoSize = true;
            this.darkTitle3.Location = new System.Drawing.Point(6, 2);
            this.darkTitle3.Name = "darkTitle3";
            this.darkTitle3.Size = new System.Drawing.Size(58, 13);
            this.darkTitle3.TabIndex = 20;
            this.darkTitle3.Text = "Other tools";
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBottom.AutoScroll = true;
            this.panelBottom.Location = new System.Drawing.Point(9, 5);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(6);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.SectionHeader = null;
            this.panelBottom.Size = new System.Drawing.Size(355, 599);
            this.panelBottom.TabIndex = 20;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint_1);
            // 
            // darkButton1
            // 
            this.darkButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.darkButton1.Location = new System.Drawing.Point(1010, 11);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(55, 23);
            this.darkButton1.TabIndex = 21;
            this.darkButton1.Text = "Exit";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.darkButton1;
            this.ClientSize = new System.Drawing.Size(1105, 653);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.clickpasteLbl1);
            this.Controls.Add(this.clickpasteLbl2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wrapBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.greetBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mspLbl);
            this.Controls.Add(this.mspTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ticketTextBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.replyOutputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatlnkBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "QuickNotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.Load += new System.EventHandler(this.Form1Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.darkSectionPanel3.ResumeLayout(false);
            this.darkSectionPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox replyOutputBox;
        private System.Windows.Forms.LinkLabel clickpasteLbl2;
        private DarkUI.Controls.DarkButton button1;
        private DarkUI.Controls.DarkTextBox nameBox1;
        private DarkUI.Controls.DarkLabel label1;
        private DarkUI.Controls.DarkButton button2;
        private DarkUI.Controls.DarkButton wrapBtn;
        private DarkUI.Controls.DarkButton endBtn;
        private DarkUI.Controls.DarkButton button7;
        private DarkUI.Controls.DarkButton greetBtn;
        private DarkUI.Controls.DarkButton button3;
        private DarkUI.Controls.DarkLabel mspLbl;
        private DarkUI.Controls.DarkLabel label4;
        private DarkUI.Controls.DarkLabel nameLbl;
        private DarkUI.Controls.DarkLabel label2;
        private DarkUI.Controls.DarkButton button4;
        private DarkUI.Controls.DarkLabel clickpasteLbl1;
        private DarkUI.Controls.DarkLabel label5;
        private DarkUI.Controls.DarkTextBox ticketTextBox;
        private DarkUI.Controls.DarkTextBox mspTextBox;
        private DarkUI.Controls.DarkTextBox chatlnkBox;
        private System.Windows.Forms.RichTextBox editor;
        private DarkUI.Controls.DarkButton button5;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkTitle darkTitle1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkTitle darkTitle2;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private DarkUI.Controls.DarkTitle darkTitle3;
        private DarkUI.Controls.DarkSectionPanel panelBottom;
        private DarkUI.Controls.DarkButton darkButton1;
    }
}

