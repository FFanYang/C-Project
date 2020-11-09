using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIFast
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e) //method, when key presed it will trigger the function or the code.
        {
            if (e.KeyCode == Keys.Enter) //if cbokey press will navigate
            {

                webBrowser1.Navigate(cboLocation.Text);

            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //update the title when change the website "-"dash
            Text = "AIFast - " + webBrowser1.Document.Title; //update window title bar to read.
        }

        private void cboLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
