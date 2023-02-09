using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {

        string homing = "https://scholar.google.pt/";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void search_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
        private void home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(homing);
        }
        private void print_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void preview_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        

        

        

        
    }
}
