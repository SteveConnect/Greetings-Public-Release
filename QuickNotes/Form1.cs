using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuickNotes
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form

    {
        private int _position;

        private bool _isExitRequested;

        private bool _isHidden;

        public Form1()
        {
            InitializeComponent();

            _isExitRequested = false;
            string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "Notes" + "\\" + "Variables" + "\\";
            // If directory does not exist, create it.
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            if (!File.Exists(root + "Name.txt"))
            {
                File.Create(root + "Name.txt");
            }
            string path = root + "Name.txt";
            string text = File.ReadAllText(path);
            nameBox1.Text = text;
        }

        public static string NewLine { get; }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Form1s the load.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1Load(object sender, EventArgs e)
        {
            RefreshCopiedTexts();

        }

        /// <summary>
        /// Refreshes the copied texts.
        /// </summary>
        public void RefreshCopiedTexts()
        {
            var allTexts = ClipboardManager.Instance.GetAllTexts();
            //Bring User Control Form Down
            _position = 25;
            panelBottom.Controls.Clear();
            foreach (var text in allTexts)
            {
                var control = new UserControlCopiedText(text, this) { Location = new Point(10, _position) };
                _position += 24;
                panelBottom.Controls.Add(control);
            }

            var userControlAddNewText = new UserControlAddNewText(this) { Location = new Point(10, _position) };
            panelBottom.Controls.Add(userControlAddNewText);
        }

        /// <summary>
        /// Adds the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void AddText(string text)
        {
            RefreshCopiedTexts();
            UpdateStatus("New note added");
        }

        /// <summary>
        /// Deletes the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void DeleteText(string text)
        {
            if (panelBottom.Controls.Count > 1)
                for (int index = 0; index < panelBottom.Controls.Count - 1; index++)
                {
                    var userControlCopiedText = (UserControlCopiedText)panelBottom.Controls[index];
                    if (text == userControlCopiedText.GetText())

                    {
                        ClipboardManager.Instance.DeleteText(text);
                        panelBottom.Controls.Remove(userControlCopiedText);
                    }
                }

            RefreshCopiedTexts();
            UpdateStatus("note deleted");
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="text">The text.</param>
        public void UpdateStatus(string text)
        {
            toolStripStatusLabel1.Text = text;
        }

        /// <summary>Form1s the form closing.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs" /> instance containing the event data.</param>
        private void Form1FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will close the application. Are you sure to do that ?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                _isExitRequested = false;
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Shows the hide tool strip menu item click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ShowHideToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (_isHidden)
            {
                Show();
                _isHidden = false;
            }
            else
            {
                Hide();
                _isHidden = true;
            }
        }

        /// <summary>
        /// Exits the tool strip menu item click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            _isExitRequested = true;
            Close();
        }

        /// <summary>
        /// Notifies the icon1 mouse double click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void NotifyIcon1MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_isHidden)
            {
                Show();
                _isHidden = false;
            }
        }

        /// <summary>
        /// Handles the Paint event of the panelBottom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void UpdateTextBox1(string text)
        {
            string noteText = text;

            editor.AppendText(noteText + Environment.NewLine);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void kryptonRichTextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void editor_Click(object sender, EventArgs e)
        {
        }

        public void EditorOut(string textboxout)
        {
            string value = editor.Text;
        }

        private ExampleDisplay[] _examples = new ExampleDisplay[]
       {
           // new ExampleDisplay("Template Test", "cs.txt", new DarkCSharpStyler()),
           // new ExampleDisplay("C# (Dark)", "cs1.txt", new DarkCSharpStyler()),
           //new ExampleDisplay("Windows Batch", "bat.txt", new BatchStyler()),
           //new ExampleDisplay("HTML", "html.txt", new HtmlStyler()),
           //new ExampleDisplay("JSON", "json.txt", new JsonStyler()),
           //new ExampleDisplay("PowerShell", "ps1.txt", new PowerShellStyler()),
           //new ExampleDisplay("Python", "py.txt", new PythonStyler()),
           //new ExampleDisplay("Ruby", "rb.txt", new RubyStyler()),
           //new ExampleDisplay("T-SQL", "sql.txt", new SqlStyler()),
           //new ExampleDisplay("Teradata Parallel Transporter", "tpt.txt", new TptStyler()),
       };

        private void stylerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var example = _examples[stylerPicker.SelectedIndex];
            // editor.Text = example.ReadFile();
            //editor.Styler = example.Styler;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
        }

        private void textExportbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void userControl12_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "Notes" + "\\" + "Variables" + "\\";

            // If directory does not exist, create it.
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string name = nameBox1.ToString();
            string path = root + "Name.txt";
            using (StreamWriter sw = File.CreateText(path))
                sw.WriteLine(nameBox1.Text);
            string text = File.ReadAllText(path);
            name = text;
        }

        private void greetBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox1.Text.ToString();
            string ticketnum = ticketTextBox.Text.ToString();
            string msp = mspTextBox.Text.ToString();
            replyOutputBox.Text = "Thank you for contacting " + msp + "." + " My name is " + name + "." + "I'll be happy to assist you today.";
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            string ticketnum = ticketTextBox.Text.ToString();
            string msp = mspTextBox.Text.ToString();
            replyOutputBox.Text = "Thank you for contacting " + msp + ". " + "Your ticket number is " + ticketnum + ". " + "Have a great day";
        }

        private void wrapBtn_Click(object sender, EventArgs e)
        {
            string ticketnum = ticketTextBox.Text.ToString();
            replyOutputBox.Text = "Your ticket number is " + ticketnum + ". " + "Is there anything else I can assist you with today?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "Notes" + "\\" + "ChatLink" + "\\";

            // If directory does not exist, create it.
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Use StreamWriter class.
            filePath = filePath + "\\Notes\\ChatLink\\chatlink.txt";
            StreamWriter sw = new StreamWriter(filePath);
            //Use write method to write the text
            sw.Write("Instructions: Copy the URL and paste it into your web browser address bar." + Environment.NewLine + Environment.NewLine + chatlnkBox.Text);
            //always close your stream
            sw.Close();
            System.Diagnostics.Process.Start(root);
        }


        private void Button4_Click(object sender, EventArgs e)
        {


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Collective-Software/ClickPaste");
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\" + "ClickPaste" + "\\" + "ClickPaste.exe";
            //replyOutputBox.Text = (path);
            Process process = new Process();
            process.StartInfo.FileName = path;
            process.Start();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ticketnum = ticketTextBox.Text.ToString();
            string msp = mspTextBox.Text.ToString();
            replyOutputBox.Text = "Due to inactivity I am going to end this chat. Thank you for contacting " + msp + ". " + "Your ticket number is " + ticketnum + ". " + "Have a great day";
        }

        public void button3_Click(object sender, EventArgs e)
        {

            if (replyOutputBox.TextLength != 0)

            {
                label5.Text = "Copied";
                label5.Visible = true;
                Clipboard.SetText(replyOutputBox.Text);
            }
            else

                label5.Text = "You need to generate a reply silly";
            label5.Visible = true;


        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

 

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clickpasteLbl1.Visible = true;
            clickpasteLbl2.Visible = true;
        }
        //Global variables for Moving a Borderless Form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void darkButton1_Click(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will close the application. Are you sure to do that ?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                _isExitRequested = false;
                e.Cancel = true;
            }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void panelBottom_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            string partnernotes = editor.Text.ToString();
            string ticketnumber = ticketTextBox.Text.ToString();
            string msp = mspTextBox.Text.ToString();

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath = filePath + "\\" + "notes" + "\\" + msp + "_" + ticketnumber + ".txt";
            StreamWriter sw = new StreamWriter(filePath);
            var newline = Environment.NewLine;

            sw.Write("MSP:" + msp + newline + "Ticket ID: " + ticketnumber + newline + "Partner facing: " + newline + partnernotes + newline);
            sw.Close();
            System.Diagnostics.Process.Start(filePath);

        }
    }
}

