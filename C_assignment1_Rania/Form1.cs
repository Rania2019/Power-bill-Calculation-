using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_assignment1_Rania
{
    public partial class inputdataform : Form
    {
        public inputdataform()
        {
            InitializeComponent();
        }

        private void Calculatebill_Click(object sender, EventArgs e)
        {
            string totalpaycurrency;
            decimal usedkwh = decimal.Parse(entered_kwh.Text);
            decimal totalpay = ((usedkwh * 0.052m) + 6m);
            totalpaycurrency = totalpay.ToString("C");
            result.Text = "The bill amount is: " +  totalpaycurrency;
            result.Visible = true;
        }
      
        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
