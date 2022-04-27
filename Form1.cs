using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserBeBad
{
    
    public partial class Form1 : Form
    {
        public int buttonOffset = 20,browserOffset,textOffset;
        private void Resolution()
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
        }
        public Form1()
        {
            InitializeComponent();
            buttonOffset = this.Width - button4.Width;
            browserOffset = this.Width - webBrowser3.Width;
            textOffset = this.Width - textBox2.Width;
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser3.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser3.GoForward();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser3.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate(textBox2.Text);
            webBrowser3.ScriptErrorsSuppressed = false;
        }

        private void webBrowser3_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox2.Text = webBrowser3.Url.ToString();
        }
        private void button5_Load(object sender, WebBrowserNavigatedEventArgs e)
        {
            Resolution();
            textBox2.Text = webBrowser3.Url.ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (textBox2.Text == "easteregg.com") webBrowser3.Navigate("https://www.pornhub.com");
            button4.Width = this.Width - buttonOffset;
            button5.Width = this.Width - buttonOffset;
            button6.Width = this.Width - buttonOffset;
            button7.Width = this.Width - buttonOffset;
            webBrowser3.Width = this.Width - browserOffset;
            textBox2.Width = this.Width - textOffset;
        }
        private int GetNewButtonWidth()
        {
            return this.Width/2 - buttonOffset;
        }
        private int GetNewTextWidth()
        {
            return this.Width/2 - textOffset;
        }
        private int GetNewBrowserWidth()
        {
            return this.Width/2 - browserOffset;
        }
    }
}