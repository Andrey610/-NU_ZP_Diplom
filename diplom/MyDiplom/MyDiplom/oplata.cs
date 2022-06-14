using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiplom
{
    public partial class oplata : Form
    {
        public oplata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oplata_Load(object sender, EventArgs e)
        {
            // webBrowser1.Navigate("https://www.liqpay.ua/en/checkout/card/i69622118407");
            webBrowser1.Navigate("https://i.pinimg.com/564x/03/b3/c5/03b3c53c7e44aa048e56218e6e9ca7f6.jpg");
        
        }
    }
}
