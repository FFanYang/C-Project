using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class currencyConverter : Form
    {
        public currencyConverter()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.ofx.com/en-nz/currency-converter/");
        }
    }
}
