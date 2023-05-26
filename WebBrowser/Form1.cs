using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://netfruittechnologies.wordpress.com";

            webBrowser.Navigate(url);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(textBox.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }
    }
}
