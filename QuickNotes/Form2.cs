using System;
using System.IO;
using System.Windows.Forms;

/// <summary>
///
/// </summary>
namespace QuickNotes
{

    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class UserControl1 : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserControl1"/> class.
        /// </summary>

        private void button21_Click(object sender, EventArgs e)
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

            // string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // filePath = filePath + "\\" + "notes" + "\\" + "Name.txt";
            // StreamWriter sw = File.AppendText(filePath);
            // //StreamWriter sw = new StreamWriter(filePath);
            // sw.Write(name);
            // sw.Close();
            // StreamReader sr = new StreamReader(filePath);
            // string line = sr.ToString();
            // line = name;
            // sr.Close();
        }

        public UserControl1()
        {
            InitializeComponent();

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

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the txtPrefix control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void button1_Click(object sender, EventArgs e)
        {
            string name = nameBox1.Text.ToString();
            string msp = MSPBox1.Text.ToString();
            richTextBox1.Text = "Thank you for contacting " + msp + ". " + "My name is " + name + ". " + "I'll be happy to assist you.";
        }

        /// <summary>
        /// Handles the TextChanged event of the textBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the label2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label2_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the label3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label3_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the textBox2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            string ticketnum = ticketbox1.Text.ToString();
            string msp = MSPBox1.Text.ToString();
            richTextBox1.Text = "Thank you for contacting " + msp + ". " + "Your ticket number is " + ticketnum + ". " + "Have a great day";
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            string ticketnum = ticketbox1.Text.ToString();
            string msp = MSPBox1.Text.ToString();
            richTextBox1.Text = "Due to inactivity I am going to end this chat. Thank you for contacting " + msp + ". " + "Your ticket number is " + ticketnum + ". " + "Have a great day";
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>




        /// <summary>
        /// Handles the Click event of the button5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            string pcname = textBox1.Text.ToString();
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Remoted into " + pcname + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the label5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label5_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the 1 event of the textBox1_TextChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button6_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Requested permission to remote into computer" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button7 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button7_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Provided user with ticket number" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the 1 event of the button_wrap_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button_wrap_Click_1(object sender, EventArgs e)
        {
            string ticketnum = ticketbox1.Text.ToString();
            richTextBox1.Text = "Your ticket number is " + ticketnum + ". " + "Is there anything else I can assist you with today?";
        }

        /// <summary>
        /// Handles the Click event of the button8 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button8_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Reviewed IT Glue / TechView References" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button9 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button9_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Reviewed ticket provided" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button10 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button10_Click(object sender, EventArgs e)
        {
            //textbox clear code
            textBox1.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            nameBox1.Text = "";
            ticketbox1.Text = "";
            MSPBox1.Text = "";
            richTextBox5.Text = "";
        }

        /// <summary>
        /// Handles the 1 event of the richTextBox2_TextChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the error_button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void error_button_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            string errorvar = richTextBox2.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Error code: " + errorvar + Environment.NewLine);
        }

        /// <summary>
        /// Handles the tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_tick(object sender, EventArgs e)
        {
            {
                //label10.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        /// <summary>
        /// Handles the Click event of the button11 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button11_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Inactivity warning" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button12 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button12_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Setting to awaiting customer" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button13 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button13_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            string newnoteentry = richTextBox4.Text.ToString();
            richTextBox3.AppendText(noteprefix + newnoteentry + Environment.NewLine);
            richTextBox4.Text = String.Empty;
        }

        /// <summary>
        /// Handles the Enter event of the textBox3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox3_Enter(object sender, EventArgs e)
        {
            //ActiveForm.AcceptButton = button13;
            //ActiveForm.AcceptButton = null; // remove "return" button behavior
        }

        /// <summary>
        /// Handles the Click event of the label11 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label11_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Enter event of the groupBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button14 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button14_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Reviewed approval contacts" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the LinkClicked event of the linkLabel2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            var destinationurl = "https://continuum.cherwellondemand.com/CherwellClient/Access?_=562d75eb#0";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        /// <summary>
        /// Handles the LinkClicked event of the linkLabel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            var destinationurl = "https://continuum.cherwellondemand.com/CherwellClient/Access?_=562d75eb#0";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        /// <summary>
        /// Handles the LinkClicked event of the linkLabel3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            var destinationurl = "https://continuum.cherwellondemand.com/CherwellClient/Access?_=562d75eb#0";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button15 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button15_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            string newnoteentry = richTextBox4.Text.ToString();
            richTextBox5.AppendText(noteprefix + newnoteentry + Environment.NewLine);
            richTextBox4.Text = String.Empty;
        }

        /// <summary>
        /// Handles the Click event of the button16 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button16_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Requested the model of the device" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button17 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button17_Click(object sender, EventArgs e)
        {
            string model = textBox2.Text.ToString();
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "The devices model is " + model + Environment.NewLine);
        }

        /// <summary>
        /// Handles the 1 event of the textBox2_TextChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button18 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button18_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Consulted tier 2" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button19 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button19_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Transferring to tier 2" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button20 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button20_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Generated chat link and placed it on users desktop in a text file" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the button22 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button22_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            richTextBox3.AppendText(noteprefix + "Sent awaiting customer email" + Environment.NewLine);
        }

        /// <summary>
        /// Handles the 1 event of the linkLabel3_LinkClicked control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the label9 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label9_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the textBox3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the credBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void credBtn_Click(object sender, EventArgs e)
        {
            string noteprefix = txtPrefix.Text.ToString();
            string username = credTextbox1.Text.ToString();
            string password = credTextbox2.Text.ToString();
            richTextBox5.AppendText(noteprefix + username + "//" + password + Environment.NewLine);
        }

        /// <summary>
        /// Handles the 1 event of the button15_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button15_Click_1(object sender, EventArgs e)
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
            sw.Write("Instructions: Copy the URL and paste it into your web browser address bar." + Environment.NewLine + Environment.NewLine + chatlnktxt.Text);

            //always close your stream
            sw.Close();
            System.Diagnostics.Process.Start(root);
        }

        /// <summary>
        /// Handles the TextChanged event of the chatlnktxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void chatlnktxt_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the 1 event of the label11_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label11_Click_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the timerlabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timerlabel_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}