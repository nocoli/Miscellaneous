using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // web browser stuff
            webBrowser1.CanGoBackChanged +=
            new EventHandler(webBrowser1_CanGoBackChanged);
            webBrowser1.CanGoForwardChanged +=
                new EventHandler(webBrowser1_CanGoForwardChanged);
            webBrowser1.DocumentTitleChanged +=
                new EventHandler(webBrowser1_DocumentTitleChanged);
            //webBrowser1.StatusTextChanged +=
            //new EventHandler(webBrowser1_StatusTextChanged);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0,20,"https://github.com/nocoli");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }


        Bitmap image1 = MyFirstProject.Properties.Resources.Boston_City_Flow;
        Bitmap image2 = MyFirstProject.Properties.Resources.Costa_Rican_Frog;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == image1)
            {
                pictureBox1.Image = image2;
            }
            else
            {
                pictureBox1.Image = image1;
            }
        }
        /*
        void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox rtb = (sender as PictureBox);
            if (rtb != null)
            {
                this.toolTip1.Show("Hello!!!", rtb);
            }
        }

        void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox rtb = (sender as PictureBox);
            if (rtb != null)
            {
                this.toolTip1.Hide(rtb);
            }
        }
        */
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        // Navigates webBrowser1 to the previous page in the history.
        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        // Disables the Back button at the beginning of the navigation history.
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            backButton.Enabled = webBrowser1.CanGoBack;
        }

        // Navigates webBrowser1 to the next page in history.
        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        // Disables the Forward button at the end of navigation history.
        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            forwardButton.Enabled = webBrowser1.CanGoForward;
        }

        // Updates the title bar with the current document title.
        private void webBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
        }
        /*
        // Updates the status bar with the current browser status text.
        private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = webBrowser1.StatusText;
        }
        */


        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox2.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox2.Text = webBrowser1.Url.ToString();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBox2.Text);
            }
        }
    }
}
