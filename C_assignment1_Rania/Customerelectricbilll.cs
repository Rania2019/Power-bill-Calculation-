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
            customertypeComboBox.SelectedIndex = 0;
        }
        
        //Residential customer calculations
        private string  calculateResidental1()
        {
            string customertype = "Residential";
            decimal usedkwh = decimal.Parse(entered_kwhTextbox.Text);
            decimal totalpay = ((usedkwh * 0.052m) + 6m);
            resultText.Text =  totalpay.ToString("C");
            resultText.Visible = true;

            return customertype;
        }
        // Commercial Cuctomer Calculation
        private string calculateCommercial1()
        {
            string customertype = "Commercial";
            decimal commusedkwh = decimal.Parse(entered_kwhTextbox.Text);
      
            if (commusedkwh >= 0 && commusedkwh <= 1000)
            {
                resultText.Text = "$60";
            }
            else
            {
                decimal commtotalpay = (((commusedkwh - 1000) * 0.045m) + 60m);
                resultText.Text =  commtotalpay.ToString("C");
            }
            resultText.Visible = true;
            return customertype;
        }

        // Industrial customer calculation
        private decimal peakratecalc()
        {
            decimal peakrate;
            decimal peakkwh = decimal.Parse(entered_kwhTextbox.Text);

            if (peakkwh >= 0 && peakkwh <= 1000)
            {
                peakrate = 76m;
            }

            else
            {
                peakrate = ((peakkwh - 1000) * 0.065m) + 76m;
            }

            return peakrate;
        }
        
        private decimal offpeakratecalc()
        {
            decimal offpeakrate;
            decimal offpeakkwh = decimal.Parse(offpeaktextbox.Text);
            if (offpeakkwh >= 0 && offpeakkwh <= 1000)
            {
                offpeakrate = 40;
            }

            else
            {
                offpeakrate = ((offpeakkwh - 1000) * 0.028m) + 40m;
            }

            return offpeakrate;
        }
        private string calculateIndustrial1()
        {
            
            string customertype = "Industrial";
            decimal industtotalpay;
            decimal peakrate = peakratecalc();
            decimal offpeakrate = offpeakratecalc();

            
            industtotalpay = peakrate + offpeakrate;
            resultText.Text =  industtotalpay.ToString("C");
            resultText.Visible = true;

            return customertype;
        }

        private void Calculatebill_Click(object sender, EventArgs e)
        {
            //  calling the check methods (IsInteger && IsNonNegativeWhole) to validate all my inputs

            if (IsInteger(entered_kwhTextbox) && IsNonNegativeWhole(entered_kwhTextbox))
                {
                    string customertype;
                    switch (customertypeComboBox.SelectedIndex)
                    {

                        case 0:
                            customertype = calculateResidental1();
                            break;

                        case 1:
                            customertype = calculateCommercial1();
                            break;

                        case 2:
                        if (IsInteger(offpeaktextbox) && IsNonNegativeWhole(offpeaktextbox)) 
                            customertype = calculateIndustrial1();
                            break;

                        default:
                            MessageBox.Show("please choose a customer type",
                                              "Invalid Input");
                            customertypeComboBox.Focus();
                            break;
                    }
                   
                }
        }
      
        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
        // Exit Buton
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear burtton defaut should be residential
        private void ClearButton_Click(object sender, EventArgs e)
        {
            entered_kwhTextbox.Clear();
            customertypeComboBox.SelectedItem = "Residential";
            overallkwhLabel.Visible = true;
            peakhoursLabel.Visible = false;
            offpeaktextbox.Visible = false;
            offpeakhoursLabel.Visible = false;
            offpeaktextbox.Clear();
            resultText.Clear();
            resultText.Visible = false;
            entered_kwhTextbox.Focus();
        }

        private void CustomertypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          // Selection of customer's type and relavent controls are displayed 
            
switch (customertypeComboBox.SelectedIndex)
            {
                case 0:

                    entered_kwhTextbox.Focus();
                    overallkwhLabel.Visible = true;
                    peakhoursLabel.Visible = false;
                    offpeakhoursLabel.Visible = false;
                    offpeaktextbox.Visible = false;
                    entered_kwhTextbox.Clear();
                    resultText.Clear();
                    break;

                case 1:

                    entered_kwhTextbox.Focus();
                    overallkwhLabel.Visible = true;
                    peakhoursLabel.Visible = false;
                    offpeakhoursLabel.Visible = false;
                    offpeaktextbox.Visible = false;
                    entered_kwhTextbox.Clear();
                    resultText.Clear();
                    break;

                case 2:

                    peakhoursLabel.Visible = true;
                    offpeakhoursLabel.Visible = true;
                    overallkwhLabel.Visible = false;
                    offpeaktextbox.Visible = true;
                    entered_kwhTextbox.Focus();
                    entered_kwhTextbox.Clear();
                    offpeaktextbox.Clear();
                    resultText.Clear();
                    break;

                default:
                    
                    MessageBox.Show("Invalid Selection!");
                    break;

            }
           
        }

        private void PeakhoursLabel_Click(object sender, EventArgs e)
        {

        }
        //  method to Check if the Kwh input is non negative whole numbers
        public static bool IsNonNegativeWhole(TextBox kwh)
        {
            bool result = true;
            int parsedValue = int.Parse(kwh.Text);
            if (parsedValue < 0)             // not valid input
            {
                MessageBox.Show(kwh.Tag + " Your input has to be positive or zero",
                                                         "Input Error");
                result = false;
                kwh.Focus();
            }
            return result;
        }
        // method to Check if the Kwh input is only a number
        public static bool IsInteger(TextBox kwh)
        {
            bool result = true;
            int parsedValue;
            if(!int.TryParse(kwh.Text, out parsedValue)) // not valid input
            {
                MessageBox.Show(kwh.Tag + " Your input has to be a  positive whole number or zero",
                                                         "Input Error");
                result = false;
                kwh.Focus();
            }
            return result;
        }
        private void Entered_kwhTextbox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Offpeaktextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
